
namespace EjerciciosFunciones2
{
    partial class Funciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.txtResul = new System.Windows.Forms.Label();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESA UNA FRASE";
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(331, 51);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(239, 22);
            this.txtFrase.TabIndex = 1;
            // 
            // txtResul
            // 
            this.txtResul.AutoSize = true;
            this.txtResul.Location = new System.Drawing.Point(84, 110);
            this.txtResul.Name = "txtResul";
            this.txtResul.Size = new System.Drawing.Size(72, 17);
            this.txtResul.TabIndex = 2;
            this.txtResul.Text = "Resultado";
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(331, 110);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(210, 22);
            this.txtRes.TabIndex = 3;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(87, 207);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(119, 53);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "PROCESAR";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtResul);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejercicios con Funciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Label txtResul;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button btnProcesar;
    }
}

