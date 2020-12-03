
namespace CapaPresentacion
{
    partial class FormMantenedorPropiedades
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
            this.dgvPropiedades = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxUbicacion = new System.Windows.Forms.TextBox();
            this.textBoxCantDormitorios = new System.Windows.Forms.TextBox();
            this.textBoxBanios = new System.Windows.Forms.TextBox();
            this.textBoxEstacionamiento = new System.Windows.Forms.TextBox();
            this.textBoxTamanio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.textBoxTamanioE = new System.Windows.Forms.TextBox();
            this.textBoxEstacionamientoE = new System.Windows.Forms.TextBox();
            this.textBoxBaniosE = new System.Windows.Forms.TextBox();
            this.textBoxCantDormitoriosE = new System.Windows.Forms.TextBox();
            this.textBoxUbicacionE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedades)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPropiedades
            // 
            this.dgvPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropiedades.Location = new System.Drawing.Point(13, 40);
            this.dgvPropiedades.Name = "dgvPropiedades";
            this.dgvPropiedades.Size = new System.Drawing.Size(587, 775);
            this.dgvPropiedades.TabIndex = 0;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 711);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ingresar Propiedad";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(740, 711);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "Realizar modificación";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(615, 766);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(244, 49);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGuardar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxTamanio);
            this.groupBox1.Controls.Add(this.textBoxEstacionamiento);
            this.groupBox1.Controls.Add(this.textBoxBanios);
            this.groupBox1.Controls.Add(this.textBoxCantDormitorios);
            this.groupBox1.Controls.Add(this.textBoxUbicacion);
            this.groupBox1.Location = new System.Drawing.Point(612, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 302);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxTamanioE);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBoxEstacionamientoE);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.buttonEditar);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxBaniosE);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxUbicacionE);
            this.groupBox2.Controls.Add(this.textBoxCantDormitoriosE);
            this.groupBox2.Location = new System.Drawing.Point(612, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 344);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar";
            // 
            // textBoxUbicacion
            // 
            this.textBoxUbicacion.Location = new System.Drawing.Point(6, 43);
            this.textBoxUbicacion.Name = "textBoxUbicacion";
            this.textBoxUbicacion.Size = new System.Drawing.Size(238, 20);
            this.textBoxUbicacion.TabIndex = 0;
            // 
            // textBoxCantDormitorios
            // 
            this.textBoxCantDormitorios.Location = new System.Drawing.Point(6, 85);
            this.textBoxCantDormitorios.Name = "textBoxCantDormitorios";
            this.textBoxCantDormitorios.Size = new System.Drawing.Size(237, 20);
            this.textBoxCantDormitorios.TabIndex = 1;
            // 
            // textBoxBanios
            // 
            this.textBoxBanios.Location = new System.Drawing.Point(6, 128);
            this.textBoxBanios.Name = "textBoxBanios";
            this.textBoxBanios.Size = new System.Drawing.Size(237, 20);
            this.textBoxBanios.TabIndex = 2;
            // 
            // textBoxEstacionamiento
            // 
            this.textBoxEstacionamiento.Location = new System.Drawing.Point(6, 171);
            this.textBoxEstacionamiento.Name = "textBoxEstacionamiento";
            this.textBoxEstacionamiento.Size = new System.Drawing.Size(237, 20);
            this.textBoxEstacionamiento.TabIndex = 3;
            // 
            // textBoxTamanio
            // 
            this.textBoxTamanio.Location = new System.Drawing.Point(6, 214);
            this.textBoxTamanio.Name = "textBoxTamanio";
            this.textBoxTamanio.Size = new System.Drawing.Size(236, 20);
            this.textBoxTamanio.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ubicación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad Dormitorios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Baños:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estacionamiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tamaño en m2:";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(51, 247);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(151, 40);
            this.buttonGuardar.TabIndex = 10;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(51, 288);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(151, 40);
            this.buttonEditar.TabIndex = 0;
            this.buttonEditar.Text = "EDITAR";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // textBoxTamanioE
            // 
            this.textBoxTamanioE.Location = new System.Drawing.Point(8, 214);
            this.textBoxTamanioE.Name = "textBoxTamanioE";
            this.textBoxTamanioE.Size = new System.Drawing.Size(236, 20);
            this.textBoxTamanioE.TabIndex = 15;
            // 
            // textBoxEstacionamientoE
            // 
            this.textBoxEstacionamientoE.Location = new System.Drawing.Point(8, 171);
            this.textBoxEstacionamientoE.Name = "textBoxEstacionamientoE";
            this.textBoxEstacionamientoE.Size = new System.Drawing.Size(237, 20);
            this.textBoxEstacionamientoE.TabIndex = 14;
            // 
            // textBoxBaniosE
            // 
            this.textBoxBaniosE.Location = new System.Drawing.Point(8, 128);
            this.textBoxBaniosE.Name = "textBoxBaniosE";
            this.textBoxBaniosE.Size = new System.Drawing.Size(237, 20);
            this.textBoxBaniosE.TabIndex = 13;
            // 
            // textBoxCantDormitoriosE
            // 
            this.textBoxCantDormitoriosE.Location = new System.Drawing.Point(8, 85);
            this.textBoxCantDormitoriosE.Name = "textBoxCantDormitoriosE";
            this.textBoxCantDormitoriosE.Size = new System.Drawing.Size(237, 20);
            this.textBoxCantDormitoriosE.TabIndex = 12;
            // 
            // textBoxUbicacionE
            // 
            this.textBoxUbicacionE.Location = new System.Drawing.Point(8, 43);
            this.textBoxUbicacionE.Name = "textBoxUbicacionE";
            this.textBoxUbicacionE.Size = new System.Drawing.Size(238, 20);
            this.textBoxUbicacionE.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ubicación";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cantidad Dormitorios";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Baños:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Estacionamiento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Tamaño en m2:";
            // 
            // FormAgenteInmobiliario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 837);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPropiedades);
            this.Name = "FormAgenteInmobiliario";
            this.Text = "FormAgenteInmobiliario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedades)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPropiedades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTamanio;
        private System.Windows.Forms.TextBox textBoxEstacionamiento;
        private System.Windows.Forms.TextBox textBoxBanios;
        private System.Windows.Forms.TextBox textBoxCantDormitorios;
        private System.Windows.Forms.TextBox textBoxUbicacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxTamanioE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxEstacionamientoE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxBaniosE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUbicacionE;
        private System.Windows.Forms.TextBox textBoxCantDormitoriosE;
    }
}