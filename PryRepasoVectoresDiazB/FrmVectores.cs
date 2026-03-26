using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryRepasoVectoresDiazB
{
    public partial class FrmVectores : Form
    {
        public FrmVectores()
        {
            InitializeComponent();
        }
        String[] Usuarios = new String[10];
        Int32 INDICE = 0;
        private int i;

        private void FrmVectores_Load(object sender, EventArgs e)
        {

        }



        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            if (INDICE < 10)

            {
                Usuarios[INDICE] = txtNyA.Text;
                INDICE++;
                MessageBox.Show("El dato se cargo correctamente");
                txtNyA.Text = "";
                Listar();
            }
            else
            {
                MessageBox.Show("No se puede cargar mas datos");
            }
        }

        private void btnListarConFor_Click(object sender, EventArgs e)
        {
            lstPersonas.Items.Clear();
            for (Int32 i = 0; i < INDICE; i++) ;
            {
                lstPersonas.Items.Add(Usuarios[i]);
            }

        }

        private void btnListarconWhile_Click(object sender, EventArgs e)
        {
            lstPersonas.Items.Clear();
            Int32 i = 0;

            while (i < INDICE)


            {
                lstPersonas.Items.Add(Usuarios[i]);
                i++;
            }
        }

        private void Listar()
        {


            lstPersonas.Items.Clear();
            for (Int32 i = 0;i < INDICE;i++)
            {
                lstPersonas.Items.Add(Usuarios[i]);
            }

            
            

        }
    }
}

   
