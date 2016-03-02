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

namespace GameContester.Service
{
    public class GameContesterNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
            this.Bind<GameContesterDbContext>().To<GameContesterDbContext>().InRequestScope();
            this.Bind<IUserRepository>().To<UserRepository>();
            this.Bind<IUserService>().To<UserService>();
            this.Bind<SimpleAuthorizationServerProvider>().ToSelf();
            this.Bind<IUserManager>().To<UserManager>();
            this.Bind<IImageService>().To<ImageService>();
            this.Bind<IMailService>().To<MailService>();
            this.Bind<ICaptchaService>().To<CaptchaService>();
        }
    }
}