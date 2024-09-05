using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroFornecedores.DAO;
using CadastroFornecedores.Models;
using CadastroFornecedores.Forms;

namespace CadastroFornecedores.Forms
{
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Fornecedores forn = new Fornecedores();
            FornecedoresDAO fornDAO = new FornecedoresDAO();
            forn.Razao_social = txt_razao_social.Text;
            forn.Nome_fornecedor = txt_nome_fantasia.Text;
            forn.Cnpj = txt_cnpj.Text;
            forn.Status_fornecedor = cb_ativo.Checked;
            forn.Telefone = txt_telefone.Text;
            forn.Email = txt_email.Text;
            fornDAO.Insert(forn);
            MessageBox.Show("Salvo com sucesso!", "Cadastro Fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            txt_razao_social.Clear();
            txt_nome_fantasia.Clear();
            txt_cnpj.Clear();
            txt_telefone.Clear();
            txt_email.Clear();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
