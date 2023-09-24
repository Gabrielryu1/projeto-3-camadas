namespace Formprojetomente.Code.DTO
{
    internal class ClienteDTO
    {
        private int id;
        
        private string cpf;
        private string nome;
        private string nick;

        //encapsulamento
        public int Id { get => id; set => id = value; }
    
        public string CPF { get => cpf; set => cpf = value; }

        public string Nome { get => nome; set => nome = value; }
        public string nick { get => nick; set => nick = value; }
    }
}
