using Prism.Commands;
using Prism.Navigation;
using Sample.Views.Components;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ICommand Sample1Command { get; set; }

        public ICommand Sample2Command { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            Sample1Command = new DelegateCommand(async () => 
            {
                await Plugin.XamExecuteAndWait.CrossXamExecuteAndWait.Current.ExecuteAndWait(() => 
                {
                    Task.Delay(3000);
                }, new Label() { Text = "Loading", Parent = new Grid() { BackgroundColor = Color.Blue } });
            });

            Sample2Command = new DelegateCommand(async () =>
            {
                await Plugin.XamExecuteAndWait.CrossXamExecuteAndWait.Current.ExecuteAndWait(() =>
                {
                    Task.Delay(3000);
                }, new LoadingView());
            });
        }
    }
}
