using System;
using System.ComponentModel;
using System.Reflection;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Binding;
using Cirrious.MvvmCross.Binding.Bindings.Target;
using Cirrious.MvvmCross.Binding.Bindings.Target.Construction;
using Xamarin.QuickUI;

namespace QuickUIDemo.Android.MvxAdaption
{
    public class MvxQuickUITargetBindingFactoryRegistry : MvxTargetBindingFactoryRegistry
    {
        protected override bool TryCreateReflectionBasedBinding(object target, string targetName, out Cirrious.MvvmCross.Binding.Bindings.Target.IMvxTargetBinding binding)
        {
            if (TryCreateDependencyObjectBasedBinding(target, targetName, out binding))
            {
                return true;
            }

            return base.TryCreateReflectionBasedBinding(target, targetName, out binding);
        }

        private bool TryCreateDependencyObjectBasedBinding(object target, string targetName, out IMvxTargetBinding binding)
        {
            var inpc = target as INotifyPropertyChanged;
            if (inpc == null)
            {
                binding = null;
                return false;
            }

            var targetType = target.GetType();
            var dependencyProperty = FindDependencyProperty(targetType, targetName);
            if (dependencyProperty == null)
            {
                binding = null;
                return false;
            }

            var property = FindActualProperty(targetType, targetName);
            if (property == null)
            {
                Mvx.Warning("Property not returned {0} - may cause issues", targetName);
            }

            var defaultMode = dependencyProperty.DefaultBindingMode.ToMvx(MvxBindingMode.TwoWay);
            // TODO - using INPC is a bit slow here - but we can override this for special common cases
            binding = new MvxNotifyPropertyChangedTargetBinding(inpc, property, defaultMode);
            return true;
        }

        public static PropertyInfo FindActualProperty(Type type, string name)
        {
            // not sure why I don't use GetRuntimeProperty - except that Xam.Android crashed when I did
            var property = type.GetProperty(name);
            return property;
        }

        private BindableProperty FindDependencyProperty(Type targetType, string targetName)
        {
            var fieldInfo = FindDependencyFieldInfo(targetType, targetName);

            if (fieldInfo == null)
            {
                return null;
            }

            return fieldInfo.GetValue(null) as BindableProperty;
        }

        private static FieldInfo FindDependencyFieldInfo(Type type, string dependencyPropertyName)
        {
            EnsureIsDependencyPropertyName(ref dependencyPropertyName);

            var typeInfo = type.GetTypeInfo();
            while (typeInfo != null)
            {
                // for some reason Xam use a FieldInfo - rather than a PropertyInfo
                var fieldInfo = typeInfo.GetDeclaredField(dependencyPropertyName);
                if (fieldInfo != null)
                {
                    return fieldInfo;
                }

                if (typeInfo.BaseType == null)
                {
                    return null;
                }

                typeInfo = typeInfo.BaseType.GetTypeInfo();
            }

            return null;
        }

        private static void EnsureIsDependencyPropertyName(ref string dependencyPropertyName)
        {
            if (!dependencyPropertyName.EndsWith("Property"))
                dependencyPropertyName += "Property";
        }
    }
}