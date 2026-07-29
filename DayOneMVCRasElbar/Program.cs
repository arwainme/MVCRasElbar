namespace DayOneMVCRasElbar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default", /// defualt = home/privcy
                pattern: "{controller=Home}/{action=Privacy}/{id?}")
                .WithStaticAssets();

            // custom route for Employees controller
            app.MapControllerRoute(
                name: "employees",
                pattern: "Hamada", //employees = Hamada = > Employee/GetAll
                defaults: new
                {
                    controller = "Employee",
                    action = "GetAll"
                });


            app.Run();
        }
    }
}
