namespace M08_P07_N02
{
    partial class Form1
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
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.lb_preco = new System.Windows.Forms.Label();
            this.lb_resposta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_mocambique = new System.Windows.Forms.RadioButton();
            this.rb_angola = new System.Windows.Forms.RadioButton();
            this.rb_caboverde = new System.Windows.Forms.RadioButton();
            this.rb_brasil = new System.Windows.Forms.RadioButton();
            this.rb_OutroPais = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_preco
            // 
            this.tb_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_preco.Location = new System.Drawing.Point(116, 57);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(100, 34);
            this.tb_preco.TabIndex = 1;
            // 
            // lb_preco
            // 
            this.lb_preco.AutoSize = true;
            this.lb_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_preco.Location = new System.Drawing.Point(27, 57);
            this.lb_preco.Name = "lb_preco";
            this.lb_preco.Size = new System.Drawing.Size(83, 29);
            this.lb_preco.TabIndex = 3;
            this.lb_preco.Text = "Preço:";
            // 
            // lb_resposta
            // 
            this.lb_resposta.AutoSize = true;
            this.lb_resposta.Location = new System.Drawing.Point(88, 177);
            this.lb_resposta.Name = "lb_resposta";
            this.lb_resposta.Size = new System.Drawing.Size(0, 17);
            this.lb_resposta.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "Obter Resposta!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_OutroPais);
            this.groupBox1.Controls.Add(this.rb_brasil);
            this.groupBox1.Controls.Add(this.rb_caboverde);
            this.groupBox1.Controls.Add(this.rb_angola);
            this.groupBox1.Controls.Add(this.rb_mocambique);
            this.groupBox1.Location = new System.Drawing.Point(277, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 175);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "País de Origem";
            // 
            // rb_mocambique
            // 
            this.rb_mocambique.AutoSize = true;
            this.rb_mocambique.Location = new System.Drawing.Point(7, 36);
            this.rb_mocambique.Name = "rb_mocambique";
            this.rb_mocambique.Size = new System.Drawing.Size(109, 21);
            this.rb_mocambique.TabIndex = 0;
            this.rb_mocambique.TabStop = true;
            this.rb_mocambique.Text = "Moçambique";
            this.rb_mocambique.UseVisualStyleBackColor = true;
            // 
            // rb_angola
            // 
            this.rb_angola.AutoSize = true;
            this.rb_angola.Location = new System.Drawing.Point(7, 63);
            this.rb_angola.Name = "rb_angola";
            this.rb_angola.Size = new System.Drawing.Size(73, 21);
            this.rb_angola.TabIndex = 1;
            this.rb_angola.TabStop = true;
            this.rb_angola.Text = "Angola";
            this.rb_angola.UseVisualStyleBackColor = true;
            // 
            // rb_caboverde
            // 
            this.rb_caboverde.AutoSize = true;
            this.rb_caboverde.Location = new System.Drawing.Point(7, 90);
            this.rb_caboverde.Name = "rb_caboverde";
            this.rb_caboverde.Size = new System.Drawing.Size(104, 21);
            this.rb_caboverde.TabIndex = 2;
            this.rb_caboverde.TabStop = true;
            this.rb_caboverde.Text = "Cabo Verde";
            this.rb_caboverde.UseVisualStyleBackColor = true;
            // 
            // rb_brasil
            // 
            this.rb_brasil.AutoSize = true;
            this.rb_brasil.Location = new System.Drawing.Point(7, 117);
            this.rb_brasil.Name = "rb_brasil";
            this.rb_brasil.Size = new System.Drawing.Size(64, 21);
            this.rb_brasil.TabIndex = 3;
            this.rb_brasil.TabStop = true;
            this.rb_brasil.Text = "Brasil";
            this.rb_brasil.UseVisualStyleBackColor = true;
            // 
            // rb_OutroPais
            // 
            this.rb_OutroPais.AutoSize = true;
            this.rb_OutroPais.Location = new System.Drawing.Point(7, 144);
            this.rb_OutroPais.Name = "rb_OutroPais";
            this.rb_OutroPais.Size = new System.Drawing.Size(96, 21);
            this.rb_OutroPais.TabIndex = 4;
            this.rb_OutroPais.TabStop = true;
            this.rb_OutroPais.Text = "Outro País";
            this.rb_OutroPais.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 249);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_resposta);
            this.Controls.Add(this.lb_preco);
            this.Controls.Add(this.tb_preco);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.Label lb_preco;
        private System.Windows.Forms.Label lb_resposta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_OutroPais;
        private System.Windows.Forms.RadioButton rb_brasil;
        private System.Windows.Forms.RadioButton rb_caboverde;
        private System.Windows.Forms.RadioButton rb_angola;
        private System.Windows.Forms.RadioButton rb_mocambique;
    }
}

