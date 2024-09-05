namespace CadastroFornecedores
{
    partial class formList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            bt_cadastrar = new Button();
            dgvList = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            razao_social = new DataGridViewTextBoxColumn();
            nome_fantasia = new DataGridViewTextBoxColumn();
            cnpj = new DataGridViewTextBoxColumn();
            status_fornecedor = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            bt_atualizar_lista = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, -4);
            label1.Name = "label1";
            label1.Size = new Size(742, 34);
            label1.TabIndex = 12;
            label1.Text = "Fornecedores";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bt_cadastrar
            // 
            bt_cadastrar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_cadastrar.Location = new Point(155, 49);
            bt_cadastrar.Name = "bt_cadastrar";
            bt_cadastrar.Size = new Size(125, 32);
            bt_cadastrar.TabIndex = 24;
            bt_cadastrar.Text = "CADASTRAR";
            bt_cadastrar.UseVisualStyleBackColor = true;
            bt_cadastrar.Click += bt_cadastrar_Click;
            // 
            // dgvList
            // 
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Columns.AddRange(new DataGridViewColumn[] { Id, razao_social, nome_fantasia, cnpj, status_fornecedor, telefone, email });
            dgvList.Location = new Point(0, 102);
            dgvList.Name = "dgvList";
            dgvList.RowTemplate.Height = 25;
            dgvList.Size = new Size(742, 297);
            dgvList.TabIndex = 25;
            dgvList.CellDoubleClick += dgvList_CellDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            // 
            // razao_social
            // 
            razao_social.HeaderText = "Razão Social";
            razao_social.Name = "razao_social";
            // 
            // nome_fantasia
            // 
            nome_fantasia.HeaderText = "Nome Fantasia";
            nome_fantasia.Name = "nome_fantasia";
            // 
            // cnpj
            // 
            cnpj.HeaderText = "CNPJ";
            cnpj.Name = "cnpj";
            // 
            // status_fornecedor
            // 
            status_fornecedor.HeaderText = "Status";
            status_fornecedor.Name = "status_fornecedor";
            // 
            // telefone
            // 
            telefone.HeaderText = "Telefone";
            telefone.Name = "telefone";
            // 
            // email
            // 
            email.HeaderText = "E-mail";
            email.Name = "email";
            // 
            // bt_atualizar_lista
            // 
            bt_atualizar_lista.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_atualizar_lista.Location = new Point(464, 49);
            bt_atualizar_lista.Name = "bt_atualizar_lista";
            bt_atualizar_lista.Size = new Size(176, 32);
            bt_atualizar_lista.TabIndex = 26;
            bt_atualizar_lista.Text = "ATUALIZAR LISTA";
            bt_atualizar_lista.UseVisualStyleBackColor = true;
            bt_atualizar_lista.Click += bt_atualizar_lista_Click;
            // 
            // formList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 401);
            Controls.Add(bt_atualizar_lista);
            Controls.Add(dgvList);
            Controls.Add(bt_cadastrar);
            Controls.Add(label1);
            Name = "formList";
            Text = "Fornecedores";
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button bt_cadastrar;
        private DataGridView dgvList;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn razao_social;
        private DataGridViewTextBoxColumn nome_fantasia;
        private DataGridViewTextBoxColumn cnpj;
        private DataGridViewTextBoxColumn status_fornecedor;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn email;
        private Button bt_atualizar_lista;
    }
}