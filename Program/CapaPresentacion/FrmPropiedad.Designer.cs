
namespace CapaPresentacion
{
    partial class FrmPropiedad
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGuardarr = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtValorDeVenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtAgente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPropiedadID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTamaño = new System.Windows.Forms.TextBox();
            this.TxtEstacionamiento = new System.Windows.Forms.TextBox();
            this.TxtBaños = new System.Windows.Forms.TextBox();
            this.TxtDormitorios = new System.Windows.Forms.TextBox();
            this.TxtUbicacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(13, 40);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(587, 482);
            this.DGV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mantenedor de Propiedades";
            // 
            // BtnGuardarr
            // 
            this.BtnGuardarr.Location = new System.Drawing.Point(606, 418);
            this.BtnGuardarr.Name = "BtnGuardarr";
            this.BtnGuardarr.Size = new System.Drawing.Size(119, 48);
            this.BtnGuardarr.TabIndex = 2;
            this.BtnGuardarr.Text = "Ingresar Propiedad";
            this.BtnGuardarr.UseVisualStyleBackColor = true;
            this.BtnGuardarr.Click += new System.EventHandler(this.BtnGuardarr_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(731, 418);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(119, 48);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.Text = "Realizar modificación";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(606, 473);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(244, 49);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtValorDeVenta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtAgente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtPropiedadID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtTamaño);
            this.groupBox1.Controls.Add(this.TxtEstacionamiento);
            this.groupBox1.Controls.Add(this.TxtBaños);
            this.groupBox1.Controls.Add(this.TxtDormitorios);
            this.groupBox1.Controls.Add(this.TxtUbicacion);
            this.groupBox1.Location = new System.Drawing.Point(612, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 372);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Valor de Venta";
            // 
            // TxtValorDeVenta
            // 
            this.TxtValorDeVenta.Location = new System.Drawing.Point(6, 129);
            this.TxtValorDeVenta.Name = "TxtValorDeVenta";
            this.TxtValorDeVenta.Size = new System.Drawing.Size(238, 20);
            this.TxtValorDeVenta.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "AgenteID";
            // 
            // TxtAgente
            // 
            this.TxtAgente.Location = new System.Drawing.Point(6, 87);
            this.TxtAgente.Name = "TxtAgente";
            this.TxtAgente.Size = new System.Drawing.Size(238, 20);
            this.TxtAgente.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "PropiedadID";
            // 
            // TxtPropiedadID
            // 
            this.TxtPropiedadID.Location = new System.Drawing.Point(6, 45);
            this.TxtPropiedadID.Name = "TxtPropiedadID";
            this.TxtPropiedadID.Size = new System.Drawing.Size(238, 20);
            this.TxtPropiedadID.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tamaño en m2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estacionamiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Baños:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad Dormitorios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ubicación";
            // 
            // TxtTamaño
            // 
            this.TxtTamaño.Location = new System.Drawing.Point(6, 342);
            this.TxtTamaño.Name = "TxtTamaño";
            this.TxtTamaño.Size = new System.Drawing.Size(236, 20);
            this.TxtTamaño.TabIndex = 4;
            // 
            // TxtEstacionamiento
            // 
            this.TxtEstacionamiento.Location = new System.Drawing.Point(6, 299);
            this.TxtEstacionamiento.Name = "TxtEstacionamiento";
            this.TxtEstacionamiento.Size = new System.Drawing.Size(237, 20);
            this.TxtEstacionamiento.TabIndex = 3;
            // 
            // TxtBaños
            // 
            this.TxtBaños.Location = new System.Drawing.Point(6, 256);
            this.TxtBaños.Name = "TxtBaños";
            this.TxtBaños.Size = new System.Drawing.Size(237, 20);
            this.TxtBaños.TabIndex = 2;
            // 
            // TxtDormitorios
            // 
            this.TxtDormitorios.Location = new System.Drawing.Point(6, 213);
            this.TxtDormitorios.Name = "TxtDormitorios";
            this.TxtDormitorios.Size = new System.Drawing.Size(237, 20);
            this.TxtDormitorios.TabIndex = 1;
            // 
            // TxtUbicacion
            // 
            this.TxtUbicacion.Location = new System.Drawing.Point(6, 171);
            this.TxtUbicacion.Name = "TxtUbicacion";
            this.TxtUbicacion.Size = new System.Drawing.Size(238, 20);
            this.TxtUbicacion.TabIndex = 0;
            // 
            // FrmPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 542);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnGuardarr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV);
            this.Name = "FrmPropiedad";
            this.Text = "FormAgenteInmobiliario";
            this.Load += new System.EventHandler(this.FrmPropiedad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGuardarr;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTamaño;
        private System.Windows.Forms.TextBox TxtEstacionamiento;
        private System.Windows.Forms.TextBox TxtBaños;
        private System.Windows.Forms.TextBox TxtDormitorios;
        private System.Windows.Forms.TextBox TxtUbicacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtValorDeVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtAgente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPropiedadID;
    }
}