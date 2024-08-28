using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();
            app.UseStaticFiles();

            #region Routing
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("You Are At Home Page");
            //    });

            //    endpoints.MapGet("/Product", async context =>
            //    {
            //        await context.Response.WriteAsync("You Are At Product  Page");
            //    });

            //    //with optional paramter

            //    endpoints.MapGet("/Product/{id?}", async context =>
            //    {
            //        var idData = context.Request.RouteValues["id"];
            //        if(idData is not null)
            //        {
            //            int id = Convert.ToInt32(idData);
            //            await context.Response.WriteAsync("You Are At Product  Page with Id={id}");

            //        }
            //       else
            //            await context.Response.WriteAsync("You Are At Product  Page");



            //    });


            //    //with paramter and constraints
            //    endpoints.MapGet("/Books/{id:int?}/{author:alpha:minlength(4):maxlength(10)}", async context =>
            //    {
            //        int id =Convert.ToInt32(context.Request.RouteValues["id"]);
            //        string author = context.Request.RouteValues["author"].ToString();
            //        await context.Response.WriteAsync($"You Request Book with Id={id} and Author {author }");
            //    });
            //});

            //app.Run(async (HttpContext) =>
            //{
            //    await HttpContext.Response.WriteAsync("Your Requested Page is not found");
            //});

            #endregion

            #region controller route
            app.MapControllerRoute(
                name :"defualt",
                pattern:"/{Controller=Home}/{action=Index}",
                defaults:new { Controller = "Home",Action ="Index"}
                
                );
            #endregion

            app.Run();
        }
    }
}
