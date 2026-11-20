namespace Ménu_MesadePartes
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            // button1
            // 
            button1.BackColor = Color.PeachPuff;
            button1.Font = new Font("Segoe UI", 12.096F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(112, 192);
            button1.Name = "button1";
            button1.Size = new Size(208, 84);
            button1.TabIndex = 2;
            button1.Text = "Registro de Expedientes";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Segoe UI", 12.096F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(476, 192);
            button2.Name = "button2";
            button2.Size = new Size(208, 84);
            button2.TabIndex = 3;
            button2.Text = "Consulta de Expedientes";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSteelBlue;
            button3.Font = new Font("Segoe UI", 12.096F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(296, 348);
            button3.Name = "button3";
            button3.Size = new Size(208, 84);
            button3.TabIndex = 4;
            button3.Text = "Búsqueda de Expedientes";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.Font = new Font("Segoe UI", 12.096F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(296, 564);
            button4.Name = "button4";
            button4.Size = new Size(208, 63);
            button4.TabIndex = 5;
            button4.Text = "Salir\r\n";
            button4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 721);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mesa de Partes Digital - Sistema de Expedientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
