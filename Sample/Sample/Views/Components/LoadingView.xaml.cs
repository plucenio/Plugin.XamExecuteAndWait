using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sample.Views.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadingView : ContentView
    {
        public LoadingView()
        {
            InitializeComponent();
        }
    }
}