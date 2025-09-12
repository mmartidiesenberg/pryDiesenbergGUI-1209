namespace pryDiesenbergGUI_1209
{
    partial class frmControles1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblNombre3 = new System.Windows.Forms.Label();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.txtNombre3 = new System.Windows.Forms.TextBox();
            this.txtAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(117, 94);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre 1";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(95, 333);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "<---";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(282, 333);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "--->";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(117, 153);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(53, 13);
            this.lblNombre2.TabIndex = 4;
            this.lblNombre2.Text = "Nombre 2";
            // 
            // lblNombre3
            // 
            this.lblNombre3.AutoSize = true;
            this.lblNombre3.Location = new System.Drawing.Point(117, 215);
            this.lblNombre3.Name = "lblNombre3";
            this.lblNombre3.Size = new System.Drawing.Size(53, 13);
            this.lblNombre3.TabIndex = 5;
            this.lblNombre3.Text = "Nombre 3";
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(282, 87);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(100, 20);
            this.txtNombre1.TabIndex = 6;
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(282, 150);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(100, 20);
            this.txtNombre2.TabIndex = 7;
            // 
            // txtNombre3
            // 
            this.txtNombre3.Location = new System.Drawing.Point(282, 215);
            this.txtNombre3.Name = "txtNombre3";
            this.txtNombre3.Size = new System.Drawing.Size(100, 20);
            this.txtNombre3.TabIndex = 8;
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(184, 269);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(75, 23);
            this.txtAgregar.TabIndex = 9;
            this.txtAgregar.Text = "Agregar";
            this.txtAgregar.UseVisualStyleBackColor = true;
            // 
            // frmControles1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.txtAgregar);
            this.Controls.Add(this.txtNombre3);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.txtNombre1);
            this.Controls.Add(this.lblNombre3);
            this.Controls.Add(this.lblNombre2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmControles1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controles de Interfaz Gráfica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblNombre3;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.TextBox txtNombre3;
        private System.Windows.Forms.Button txtAgregar;
    }
}

