using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto3Camadas.Code.DTO;
using Projeto3Camadas.Code.DAL;
using System.Data;

namespace Projeto3Camadas.Code.BLL
{
    class ClienteBLL
    {

        AcessoBancoDados bd;

        public void Inserir(ClienteDTO dto)
        {
            try
            {
                string nome = dto.Nome.Replace("'", "''");

                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "INSERT INTO cliente (nome, email) VALUES('" + nome + "','" + dto.Email + "')";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar cadastrar o cliente" + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }

        public DataTable SelecionaTodosClientes()
        {
            DataTable dt = new DataTable();

            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();

                dt = bd.RetDataTable("Select id, nome, email from cliente");
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar selecionar todos os clientes: " + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return dt;
        }

        public void Atualizar(ClienteDTO dto)
        {
            try
            {
                string nome = dto.Nome.Replace("'", "''");

                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "UPDATE cliente set nome = '" + dto.Nome + "', email = '" + dto.Email + "'where id =" + dto.Id;
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar atualizar o cliente" + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }

        public void Excluir(string idCliente)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "DELETE FROM cliente where id =" + idCliente;
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar excluir o cliente" + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }



    }
}
