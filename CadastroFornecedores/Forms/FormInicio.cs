using MySql.Data.MySqlClient;
using CadastroFornecedores.DAO;
using CadastroFornecedores.Models;
using CadastroFornecedores.Forms;

namespace CadastroFornecedores
{
    public partial class formList : Form
    {
        public formList()
        {
            InitializeComponent();
            Fornecedores forn = new Fornecedores();
            FornecedoresDAO fornDAO = new FornecedoresDAO();
            List<Fornecedores> lista = fornDAO.Listar();
            foreach (var f in lista)
            {
                dgvList.Rows.Add(f.Id_fornecedor, f.Razao_social, f.Nome_fornecedor,
                    f.Cnpj, f.Status_fornecedor, f.Telefone, f.Email);
            }
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrar form = new FormCadastrar();
            form.ShowDialog();
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id_forn = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells["Id"].Value);
                FormEditar formEditarCliente = new FormEditar(id_forn);
                formEditarCliente.ShowDialog();
                Fornecedores forn = new Fornecedores();
                FornecedoresDAO fornDAO = new FornecedoresDAO();
                List<Fornecedores> lista = fornDAO.Listar();
                foreach (var f in lista)
                {
                    dgvList.Rows.Add(f.Id_fornecedor, f.Razao_social, f.Nome_fornecedor,
                        f.Cnpj, f.Status_fornecedor, f.Telefone, f.Email);
                }
            }
        }

        private void bt_atualizar_lista_Click(object sender, EventArgs e)
        {
            dgvList.Rows.Clear();
            Fornecedores forn = new Fornecedores();
            FornecedoresDAO fornDAO = new FornecedoresDAO();
            List<Fornecedores> lista = fornDAO.Listar();
            foreach (var f in lista)
            {
                dgvList.Rows.Add(f.Id_fornecedor, f.Razao_social, f.Nome_fornecedor,
                    f.Cnpj, f.Status_fornecedor, f.Telefone, f.Email);
            }
        }
    }
}