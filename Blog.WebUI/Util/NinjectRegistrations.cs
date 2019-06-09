using Blog.Domain.Interfaces;
using Infrastructure.Data;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.WebUI.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IArticleRepository>().To<ArticleRepository>();
            Bind<IRequestRepository>().To <RequestRepository>();
        }
    }
}