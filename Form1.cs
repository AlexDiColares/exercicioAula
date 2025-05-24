namespace appTesteNovo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Alex" && txtSenha.Text == "123")
            {
                this.Visible = false;
                frmPrincipal frmP = new frmPrincipal();
                
                frmP.Show();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorretos. Digite novamente!");
                txtUsuario.Text = "";
                txtSenha.Text = "";
            }
        }
    }
}
