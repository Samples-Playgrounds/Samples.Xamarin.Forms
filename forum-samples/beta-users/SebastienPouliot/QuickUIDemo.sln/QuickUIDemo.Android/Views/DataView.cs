using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Binding.BindingContext;
using QuickUIDemo.Android.Core;
using QuickUIDemo.Android.MvxAdaption;
using Xamarin.QuickUI;

namespace QuickUIDemo.Android.Views
{
    [Activity(Label = "Data View")]
    public class DataView : MvxAndroidActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            QuickUI.Init(this, bundle);
            var page = new DataPage();
            SetPage(page);

            var set = this.CreateBindingSet<DataView, DataViewModel>();
            set.Bind(page.listView).For(v => v.ItemSource).To(vm => vm.People);
            set.Apply();
        }

        public class DataPage : ContentPage
        {
            public ListView listView;

            public DataPage()
            {
                Title = "Person List";

                listView = new ListView
                    {
                        Template = new CellTemplate(typeof(TextCell))
                    };

                // this here is way too closed
                // there is no way into the ListView/Template mechanism to replace the binding engine
                // - it seems the library always uses objects instead of interfaces
                // - it seems the library is very keen to use `internal` constructors, methods, etc
                // - you can't override GetCell in the CellTemplate
                // - you can't override Cell inside TableSectionModel in ListView
                // - you can't create any class directly on top of BindingBase because it has an internal constructor
                // - you can't create any class on top of Binding because it's been sealed
                // pah!
                listView.Template.SetBinding(TextCell.TextProperty, new Binding("Name"));
                listView.Template.SetBinding(TextCell.DetailProperty, new Binding("Title"));

                Content = listView;
            }
        }
    }
}