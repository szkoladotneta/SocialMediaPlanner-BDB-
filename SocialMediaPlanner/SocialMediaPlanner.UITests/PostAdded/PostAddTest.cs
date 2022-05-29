using Bunit;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using SocialMediaPlanner.Client.Brokers.API;
using SocialMediaPlanner.Client.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SocialMediaPlanner.UITests.PostAdded
{
    public class PostAddTest
    {
        [Fact]
        public void Test1()
        {
            using var ctx = new TestContext();
            var apiBrokerMock = new Mock<IApiBroker>();
            ctx.Services.AddSingleton(apiBrokerMock.Object);

            var component = ctx.RenderComponent<PostAdd>();

            component.Find("#body").Change("Test body of the new post");
            component.Find("#title").Change("Test title");
            component.Find("#scheduledDate").Change(DateTime.Now.ToString("yyyy-MM-dd"));

            var buttonSubmit= component.Find(".btn.btn-success.float-right");

            buttonSubmit.Click();

            component.Find("#isSentCheckBox").Attributes["checked"].Value.Should().NotBeNull();
        }
    }
}
