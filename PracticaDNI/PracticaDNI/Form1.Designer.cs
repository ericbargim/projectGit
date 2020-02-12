namespace PracticaDNI
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
            this.textBoxDNINums = new System.Windows.Forms.TextBox();
            this.labelDNI = new System.Windows.Forms.Label();
            this.textBoxDNILetter = new System.Windows.Forms.TextBox();
            this.buttonCalculateLetter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDNINums
            // 
            this.textBoxDNINums.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDNINums.Location = new System.Drawing.Point(156, 77);
            this.textBoxDNINums.MaxLength = 8;
            this.textBoxDNINums.Name = "textBoxDNINums";
            this.textBoxDNINums.Size = new System.Drawing.Size(265, 32);
            this.textBoxDNINums.TabIndex = 0;
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDNI.Location = new System.Drawing.Point(100, 77);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(50, 30);
            this.labelDNI.TabIndex = 1;
            this.labelDNI.Text = "DNI";
            // 
            // textBoxDNILetter
            // 
            this.textBoxDNILetter.Enabled = false;
            this.textBoxDNILetter.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDNILetter.Location = new System.Drawing.Point(440, 77);
            this.textBoxDNILetter.Name = "textBoxDNILetter";
            this.textBoxDNILetter.ReadOnly = true;
            this.textBoxDNILetter.Size = new System.Drawing.Size(33, 32);
            this.textBoxDNILetter.TabIndex = 2;
            // 
            // buttonCalculateLetter
            // 
            this.buttonCalculateLetter.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculateLetter.Location = new System.Drawing.Point(105, 127);
            this.buttonCalculateLetter.Name = "buttonCalculateLetter";
            this.buttonCalculateLetter.Size = new System.Drawing.Size(368, 38);
            this.buttonCalculateLetter.TabIndex = 3;
            this.buttonCalculateLetter.Text = "Calculate letter";
            this.buttonCalculateLetter.UseVisualStyleBackColor = true;
            this.buttonCalculateLetter.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(646, 249);
            this.Controls.Add(this.buttonCalculateLetter);
            this.Controls.Add(this.textBoxDNILetter);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.textBoxDNINums);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DNI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDNINums;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.TextBox textBoxDNILetter;
        private System.Windows.Forms.Button buttonCalculateLetter;
    }
}

