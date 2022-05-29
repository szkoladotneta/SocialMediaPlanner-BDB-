using Bunit;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using SocialMediaPlanner.Client.Brokers.API;
using SocialMediaPlanner.Client.Pages;
using SocialMediaPlanner.Shared.Posts.Queries.AllPostsQuery;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace SocialMediaPlanner.UITests.PostsTests
{
    public class PostsTest
    {
        [Fact]
        public void WhenApiBrokerInjected_ScheduledDateFound()
        {
            using var ctx = new TestContext();

            var apiBrokerMock = new Mock<IApiBroker>();
            apiBrokerMock.Setup(
                m => m.GetAllPostsAsync()).Returns(Task.FromResult(new List<PostForListVm>()
                {
                    new PostForListVm()
                    {
                        Body= "Test",
                        ScheduledDate = new System.DateTime(2022,5,5),
                        Id = 1,
                        IsDraft = true,
                        CreateDate = System.DateTime.Now,
                        Title="Test Title",
                        StatusId = 1
                    }
                }
                ));

            ctx.Services.AddSingleton(apiBrokerMock.Object);

            var component = ctx.RenderComponent<Posts>();

            component.WaitForState(() => component.Find(".scheduledDate").TextContent == "05.05.2022 00:00:00");

            //component.Find(".scheduledDate").TextContent.Should().Be("05.05.2022 00:00:00");

            //component.Find(".breadcrumb-item.active").TextContent.Should().Be("Posts");

        }
    }
}
