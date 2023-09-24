using FormProgramCamadas.Code.BLL;
using FormProgramCamadas.Code.DTO;
using System.Globalization;

namespace FormProgramCamadas//Camada de apresentação
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
            //preenchendo o objeto de acordo com o que o usuário digitou
            dto.Nome = txtNome.Text;
            dto.Email = txtnick.Text;
            dto.CPF = txtCPF.Text;
           

            //invocando o método inserir da camada de negócios para gravar no banco de dados
            bll.Inserir(dto);
        }

    }
}