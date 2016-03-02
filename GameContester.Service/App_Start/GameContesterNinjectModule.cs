using System.Web;
using GameContester.Application.Services;
using GameContester.Contracts.Managers;
using GameContester.Contracts.Repositories;
using GameContester.Contracts.Services;
using GameContester.DataAccess;
using GameContester.DataAccess.Managers;
using GameContester.DataAccess.Repository;
using GameContester.Service.Providers;
using Ninject.Modules;
using Ninject.Web.Common;

namespace GameContester.Service.App_Start
{
    public class GameContesterNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
            this.Bind<GameContesterDBContext>().To<GameContesterDBContext>().InRequestScope();
            this.Bind<IUserRepository>().To<UserRepositiry>();
            this.Bind<IUserService>().To<UserService>();
            this.Bind<SimpleAuthorizationServerProvider>().ToSelf();
            this.Bind<IUserManager>().To<UserManager>();
            this.Bind<IMailService>().To<MailService>();
            this.Bind<ICaptchaService>().To<CaptchaService>();
        }
    }
}