namespace Ménu_MesadePartes
{
    public partial class FrmBusqueda : Form
    {


        string archivo = Path.Combine(Application.StartupPath, "expedientes.txt");

        public FrmBusqueda()
        {
            InitializeComponent();
        }



        void buscarExpediente()
        {
            string codigoBuscado = txtCodigoBuscar.Text.Trim();

            if (codigoBuscado == "")
            {
                MessageBox.Show("Debe ingresar un código para buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoBuscar.Focus();
                return;
            }

            if (!File.Exists(archivo))
            {
                MessageBox.Show("No existe el archivo de expedientes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string[] lineas = File.ReadAllLines(archivo);
            bool encontrado = false;

            for (int i = 0; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i]))
                {
                    continue;
                }

                string[] datos = lineas[i].Split('|');

                if (datos.Length == 6 && datos[0].Equals(codigoBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    txtResultado.Text = "¡Expediente Encontrado!\r\n" +
                                       "Código: " + datos[0] + "\r\n" +
                                       "DNI: " + datos[1] + "\r\n" +
                                       "Solicitante: " + datos[2] + "\r\n" +
                                       "Tipo de Documento: " + datos[3] + "\r\n" +
                                       "Asunto: " + datos[4] + "\r\n" +
                                       "Fecha: " + datos[5];

                    

                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("Mensaje: El código de expediente no existe", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
        }

        void limpiar()
        {
            txtCodigoBuscar.Clear();
            txtResultado.Clear();
            txtCodigoBuscar.Focus();
        }

        void cerrar()
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir de la búsqueda?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarExpediente();
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrar();
        }
    }
}
