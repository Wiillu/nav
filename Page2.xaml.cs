using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace nav
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        public void AnteriorPag(object sender, EventArgs e)
        {
            Navigation.PopAsync();//sirve para ir a la pagina anterior
        }
        public void SiguientePag(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new Page3());
            Navigation.PushModalAsync(new Page3());//modal que quita la barra de navegacion a l pagina dirigida
        }
    }
}