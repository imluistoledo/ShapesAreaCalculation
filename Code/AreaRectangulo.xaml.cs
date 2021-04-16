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
    public partial class AreaRectangulo : ContentPage
    {
        public AreaRectangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double _base = Convert.ToDouble(txtBase.Text);
            double _altura = Convert.ToDouble(txtAltura.Text);
            double area;
            if (_base.GetType() == Type.GetType("System.Double") &&
                _altura.GetType() == Type.GetType("System.Double"))
            {
                area = (_base * _altura);
                txtBase.Text = "";
                txtAltura.Text = "";
                lblArea.Text = area.ToString() + " cm^2";
            }
        }
    }
}