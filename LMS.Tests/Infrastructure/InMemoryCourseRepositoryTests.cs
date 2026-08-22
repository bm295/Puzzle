using LMS.Domain.Courses;
using LMS.Infrastructure.Courses;

namespace LMS.Tests.Infrastructure;

public sealed class InMemoryCourseRepositoryTests
{
    [Fact]
    public async Task ListPublishedAsync_ReturnsThePublishedCatalog()
    {
        var repository = new InMemoryCourseRepository();

        var courses = await repository.ListPublishedAsync(CancellationToken.None);

        Assert.Equal(2, courses.Count);
        Assert.All(courses, course => Assert.Equal(CourseStatus.Published, course.Status));
        Assert.Equal(["Course Authoring Essentials", "LMS Foundations"], courses.Select(course => course.Title).Order());
    }

    [Fact]
    public async Task ListPublishedAsync_ReturnsAFreshAggregateGraphForEveryQuery()
    {
        var repository = new InMemoryCourseRepository();
        var firstResult = await repository.ListPublishedAsync(CancellationToken.None);
        var mutatedCourse = firstResult.First();
        mutatedCourse.AddLesson(Lesson.Create(Guid.NewGuid(), "Caller mutation", 99));

        var secondResult = await repository.ListPublishedAsync(CancellationToken.None);
        var reloadedCourse = secondResult.Single(course => course.Id == mutatedCourse.Id);

        Assert.DoesNotContain(reloadedCourse.Lessons, lesson => lesson.Sequence == 99);
        Assert.NotSame(mutatedCourse, reloadedCourse);
    }

    [Fact]
    public async Task ListPublishedAsync_WhenCancelled_ThrowsBeforeCreatingResults()
    {
        var repository = new InMemoryCourseRepository();
        using var cancellation = new CancellationTokenSource();
        cancellation.Cancel();

        await Assert.ThrowsAsync<OperationCanceledException>(
            () => repository.ListPublishedAsync(cancellation.Token));
    }
}
