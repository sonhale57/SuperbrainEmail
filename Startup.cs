using Hangfire;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperbrainEmail.Startup))]
namespace SuperbrainEmail
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration.UseSqlServerStorage("ModelDbContext");
            app.UseHangfireDashboard("/hangfire", new DashboardOptions()
            {
                //Authorization = new[] { new HangfireAthorizationFilter()}
            });
            //BackgroundJob.Enqueue(() => Console.WriteLine("Fire-and-forget!"));
            //RecurringJob.AddOrUpdate(() => Console.WriteLine("Recurring!"),Cron.Minutely);
            app.UseHangfireServer();
        }
    }
}
