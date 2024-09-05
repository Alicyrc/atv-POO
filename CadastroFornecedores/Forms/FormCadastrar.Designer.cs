namespace CadastroFornecedores.Forms
{
    partial class FormCadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            bt_limpar = new Button();
            bt_salvar = new Button();
            lblRazaoSocial = new Label();
            txt_razao_social = new TextBox();
            txt_nome_fantasia = new TextBox();
            lblNomeFantasia = new Label();
            txt_cnpj = new TextBox();
            lblCnpj = new Label();
            lblStatus = new Label();
            txt_telefone = new TextBox();
            lblTelefone = new Label();
            txt_email = new TextBox();
            lblEmail = new Label();
            bt_cancelar = new Button();
            cb_ativo = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1, -3);
            label1.Name = "label1";
            label1.Size = new Size(559, 34);
            label1.TabIndex = 13;
            label1.Text = "Cadastro de Fornecedores";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bt_limpar
            // 
            bt_limpar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_limpar.Location = new Point(227, 272);
            bt_limpar.Name = "bt_limpar";
            bt_limpar.Size = new Size(94, 32);
            bt_limpar.TabIndex = 24;
            bt_limpar.Text = "LIMPAR";
            bt_limpar.UseVisualStyleBackColor = true;
            bt_limpar.Click += bt_limpar_Click;
            // 
            // bt_salvar
            // 
            bt_salvar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_salvar.Location = new Point(366, 272);
            bt_salvar.Name = "bt_salvar";
            bt_salvar.Size = new Size(94, 32);
            bt_salvar.TabIndex = 25;
            bt_salvar.Text = "SALVAR";
            bt_salvar.UseVisualStyleBackColor = true;
            bt_salvar.Click += bt_salvar_Click;
            // 
            // lblRazaoSocial
            // 
            lblRazaoSocial.AutoSize = true;
            lblRazaoSocial.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRazaoSocial.Location = new Point(12, 54);
            lblRazaoSocial.Name = "lblRazaoSocial";
            lblRazaoSocial.Size = new Size(117, 22);
            lblRazaoSocial.TabIndex = 26;
            lblRazaoSocial.Text = "Razão Social";
            // 
            // txt_razao_social
            // 
            txt_razao_social.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_razao_social.Location = new Point(12, 79);
            txt_razao_social.Name = "txt_razao_social";
            txt_razao_social.Size = new Size(265, 26);
            txt_razao_social.TabIndex = 27;
            // 
            // txt_nome_fantasia
            // 
            txt_nome_fantasia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome_fantasia.Location = new Point(283, 79);
            txt_nome_fantasia.Name = "txt_nome_fantasia";
            txt_nome_fantasia.Size = new Size(265, 26);
            txt_nome_fantasia.TabIndex = 29;
            // 
            // lblNomeFantasia
            // 
            lblNomeFantasia.AutoSize = true;
            lblNomeFantasia.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeFantasia.Location = new Point(283, 54);
            lblNomeFantasia.Name = "lblNomeFantasia";
            lblNomeFantasia.Size = new Size(134, 22);
            lblNomeFantasia.TabIndex = 28;
            lblNomeFantasia.Text = "Nome Fantasia";
            // 
            // txt_cnpj
            // 
            txt_cnpj.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cnpj.Location = new Point(12, 140);
            txt_cnpj.Name = "txt_cnpj";
            txt_cnpj.Size = new Size(219, 26);
            txt_cnpj.TabIndex = 31;
            // 
            // lblCnpj
            // 
            lblCnpj.AutoSize = true;
            lblCnpj.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCnpj.Location = new Point(12, 115);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(60, 22);
            lblCnpj.TabIndex = 30;
            lblCnpj.Text = "CNPJ";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.Location = new Point(241, 115);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(61, 22);
            lblStatus.TabIndex = 32;
            lblStatus.Text = "Status";
            // 
            // txt_telefone
            // 
            txt_telefone.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_telefone.Location = new Point(327, 140);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(217, 26);
            txt_telefone.TabIndex = 35;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefone.Location = new Point(327, 115);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(79, 22);
            lblTelefone.TabIndex = 34;
            lblTelefone.Text = "Telefone";
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(12, 203);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(532, 26);
            txt_email.TabIndex = 37;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(12, 178);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 22);
            lblEmail.TabIndex = 36;
            lblEmail.Text = "Email";
            // 
            // bt_cancelar
            // 
            bt_cancelar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_cancelar.Location = new Point(83, 272);
            bt_cancelar.Name = "bt_cancelar";
            bt_cancelar.Size = new Size(107, 32);
            bt_cancelar.TabIndex = 38;
            bt_cancelar.Text = "CANCELAR";
            bt_cancelar.UseVisualStyleBackColor = true;
            bt_cancelar.Click += bt_cancelar_Click;
            // 
            // cb_ativo
            // 
            cb_ativo.AutoSize = true;
            cb_ativo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_ativo.Location = new Point(251, 140);
            cb_ativo.Name = "cb_ativo";
            cb_ativo.Size = new Size(61, 23);
            cb_ativo.TabIndex = 39;
            cb_ativo.Text = "Ativo";
            cb_ativo.UseVisualStyleBackColor = true;
            // 
            // FormCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 345);
            Controls.Add(cb_ativo);
            Controls.Add(bt_cancelar);
            Controls.Add(txt_email);
            Controls.Add(lblEmail);
            Controls.Add(txt_telefone);
            Controls.Add(lblTelefone);
            Controls.Add(lblStatus);
            Controls.Add(txt_cnpj);
            Controls.Add(lblCnpj);
            Controls.Add(txt_nome_fantasia);
            Controls.Add(lblNomeFantasia);
            Controls.Add(txt_razao_social);
            Controls.Add(lblRazaoSocial);
            Controls.Add(bt_salvar);
            Controls.Add(bt_limpar);
            Controls.Add(label1);
            Name = "FormCadastrar";
            Text = "FormCadastrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bt_limpar;
        private Button bt_salvar;
        private Label lblRazaoSocial;
        private TextBox txt_razao_social;
        private TextBox txt_nome_fantasia;
        private Label lblNomeFantasia;
        private TextBox txt_cnpj;
        private Label lblCnpj;
        private Label lblStatus;
        private TextBox txt_telefone;
        private Label lblTelefone;
        private TextBox txt_email;
        private Label lblEmail;
        private Button bt_cancelar;
        private CheckBox cb_ativo;
    }
}