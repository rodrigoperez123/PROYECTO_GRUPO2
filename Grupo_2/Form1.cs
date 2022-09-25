using System;//Rodrigo Alejandro
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            ActualizarLista();
            timer1.Enabled = true;

        }//Rodrigo Alejandro
        private void ActualizarLista()
        {//Jonathan Arriaga
            Admin.Rows.Clear();
            foreach (Process p in Process.GetProcesses()){
                int n = Admin.Rows.Add();
                Admin.Rows[n].Cells[0].Value = p.ProcessName;
                Admin.Rows[n].Cells[1].Value = p.Id;
                Admin.Rows[n].Cells[2].Value = p.WorkingSet64;
                Admin.Rows[n].Cells[3].Value = p.VirtualMemorySize64;
                Admin.Rows[n].Cells[4].Value = p.SessionId;
            }
            txtcontador.Text = "Procesos Actuales: " + Admin.Rows.Count.ToString();
            }

        private void btnDetener_Click(object sender, EventArgs e)//Erick Ramirez
        {
            try
            {
                foreach (Process p in Process.GetProcesses())
                {
                    if (p.ProcessName == txtNumProces.Text)
                    {
                        p.Kill(); // elimina el proceso
                        
                    }
                }
            }
            catch (Exception x)
            { 
            MessageBox.Show(" no selecciono nigun proceso " + x, " error al eliminar ", MessageBoxButtons.OK);
            }
            ActualizarLista();
        }
        

        private void dgvAdministrador_CellContentClick(object sender, DataGridViewCellEventArgs e)//Jefferson Juarez
        {
            txtNumProces.Text = Admin.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizarLista();
        }
    }
}
