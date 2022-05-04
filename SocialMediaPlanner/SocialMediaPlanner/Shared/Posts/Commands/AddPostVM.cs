using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace SocialMediaPlanner.Shared.Posts.Commands
{
    public class AddPostVM
    {

        public string Title { get; set; }
        public string Body { get; set; }

        public bool IsAdvertised { get; set; }
        public int DaysForAds { get; set; }
        public decimal AdsBudget { get; set; }
        public DateTime? ScheduledDate { get; set; }
        public AccountVm Accounts { get; set; }
    }

    public class AddPostValidator : AbstractValidator<AddPostVM>
    {
        public AddPostValidator()
        {
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.Body).NotEmpty();
            RuleFor(x => x.Body).MinimumLength(10).WithMessage("Body needs to be at least 10 chars");
        }
    }

    public class AccountVm
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
    }
}
