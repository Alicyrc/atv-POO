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
    public partial class FormEditar : Form
    {
        private int id_form_editar;
        public FormEditar()
        {
            InitializeComponent();
        }
        public FormEditar(int id)
        {
            id_form_editar = id;
            InitializeComponent();
            Fornecedores forn = new Fornecedores();
            FornecedoresDAO fornDAO = new FornecedoresDAO();
            List<Fornecedores> lista;
            lista = fornDAO.Listar();
            foreach (Fornecedores f in lista)
            {
                txt_razao_social.Text = f.Razao_social;
                txt_nome_fantasia.Text = f.Nome_fornecedor;
                txt_cnpj.Text = f.Cnpj;
                cb_ativo.Checked = f.Status_fornecedor;
                txt_telefone.Text = f.Telefone;
                txt_email.Text = f.Email;
            }
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Fornecedores forn = new Fornecedores();
            FornecedoresDAO fornDAO = new FornecedoresDAO();
            forn.Id_fornecedor = id_form_editar;
            forn.Razao_social = txt_razao_social.Text;
            forn.Nome_fornecedor = txt_nome_fantasia.Text;
            forn.Cnpj = txt_cnpj.Text;
            forn.Status_fornecedor = cb_ativo.Checked;
            forn.Telefone = txt_telefone.Text;
            forn.Email = txt_email.Text;
            fornDAO.Update(forn, id_form_editar);
            MessageBox.Show("Alterações salvas com sucesso!", "Editar Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_deletar_Click(object sender, EventArgs e)
        {
            Fornecedores forn = new Fornecedores();
            FornecedoresDAO fornDAO = new FornecedoresDAO();
            fornDAO.Delete(id_form_editar);
            MessageBox.Show("Fornecedor excluído!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
