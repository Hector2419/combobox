namespace Webbrowser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.atras = new System.Windows.Forms.Button();
            this.link = new System.Windows.Forms.TextBox();
            this.ir = new System.Windows.Forms.Button();
            this.agregarfavoritos = new System.Windows.Forms.Button();
            this.seleccionarfavoritos = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.seleccionarfavoritos);
            this.panel1.Controls.Add(this.agregarfavoritos);
            this.panel1.Controls.Add(this.ir);
            this.panel1.Controls.Add(this.link);
            this.panel1.Controls.Add(this.atras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 100);
            this.panel1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 100);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(804, 355);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser1_DocumentCompleted);
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(27, 41);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(75, 23);
            this.atras.TabIndex = 0;
            this.atras.Text = "Atrás";
            this.atras.UseVisualStyleBackColor = true;
            // 
            // link
            // 
            this.link.Location = new System.Drawing.Point(154, 44);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(232, 20);
            this.link.TabIndex = 1;
            // 
            // ir
            // 
            this.ir.Location = new System.Drawing.Point(414, 41);
            this.ir.Name = "ir";
            this.ir.Size = new System.Drawing.Size(75, 23);
            this.ir.TabIndex = 2;
            this.ir.Text = "ir";
            this.ir.UseVisualStyleBackColor = true;
            // 
            // agregarfavoritos
            // 
            this.agregarfavoritos.Location = new System.Drawing.Point(606, 12);
            this.agregarfavoritos.Name = "agregarfavoritos";
            this.agregarfavoritos.Size = new System.Drawing.Size(113, 23);
            this.agregarfavoritos.TabIndex = 3;
            this.agregarfavoritos.Text = "Agregar a favoritos";
            this.agregarfavoritos.UseVisualStyleBackColor = true;
            // 
            // seleccionarfavoritos
            // 
            this.seleccionarfavoritos.FormattingEnabled = true;
            this.seleccionarfavoritos.Location = new System.Drawing.Point(606, 44);
            this.seleccionarfavoritos.Name = "seleccionarfavoritos";
            this.seleccionarfavoritos.Size = new System.Drawing.Size(113, 21);
            this.seleccionarfavoritos.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 455);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox link;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Button ir;
        private System.Windows.Forms.ComboBox seleccionarfavoritos;
        private System.Windows.Forms.Button agregarfavoritos;
    }
}

