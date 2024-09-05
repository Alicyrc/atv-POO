using MySql.Data.MySqlClient;

public static class Conexao
{
    static MySqlConnection conexao;
    public static MySqlConnection Conectar()
    {
        try
        {
            string strconexao = "server=localhost;uid=root;pwd=alicy3003;database=GestaoFinanceira";
            conexao = new MySqlConnection(strconexao);
            conexao.Open();
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao conectar" + ex.Message);
        }
        return conexao;
    }
    public static void FecharConexao()
    {
        conexao.Close();
    }
}
