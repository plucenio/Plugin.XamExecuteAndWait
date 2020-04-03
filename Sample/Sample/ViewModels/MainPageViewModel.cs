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

            SampleCommand = new DelegateCommand(async () =>
            {
                await Action();
            });
        }

        private async Task Action()
        {
            await Plugin.XamExecuteAndWait.CrossXamExecuteAndWait.Current.ExecuteAndWait(() =>
            {
               for(var i = 0; i < 10000; i++)
               {

               }
            }, new LoadingView());
        }
    }
}
