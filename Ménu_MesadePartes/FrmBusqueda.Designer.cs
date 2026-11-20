namespace Ménu_MesadePartes
{
    partial class FrmBusqueda
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
            txtCodigoBuscar = new TextBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            label3 = new Label();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(432, 48);
            label1.TabIndex = 0;
            label1.Text = "Busqueda de Expediente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 97);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 21);
            label2.TabIndex = 1;
            label2.Text = "Codigo de Expediente:";
            // 
            // txtCodigoBuscar
            // 
            txtCodigoBuscar.Location = new Point(57, 134);
            txtCodigoBuscar.Margin = new Padding(4);
            txtCodigoBuscar.Name = "txtCodigoBuscar";
            txtCodigoBuscar.Size = new Size(544, 29);
            txtCodigoBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Moccasin;
            btnBuscar.Location = new Point(73, 209);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(134, 57);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.PeachPuff;
            btnLimpiar.Location = new Point(255, 209);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(125, 57);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.IndianRed;
            btnSalir.Location = new Point(424, 209);
            btnSalir.Margin = new Padding(4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(135, 57);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.096F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 310);
            label3.Name = "label3";
            label3.Size = new Size(271, 30);
            label3.TabIndex = 6;
            label3.Text = "Resultado de la búsqueda:";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(57, 364);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(544, 245);
            txtResultado.TabIndex = 7;
            // 
            // FrmBusqueda
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 630);
            Controls.Add(txtResultado);
            Controls.Add(label3);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(txtCodigoBuscar);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "FrmBusqueda";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCodigoBuscar;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label3;
        private TextBox txtResultado;
    }
}
