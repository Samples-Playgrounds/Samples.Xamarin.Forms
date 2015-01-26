using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlsViewsExtras.Charts
{
	public partial class ChartsOxyPlot : Xamarin.Forms.ContentPage
	{
		public ChartsOxyPlot()
		{
			InitializeComponent();
		}


		public void Sample02()
		{
            this.Title = "Gráfico";
            this.Icon = "Icon.png";

            OxyPlot.PlotModel myModel = new OxyPlot.PlotModel("Square wave");
			OxyPlot.Series.LineSeries ls = new OxyPlot.Series.LineSeries("sin(x)+sin(3x)/3+sin(5x)/5+...");
            int n = 10;
            for (double x = -10; x < 10; x += 0.0001)
            {
                double y = 0;
                for (int i = 0; i < n; i++)
                {
                    int j = i * 2 + 1;
                    y += Math.Sin(j * x) / j;
                }
                ls.Points.Add(new OxyPlot.DataPoint(x, y));
            }

            myModel.Series.Add(ls);
            myModel.Axes.Add(new OxyPlot.Axes.LinearAxis(OxyPlot.Axes.AxisPosition.Left, -4, 4));
            myModel.Axes.Add(new OxyPlot.Axes.LinearAxis(OxyPlot.Axes.AxisPosition.Bottom));

            this.Content = new Xamarin.Forms.StackLayout
            {
                Spacing = 20,
                Padding = 10,
                VerticalOptions = Xamarin.Forms.LayoutOptions.Center,
                Children =
                {
                    myModel
                }
            };

            return;
        }

	}
}
