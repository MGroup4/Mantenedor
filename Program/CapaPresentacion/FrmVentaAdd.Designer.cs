
namespace CapaPresentacion
{
    partial class FrmVentaAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentaAdd));
            this.BtnVenta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtDNIV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPrecioV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPFechaV = new System.Windows.Forms.DateTimePicker();
            this.BtnAlquiler = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.DtpFechaAF = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaAI = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDNIA = new System.Windows.Forms.TextBox();
            this.TxtPrecioCuotas = new System.Windows.Forms.TextBox();
            this.TxtCuotas = new System.Windows.Forms.TextBox();
            this.TxtPrecioA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnVenta
            // 
            this.BtnVenta.Location = new System.Drawing.Point(230, 557);
            this.BtnVenta.Name = "BtnVenta";
            this.BtnVenta.Size = new System.Drawing.Size(189, 59);
            this.BtnVenta.TabIndex = 0;
            this.BtnVenta.Text = "Realizar Venta";
            this.BtnVenta.UseVisualStyleBackColor = true;
            this.BtnVenta.Click += new System.EventHandler(this.BtnVenta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtDNIV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtPrecioV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DTPFechaV);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 517);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Realizar Venta";
            // 
            // TxtDNIV
            // 
            this.TxtDNIV.Location = new System.Drawing.Point(277, 103);
            this.TxtDNIV.Name = "TxtDNIV";
            this.TxtDNIV.Size = new System.Drawing.Size(111, 20);
            this.TxtDNIV.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI Cliente";
            // 
            // TxtPrecioV
            // 
            this.TxtPrecioV.Location = new System.Drawing.Point(62, 103);
            this.TxtPrecioV.Name = "TxtPrecioV";
            this.TxtPrecioV.Size = new System.Drawing.Size(142, 20);
            this.TxtPrecioV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de Venta";
            // 
            // DTPFechaV
            // 
            this.DTPFechaV.Location = new System.Drawing.Point(104, 36);
            this.DTPFechaV.Name = "DTPFechaV";
            this.DTPFechaV.Size = new System.Drawing.Size(200, 20);
            this.DTPFechaV.TabIndex = 0;
            // 
            // BtnAlquiler
            // 
            this.BtnAlquiler.Location = new System.Drawing.Point(460, 557);
            this.BtnAlquiler.Name = "BtnAlquiler";
            this.BtnAlquiler.Size = new System.Drawing.Size(171, 59);
            this.BtnAlquiler.TabIndex = 2;
            this.BtnAlquiler.Text = "Realizar Alquiler";
            this.BtnAlquiler.UseVisualStyleBackColor = true;
            this.BtnAlquiler.Click += new System.EventHandler(this.BtnAlquiler_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCalcular);
            this.groupBox2.Controls.Add(this.DtpFechaAF);
            this.groupBox2.Controls.Add(this.DtpFechaAI);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtDNIA);
            this.groupBox2.Controls.Add(this.TxtPrecioCuotas);
            this.groupBox2.Controls.Add(this.TxtCuotas);
            this.groupBox2.Controls.Add(this.TxtPrecioA);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(449, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 516);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Realizar Alquiler";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(171, 323);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(142, 59);
            this.BtnCalcular.TabIndex = 4;
            this.BtnCalcular.Text = "Calcular precio por Cuotas";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // DtpFechaAF
            // 
            this.DtpFechaAF.Location = new System.Drawing.Point(150, 78);
            this.DtpFechaAF.Name = "DtpFechaAF";
            this.DtpFechaAF.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaAF.TabIndex = 0;
            // 
            // DtpFechaAI
            // 
            this.DtpFechaAI.Location = new System.Drawing.Point(150, 35);
            this.DtpFechaAI.Name = "DtpFechaAI";
            this.DtpFechaAI.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaAI.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Fecha de Alquiler Fin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fecha de Alquiler Inicio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 411);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Precio por cuotas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Cuotas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Precio";
            // 
            // TxtDNIA
            // 
            this.TxtDNIA.Location = new System.Drawing.Point(286, 145);
            this.TxtDNIA.Name = "TxtDNIA";
            this.TxtDNIA.Size = new System.Drawing.Size(111, 20);
            this.TxtDNIA.TabIndex = 6;
            // 
            // TxtPrecioCuotas
            // 
            this.TxtPrecioCuotas.Location = new System.Drawing.Point(123, 411);
            this.TxtPrecioCuotas.Name = "TxtPrecioCuotas";
            this.TxtPrecioCuotas.Size = new System.Drawing.Size(274, 20);
            this.TxtPrecioCuotas.TabIndex = 10;
            // 
            // TxtCuotas
            // 
            this.TxtCuotas.Location = new System.Drawing.Point(113, 272);
            this.TxtCuotas.Name = "TxtCuotas";
            this.TxtCuotas.Size = new System.Drawing.Size(142, 20);
            this.TxtCuotas.TabIndex = 9;
            // 
            // TxtPrecioA
            // 
            this.TxtPrecioA.Location = new System.Drawing.Point(71, 145);
            this.TxtPrecioA.Name = "TxtPrecioA";
            this.TxtPrecioA.Size = new System.Drawing.Size(142, 20);
            this.TxtPrecioA.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "DNI Cliente";
            // 
            // FrmVentaAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 628);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnAlquiler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnVenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVentaAdd";
            this.Text = "Comfy Houser - Venta/Aqluiler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtDNIV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPrecioV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTPFechaV;
        private System.Windows.Forms.Button BtnAlquiler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.DateTimePicker DtpFechaAF;
        private System.Windows.Forms.DateTimePicker DtpFechaAI;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDNIA;
        private System.Windows.Forms.TextBox TxtPrecioCuotas;
        private System.Windows.Forms.TextBox TxtCuotas;
        private System.Windows.Forms.TextBox TxtPrecioA;
        private System.Windows.Forms.Label label8;
    }
}