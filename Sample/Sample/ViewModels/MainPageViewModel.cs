using DryIoc;
using ImTools;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using Rg.Plugins.Popup.Contracts;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Sample.Views.Components;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ICommand SampleCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            SampleCommand = new DelegateCommand(async () =>
            {
                await Action();
            });
        }

        private async Task Action()
        {
            await Plugin.XamExecuteAndWait.CrossXamExecuteAndWait.Current.ExecuteAndWait(() =>
            {
                Task.Delay(1000);
                NavigationService.NavigateAsync("NavigationPage/SecondPage");
            }, new LoadingView());            
        }        
    }
}
