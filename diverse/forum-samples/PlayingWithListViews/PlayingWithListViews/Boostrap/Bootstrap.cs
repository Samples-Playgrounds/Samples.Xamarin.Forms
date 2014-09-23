using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using PlayingWithListViews.Views;
using Xamarin.QuickUI;

namespace PlayingWithListViews.Boostrap
{
    public class Bootstrap
    {
        /// <summary>
        /// Returns the main app. Singleton.
        /// </summary>
        /// <value>The main app.</value>
        public static Bootstrap MainApp
        {
            get { return mainApp ?? (mainApp = new Bootstrap()); }
        }
        static Bootstrap mainApp;

        private Bootstrap()
        {
      
        }

      
        /// <summary>
        /// Gets the main page.
        /// </summary>
        public Page MainPage
        {
            get
            {
                if (mainPage == null)
                {
                    mainPage = new NavigationPage();
                    mainPage.Navigation.Push(new ExampleView());
                }
                return mainPage;
            }

        }
        Page mainPage;
    }
}