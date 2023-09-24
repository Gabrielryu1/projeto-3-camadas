using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormProgramCamadas.Code.DTO;
using projetomente.Code.DAL;

namespace FormProgramCamadas.Code.BLL  //Busines Lógic Layer = camada lógica de negócios
{
    internal class ClienteBLL
    {
        AcessoBancoDedados bd = new AcessoBancoDedados();
        public void Inserir(ClienteDTO dto)
        {
            bd.Conectar();
            string comando = "INSERT INTO cliente (nome, cpf, nick) VALUES ('" + dto.Nome + "', '" + dto.nick + "', '" + dto.CPF + "')";
            bd.ExecutarComandoSQL(comando);
        }
    }
}
