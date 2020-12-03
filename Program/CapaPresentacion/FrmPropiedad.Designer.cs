
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
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(17, 49);
            this.DGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.Size = new System.Drawing.Size(783, 619);
            this.DGV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mantenedor de Propiedades";
            // 
            // BtnGuardarr
            // 
            this.BtnGuardarr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarr.Location = new System.Drawing.Point(808, 514);
            this.BtnGuardarr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGuardarr.Name = "BtnGuardarr";
            this.BtnGuardarr.Size = new System.Drawing.Size(159, 59);
            this.BtnGuardarr.TabIndex = 2;
            this.BtnGuardarr.Text = "Ingresar Propiedad";
            this.BtnGuardarr.UseVisualStyleBackColor = true;
            this.BtnGuardarr.Click += new System.EventHandler(this.BtnGuardarr_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditar.Location = new System.Drawing.Point(975, 514);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(159, 59);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.Text = "Realizar modificación";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.Location = new System.Drawing.Point(808, 582);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(325, 60);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(816, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(337, 458);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(9, 135);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Valor de Venta";
            // 
            // TxtValorDeVenta
            // 
            this.TxtValorDeVenta.Location = new System.Drawing.Point(8, 159);
            this.TxtValorDeVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtValorDeVenta.Name = "TxtValorDeVenta";
            this.TxtValorDeVenta.Size = new System.Drawing.Size(316, 22);
            this.TxtValorDeVenta.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(9, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "AgenteID";
            // 
            // TxtAgente
            // 
            this.TxtAgente.Location = new System.Drawing.Point(8, 107);
            this.TxtAgente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtAgente.Name = "TxtAgente";
            this.TxtAgente.Size = new System.Drawing.Size(316, 22);
            this.TxtAgente.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(9, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "PropiedadID";
            // 
            // TxtPropiedadID
            // 
            this.TxtPropiedadID.Location = new System.Drawing.Point(8, 55);
            this.TxtPropiedadID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPropiedadID.Name = "TxtPropiedadID";
            this.TxtPropiedadID.Size = new System.Drawing.Size(316, 22);
            this.TxtPropiedadID.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(9, 401);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tamaño en m2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(9, 348);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estacionamiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(9, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Baños:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad Dormitorios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(9, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ubicación";
            // 
            // TxtTamaño
            // 
            this.TxtTamaño.Location = new System.Drawing.Point(8, 421);
            this.TxtTamaño.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTamaño.Name = "TxtTamaño";
            this.TxtTamaño.Size = new System.Drawing.Size(313, 22);
            this.TxtTamaño.TabIndex = 4;
            // 
            // TxtEstacionamiento
            // 
            this.TxtEstacionamiento.Location = new System.Drawing.Point(8, 368);
            this.TxtEstacionamiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtEstacionamiento.Name = "TxtEstacionamiento";
            this.TxtEstacionamiento.Size = new System.Drawing.Size(315, 22);
            this.TxtEstacionamiento.TabIndex = 3;
            // 
            // TxtBaños
            // 
            this.TxtBaños.Location = new System.Drawing.Point(8, 315);
            this.TxtBaños.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBaños.Name = "TxtBaños";
            this.TxtBaños.Size = new System.Drawing.Size(315, 22);
            this.TxtBaños.TabIndex = 2;
            // 
            // TxtDormitorios
            // 
            this.TxtDormitorios.Location = new System.Drawing.Point(8, 262);
            this.TxtDormitorios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDormitorios.Name = "TxtDormitorios";
            this.TxtDormitorios.Size = new System.Drawing.Size(315, 22);
            this.TxtDormitorios.TabIndex = 1;
            // 
            // TxtUbicacion
            // 
            this.TxtUbicacion.Location = new System.Drawing.Point(8, 210);
            this.TxtUbicacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtUbicacion.Name = "TxtUbicacion";
            this.TxtUbicacion.Size = new System.Drawing.Size(316, 22);
            this.TxtUbicacion.TabIndex = 0;
            // 
            // FrmPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(111)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(1164, 686);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnGuardarr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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