namespace FPLSP.Repositories.Services.FPLExam
{
    public class BackGroundExamOnlineServices : BackgroundService
    {
        private int totaltime;
        public static event Func<DateTime, Task> UpdateEvent;
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(1000);
                await UpdateEvent?.Invoke(DateTime.Now);
            }
        }

        public override async Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("thuyen qua la dep trai");
        }
        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("ket thuc su dep rai cua thuyen");
        }


    }
}
