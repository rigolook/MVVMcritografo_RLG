using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CritografoMVVM_RLG.VistaModelo
{
    public class VMcritografo : BaseViewModel
    {
        #region VARIABLES
        string _nombre;
        bool _generoh;
        bool _generom;
        bool _feo;
        bool _hermoso;
        bool _alto;
        bool _bajo;
        bool _listo;
        bool _tonto;
        string _critica;
        #endregion

        #region OBJETOS
        public string Critica
        {
            get { return _critica; }
            set { SetValue(ref _critica, value);} 
        }
        public string Nombre
        {
            get { return _nombre; }
            set { SetValue(ref _nombre, value); }
        }
        public bool GeneroH
        {
            get { return _generoh; }
            set { SetValue(ref _generoh, value);}
        }
        public bool GeneroM
        {
            get { return _generom; }
            set { SetValue(ref _generom, value); }
        }
        public bool Feo
        {
            get { return _feo; }
            set { SetValue(ref _feo, value); }
        }
        public bool Hermoso
        {
            get { return _hermoso; }
            set { SetValue(ref _hermoso, value); }
        }
        public bool Alto
        {
            get { return _alto; }
            set { SetValue(ref _alto, value); }
        }
        public bool Bajo
        {
            get { return _bajo; }
            set { SetValue(ref _bajo, value);}
        }
        public bool Listo
        {
            get { return _listo; }
            set { SetValue(ref _listo, value);}
        }
        public bool Tonto
        {
            get { return _tonto; }
            set{SetValue(ref _tonto, value);}
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void criticas()
        {
            string nombre = Nombre;
            

            string caracteristicas = obtenerCaracteristicas();
            string critica;
            if (GeneroH)
            {
                critica = $"{nombre} su genero es hombre, el es {caracteristicas}";
            }
            else if (GeneroM)
            {
                critica = $"{nombre} su genero es mujer, ella es {caracteristicas}";
            }
            else
            {
                critica = "su genero desconocido";
            }
            Critica = critica+".";
        }
        private string obtenerCaracteristicas()
        {
            var caracteristicasSeleccionadas = new System.Collections.Generic.List<string>();
            if (GeneroH == true)
            {
                if (Feo) { caracteristicasSeleccionadas.Add("feo"); }
                if (Hermoso) { caracteristicasSeleccionadas.Add("hermoso"); }
                if (Alto) { caracteristicasSeleccionadas.Add("alto"); }
                if (Bajo) { caracteristicasSeleccionadas.Add("bajo"); }
                if (Listo) { caracteristicasSeleccionadas.Add("listo"); }
                if (Tonto) { caracteristicasSeleccionadas.Add("tonto"); }
            }
            else
            {
                if (Feo) { caracteristicasSeleccionadas.Add("fea"); }
                if (Hermoso) { caracteristicasSeleccionadas.Add("hermosa"); }
                if (Alto) { caracteristicasSeleccionadas.Add("alta"); }
                if (Bajo) { caracteristicasSeleccionadas.Add("baja"); }
                if (Listo) { caracteristicasSeleccionadas.Add("lista"); }
                if (Tonto) { caracteristicasSeleccionadas.Add("tonta"); }
            }

            if (caracteristicasSeleccionadas.Count > 1)
            {
                int lastIndex = caracteristicasSeleccionadas.Count - 1;
                caracteristicasSeleccionadas[lastIndex] = "y " + caracteristicasSeleccionadas[lastIndex];
            }

            return string.Join(", ", caracteristicasSeleccionadas);
        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand criticacommand => new Command(criticas);
        #endregion
        #region CONTRUCTOR
        public VMcritografo(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
    }
}
