namespace AplicacionRegistrosAleatorios
{
    partial class GUIAgregarEquipo
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGrabarEquipo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtBoxColor = new System.Windows.Forms.ComboBox();
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.txtBoxJugadores = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGrabarEquipo);
            this.panel2.Location = new System.Drawing.Point(160, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 61);
            this.panel2.TabIndex = 14;
            // 
            // btnGrabarEquipo
            // 
            this.btnGrabarEquipo.Location = new System.Drawing.Point(25, 14);
            this.btnGrabarEquipo.Name = "btnGrabarEquipo";
            this.btnGrabarEquipo.Size = new System.Drawing.Size(147, 33);
            this.btnGrabarEquipo.TabIndex = 8;
            this.btnGrabarEquipo.Text = "Grabar Equipo";
            this.btnGrabarEquipo.UseVisualStyleBackColor = true;
            this.btnGrabarEquipo.Click += new System.EventHandler(this.btnGrabarEquipo_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.txtBoxColor);
            this.panel1.Controls.Add(this.dateTimeFecha);
            this.panel1.Controls.Add(this.txtBoxJugadores);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBoxNombre);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 181);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Codigo: ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(177, 79);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(153, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtBoxColor
            // 
            this.txtBoxColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBoxColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBoxColor.FormattingEnabled = true;
            this.txtBoxColor.Items.AddRange(new object[] {
            "Negro",
            "Azul",
            "Café",
            "Gris",
            "Verde",
            "Naranja",
            "Rosa",
            "Morado",
            "Rojo",
            "Blanco",
            "Amarillo",
            "Vinotinto"});
            this.txtBoxColor.Location = new System.Drawing.Point(178, 105);
            this.txtBoxColor.Name = "txtBoxColor";
            this.txtBoxColor.Size = new System.Drawing.Size(152, 21);
            this.txtBoxColor.TabIndex = 4;
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.Location = new System.Drawing.Point(178, 134);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFecha.TabIndex = 5;
            // 
            // txtBoxJugadores
            // 
            this.txtBoxJugadores.Location = new System.Drawing.Point(177, 53);
            this.txtBoxJugadores.Name = "txtBoxJugadores";
            this.txtBoxJugadores.Size = new System.Drawing.Size(153, 20);
            this.txtBoxJugadores.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha Creación: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Color: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "N° jugadores: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre: ";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(177, 27);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(153, 20);
            this.txtBoxNombre.TabIndex = 1;
            // 
            // GUIAgregarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 275);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GUIAgregarEquipo";
            this.Text = "GUIAgregarEquipo";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGrabarEquipo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox txtBoxColor;
        private System.Windows.Forms.DateTimePicker dateTimeFecha;
        private System.Windows.Forms.TextBox txtBoxJugadores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNombre;
    }
}