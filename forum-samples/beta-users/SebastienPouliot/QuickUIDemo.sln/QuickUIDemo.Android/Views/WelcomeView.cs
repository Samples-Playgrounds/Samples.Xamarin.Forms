using System;
using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.ViewModels;
using QuickUIDemo.Android.Core;
using QuickUIDemo.Android.MvxAdaption;
using Xamarin.QuickUI;

namespace QuickUIDemo.Android.Views
{
    [Activity(Label = "Welcome View")]
    public class WelcomeView : MvxAndroidActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            QuickUI.Init(this, bundle);
            var page = new WelcomePage();
            SetPage(page);

            var set = this.CreateBindingSet<WelcomeView, WelcomeViewModel>();
            set.Bind(page.loginButton).For(v => v.IsEnabled).To(vm => vm.LoginAvailable);
            set.Bind(page.loginButton).For(v => v.Command).To(vm => vm.Go);
            set.Bind(page.usernameEntry).To(vm => vm.UserName);
            set.Bind(page.passwordEntry).To(vm => vm.Password);
            set.Apply();
        }

        public class WelcomePage : ContentPage
        {
            public StackLayout mainLayout;
            public Entry usernameEntry;
            public Entry passwordEntry;
            public Button loginButton;

            public WelcomePage()
            {
                Title = "QuickUI Demo";
                Content = mainLayout = new StackLayout
                {
                    Padding = new Thickness(20, 20, 20, 100),
                    Spacing = 10,
                    Orientation = StackLayout.StackOrientation.Vertical,
                    VerticalOptions = LayoutOptions.Center
                };

                mainLayout.Add(new Label
                {
                    Text = "Welcome to the QuickUI Demo App!",
                    XAlign = TextAlignment.Center
                });

                mainLayout.Add(usernameEntry = new Entry { Placeholder = "Username" });
                mainLayout.Add(passwordEntry = new Entry
                {
                    Placeholder = "Password",
                    Password = true
                });
                mainLayout.Add(loginButton = new Button
                {
                    Text = "Login",
                    IsEnabled = false
                });
            }
        }
    }
}