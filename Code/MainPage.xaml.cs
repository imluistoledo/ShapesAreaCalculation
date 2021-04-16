using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mide_tu_figura
{
    public partial class MainPage : ContentPage
    {
        public IList<FigurasProps> Figuras { get; private set; }

        private FigurasProps _FiguraSeleccionada { get; set; }

        public FigurasProps FiguraSeleccionada
        {
            get { return _FiguraSeleccionada; }
            set
            {
                if (_FiguraSeleccionada != value)
                {
                    _FiguraSeleccionada = value;
                    //Llama al metodo para identificar el elemento seleccionado
                    SeleccionoFigura();
                }
            }
        }

        private async void SeleccionoFigura()
        {
            // Obtiene el nombre de la figura que se selecciono
            var figuraSeleccionada = FiguraSeleccionada.txtFigura.ToString();
            
            // Segun la figura, redirecciona a su respectiva pagina
            switch (figuraSeleccionada)
            {
                case "Círculo": // Redirige a pagina del area del Circulo
                    await Navigation.PushAsync(new AreaCirculo());
                    break;
                case "Triángulo": // Redirige a pagina del area del Triangulo
                    await Navigation.PushAsync(new AreaTriangulo());
                    break;
                case "Rectángulo": // Redirige a pagina del area del Rectangulo
                    await Navigation.PushAsync(new AreaRectangulo());
                    break;
                case "Cuadrado": // Redirige a pagina del area del Cuadrado
                    await Navigation.PushAsync(new AreaCuadrado());
                    break;
                default:
                    break;
            }
        }

        public MainPage()
        {
            InitializeComponent();
            Figuras = new List<FigurasProps>();

            Figuras.Add(new FigurasProps
            {
                imgFigura = "circulo.png",
                txtFigura = "Círculo",
                txtFormula = @"Fórmula: A = 𝝅 r^2",
                clrFigura = "#ED1C24"
            });
            Figuras.Add(new FigurasProps
            {
                imgFigura = "triangulo.png",
                txtFigura = "Triángulo",
                txtFormula = @"Fórmula: A = (b ∗ h) / 2",
                clrFigura = "#22B14C"
            });
            Figuras.Add(new FigurasProps
            {
                imgFigura = "rectangulo.png",
                txtFigura = "Rectángulo",
                txtFormula = @"Fórmula: A = b * h",
                clrFigura = "#FFC90E"
            });
            Figuras.Add(new FigurasProps
            {
                imgFigura = "cuadrado.png",
                txtFigura = "Cuadrado",
                txtFormula = @"Fórmula: A = l * l",
                clrFigura = "#00A2E8"
            });

            BindingContext = this;
        }
    }
}
