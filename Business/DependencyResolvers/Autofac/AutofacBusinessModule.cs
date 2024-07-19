using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstracts;
using Business.Concretes;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfLikeDal>().As<ILikeDal>().SingleInstance();
            builder.RegisterType<LikeManager>().As<ILikeService>().SingleInstance();

            builder.RegisterType<EfCommentDal>().As<ICommentDal>().SingleInstance();
            builder.RegisterType<CommentManager>().As<ICommentService>().SingleInstance();

            builder.RegisterType<EfPostDal>().As<IPostDal>().SingleInstance();
            builder.RegisterType<PostManager>().As<IPostService>().SingleInstance();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
