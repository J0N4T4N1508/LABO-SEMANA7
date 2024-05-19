namespace Formulario2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblCondiciondeTrabajo = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblTipodeAfiliacion = new System.Windows.Forms.Label();
            this.lblTipodeActividad = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.cboCondiciondeContrato = new System.Windows.Forms.ComboBox();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.cboTipodeActividad = new System.Windows.Forms.ComboBox();
            this.cboTipodeAfiliacion = new System.Windows.Forms.ComboBox();
            this.btnCrearObjeto = new System.Windows.Forms.Button();
            this.btnMostrarResultado = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(22, 42);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(22, 80);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(63, 16);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres";
            // 
            // lblCondiciondeTrabajo
            // 
            this.lblCondiciondeTrabajo.AutoSize = true;
            this.lblCondiciondeTrabajo.Location = new System.Drawing.Point(248, 39);
            this.lblCondiciondeTrabajo.Name = "lblCondiciondeTrabajo";
            this.lblCondiciondeTrabajo.Size = new System.Drawing.Size(139, 16);
            this.lblCondiciondeTrabajo.TabIndex = 2;
            this.lblCondiciondeTrabajo.Text = "Condicion de Contrato";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(248, 80);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(87, 16);
            this.lblEspecialidad.TabIndex = 3;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblTipodeAfiliacion
            // 
            this.lblTipodeAfiliacion.AutoSize = true;
            this.lblTipodeAfiliacion.Location = new System.Drawing.Point(532, 77);
            this.lblTipodeAfiliacion.Name = "lblTipodeAfiliacion";
            this.lblTipodeAfiliacion.Size = new System.Drawing.Size(111, 16);
            this.lblTipodeAfiliacion.TabIndex = 4;
            this.lblTipodeAfiliacion.Text = "Tipo de Afiliacion";
            // 
            // lblTipodeActividad
            // 
            this.lblTipodeActividad.AutoSize = true;
            this.lblTipodeActividad.Location = new System.Drawing.Point(532, 42);
            this.lblTipodeActividad.Name = "lblTipodeActividad";
            this.lblTipodeActividad.Size = new System.Drawing.Size(113, 16);
            this.lblTipodeActividad.TabIndex = 5;
            this.lblTipodeActividad.Text = "Tipo de Actividad";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(107, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 22);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(107, 74);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(121, 22);
            this.txtNombres.TabIndex = 7;
            // 
            // cboCondiciondeContrato
            // 
            this.cboCondiciondeContrato.FormattingEnabled = true;
            this.cboCondiciondeContrato.Items.AddRange(new object[] {
            "Estable",
            "Contratado"});
            this.cboCondiciondeContrato.Location = new System.Drawing.Point(393, 34);
            this.cboCondiciondeContrato.Name = "cboCondiciondeContrato";
            this.cboCondiciondeContrato.Size = new System.Drawing.Size(121, 24);
            this.cboCondiciondeContrato.TabIndex = 12;
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Items.AddRange(new object[] {
            "Estructuras",
            "Recursos Hidricos"});
            this.cboEspecialidad.Location = new System.Drawing.Point(393, 72);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(121, 24);
            this.cboEspecialidad.TabIndex = 13;
            // 
            // cboTipodeActividad
            // 
            this.cboTipodeActividad.FormattingEnabled = true;
            this.cboTipodeActividad.Items.AddRange(new object[] {
            "Supervision de Obras",
            "Supervision de Vias"});
            this.cboTipodeActividad.Location = new System.Drawing.Point(662, 39);
            this.cboTipodeActividad.Name = "cboTipodeActividad";
            this.cboTipodeActividad.Size = new System.Drawing.Size(170, 24);
            this.cboTipodeActividad.TabIndex = 14;
            // 
            // cboTipodeAfiliacion
            // 
            this.cboTipodeAfiliacion.FormattingEnabled = true;
            this.cboTipodeAfiliacion.Items.AddRange(new object[] {
            "AFP",
            "SNP"});
            this.cboTipodeAfiliacion.Location = new System.Drawing.Point(662, 72);
            this.cboTipodeAfiliacion.Name = "cboTipodeAfiliacion";
            this.cboTipodeAfiliacion.Size = new System.Drawing.Size(170, 24);
            this.cboTipodeAfiliacion.TabIndex = 15;
            // 
            // btnCrearObjeto
            // 
            this.btnCrearObjeto.Location = new System.Drawing.Point(12, 478);
            this.btnCrearObjeto.Name = "btnCrearObjeto";
            this.btnCrearObjeto.Size = new System.Drawing.Size(108, 23);
            this.btnCrearObjeto.TabIndex = 18;
            this.btnCrearObjeto.Text = "Crear Objeto";
            this.btnCrearObjeto.UseVisualStyleBackColor = true;
            this.btnCrearObjeto.Click += new System.EventHandler(this.btnCrearObjeto_Click);
            // 
            // btnMostrarResultado
            // 
            this.btnMostrarResultado.Location = new System.Drawing.Point(155, 478);
            this.btnMostrarResultado.Name = "btnMostrarResultado";
            this.btnMostrarResultado.Size = new System.Drawing.Size(133, 23);
            this.btnMostrarResultado.TabIndex = 20;
            this.btnMostrarResultado.Text = "Mostrar resultado";
            this.btnMostrarResultado.UseVisualStyleBackColor = true;
            this.btnMostrarResultado.Click += new System.EventHandler(this.btnMostrarResultado_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(25, 171);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(778, 261);
            this.txtResultado.TabIndex = 21;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(330, 478);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(456, 478);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 513);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnMostrarResultado);
            this.Controls.Add(this.btnCrearObjeto);
            this.Controls.Add(this.cboTipodeAfiliacion);
            this.Controls.Add(this.cboTipodeActividad);
            this.Controls.Add(this.cboEspecialidad);
            this.Controls.Add(this.cboCondiciondeContrato);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblTipodeActividad);
            this.Controls.Add(this.lblTipodeAfiliacion);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblCondiciondeTrabajo);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblCodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblCondiciondeTrabajo;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblTipodeAfiliacion;
        private System.Windows.Forms.Label lblTipodeActividad;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.ComboBox cboCondiciondeContrato;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.ComboBox cboTipodeActividad;
        private System.Windows.Forms.ComboBox cboTipodeAfiliacion;
        private System.Windows.Forms.Button btnCrearObjeto;
        private System.Windows.Forms.Button btnMostrarResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

