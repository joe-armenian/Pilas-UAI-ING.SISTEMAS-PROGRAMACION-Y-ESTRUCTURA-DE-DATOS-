namespace Pilas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreNodo = new System.Windows.Forms.TextBox();
            this.btnAgregarNuevoNodo = new System.Windows.Forms.Button();
            this.lstMiPila = new System.Windows.Forms.ListBox();
            this.btnDesapilar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombreNodo
            // 
            this.txtNombreNodo.Location = new System.Drawing.Point(164, 66);
            this.txtNombreNodo.Name = "txtNombreNodo";
            this.txtNombreNodo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreNodo.TabIndex = 1;
            // 
            // btnAgregarNuevoNodo
            // 
            this.btnAgregarNuevoNodo.Location = new System.Drawing.Point(177, 112);
            this.btnAgregarNuevoNodo.Name = "btnAgregarNuevoNodo";
            this.btnAgregarNuevoNodo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarNuevoNodo.TabIndex = 2;
            this.btnAgregarNuevoNodo.Text = "Apilar";
            this.btnAgregarNuevoNodo.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoNodo.Click += new System.EventHandler(this.btnAgregarNuevoNodo_Click);
            // 
            // lstMiPila
            // 
            this.lstMiPila.FormattingEnabled = true;
            this.lstMiPila.Location = new System.Drawing.Point(335, 69);
            this.lstMiPila.Name = "lstMiPila";
            this.lstMiPila.Size = new System.Drawing.Size(120, 173);
            this.lstMiPila.TabIndex = 3;
            // 
            // btnDesapilar
            // 
            this.btnDesapilar.Location = new System.Drawing.Point(177, 169);
            this.btnDesapilar.Name = "btnDesapilar";
            this.btnDesapilar.Size = new System.Drawing.Size(75, 23);
            this.btnDesapilar.TabIndex = 4;
            this.btnDesapilar.Text = "Desapilar";
            this.btnDesapilar.UseVisualStyleBackColor = true;
            this.btnDesapilar.Click += new System.EventHandler(this.btnDesapilar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(538, 314);
            this.Controls.Add(this.btnDesapilar);
            this.Controls.Add(this.lstMiPila);
            this.Controls.Add(this.btnAgregarNuevoNodo);
            this.Controls.Add(this.txtNombreNodo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreNodo;
        private System.Windows.Forms.Button btnAgregarNuevoNodo;
        private System.Windows.Forms.ListBox lstMiPila;
        private System.Windows.Forms.Button btnDesapilar;
    }
}

