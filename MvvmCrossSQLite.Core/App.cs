using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using MvvmCrossSQLite.Core.ViewModels;

namespace MvvmCrossSQLite.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<CategoryViewModel>());
        }
    }
}
