using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario3
{
    public partial class Form1 : Form
    {
        Jefe jefe;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCargo.SelectedIndex = 0;
            cboArea.SelectedIndex = 0;
            
        }

        private void btnObjeto_Click(object sender, EventArgs e)
        {

            string Nombre = txtNombres.Text;
            int DNI = int.Parse(txtDNI.Text);
            string Cargo = cboCargo.Text;
            string Area = cboArea.Text;
            int AñosAntiguedad = int.Parse(txtAntiguedad.Text);

            jefe = new Jefe(Nombre,DNI,Cargo,Area,AñosAntiguedad);
            MessageBox.Show("Objeto creado");
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            
            txtResultado.AppendText("Nombre: " + jefe.Nombre + Environment.NewLine);
            txtResultado.AppendText("DNI: " + jefe.DNI + Environment.NewLine);
            txtResultado.AppendText("Cargo: " + jefe.Cargo + Environment.NewLine);
            txtResultado.AppendText("Area: " + jefe.Area + Environment.NewLine);
            txtResultado.AppendText("Años de Antiguedad: " + jefe.AñosAntiguedad + Environment.NewLine);
            txtResultado.AppendText("Sueldo: " + jefe.SueldoBase() + Environment.NewLine);
            txtResultado.AppendText("Movilidad: " + jefe.Movilidad() + Environment.NewLine);
            txtResultado.AppendText("Bonificacion: " + jefe.Bonificacion() + Environment.NewLine);
            txtResultado.AppendText("Sueldo final: " + jefe.SueldoFinal() + Environment.NewLine);
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtNombres.Clear();
            txtDNI.Clear();
            cboCargo.SelectedIndex = 0;
            cboArea.SelectedIndex = 0; 
            txtAntiguedad.Clear();
            txtResultado.Clear();
            txtNombres.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
