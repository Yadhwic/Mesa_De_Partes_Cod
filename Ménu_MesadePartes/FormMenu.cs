using Ménu_MesadePartes;

namespace Ménu_MesadePartes
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FrmRegistro frm = new FrmRegistro();
            frm.ShowDialog();
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FrmConsulta frm = new FrmConsulta();
            frm.ShowDialog();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBúsqueda_Click(object sender, EventArgs e)
        {
            FrmBusqueda frm = new FrmBusqueda();
            frm.ShowDialog();
        }
    }
}
