namespace Ménu_MesadePartes
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnRegistro = new Button();
            btnConsulta = new Button();
            btnBúsqueda = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 45);
            label1.Name = "label1";
            label1.Size = new Size(392, 47);
            label1.TabIndex = 0;
            label1.Text = "Mesa de Partes Digital";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 101);
            label2.Name = "label2";
            label2.Size = new Size(248, 21);
            label2.TabIndex = 1;
            label2.Text = "Sistema de gestión de expedientes";
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.PeachPuff;
            btnRegistro.Font = new Font("Segoe UI", 12.096F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistro.Location = new Point(112, 192);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(208, 84);
            btnRegistro.TabIndex = 2;
            btnRegistro.Text = "Registro de Expedientes";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnConsulta
            // 
            btnConsulta.BackColor = Color.Silver;
            btnConsulta.Font = new Font("Segoe UI", 12.096F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsulta.Location = new Point(476, 192);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(208, 84);
            btnConsulta.TabIndex = 3;
            btnConsulta.Text = "Consulta de Expedientes";
            btnConsulta.UseVisualStyleBackColor = false;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // btnBúsqueda
            // 
            btnBúsqueda.BackColor = Color.LightSteelBlue;
            btnBúsqueda.Font = new Font("Segoe UI", 12.096F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBúsqueda.Location = new Point(296, 348);
            btnBúsqueda.Name = "btnBúsqueda";
            btnBúsqueda.Size = new Size(208, 84);
            btnBúsqueda.TabIndex = 4;
            btnBúsqueda.Text = "Búsqueda de Expedientes";
            btnBúsqueda.UseVisualStyleBackColor = false;
            btnBúsqueda.Click += btnBúsqueda_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.IndianRed;
            btnSalir.Font = new Font("Segoe UI", 12.096F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(296, 564);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(208, 63);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir\r\n";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 721);
            Controls.Add(btnSalir);
            Controls.Add(btnBúsqueda);
            Controls.Add(btnConsulta);
            Controls.Add(btnRegistro);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mesa de Partes Digital - Sistema de Expedientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnRegistro;
        private Button btnConsulta;
        private Button btnBúsqueda;
        private Button btnSalir;
    }
}
