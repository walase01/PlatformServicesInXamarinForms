using DependencyCustomInXamarnFroms.Services;
using DependencyCustomInXamarnFroms.ViewModels;
using DependencyCustomInXamarnFroms.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DependencyCustomInXamarnFroms
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformsInitializer = null): base(platformsInitializer)
        {

        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync($"{Config.Navegation}/{Config.Tabbed}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>(Config.Navegation);
            containerRegistry.RegisterForNavigation<SpecificTabbedPage>(Config.Tabbed);
            containerRegistry.RegisterForNavigation<OrientarionPage, OrientationViewModel>(Config.Orientation);
            containerRegistry.RegisterForNavigation<MyEntryPage, EntryViewModel>(Config.EntryEffec);
            containerRegistry.RegisterForNavigation<EffectPage>(Config.Effed);
        }
    }
}
