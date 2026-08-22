using LMS.Application.Abstractions;
using LMS.Application.Courses;
using LMS.Domain.Courses;

namespace LMS.Tests.Application;

public sealed class ListPublishedCoursesUseCaseTests
{
    [Fact]
    public async Task ExecuteAsync_OrdersCoursesAndLessonsAndMapsTheirData()
    {
        var organizationId = Guid.NewGuid();
        var laterCourse = PublishedCourse(organizationId, "Zulu", ("Second", 2), ("First", 1));
        var earlierCourse = PublishedCourse(organizationId, "Alpha", ("Only", 1));
        var useCase = new ListPublishedCoursesUseCase(new StubCourseRepository([laterCourse, earlierCourse]));

        var result = await useCase.ExecuteAsync(CancellationToken.None);

        Assert.Equal(["Alpha", "Zulu"], result.Select(course => course.Title));
        Assert.Equal(["First", "Second"], result.Single(course => course.Title == "Zulu").Lessons.Select(lesson => lesson.Title));
        Assert.All(result, course => Assert.Equal("Published", course.Status));
        Assert.All(result, course => Assert.Equal(organizationId, course.OrganizationId));
    }

    [Fact]
    public async Task ExecuteAsync_ForwardsCancellationTokenToRepository()
    {
        using var cancellation = new CancellationTokenSource();
        var repository = new StubCourseRepository([]);
        var useCase = new ListPublishedCoursesUseCase(repository);

        await useCase.ExecuteAsync(cancellation.Token);

        Assert.Equal(cancellation.Token, repository.ObservedCancellationToken);
    }

    private static Course PublishedCourse(Guid organizationId, string title, params (string Title, int Sequence)[] lessons)
    {
        var course = Course.Draft(Guid.NewGuid(), organizationId, title, $"Description for {title}");
        foreach (var lesson in lessons)
        {
            course.AddLesson(Lesson.Create(Guid.NewGuid(), lesson.Title, lesson.Sequence));
        }

        course.Publish();
        return course;
    }

    private sealed class StubCourseRepository(IReadOnlyCollection<Course> courses) : ICourseRepository
    {
        public CancellationToken ObservedCancellationToken { get; private set; }

        public Task<IReadOnlyCollection<Course>> ListPublishedAsync(CancellationToken cancellationToken = default)
        {
            ObservedCancellationToken = cancellationToken;
            return Task.FromResult(courses);
        }
    }
}
