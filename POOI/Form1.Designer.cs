
namespace POOI
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
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.txtGrados = new System.Windows.Forms.TextBox();
            this.btnAumentarGrados = new System.Windows.Forms.Button();
            this.btnDisminuirGrados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(41, 47);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(77, 13);
            this.lblTemperatura.TabIndex = 0;
            this.lblTemperatura.Text = "Ingrese grados";
            // 
            // txtGrados
            // 
            this.txtGrados.Location = new System.Drawing.Point(44, 73);
            this.txtGrados.Name = "txtGrados";
            this.txtGrados.Size = new System.Drawing.Size(125, 20);
            this.txtGrados.TabIndex = 1;
            // 
            // btnAumentarGrados
            // 
            this.btnAumentarGrados.Location = new System.Drawing.Point(44, 110);
            this.btnAumentarGrados.Name = "btnAumentarGrados";
            this.btnAumentarGrados.Size = new System.Drawing.Size(125, 23);
            this.btnAumentarGrados.TabIndex = 2;
            this.btnAumentarGrados.Text = "Aumentar grados";
            this.btnAumentarGrados.UseVisualStyleBackColor = true;
            this.btnAumentarGrados.Click += new System.EventHandler(this.btnAumentarGrados_Click);
            // 
            // btnDisminuirGrados
            // 
            this.btnDisminuirGrados.Location = new System.Drawing.Point(44, 155);
            this.btnDisminuirGrados.Name = "btnDisminuirGrados";
            this.btnDisminuirGrados.Size = new System.Drawing.Size(125, 23);
            this.btnDisminuirGrados.TabIndex = 3;
            this.btnDisminuirGrados.Text = "Disminuir grados";
            this.btnDisminuirGrados.UseVisualStyleBackColor = true;
            this.btnDisminuirGrados.Click += new System.EventHandler(this.btnDisminuirGrados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 235);
            this.Controls.Add(this.btnDisminuirGrados);
            this.Controls.Add(this.btnAumentarGrados);
            this.Controls.Add(this.txtGrados);
            this.Controls.Add(this.lblTemperatura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.TextBox txtGrados;
        private System.Windows.Forms.Button btnAumentarGrados;
        private System.Windows.Forms.Button btnDisminuirGrados;
    }
}

