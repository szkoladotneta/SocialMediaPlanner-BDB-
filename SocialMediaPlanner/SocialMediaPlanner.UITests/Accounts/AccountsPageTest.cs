using Xunit;
using Bunit;
using FluentAssertions;
using SocialMediaPlanner.Client.Pages;

namespace SocialMediaPlanner.UITests
{
    public class AccountsPageTest : TestContext
    {
        [Fact]
        public void WhenRenderAccounts_BreadcrumItemActive_ShouldBe_Accounts()
        {
            //Act
            var component = RenderComponent<Accounts>();

            //Assert
            component.Find(".breadcrumb-item.active").TextContent.Should().Be("Accounts");
        }

        [Fact]
        public void WhenRenderAccounts_H1_ShouldBe_HelloAccounts()
        {
            var component = RenderComponent<Accounts>();

            component.Find(".row.hello").MarkupMatches(@"<div class=""row hello"">
            <h1>Hello Accounts</h1>
        </div>");
        }
    }
}