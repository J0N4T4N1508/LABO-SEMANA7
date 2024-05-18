using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario2
{
    public partial class Form1 : Form
    {
        Arquitecto arquitecto;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCondiciondeContrato.SelectedIndex = 0;
            cboEspecialidad.SelectedIndex = 0;
            cboTipodeActividad.SelectedIndex = 0;
            cboTipodeAfiliacion.SelectedIndex = 0;
        }

        private void btnCrearObjeto_Click(object sender, EventArgs e)
        {
            int Codigo = int.Parse(txtCodigo.Text);
            string Nombres = txtNombres.Text;
            string CondicionContrato = cboCondiciondeContrato.Text;
            string Especialidad = cboEspecialidad.Text;
            string TipoActividad = cboTipodeActividad.Text;
            string TipoAfiliacion = cboTipodeAfiliacion.Text;

            arquitecto = new Arquitecto(Codigo,Nombres,CondicionContrato,Especialidad,TipoActividad,TipoAfiliacion);
            MessageBox.Show("Objeto creado");
        }

        private void btnMostrarResultado_Click(object sender, EventArgs e)
        {
            //txtResultado.AppendText("Objeto Nro: " + Arquitecto.GetContador().ToString() + Environment.NewLine);
            txtResultado.AppendText("Codigo: " + arquitecto.Codigo + Environment.NewLine);
            txtResultado.AppendText("Nombre: " + arquitecto.Nombres + Environment.NewLine);
            txtResultado.AppendText("Condicion de contrato: " + arquitecto.CondicionContrato + Environment.NewLine);
            txtResultado.AppendText("Especialidad: " + arquitecto.Especialidad + Environment.NewLine);
            txtResultado.AppendText("Tipo de actividad: " + arquitecto.TipoActividad + Environment.NewLine);
            txtResultado.AppendText("Tipo de afiliacion: " + arquitecto.TipoAfiliacion + Environment.NewLine);
            txtResultado.AppendText("Sueldo: " + arquitecto.SueldoBase() + Environment.NewLine);
            txtResultado.AppendText("Bonificacion: " + arquitecto.Bonificacion() + Environment.NewLine);
            txtResultado.AppendText("Descuento: " + arquitecto.Descuento() + Environment.NewLine);
            txtResultado.AppendText("Sueldo Bruto: " + arquitecto.SueldoBruto() + Environment.NewLine);
            txtResultado.AppendText("Sueldo Neto: " + arquitecto.SueldoNeto() + Environment.NewLine);


        }
    }
}
