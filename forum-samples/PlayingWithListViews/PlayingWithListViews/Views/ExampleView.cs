using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using PlayingWithListViews.ValueConverters;
using PlayingWithListViews.ViewModels;
using Xamarin.QuickUI;

namespace PlayingWithListViews.Views
{
    public class ExampleView : ContentPage
    {
        public ExampleView()
        {
            Title = "Hours";
            var exampleViewModel = new ExampleViewModel();
            BindingContext = exampleViewModel;
            
            var listView = new ListView
            {
                ItemTemplate = new DataTemplate(() =>
                {
                    var jobId = new Label();                    
                    jobId.Font = Font.SystemFontOfSize(20);
                    jobId.WidthRequest = 105;
                    jobId.VerticalOptions = LayoutOptions.Center;
                    jobId.SetBinding(Label.TextProperty, "JobId");
                    jobId.HorizontalOptions = LayoutOptions.StartAndExpand;
                    var jobName = new Label();
                    jobName.VerticalOptions = LayoutOptions.Center;
                    jobName.SetBinding(Label.TextProperty, "JobName");
                    jobName.WidthRequest = 175;
                    jobName.HorizontalOptions = LayoutOptions.CenterAndExpand;
                    var hours = new Label();
                    hours.WidthRequest = 45;
                    hours.VerticalOptions = LayoutOptions.Center;
                    hours.XAlign = TextAlignment.End;
                    hours.HorizontalOptions = LayoutOptions.EndAndExpand;
                    hours.SetBinding(Label.TextProperty, new Binding("Hours", BindingMode.OneWay, new DoubleStringConverter()));
                    var hlayout = new StackLayout();
                    hlayout.Children.Add(jobId);
                    hlayout.Children.Add(jobName);
                    hlayout.Children.Add(hours);
                    hlayout.Orientation = StackOrientation.Horizontal;
                    return (Cell)new ViewCell(hlayout);
                })
            };
            listView.SetBinding(ListView.ItemSourceProperty, new Binding("Jobs", BindingMode.TwoWay));

            var addOneJobButton = new Button
            {
                Text = "Add One"
            };
            addOneJobButton.SetBinding(Button.CommandProperty, new Binding("AddOneCommand"));

            var addTwoJobsButton = new Button
            {
                Text = "Add Two"
            };
            addTwoJobsButton.SetBinding(Button.CommandProperty, new Binding("AddTwoCommand"));
            
            var layout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Start,
                Spacing = 15
            };            
            layout.Children.Add(listView);    
            layout.Children.Add(addOneJobButton);
            layout.Children.Add(addTwoJobsButton);
            Content = layout;

        }        


       
    }
}