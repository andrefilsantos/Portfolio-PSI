namespace m09_p01
{
    partial class frm_1
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
            this.lb_funcionarios = new System.Windows.Forms.ListBox();
            this.lbl_empresa = new System.Windows.Forms.Label();
            this.btn_addNew = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.lbl_salario = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_idade = new System.Windows.Forms.TextBox();
            this.tb_salario = new System.Windows.Forms.TextBox();
            this.lbl_sal = new System.Windows.Forms.Label();
            this.cb_cargo = new System.Windows.Forms.ComboBox();
            this.lbl_acoes = new System.Windows.Forms.Label();
            this.tb_acoes = new System.Windows.Forms.TextBox();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_funcionarios
            // 
            this.lb_funcionarios.FormattingEnabled = true;
            this.lb_funcionarios.Location = new System.Drawing.Point(12, 25);
            this.lb_funcionarios.Name = "lb_funcionarios";
            this.lb_funcionarios.Size = new System.Drawing.Size(120, 290);
            this.lb_funcionarios.TabIndex = 0;
            this.lb_funcionarios.SelectedIndexChanged += new System.EventHandler(this.lb_funcionarios_SelectedIndexChanged);
            // 
            // lbl_empresa
            // 
            this.lbl_empresa.AutoSize = true;
            this.lbl_empresa.Location = new System.Drawing.Point(13, 6);
            this.lbl_empresa.Name = "lbl_empresa";
            this.lbl_empresa.Size = new System.Drawing.Size(117, 13);
            this.lbl_empresa.TabIndex = 1;
            this.lbl_empresa.Text = "Funcionarios Empresa: ";
            // 
            // btn_addNew
            // 
            this.btn_addNew.Location = new System.Drawing.Point(139, 25);
            this.btn_addNew.Name = "btn_addNew";
            this.btn_addNew.Size = new System.Drawing.Size(195, 23);
            this.btn_addNew.TabIndex = 2;
            this.btn_addNew.Text = "Adicionar novo";
            this.btn_addNew.UseVisualStyleBackColor = true;
            this.btn_addNew.Click += new System.EventHandler(this.btn_addNew_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(139, 55);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_nome.TabIndex = 3;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(140, 84);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(38, 13);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "E-mail:";
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(140, 110);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(37, 13);
            this.lbl_idade.TabIndex = 5;
            this.lbl_idade.Text = "Idade:";
            // 
            // lbl_salario
            // 
            this.lbl_salario.AutoSize = true;
            this.lbl_salario.Location = new System.Drawing.Point(140, 136);
            this.lbl_salario.Name = "lbl_salario";
            this.lbl_salario.Size = new System.Drawing.Size(42, 13);
            this.lbl_salario.TabIndex = 6;
            this.lbl_salario.Text = "Salario:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(181, 55);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(153, 20);
            this.tb_nome.TabIndex = 7;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(181, 81);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(153, 20);
            this.tb_email.TabIndex = 8;
            // 
            // tb_idade
            // 
            this.tb_idade.Location = new System.Drawing.Point(181, 107);
            this.tb_idade.Name = "tb_idade";
            this.tb_idade.Size = new System.Drawing.Size(153, 20);
            this.tb_idade.TabIndex = 9;
            // 
            // tb_salario
            // 
            this.tb_salario.Location = new System.Drawing.Point(181, 133);
            this.tb_salario.Name = "tb_salario";
            this.tb_salario.Size = new System.Drawing.Size(153, 20);
            this.tb_salario.TabIndex = 10;
            // 
            // lbl_sal
            // 
            this.lbl_sal.AutoSize = true;
            this.lbl_sal.Location = new System.Drawing.Point(138, 159);
            this.lbl_sal.Name = "lbl_sal";
            this.lbl_sal.Size = new System.Drawing.Size(38, 13);
            this.lbl_sal.TabIndex = 11;
            this.lbl_sal.Text = "Cargo:";
            // 
            // cb_cargo
            // 
            this.cb_cargo.FormattingEnabled = true;
            this.cb_cargo.Items.AddRange(new object[] {
            "EMPREGADO",
            "PATRAO"});
            this.cb_cargo.Location = new System.Drawing.Point(181, 156);
            this.cb_cargo.Name = "cb_cargo";
            this.cb_cargo.Size = new System.Drawing.Size(153, 21);
            this.cb_cargo.TabIndex = 12;
            this.cb_cargo.SelectedIndexChanged += new System.EventHandler(this.cb_cargo_SelectedIndexChanged);
            // 
            // lbl_acoes
            // 
            this.lbl_acoes.AutoSize = true;
            this.lbl_acoes.Location = new System.Drawing.Point(135, 186);
            this.lbl_acoes.Name = "lbl_acoes";
            this.lbl_acoes.Size = new System.Drawing.Size(40, 13);
            this.lbl_acoes.TabIndex = 13;
            this.lbl_acoes.Text = "Ações:";
            // 
            // tb_acoes
            // 
            this.tb_acoes.Location = new System.Drawing.Point(181, 183);
            this.tb_acoes.Name = "tb_acoes";
            this.tb_acoes.Size = new System.Drawing.Size(153, 20);
            this.tb_acoes.TabIndex = 14;
            this.tb_acoes.TextChanged += new System.EventHandler(this.tb_acoes_TextChanged);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(341, 25);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_mostrar.TabIndex = 15;
            this.btn_mostrar.Text = "Mostrar Dados";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // frm_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.tb_acoes);
            this.Controls.Add(this.lbl_acoes);
            this.Controls.Add(this.cb_cargo);
            this.Controls.Add(this.lbl_sal);
            this.Controls.Add(this.tb_salario);
            this.Controls.Add(this.tb_idade);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lbl_salario);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_addNew);
            this.Controls.Add(this.lbl_empresa);
            this.Controls.Add(this.lb_funcionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_1";
            this.Text = "M09_P01";
            this.Load += new System.EventHandler(this.frm_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_funcionarios;
        private System.Windows.Forms.Label lbl_empresa;
        private System.Windows.Forms.Button btn_addNew;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.Label lbl_salario;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_idade;
        private System.Windows.Forms.TextBox tb_salario;
        private System.Windows.Forms.Label lbl_sal;
        private System.Windows.Forms.ComboBox cb_cargo;
        private System.Windows.Forms.Label lbl_acoes;
        private System.Windows.Forms.TextBox tb_acoes;
        private System.Windows.Forms.Button btn_mostrar;
    }
}

