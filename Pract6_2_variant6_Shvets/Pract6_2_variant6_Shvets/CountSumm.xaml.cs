using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pract6_2_variant6_Shvets
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CountSumm :ContentPage
    {
        double oklad;
        string vehicle;
        string price;
        string maintenence;
        double countOfDays;
        public CountSumm(string countOfDays, string oklad, string vehichle, string price, string maintenence)
        {
            InitializeComponent();
            this.oklad = double.Parse(oklad);
            this.vehicle = vehichle;
            this.price = price;
            this.maintenence = maintenence;
            this.countOfDays = double.Parse(countOfDays);
            countPrice();

        }
        public void countPrice()
        {
            double percent;
            if (countOfDays>=1 && countOfDays<=3)
            {
                percent = 0.6;
            }
            else if(countOfDays>=4&& countOfDays<=6) 
            {
                percent = 0.75;
            }
            else if (countOfDays >= 20 && countOfDays <= 30)
            {
                percent = 1.2;
            }
            else
            {
                percent = 1;
            }
            double result = (oklad * percent)*1.2;
            stoPriceLabel.Text += result.ToString();
            
        }

        private void homePageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage(countOfDays.ToString(), oklad.ToString(), vehicle, price, maintenence));
        }
    }
}