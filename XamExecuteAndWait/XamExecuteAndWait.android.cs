﻿using Android.Content;
using Android.OS;
using Rg.Plugins.Popup.Contracts;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Plugin.XamExecuteAndWait
{
    /// <summary>
    /// Interface for XamExecuteAndWait
    /// </summary>
    public class XamExecuteAndWaitImplementation : IXamExecuteAndWait
    {
        public void Init(Context context, Bundle bundle)
        {
            Rg.Plugins.Popup.Popup.Init(context, bundle);
        }

        public void Init()
        {
        }

        public async Task ExecuteAndWait(Action action, View view)
        {
            var popup = new PopupPage()
            {
                CloseWhenBackgroundIsClicked = false,
                Content = view,
                BackgroundColor = Color.Transparent,
                IsBusy = true,
            };
            IPopupNavigation ipn = PopupNavigation.Instance;
            await ipn.PushAsync(popup);
            action.Invoke();
            await ipn.RemovePageAsync(popup);
        }
    }
}
