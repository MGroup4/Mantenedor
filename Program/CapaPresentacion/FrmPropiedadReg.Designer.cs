﻿
namespace CapaPresentacion
{
    partial class FormPropiedadesDispo
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
            this.dgvPropiedadesDispo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonComprarAlquilar = new System.Windows.Forms.Button();
            this.buttonMostrarInfo = new System.Windows.Forms.Button();
            this.buttonMostrarVenta = new System.Windows.Forms.Button();
            this.buttonMostrarAlquiler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedadesDispo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPropiedadesDispo
            // 
            this.dgvPropiedadesDispo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPropiedadesDispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropiedadesDispo.Location = new System.Drawing.Point(13, 61);
            this.dgvPropiedadesDispo.Name = "dgvPropiedadesDispo";
            this.dgvPropiedadesDispo.Size = new System.Drawing.Size(632, 500);
            this.dgvPropiedadesDispo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Propiedades disponibles:";
            // 
            // buttonComprarAlquilar
            // 
            this.buttonComprarAlquilar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonComprarAlquilar.Location = new System.Drawing.Point(672, 507);
            this.buttonComprarAlquilar.Name = "buttonComprarAlquilar";
            this.buttonComprarAlquilar.Size = new System.Drawing.Size(203, 54);
            this.buttonComprarAlquilar.TabIndex = 2;
            this.buttonComprarAlquilar.Text = "Comprar/Alquilar";
            this.buttonComprarAlquilar.UseVisualStyleBackColor = true;
            this.buttonComprarAlquilar.Click += new System.EventHandler(this.buttonComprarAlquilar_Click);
            // 
            // buttonMostrarInfo
            // 
            this.buttonMostrarInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMostrarInfo.Location = new System.Drawing.Point(672, 428);
            this.buttonMostrarInfo.Name = "buttonMostrarInfo";
            this.buttonMostrarInfo.Size = new System.Drawing.Size(203, 54);
            this.buttonMostrarInfo.TabIndex = 3;
            this.buttonMostrarInfo.Text = "Mostrar Información";
            this.buttonMostrarInfo.UseVisualStyleBackColor = true;
            // 
            // buttonMostrarVenta
            // 
            this.buttonMostrarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMostrarVenta.Location = new System.Drawing.Point(672, 61);
            this.buttonMostrarVenta.Name = "buttonMostrarVenta";
            this.buttonMostrarVenta.Size = new System.Drawing.Size(212, 54);
            this.buttonMostrarVenta.TabIndex = 4;
            this.buttonMostrarVenta.Text = "Mostrar solo Venta";
            this.buttonMostrarVenta.UseVisualStyleBackColor = true;
            // 
            // buttonMostrarAlquiler
            // 
            this.buttonMostrarAlquiler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMostrarAlquiler.Location = new System.Drawing.Point(672, 132);
            this.buttonMostrarAlquiler.Name = "buttonMostrarAlquiler";
            this.buttonMostrarAlquiler.Size = new System.Drawing.Size(212, 54);
            this.buttonMostrarAlquiler.TabIndex = 5;
            this.buttonMostrarAlquiler.Text = "Mostrar solo Alquiler";
            this.buttonMostrarAlquiler.UseVisualStyleBackColor = true;
            // 
            // FormPropiedadesDispo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(896, 581);
            this.Controls.Add(this.buttonMostrarAlquiler);
            this.Controls.Add(this.buttonMostrarVenta);
            this.Controls.Add(this.buttonMostrarInfo);
            this.Controls.Add(this.buttonComprarAlquilar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPropiedadesDispo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPropiedadesDispo";
            this.Text = "FormPropiedades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedadesDispo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPropiedadesDispo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonComprarAlquilar;
        private System.Windows.Forms.Button buttonMostrarInfo;
        private System.Windows.Forms.Button buttonMostrarVenta;
        private System.Windows.Forms.Button buttonMostrarAlquiler;
    }
}