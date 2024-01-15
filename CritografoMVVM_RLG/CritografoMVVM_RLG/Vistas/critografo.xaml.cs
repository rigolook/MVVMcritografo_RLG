using CritografoMVVM_RLG.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CritografoMVVM_RLG.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class critografo : ContentPage
    {
        public critografo()
        {
            InitializeComponent();
            BindingContext = new VMcritografo(Navigation);
        }
    }
}