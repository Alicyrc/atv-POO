namespace CadastroFornecedores.Forms
{
    partial class FormEditar
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
            cb_ativo = new CheckBox();
            bt_cancelar = new Button();
            txt_email = new TextBox();
            lblEmail = new Label();
            txt_telefone = new TextBox();
            lblTelefone = new Label();
            lblStatus = new Label();
            txt_cnpj = new TextBox();
            lblCnpj = new Label();
            txt_nome_fantasia = new TextBox();
            lblNomeFantasia = new Label();
            txt_razao_social = new TextBox();
            lblRazaoSocial = new Label();
            bt_salvar = new Button();
            label1 = new Label();
            bt_deletar = new Button();
            SuspendLayout();
            // 
            // cb_ativo
            // 
            cb_ativo.AutoSize = true;
            cb_ativo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_ativo.Location = new Point(251, 143);
            cb_ativo.Name = "cb_ativo";
            cb_ativo.Size = new Size(61, 23);
            cb_ativo.TabIndex = 54;
            cb_ativo.Text = "Ativo";
            cb_ativo.UseVisualStyleBackColor = true;
            // 
            // bt_cancelar
            // 
            bt_cancelar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_cancelar.Location = new Point(83, 275);
            bt_cancelar.Name = "bt_cancelar";
            bt_cancelar.Size = new Size(107, 32);
            bt_cancelar.TabIndex = 53;
            bt_cancelar.Text = "CANCELAR";
            bt_cancelar.UseVisualStyleBackColor = true;
            bt_cancelar.Click += bt_cancelar_Click;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(12, 206);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(532, 26);
            txt_email.TabIndex = 52;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(12, 181);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 22);
            lblEmail.TabIndex = 51;
            lblEmail.Text = "Email";
            // 
            // txt_telefone
            // 
            txt_telefone.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_telefone.Location = new Point(327, 143);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(217, 26);
            txt_telefone.TabIndex = 50;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefone.Location = new Point(327, 118);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(79, 22);
            lblTelefone.TabIndex = 49;
            lblTelefone.Text = "Telefone";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.Location = new Point(241, 118);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(61, 22);
            lblStatus.TabIndex = 48;
            lblStatus.Text = "Status";
            // 
            // txt_cnpj
            // 
            txt_cnpj.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cnpj.Location = new Point(12, 143);
            txt_cnpj.Name = "txt_cnpj";
            txt_cnpj.Size = new Size(219, 26);
            txt_cnpj.TabIndex = 47;
            // 
            // lblCnpj
            // 
            lblCnpj.AutoSize = true;
            lblCnpj.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCnpj.Location = new Point(12, 118);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(60, 22);
            lblCnpj.TabIndex = 46;
            lblCnpj.Text = "CNPJ";
            // 
            // txt_nome_fantasia
            // 
            txt_nome_fantasia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome_fantasia.Location = new Point(283, 82);
            txt_nome_fantasia.Name = "txt_nome_fantasia";
            txt_nome_fantasia.Size = new Size(265, 26);
            txt_nome_fantasia.TabIndex = 45;
            // 
            // lblNomeFantasia
            // 
            lblNomeFantasia.AutoSize = true;
            lblNomeFantasia.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeFantasia.Location = new Point(283, 57);
            lblNomeFantasia.Name = "lblNomeFantasia";
            lblNomeFantasia.Size = new Size(134, 22);
            lblNomeFantasia.TabIndex = 44;
            lblNomeFantasia.Text = "Nome Fantasia";
            // 
            // txt_razao_social
            // 
            txt_razao_social.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_razao_social.Location = new Point(12, 82);
            txt_razao_social.Name = "txt_razao_social";
            txt_razao_social.Size = new Size(265, 26);
            txt_razao_social.TabIndex = 43;
            // 
            // lblRazaoSocial
            // 
            lblRazaoSocial.AutoSize = true;
            lblRazaoSocial.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRazaoSocial.Location = new Point(12, 57);
            lblRazaoSocial.Name = "lblRazaoSocial";
            lblRazaoSocial.Size = new Size(117, 22);
            lblRazaoSocial.TabIndex = 42;
            lblRazaoSocial.Text = "Razão Social";
            // 
            // bt_salvar
            // 
            bt_salvar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_salvar.Location = new Point(366, 275);
            bt_salvar.Name = "bt_salvar";
            bt_salvar.Size = new Size(94, 32);
            bt_salvar.TabIndex = 41;
            bt_salvar.Text = "SALVAR";
            bt_salvar.UseVisualStyleBackColor = true;
            bt_salvar.Click += bt_salvar_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1, 0);
            label1.Name = "label1";
            label1.Size = new Size(559, 34);
            label1.TabIndex = 40;
            label1.Text = "Editar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bt_deletar
            // 
            bt_deletar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_deletar.Location = new Point(225, 275);
            bt_deletar.Name = "bt_deletar";
            bt_deletar.Size = new Size(107, 32);
            bt_deletar.TabIndex = 55;
            bt_deletar.Text = "DELETAR";
            bt_deletar.UseVisualStyleBackColor = true;
            bt_deletar.Click += bt_deletar_Click;
            // 
            // FormEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 355);
            Controls.Add(bt_deletar);
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
            Controls.Add(label1);
            Name = "FormEditar";
            Text = "FormEditar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cb_ativo;
        private Button bt_cancelar;
        private TextBox txt_email;
        private Label lblEmail;
        private TextBox txt_telefone;
        private Label lblTelefone;
        private Label lblStatus;
        private TextBox txt_cnpj;
        private Label lblCnpj;
        private TextBox txt_nome_fantasia;
        private Label lblNomeFantasia;
        private TextBox txt_razao_social;
        private Label lblRazaoSocial;
        private Button bt_salvar;
        private Label label1;
        private Button bt_deletar;
    }
}