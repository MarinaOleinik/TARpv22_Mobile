using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TARpv22_Mobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EntryPage : ContentPage
	{
        Label lbl;
        Editor editor;
        BoxView box;
		public EntryPage ()
		{
            box = new BoxView
            {
                Color = Color.White,
                CornerRadius = 10,
                WidthRequest = 200,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            //Ekraani suurus
            int mon_height=(int)DeviceDisplay.MainDisplayInfo.Height;
            int mon_width = (int)DeviceDisplay.MainDisplayInfo.Width;

            Button Tagasi_btn = new Button
            {
                Text = "Tagasi Start lehele",
                BackgroundColor = Color.FromRgb(32, 32, 34),
                TextColor = Color.Fuchsia
            };
            lbl = new Label
            { 
                Text = "Mingi tekst",
                BackgroundColor= Color.FromRgb(200, 32,0),
                TextColor= Color.Fuchsia,
            };
            editor = new Editor
            {
                Placeholder = "Sisesta siia tekst...",
                HorizontalOptions = LayoutOptions.Center
            };

            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.FromRgb(32, 32, 255),
                Children = {lbl,editor,box, Tagasi_btn},
                VerticalOptions = LayoutOptions.End
            };
            
            Content = st;
            Tagasi_btn.Clicked += Tagasi_btn_Clicked;
            editor.TextChanged += Editor_TextChanged;
        }

        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            lbl.Text=editor.Text;
        }

        private async void Tagasi_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}