namespace CapaPresentacion.INFORMES
{
    partial class Informe_Facturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informe_Facturacion));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnConsultarFactura = new System.Windows.Forms.Button();
            this.dtgInformeFactura = new System.Windows.Forms.DataGridView();
            this.ClnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnTitular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolverInformeFacturacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInformeFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(59, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "INFORME DE FACTURACIÓN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 33);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpFechaFin);
            this.panel1.Controls.Add(this.dtpFechaInicio);
            this.panel1.Controls.Add(this.btnConsultarFactura);
            this.panel1.Controls.Add(this.dtgInformeFactura);
            this.panel1.Controls.Add(this.btnVolverInformeFacturacion);
            this.panel1.Location = new System.Drawing.Point(-2, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 379);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fecha Fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fecha Inicio";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(268, 48);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(175, 20);
            this.dtpFechaFin.TabIndex = 20;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(55, 48);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(175, 20);
            this.dtpFechaInicio.TabIndex = 19;
            // 
            // btnConsultarFactura
            // 
            this.btnConsultarFactura.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConsultarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFactura.Location = new System.Drawing.Point(463, 39);
            this.btnConsultarFactura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultarFactura.Name = "btnConsultarFactura";
            this.btnConsultarFactura.Size = new System.Drawing.Size(99, 35);
            this.btnConsultarFactura.TabIndex = 18;
            this.btnConsultarFactura.Text = "Consultar";
            this.btnConsultarFactura.UseVisualStyleBackColor = false;
            // 
            // dtgInformeFactura
            // 
            this.dtgInformeFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInformeFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnNumero,
            this.ClnTitular,
            this.ClnValor,
            this.ClnFecha});
            this.dtgInformeFactura.Location = new System.Drawing.Point(35, 94);
            this.dtgInformeFactura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgInformeFactura.Name = "dtgInformeFactura";
            this.dtgInformeFactura.RowHeadersWidth = 62;
            this.dtgInformeFactura.RowTemplate.Height = 28;
            this.dtgInformeFactura.Size = new System.Drawing.Size(659, 217);
            this.dtgInformeFactura.TabIndex = 17;
            // 
            // ClnNumero
            // 
            this.ClnNumero.HeaderText = "NUMERO DE FACTURA";
            this.ClnNumero.MinimumWidth = 8;
            this.ClnNumero.Name = "ClnNumero";
            this.ClnNumero.ReadOnly = true;
            this.ClnNumero.Width = 150;
            // 
            // ClnTitular
            // 
            this.ClnTitular.HeaderText = "TITULAR DE LA FACTURA";
            this.ClnTitular.MinimumWidth = 8;
            this.ClnTitular.Name = "ClnTitular";
            this.ClnTitular.ReadOnly = true;
            this.ClnTitular.Width = 150;
            // 
            // ClnValor
            // 
            this.ClnValor.HeaderText = "VALOR DE FACTURA";
            this.ClnValor.MinimumWidth = 8;
            this.ClnValor.Name = "ClnValor";
            this.ClnValor.ReadOnly = true;
            this.ClnValor.Width = 150;
            // 
            // ClnFecha
            // 
            this.ClnFecha.HeaderText = "FECHA DE FACTURACIÓN";
            this.ClnFecha.MinimumWidth = 8;
            this.ClnFecha.Name = "ClnFecha";
            this.ClnFecha.ReadOnly = true;
            this.ClnFecha.Width = 150;
            // 
            // btnVolverInformeFacturacion
            // 
            this.btnVolverInformeFacturacion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVolverInformeFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverInformeFacturacion.Location = new System.Drawing.Point(619, 326);
            this.btnVolverInformeFacturacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolverInformeFacturacion.Name = "btnVolverInformeFacturacion";
            this.btnVolverInformeFacturacion.Size = new System.Drawing.Size(91, 38);
            this.btnVolverInformeFacturacion.TabIndex = 16;
            this.btnVolverInformeFacturacion.Text = "Volver";
            this.btnVolverInformeFacturacion.UseVisualStyleBackColor = false;
            this.btnVolverInformeFacturacion.Click += new System.EventHandler(this.btnVolverInformeFacturacion_Click);
            // 
            // Informe_Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(727, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Informe_Facturacion";
            this.Text = "Informe_Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInformeFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgInformeFactura;
        private System.Windows.Forms.Button btnVolverInformeFacturacion;
        private System.Windows.Forms.Button btnConsultarFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnTitular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnFecha;
    }
}