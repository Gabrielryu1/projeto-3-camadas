using FormProgramCamadas.Code.BLL;
using FormProgramCamadas.Code.DTO;
using System.Globalization;

namespace FormProgramCamadas//Camada de apresenta��o
{
    public partial class frmCadastroCliente : Form
    {
        ClienteBLL bll = new ClienteBLL();
        ClienteDTO dto = new ClienteDTO();
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //preenchendo o objeto de acordo com o que o usu�rio digitou
            dto.Nome = txtNome.Text;
            dto.Email = txtnick.Text;
            dto.CPF = txtCPF.Text;
           

            //invocando o m�todo inserir da camada de neg�cios para gravar no banco de dados
            bll.Inserir(dto);
        }

    }
}