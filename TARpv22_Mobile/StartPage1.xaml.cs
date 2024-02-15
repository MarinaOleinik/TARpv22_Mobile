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
    public partial class StartPage1 : ContentPage
    {
        List<ContentPage> pages = new List<ContentPage>() { new EntryPage() , new TimePage(), new DateTimePage()};
        List<string> texts = new List<string>() {"Ava entry leht", "Ava timer leht", "Ava kalendi leht"};
        StackLayout st;
        public StartPage1()
        {
            st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.AliceBlue
            };
            for (int i = 0; i < pages.Count; i++)
            {
                Button button = new Button
                {
                    Text = texts[i],
                    BackgroundColor=Color.AntiqueWhite,
                    TextColor=Color.Black,
                    TabIndex = i
                };
                st.Children.Add(button);
                button.Clicked += Ava_vajav_leht;
            }
            ScrollView sv=new ScrollView { Content=st };
            Content = sv;
        }
        private async void Ava_vajav_leht(object sender, EventArgs e)
        {
            Button btn=(Button)sender;
            await Navigation.PushAsync(pages[btn.TabIndex]);
        }
    }
}