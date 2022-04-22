namespace SocialMediaPlanner.Client.Service
{
    public interface ITestService
    {
        int Counter { get; set; }
        void RaiseValue();
    }
    public class TestService : ITestService
    {
        public int Counter { get; set; }
        public TestService()
        {
            Counter = 0;
        }
        public void RaiseValue()
        {
            Counter += 1;
        }
    }
}
