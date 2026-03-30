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
        String[] Meses = new String[12] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        Decimal[] Importes = new decimal[12];
       

        private void FrmVectores_Load(object sender, EventArgs e)
        {
            for (Int32 i = 0; i < Meses.Length; i++) 
            {   
                //agregar algo a combobox
                cmbMes.Items.Add(Meses[i]);
                cmbMes.SelectedIndex = 0;
            }
        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            Int32 i = cmbMes.SelectedIndex;
            Decimal importe = Convert.ToDecimal(txtImporte.Text);
            Importes[i] = Importes[i] + importe;
            Listar(); 
            //MessageBox.Show("El importe se cargo correctamente");

            
        }

        private void btnListarConFor_Click(object sender, EventArgs e)
        {       
                dgvListado.Rows.Clear();   
                for(Int32 i = 0;i < Meses.Length;i++)
                {
                    dgvListado.Rows.Add(Meses[i], Importes[i]);                
                }


        }

        private void btnListarconWhile_Click(object sender, EventArgs e)
        {
            Listar();
           
        }

        private void Listar()
        {
            Int32 i = 0;
            dgvListado.Rows.Clear();
            while (i < Meses.Length)
            {

                int v = dgvListado.Rows.Add(Meses[i], Importes[i]);
                i++;

            }

        }
    }
}

   
