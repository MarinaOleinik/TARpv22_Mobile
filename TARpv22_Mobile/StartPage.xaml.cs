using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TARpv22_Mobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StartPage : ContentPage
	{
		public StartPage ()
		{
			Button Entry_btn = new Button
			{
				Text = "Entry leht",
				BackgroundColor = Color.FromRgb(100, 32, 34),
				TextColor=Color.Fuchsia
			};
            Button Time_btn = new Button
            {
                Text = "Time leht",
                BackgroundColor = Color.FromRgb(100, 32, 34),
                TextColor = Color.Fuchsia
            };
            Button Entry_b22tn = new Button
            {
                Text = "Entry leht",
                BackgroundColor = Color.FromRgb(100, 32, 34),
                TextColor = Color.Fuchsia
            };
            Button Time_b2tn = new Button
            {
                Text = "Time leht",
                BackgroundColor = Color.FromRgb(100, 32, 34),
                TextColor = Color.Fuchsia
            };
            Button Entry_bt2n = new Button
            {
                Text = "Entry leht",
                BackgroundColor = Color.FromRgb(100, 32, 34),
                TextColor = Color.Fuchsia
            };
            
            StackLayout st = new StackLayout
			{
				Orientation = StackOrientation.Vertical,
				BackgroundColor = Color.FromRgb(32, 32, 255)
			};
			st.Children.Add(Entry_btn);
			st.Children.Add(Time_btn);
            
			Content = st;
            
            Time_btn.Clicked += Time_btn_Clicked;
           

        }

        private async  void Time_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TimePage());
        }

        private async void Entry_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EntryPage());
        }
        
    }
}