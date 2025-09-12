namespace pryDiesenbergGUI_1209
{
    partial class frmBotonera
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
            this.btnBotonera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBotonera
            // 
            this.btnBotonera.Location = new System.Drawing.Point(142, 199);
            this.btnBotonera.Name = "btnBotonera";
            this.btnBotonera.Size = new System.Drawing.Size(183, 58);
            this.btnBotonera.TabIndex = 0;
            this.btnBotonera.Text = "Abrir Botonera";
            this.btnBotonera.UseVisualStyleBackColor = true;
            this.btnBotonera.Click += new System.EventHandler(this.btnBotonera_Click_1);
            // 
            // frmBotonera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnBotonera);
            this.Name = "frmBotonera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Botonera";
            this.Load += new System.EventHandler(this.frmBotonera_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBotonera;
    }
}