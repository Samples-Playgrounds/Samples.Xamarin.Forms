using System;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cirrious.MvvmCross.ViewModels;

namespace QuickUIDemo.Android.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            this.RegisterAppStart<WelcomeViewModel>();
        }
    }
}