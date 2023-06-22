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
    public partial class ChoiseTerm :ContentPage
    {
        public ChoiseTerm (string typeOfWork,string mark,int maintenence)
        {
            InitializeComponent();
        }
    }
}