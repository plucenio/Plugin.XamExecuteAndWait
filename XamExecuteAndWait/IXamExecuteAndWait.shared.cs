using Android.Content;
using Android.OS;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Plugin.XamExecuteAndWait
{
    public interface IXamExecuteAndWait
    {
        void Init();

        void Init(Context context, Bundle bundle);

        Task ExecuteAndWait(Action action, View view);
    }
}
