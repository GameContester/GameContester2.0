using System;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using GameContester.Service.Controllers;
using GameContester.Service.Providers;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Ninject;
using Owin;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using GameContester.DataAccess.Repository;
using GameContester.DataAccess;
using GameContester.DataAccess.Managers;
using GameContester.Application.Services;

namespace GameContester.Service
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var kernel = CreateKernel();
            ConfigureOAuth(app);
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseCors(CorsOptions.AllowAll);
            app.UseWebApi(config);
            config.DependencyResolver = new NinjectResolver(kernel);
            config.Services.Replace(typeof(IExceptionHandler), new OopsExceptionHandler());
        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            var context = new GameContesterDbContext();
            var userService = new UserService(new UserRepository(context, new UserManager(context)), new MailService());

            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new SimpleAuthorizationServerProvider(userService)
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        }


        private static StandardKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Load<GameContesterNinjectModule>();
            return kernel;
        }
    }
}