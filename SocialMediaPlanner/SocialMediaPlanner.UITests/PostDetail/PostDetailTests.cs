using Bunit;
using Xunit;
using FluentAssertions;
using SocialMediaPlanner.Client.Pages;

namespace SocialMediaPlanner.UITests.PostDetail
{
    public class PostDetailTests : TestContext
    {
        [Fact]
        public void Test1()
        {
            var component = RenderComponent<PostDetails>(
                parameters =>
                    parameters
                    .Add(c => c.Id, 10)
                    .Add(c => c.Example, "Test")
                );

            component.Find("#headerExamplePost").TextContent.Should().Be("This is an example text: Test for Id: 10");
        }
    }
}
