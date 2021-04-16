using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mide_tu_figura
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AreaCirculo : ContentPage
    {
        public AreaCirculo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double radio = Convert.ToDouble(txtRadio.Text);
            double pi = 3.1416;
            double area;
            if (radio.GetType() == Type.GetType("System.Double"))
            {
                area = (pi*(radio * radio));
                txtRadio.Text = "";
                lblArea.Text = area.ToString() + " cm^2";
            }
        }
    }
}