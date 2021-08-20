using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace HolisticWare.DomainBusinessLogic.UI.MAUI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BodyCompositionFatSkinFoldSites3 : ContentPage, IPage
	{
		public BodyCompositionFatSkinFoldSites3()
		{
			InitializeComponent();
		}

		int count = 0;

		private void OnButtonClicked(object sender, EventArgs e)
		{
		}
	}
}
