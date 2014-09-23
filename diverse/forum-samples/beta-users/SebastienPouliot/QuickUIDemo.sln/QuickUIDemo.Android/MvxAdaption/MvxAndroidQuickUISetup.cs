using Android.Content;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.Droid;
using Cirrious.MvvmCross.Droid.Platform;
using Xamarin.QuickUI;

namespace QuickUIDemo.Android.MvxAdaption
{
    public abstract class MvxAndroidQuickUISetup
        : MvxAndroidSetup
    {
        protected MvxAndroidQuickUISetup(Context applicationContext)
            : base(applicationContext)
        {
        }

        protected override MvxAndroidBindingBuilder CreateBindingBuilder()
        {
            var bindingBuilder = new MvxAndroidQuickUIBindingBuilder();
            return bindingBuilder;
        }

        protected override void FillBindingNames(IMvxBindingNameRegistry registry)
        {
            registry.AddOrOverwrite(typeof(Entry), "Text");
            // TODO - more here - but wait for stability and open source

            base.FillBindingNames(registry);
        }
    }
}