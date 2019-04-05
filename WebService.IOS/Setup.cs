using MvvmCross;
using MvvmCross.Base;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.IoC;
using MvvmCross.Platforms.Ios.Core;
using MvvmCross.Plugin.Json;
using MvvmCross.ViewModels;
using RestFulWebService;
using UIKit;

namespace WebService.IOS
{
    public class Setup : MvxIosSetup<App>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

            Mvx.RegisterType<IMvxJsonConverter, MvxJsonConverter>();
        }

        protected override void InitializeLastChance()
        {
            base.InitializeLastChance();

            var registry = Mvx.Resolve<IMvxTargetBindingFactoryRegistry>();
        }

        protected override IMvxIocOptions CreateIocOptions()
        {
            return new MvxIocOptions
            {
                PropertyInjectorOptions = MvxPropertyInjectorOptions.MvxInject
            };
        }

        protected override IMvxApplication CreateApp()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            return base.CreateApp();
        }
    }
}
