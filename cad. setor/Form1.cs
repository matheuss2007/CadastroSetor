using Microsoft.Win32;
using MySql.Data.MySqlClient;

namespace cad._setor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if ( !txtSetor.Text.Equals(""))
                {
                    setor s = new setor();
                    
                    s.Nome = txtSetor.Text;
                    if (s.InserirSetor())
                    {
                        MessageBox.Show("Gravado com sucesso!");
                       
                        txtNome.Clear();

                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
    }
}
