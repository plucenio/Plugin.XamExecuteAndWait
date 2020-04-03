using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
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

            SampleCommand = new DelegateCommand(() =>
            {
                Action();
            });
        }

        private void Action()
        {
            Plugin.XamExecuteAndWait.CrossXamExecuteAndWait.Current.ExecuteAndWait(() =>
            {
                NavigationService.NavigateAsync("NavigationPage/SecondPage");
            }, new LoadingView());            
        }
    }
}
