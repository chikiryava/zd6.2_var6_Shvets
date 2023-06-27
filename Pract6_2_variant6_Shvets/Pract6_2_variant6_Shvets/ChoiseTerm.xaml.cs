using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pract6_2_variant6_Shvets
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChoiseTerm :ContentPage
    {
        string oklad;
        string vehicle;
        string price;
        string maintenence;
        public ChoiseTerm (string typeOfWork, string countOfDays, string oklad, string vehichle, string price, string maintenence)
        {
            InitializeComponent();
            type.Text = typeOfWork;
            vehicleMark.Text = vehichle;
            vehicleMaintenence.Text = maintenence.ToString();
            this.oklad = oklad;
            this.vehicle = vehichle;
            this.price = price;
            this.maintenence = maintenence;
        }
        private bool Check ()
        {
            if (days.Text == null || int.Parse(days.Text) < 1 || int.Parse(days.Text) > 30)
            {
                this.DisplayToastAsync("Количество дней должно быть больше 1 и меньше 30");
                return false;
            };
            return true;
        }

        private void Button_Clicked (object sender, EventArgs e)
        {
            if (Check())
                Navigation.PushAsync(new MainPage(int.Parse(days.Text),oklad, vehicle, price, maintenence));
        }

        private void Button_Clicked_1 (object sender, EventArgs e)
        {
            if (Check())
            {
                Navigation.PushAsync(new MainPage(int.Parse(days.Text), oklad, vehicle, price, maintenence));
            }
                
        }
    }
}