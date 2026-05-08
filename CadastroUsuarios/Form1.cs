using System.Diagnostics;

namespace CadastroUsuarios
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            lsbExibir.Items.Add("RM: " + txtRM.Text);
            lsbExibir.Items.Add("CPF: " + mskCPF.Text);
            lsbExibir.Items.Add("Nome: " + txtNome.Text);
            lsbExibir.Items.Add("Nascimento: " + dtpNascimento.Text);
            lsbExibir.Items.Add("Sexo: " + cmbSexo.Text);
            lsbExibir.Items.Add("Naturalidade: " + cmbNaturalidade.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRM.Clear();
            mskCPF.Clear();
            txtNome.Clear();
            cmbSexo.SelectedIndex = -1;
            cmbNaturalidade.SelectedIndex = -1;

            lsbExibir.Items.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void btnBloco_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void btnChrome_Click(object sender, EventArgs e)
        {
            String path = "\"C:\\Program Files\\BraveSoftware\\Brave-Browser\\Application\\brave.exe\"";
            String url = "https://fatectq.cps.sp.gov.br/";
            Process.Start(path, url);
        }

        private void btnPainel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("control");
        }

        private void btnCMD_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd");
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            lsbExibir.Items.Clear();

            lsbExibir.Items.Add("Nome do computador: " + Environment.MachineName);
            lsbExibir.Items.Add("Usuário: " + Environment.UserName);
            lsbExibir.Items.Add("Sistema Operacional: " + Environment.OSVersion);
            lsbExibir.Items.Add("Versão do .NET: " + Environment.Version);
            lsbExibir.Items.Add("Processadores: " + Environment.ProcessorCount);
            lsbExibir.Items.Add("64 bits: " + Environment.Is64BitOperatingSystem);
        }
    }
}
