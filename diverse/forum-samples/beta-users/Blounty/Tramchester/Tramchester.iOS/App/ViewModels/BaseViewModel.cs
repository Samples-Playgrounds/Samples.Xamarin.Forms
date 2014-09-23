using System;
using System.ComponentModel;
using System.Linq.Expressions;
using Xamarin.QuickUI;
using XPlatUtils;
using Tramchester.App.Views;
using System.Collections.Generic;
using System.Linq;

namespace Tramchester.App.ViewModels
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		internal INavigation Navigation;

		public event PropertyChangedEventHandler PropertyChanged;

		public virtual void Init(Dictionary <string, object> parameters)
		{
		}

		protected void RaiseChanged<T>(Expression<Func<T>> propertyExpression)
		{
			var handler = PropertyChanged;

			if (handler != null)
			{
				var body = propertyExpression.Body as MemberExpression;
				if (body == null)
					throw new ArgumentException("'propertyExpression' should be a member expression");

				var expression = body.Expression as ConstantExpression;
				if (expression == null)
					throw new ArgumentException("'propertyExpression' body should be a constant expression");

				object target = Expression.Lambda(expression).Compile().DynamicInvoke();

				var e = new PropertyChangedEventArgs(body.Member.Name);
				handler(target, e);
			}
		}

		protected void Navigate<T>(Dictionary<string, object> parameters = null)
		{
			var viewModelType = typeof(T);

			var viewModelTypeName = viewModelType.FullName;

			var viewTypeName = typeof(T).FullName.Replace ("ViewModels", "Views").Replace ("Model", "");

			var view = (ContentPage)Activator.CreateInstance (Type.GetType (viewTypeName));

			var viewModel = (BaseViewModel)ServiceContainer.Resolve (Type.GetType (viewModelTypeName));

			viewModel.Navigation = view.Navigation;

			view.BindingContext = viewModel;

			if (parameters != null) {
				viewModel.Init (parameters);
			}

			this.Navigation.Push (view);
		}

		protected void NavigateBack()
		{
			this.Navigation.Pop ();
		}
	}
}

