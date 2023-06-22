using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace Pract6_2_variant6_Shvets
{
    public partial class MainPage :CarouselPage
    {
        public List<TypesofWork> work { get; set; }
        public MainPage ()
        {
            InitializeComponent();
            work = new List<TypesofWork>
        {
            new TypesofWork {Title="Уборно-моечные", Image="cleaning.jpg" },
            new TypesofWork {Title="Контрольно-диагностические", Image="repair.jpg" },
            new TypesofWork {Title = "Профилактический ремонт",Image = "repair1.jpeg"}
        };
            this.BindingContext = this;
        }

        private void workList_ItemSelected (object sender, SelectedItemChangedEventArgs e)
        {
            carousel.CurrentPage = second;
        }

        private void choiseTermButton_Clicked (object sender, EventArgs e)
        {
            if(CheckString(workList.SelectedItem.ToString(),"тип работы")&& CheckString(vehicleEntry.Text,"марка авто")&& CheckNumber(maintenenceEntry.Text,"содержание ремонта"))
                Navigation.PushAsync(new ChoiseTerm(workList.SelectedItem.ToString(),vehicleEntry.Text,int.Parse(maintenenceEntry.Text)));
        }

        private void countSummButton_Clicked (object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        private bool CheckString(string value,string field)
        {
            if (value == null || value.Length <= 2)
            {
                this.DisplayToastAsync($"Строка {field} должна быть больше 2 символов");
                return false;
            }
            return true;
        }
        private bool CheckNumber(string value,string field)
        {
            try
            {

                if (int.Parse(value) <= 0)
                {
                    this.DisplayToastAsync($"Значение {field} должно быть больше 0");
                    return false;
                }
                return true;
            } catch
            {
                this.DisplayToastAsync($"Значение {field} не является целым числом");
                return false;
            }
        }
    }
}
