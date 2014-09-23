using System;
using Cirrious.MvvmCross.Binding;
using Xamarin.QuickUI;

namespace QuickUIDemo.Android.MvxAdaption
{
    public static class BindingModeExtensions
    {
        public static MvxBindingMode ToMvx(this BindingMode mode, MvxBindingMode ifDefault = MvxBindingMode.Default)
        {
            switch (mode)
            {
                case BindingMode.Default:
                    return ifDefault;

                case BindingMode.TwoWay:
                    return MvxBindingMode.TwoWay;
                
                case BindingMode.OneWay:
                    return MvxBindingMode.OneWay;
                
                case BindingMode.OneWayToSource:
                    return MvxBindingMode.OneWayToSource;
                
                default:
                    throw new ArgumentOutOfRangeException("mode");
            }
        }
    }
}