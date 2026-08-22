using LMS.Domain.Courses;

namespace LMS.Tests.Domain;

public sealed class CourseTests
{
    [Fact]
    public void Draft_NormalizesUserProvidedText()
    {
        var course = Course.Draft(Guid.NewGuid(), Guid.NewGuid(), "  Architecture  ", "  Boundaries matter.  ");

        Assert.Equal("Architecture", course.Title);
        Assert.Equal("Boundaries matter.", course.Description);
        Assert.Equal(CourseStatus.Draft, course.Status);
    }

    [Fact]
    public void Publish_WithoutLessons_IsRejected()
    {
        var course = Course.Draft(Guid.NewGuid(), Guid.NewGuid(), "Architecture", string.Empty);

        var exception = Assert.Throws<InvalidOperationException>(course.Publish);

        Assert.Equal("A course must contain at least one lesson before publishing.", exception.Message);
        Assert.Equal(CourseStatus.Draft, course.Status);
    }

    [Fact]
    public void AddLesson_WithDuplicateSequence_IsRejected()
    {
        var course = Course.Draft(Guid.NewGuid(), Guid.NewGuid(), "Architecture", string.Empty);
        course.AddLesson(Lesson.Create(Guid.NewGuid(), "Boundaries", 1));

        var exception = Assert.Throws<InvalidOperationException>(
            () => course.AddLesson(Lesson.Create(Guid.NewGuid(), "Dependencies", 1)));

        Assert.Contains("sequence 1", exception.Message);
        Assert.Single(course.Lessons);
    }
}
