using Bunit;
using System;
using Xunit;
using SocialMediaPlanner.Client.Pages;
using Index = SocialMediaPlanner.Client.Pages.Index;
using FluentAssertions;
using Majorsoft.Blazor.Components.Notifications;

namespace SocialMediaPlanner.UITests.Indexes
{
    public class IndexTest
    {
        [Fact]
        public void Test1()
        {
            using var ctx = new TestContext();
            ctx.Services.AddNotifications();

            var module = ctx.JSInterop.SetupModule("./_content/Majorsoft.Blazor.Components.Notifications/notification.min.js");
            module.Setup<bool>("isBrowserSupported").SetResult(true);
            module.Setup<String>("checkPermission").SetResult("Granted");
            var component = ctx.RenderComponent<Index>();

            component.Find(".breadcrumb-item.active").TextContent.Should().Be("Home");
        }
    }
}
