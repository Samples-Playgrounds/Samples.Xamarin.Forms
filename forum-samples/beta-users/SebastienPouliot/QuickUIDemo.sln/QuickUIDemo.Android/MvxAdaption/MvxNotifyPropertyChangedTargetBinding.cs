using System;
using System.ComponentModel;
using System.Reflection;
using Cirrious.MvvmCross.Binding;
using Cirrious.MvvmCross.Binding.Bindings.Target;

namespace QuickUIDemo.Android.MvxAdaption
{
    public class MvxNotifyPropertyChangedTargetBinding : MvxConvertingTargetBinding
    {
        private readonly PropertyInfo _propertyInfo;
        private readonly MvxBindingMode _mode;
        private bool _subscribed;

        public MvxNotifyPropertyChangedTargetBinding(INotifyPropertyChanged target, PropertyInfo propertyInfo, MvxBindingMode mode = MvxBindingMode.TwoWay)
            : base(target)
        {
            _propertyInfo = propertyInfo;
            _mode = mode;
        }

        public override void SubscribeToEvents()
        {
            var target = (INotifyPropertyChanged)base.Target;
            if (target == null)
                return;

            target.PropertyChanged += TargetOnPropertyChanged;
            _subscribed = true;
        }

        private void TargetOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if (string.IsNullOrEmpty(propertyChangedEventArgs.PropertyName)
                || propertyChangedEventArgs.PropertyName == _propertyInfo.Name)
            {
                FireValueChanged(_propertyInfo.GetGetMethod().Invoke(sender, new object[] {}));
            }
        }

        protected override void SetValueImpl(object target, object value)
        {
            if (target == null)
                return;

            var setter = _propertyInfo.GetSetMethod();
            setter.Invoke(target, new object[] {value});
        }

        public override Type TargetType
        {
            get { return _propertyInfo.PropertyType; }
        }

        public override MvxBindingMode DefaultMode
        {
            get { return _mode; }
        }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                if (_subscribed)
                {
                    var target = (INotifyPropertyChanged)base.Target;
                    if (target != null)
                    {
                        target.PropertyChanged -= TargetOnPropertyChanged;
                    }
                    _subscribed = false;
                }
            }
            base.Dispose(isDisposing);
        }
    }
}