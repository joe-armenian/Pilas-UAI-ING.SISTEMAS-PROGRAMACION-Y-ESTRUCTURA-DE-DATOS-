using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas
{
    public partial class Form1 : Form
    {

        MiPila  _miPila = new MiPila();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarNuevoNodo_Click(object sender, EventArgs e)
        {
            MiNodo unNuevoNodo=new MiNodo();
            unNuevoNodo.Nombre = txtNombreNodo.Text;
            _miPila.Apilar(unNuevoNodo);
            MostrarPila();

        }



        public void MostrarPila()
        {
            lstMiPila.Items.Clear();

            if (_miPila.Tope() != null)
            {
                MostrarNodoEnLista(_miPila.Tope());
            }
        


    }

        public void MostrarNodoEnLista(MiNodo unNodo)
        {
            lstMiPila.Items.Add(unNodo.Nombre);

            if (unNodo.Siguiente != null)
            {
                MostrarNodoEnLista(unNodo.Siguiente);

            }
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            _miPila.Desapilar();
            MostrarPila();

        }
    }
}
