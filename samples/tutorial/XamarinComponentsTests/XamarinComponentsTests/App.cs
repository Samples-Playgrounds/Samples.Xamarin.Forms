using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

using System.Collections.ObjectModel;

using Syncfusion.SfChart.XForms;

namespace XamarinComponentsTests
{
	public class App
		: Application // superclass new in 1.3
	{
	    public App ()
	    {
	        // The root page of your application
	        MainPage =	// property 
				new WeatherChartDemo()
				; 	

	        return;
	    }

		//public static Page GetMainPage()
		//{
		//	return new WeatherChartDemo();
		//}
	}

	public class WeatherChartDemo : ContentPage
	{

		public WeatherChartDemo()
		{
			//Initializing chart
			SfChart chart = new SfChart();
			chart.Title = new ChartTitle() { Text = "Weather Analysis" };

			//Initializing Primary Axis
			CategoryAxis primaryAxis = new CategoryAxis();
			primaryAxis.Title = new ChartAxisTitle() { Text = "Month" };

			chart.PrimaryAxis = primaryAxis;

			//Initializing Secondary Axis
			NumericalAxis secondaryAxis = new NumericalAxis();
			secondaryAxis.Title = new ChartAxisTitle() { Text = "Temperature" };

			chart.SecondaryAxis = secondaryAxis;


			DataModel dataModel = new DataModel();

			//Adding ColumnSeries to the chart for percipitation
			chart.Series.Add(new ColumnSeries()
			{
				ItemsSource = dataModel.Precipitation,
				Label = "Precipitation",
				YAxis = new NumericalAxis()
				{
					OpposedPosition = true,
					ShowMajorGridLines = false
				}
			});

			//Adding the SplineSeries to the chart for high temperature
			chart.Series.Add(new SplineSeries()
			{
				ItemsSource = dataModel.HighTemperature,
				Label = "High"
			});

			//Adding the SplineSeries to the chart for low temperature
			chart.Series.Add(new SplineSeries()
			{
				ItemsSource = dataModel.LowTemperature,
				Label = "Low"
			});

			//Adding Chart Legend for the Chart
			chart.Legend = new ChartLegend() { IsVisible = true };

			this.Content = chart;

			return;
		}
	}

	public class DataModel
	{
		public ObservableCollection<ChartDataPoint> HighTemperature;

		public ObservableCollection<ChartDataPoint> LowTemperature;

		public ObservableCollection<ChartDataPoint> Precipitation;

		public DataModel()
		{
			HighTemperature = new ObservableCollection<ChartDataPoint>();

			HighTemperature.Add(new ChartDataPoint("Jan", 42));
			HighTemperature.Add(new ChartDataPoint("Feb", 44));
			HighTemperature.Add(new ChartDataPoint("Mar", 53));
			HighTemperature.Add(new ChartDataPoint("Apr", 64));
			HighTemperature.Add(new ChartDataPoint("May", 75));
			HighTemperature.Add(new ChartDataPoint("Jun", 83));
			HighTemperature.Add(new ChartDataPoint("Jul", 87));
			HighTemperature.Add(new ChartDataPoint("Aug", 84));
			HighTemperature.Add(new ChartDataPoint("Sep", 78));
			HighTemperature.Add(new ChartDataPoint("Oct", 67));
			HighTemperature.Add(new ChartDataPoint("Nov", 55));
			HighTemperature.Add(new ChartDataPoint("Dec", 45));

			LowTemperature = new ObservableCollection<ChartDataPoint>();

			LowTemperature.Add(new ChartDataPoint("Jan", 27));
			LowTemperature.Add(new ChartDataPoint("Feb", 28));
			LowTemperature.Add(new ChartDataPoint("Mar", 35));
			LowTemperature.Add(new ChartDataPoint("Apr", 44));
			LowTemperature.Add(new ChartDataPoint("May", 54));
			LowTemperature.Add(new ChartDataPoint("Jun", 63));
			LowTemperature.Add(new ChartDataPoint("Jul", 68));
			LowTemperature.Add(new ChartDataPoint("Aug", 66));
			LowTemperature.Add(new ChartDataPoint("Sep", 59));
			LowTemperature.Add(new ChartDataPoint("Oct", 48));
			LowTemperature.Add(new ChartDataPoint("Nov", 38));
			LowTemperature.Add(new ChartDataPoint("Dec", 29));

			Precipitation = new ObservableCollection<ChartDataPoint>();

			Precipitation.Add(new ChartDataPoint("Jan", 3.03));
			Precipitation.Add(new ChartDataPoint("Feb", 2.48));
			Precipitation.Add(new ChartDataPoint("Mar", 3.23));
			Precipitation.Add(new ChartDataPoint("Apr", 3.15));
			Precipitation.Add(new ChartDataPoint("May", 4.13));
			Precipitation.Add(new ChartDataPoint("Jun", 3.23));
			Precipitation.Add(new ChartDataPoint("Jul", 4.13));
			Precipitation.Add(new ChartDataPoint("Aug", 4.88));
			Precipitation.Add(new ChartDataPoint("Sep", 3.82));
			Precipitation.Add(new ChartDataPoint("Oct", 3.07));
			Precipitation.Add(new ChartDataPoint("Nov", 2.83));
			Precipitation.Add(new ChartDataPoint("Dec", 2.8));
		}
	}
}