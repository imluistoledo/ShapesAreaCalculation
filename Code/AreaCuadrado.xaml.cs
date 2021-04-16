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
    public partial class AreaCuadrado : ContentPage
    {
        public AreaCuadrado()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double lado = Convert.ToDouble(txtRadio.Text);
            double area;
            if (lado.GetType() == Type.GetType("System.Double"))
            {
                area = (lado*lado);
                txtRadio.Text = "";
                lblArea.Text = area.ToString() + " cm^2";
            }
        }
    }
}