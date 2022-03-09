namespace AplicacionRegistrosAleatorios
{
    partial class GUIListarEquipos
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
            this.btnListar = new System.Windows.Forms.Button();
            this.txtBoxListar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(164, 206);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(147, 42);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar Equipos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtBoxListar
            // 
            this.txtBoxListar.Location = new System.Drawing.Point(12, 12);
            this.txtBoxListar.Multiline = true;
            this.txtBoxListar.Name = "txtBoxListar";
            this.txtBoxListar.Size = new System.Drawing.Size(430, 178);
            this.txtBoxListar.TabIndex = 2;
            // 
            // GUIListarEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 261);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtBoxListar);
            this.Name = "GUIListarEquipos";
            this.Text = "GUIListarEquipos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtBoxListar;
    }
}