using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroFornecedores.Models;
using MySql.Data.MySqlClient;
using CadastroFornecedores.DAO;

namespace CadastroFornecedores.DAO
{
    internal class FornecedoresDAO
    {
        public void Insert(Fornecedores fornecedor)
        {
            try
            {
                string sql = "INSERT INTO Fornecedores(razao_social, nome_fornecedor, cnpj, status_fornecedor, telefone, email) VALUES " +
                    "(@razao_social, @nome_fornecedor, @cnpj, @status_fornecedor, @telefone, @email)";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@razao_social", fornecedor.Razao_social);
                comando.Parameters.AddWithValue("@nome_fornecedor", fornecedor.Nome_fornecedor);
                comando.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
                comando.Parameters.AddWithValue("@status_fornecedor", fornecedor.Status_fornecedor);
                comando.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
                comando.Parameters.AddWithValue("@email", fornecedor.Email);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro" + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }
        public void Delete(int id)
        {
            try
            {
                string sql = "DELETE FROM Fornecedores WHERE id_fornecedor = @id_fornecedor";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_fornecedor", id);
                comando.ExecuteNonQuery();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir");
            }
        }
        public List<Fornecedores> Listar()
        {
            List<Fornecedores> fornecedores = new List<Fornecedores>();
            try
            {
                var sql = "SELECT * FROM Fornecedores ORDER BY razao_social";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Fornecedores f = new Fornecedores();
                        f.Id_fornecedor = dr.GetInt32("id_fornecedor");
                        f.Razao_social = dr.GetString("razao_social");
                        f.Nome_fornecedor = dr.GetString("nome_fornecedor");
                        f.Cnpj = dr.GetString("cnpj");
                        f.Status_fornecedor = dr.GetBoolean("status_fornecedor");
                        f.Telefone = dr.GetString("telefone");
                        f.Email = dr.GetString("email");
                        fornecedores.Add(f);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar" + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
            return fornecedores;
        }
        public void Update(Fornecedores fornecedor, int id)
        {
            try
            {
                string sql = "UPDATE Fornecedores SET razao_social = @razao_social, nome_fornecedor = @nome_fornecedor, cnpj = @cnpj, " +
                    "status_fornecedor = @status_fornecedor, telefone = @telefone, email = @email WHERE id_fornecedor = @id";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@razao_social", fornecedor.Razao_social);
                comando.Parameters.AddWithValue("@nome_fornecedor", fornecedor.Nome_fornecedor);
                comando.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
                comando.Parameters.AddWithValue("@status_fornecedor", fornecedor.Status_fornecedor);
                comando.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
                comando.Parameters.AddWithValue("@email", fornecedor.Email);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro" + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }
    }
}
