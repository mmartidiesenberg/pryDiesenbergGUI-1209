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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBotonera));
            this.btnBotonera = new System.Windows.Forms.Button();
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBotonera
            // 
            this.btnBotonera.Location = new System.Drawing.Point(139, 154);
            this.btnBotonera.Name = "btnBotonera";
            this.btnBotonera.Size = new System.Drawing.Size(183, 58);
            this.btnBotonera.TabIndex = 0;
            this.btnBotonera.Text = "Abrir Botonera";
            this.btnBotonera.UseVisualStyleBackColor = true;
            this.btnBotonera.Click += new System.EventHandler(this.btnBotonera_Click_1);
            // 
            // lstNombres
            // 
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.Location = new System.Drawing.Point(104, 246);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(264, 95);
            this.lstNombres.TabIndex = 1;
            // 
            // frmBotonera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lstNombres);
            this.Controls.Add(this.btnBotonera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBotonera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Botonera";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBotonera;
        private System.Windows.Forms.ListBox lstNombres;
    }
}