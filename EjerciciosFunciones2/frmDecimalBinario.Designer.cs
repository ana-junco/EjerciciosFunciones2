﻿
namespace EjerciciosFunciones2
{
    partial class frmDecimalBinario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.caja1 = new System.Windows.Forms.CheckBox();
            this.caja2 = new System.Windows.Forms.CheckBox();
            this.caja3 = new System.Windows.Forms.CheckBox();
            this.caja4 = new System.Windows.Forms.CheckBox();
            this.caja5 = new System.Windows.Forms.CheckBox();
            this.caja6 = new System.Windows.Forms.CheckBox();
            this.caja8 = new System.Windows.Forms.CheckBox();
            this.caja7 = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnBinaDeci = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESA UN ENTERO";
            // 
            // txtEntero
            // 
            this.txtEntero.Location = new System.Drawing.Point(327, 78);
            this.txtEntero.Name = "txtEntero";
            this.txtEntero.Size = new System.Drawing.Size(100, 22);
            this.txtEntero.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.caja7);
            this.groupBox1.Controls.Add(this.caja8);
            this.groupBox1.Controls.Add(this.caja6);
            this.groupBox1.Controls.Add(this.caja5);
            this.groupBox1.Controls.Add(this.caja4);
            this.groupBox1.Controls.Add(this.caja3);
            this.groupBox1.Controls.Add(this.caja2);
            this.groupBox1.Controls.Add(this.caja1);
            this.groupBox1.Location = new System.Drawing.Point(74, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 155);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // caja1
            // 
            this.caja1.AutoSize = true;
            this.caja1.Location = new System.Drawing.Point(630, 68);
            this.caja1.Name = "caja1";
            this.caja1.Size = new System.Drawing.Size(18, 17);
            this.caja1.TabIndex = 0;
            this.caja1.UseVisualStyleBackColor = true;
            this.caja1.CheckedChanged += new System.EventHandler(this.caja1_CheckedChanged);
            // 
            // caja2
            // 
            this.caja2.AutoSize = true;
            this.caja2.Location = new System.Drawing.Point(554, 68);
            this.caja2.Name = "caja2";
            this.caja2.Size = new System.Drawing.Size(18, 17);
            this.caja2.TabIndex = 1;
            this.caja2.UseVisualStyleBackColor = true;
            this.caja2.CheckedChanged += new System.EventHandler(this.caja1_CheckedChanged);
            // 
            // caja3
            // 
            this.caja3.AutoSize = true;
            this.caja3.Location = new System.Drawing.Point(477, 68);
            this.caja3.Name = "caja3";
            this.caja3.Size = new System.Drawing.Size(18, 17);
            this.caja3.TabIndex = 2;
            this.caja3.UseVisualStyleBackColor = true;
            this.caja3.CheckedChanged += new System.EventHandler(this.caja1_CheckedChanged);
            // 
            // caja4
            // 
            this.caja4.AutoSize = true;
            this.caja4.Location = new System.Drawing.Point(393, 68);
            this.caja4.Name = "caja4";
            this.caja4.Size = new System.Drawing.Size(18, 17);
            this.caja4.TabIndex = 3;
            this.caja4.UseVisualStyleBackColor = true;
            this.caja4.CheckedChanged += new System.EventHandler(this.caja1_CheckedChanged);
            // 
            // caja5
            // 
            this.caja5.AutoSize = true;
            this.caja5.Location = new System.Drawing.Point(304, 68);
            this.caja5.Name = "caja5";
            this.caja5.Size = new System.Drawing.Size(18, 17);
            this.caja5.TabIndex = 4;
            this.caja5.UseVisualStyleBackColor = true;
            this.caja5.CheckedChanged += new System.EventHandler(this.caja1_CheckedChanged);
            // 
            // caja6
            // 
            this.caja6.AutoSize = true;
            this.caja6.Location = new System.Drawing.Point(209, 68);
            this.caja6.Name = "caja6";
            this.caja6.Size = new System.Drawing.Size(18, 17);
            this.caja6.TabIndex = 5;
            this.caja6.UseVisualStyleBackColor = true;
            this.caja6.CheckedChanged += new System.EventHandler(this.caja1_CheckedChanged);
            // 
            // caja8
            // 
            this.caja8.AutoSize = true;
            this.caja8.Location = new System.Drawing.Point(24, 68);
            this.caja8.Name = "caja8";
            this.caja8.Size = new System.Drawing.Size(18, 17);
            this.caja8.TabIndex = 6;
            this.caja8.UseVisualStyleBackColor = true;
            this.caja8.CheckedChanged += new System.EventHandler(this.caja1_CheckedChanged);
            // 
            // caja7
            // 
            this.caja7.AutoSize = true;
            this.caja7.Location = new System.Drawing.Point(108, 68);
            this.caja7.Name = "caja7";
            this.caja7.Size = new System.Drawing.Size(18, 17);
            this.caja7.TabIndex = 7;
            this.caja7.UseVisualStyleBackColor = true;
            this.caja7.CheckedChanged += new System.EventHandler(this.caja1_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(98, 348);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(142, 52);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnBinaDeci
            // 
            this.btnBinaDeci.Location = new System.Drawing.Point(327, 343);
            this.btnBinaDeci.Name = "btnBinaDeci";
            this.btnBinaDeci.Size = new System.Drawing.Size(141, 81);
            this.btnBinaDeci.TabIndex = 4;
            this.btnBinaDeci.Text = "CONVERTIR BINARIO A DECIMAL";
            this.btnBinaDeci.UseVisualStyleBackColor = true;
            this.btnBinaDeci.Click += new System.EventHandler(this.btnBinaDeci_Click);
            // 
            // frmDecimalBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBinaDeci);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEntero);
            this.Controls.Add(this.label1);
            this.Name = "frmDecimalBinario";
            this.Text = "frmDecimalBinario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox caja7;
        private System.Windows.Forms.CheckBox caja8;
        private System.Windows.Forms.CheckBox caja6;
        private System.Windows.Forms.CheckBox caja5;
        private System.Windows.Forms.CheckBox caja4;
        private System.Windows.Forms.CheckBox caja3;
        private System.Windows.Forms.CheckBox caja2;
        private System.Windows.Forms.CheckBox caja1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnBinaDeci;
    }
}