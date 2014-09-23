using Cirrious.MvvmCross.Binding.Bindings.Target.Construction;
using Cirrious.MvvmCross.Binding.Droid;

namespace QuickUIDemo.Android.MvxAdaption
{
    public class MvxAndroidQuickUIBindingBuilder : MvxAndroidBindingBuilder
    {
        protected override IMvxTargetBindingFactoryRegistry CreateTargetBindingRegistry()
        {
            return new MvxQuickUITargetBindingFactoryRegistry();
        }
    }
}