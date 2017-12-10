namespace Ayuda_Remota
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIpLocal = new System.Windows.Forms.Button();
            this.lstbPc = new System.Windows.Forms.ListBox();
            this.btnBuscarEquipo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIpLocal
            // 
            this.btnIpLocal.Location = new System.Drawing.Point(12, 12);
            this.btnIpLocal.Name = "btnIpLocal";
            this.btnIpLocal.Size = new System.Drawing.Size(100, 23);
            this.btnIpLocal.TabIndex = 0;
            this.btnIpLocal.Text = "Ip Local";
            this.btnIpLocal.UseVisualStyleBackColor = true;
            this.btnIpLocal.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstbPc
            // 
            this.lstbPc.FormattingEnabled = true;
            this.lstbPc.Location = new System.Drawing.Point(148, 12);
            this.lstbPc.Name = "lstbPc";
            this.lstbPc.Size = new System.Drawing.Size(120, 238);
            this.lstbPc.TabIndex = 1;
            // 
            // btnBuscarEquipo
            // 
            this.btnBuscarEquipo.Location = new System.Drawing.Point(12, 42);
            this.btnBuscarEquipo.Name = "btnBuscarEquipo";
            this.btnBuscarEquipo.Size = new System.Drawing.Size(100, 23);
            this.btnBuscarEquipo.TabIndex = 2;
            this.btnBuscarEquipo.Text = "Buscar Equipo";
            this.btnBuscarEquipo.UseVisualStyleBackColor = true;
            this.btnBuscarEquipo.Click += new System.EventHandler(this.btnBuscarEquipo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnBuscarEquipo);
            this.Controls.Add(this.lstbPc);
            this.Controls.Add(this.btnIpLocal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIpLocal;
        private System.Windows.Forms.ListBox lstbPc;
        private System.Windows.Forms.Button btnBuscarEquipo;
    }
}

