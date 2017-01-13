namespace M08_P06_N02
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
            this.lb_idade = new System.Windows.Forms.Label();
            this.tb_idade = new System.Windows.Forms.TextBox();
            this.lb_resposta = new System.Windows.Forms.Label();
            this.btn_obtresp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_idade
            // 
            this.lb_idade.AutoSize = true;
            this.lb_idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idade.Location = new System.Drawing.Point(50, 33);
            this.lb_idade.Name = "lb_idade";
            this.lb_idade.Size = new System.Drawing.Size(94, 32);
            this.lb_idade.TabIndex = 0;
            this.lb_idade.Text = "Idade:";
            this.lb_idade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_idade
            // 
            this.tb_idade.Location = new System.Drawing.Point(150, 38);
            this.tb_idade.MaximumSize = new System.Drawing.Size(250, 250);
            this.tb_idade.Name = "tb_idade";
            this.tb_idade.Size = new System.Drawing.Size(100, 22);
            this.tb_idade.TabIndex = 1;
            // 
            // lb_resposta
            // 
            this.lb_resposta.AutoSize = true;
            this.lb_resposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resposta.Location = new System.Drawing.Point(27, 149);
            this.lb_resposta.Name = "lb_resposta";
            this.lb_resposta.Size = new System.Drawing.Size(0, 25);
            this.lb_resposta.TabIndex = 2;
            this.lb_resposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_obtresp
            // 
            this.btn_obtresp.Location = new System.Drawing.Point(78, 90);
            this.btn_obtresp.Name = "btn_obtresp";
            this.btn_obtresp.Size = new System.Drawing.Size(141, 42);
            this.btn_obtresp.TabIndex = 3;
            this.btn_obtresp.Text = "Obter Resposta";
            this.btn_obtresp.UseVisualStyleBackColor = true;
            this.btn_obtresp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_obtresp_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 198);
            this.Controls.Add(this.btn_obtresp);
            this.Controls.Add(this.lb_resposta);
            this.Controls.Add(this.tb_idade);
            this.Controls.Add(this.lb_idade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_idade;
        private System.Windows.Forms.TextBox tb_idade;
        private System.Windows.Forms.Label lb_resposta;
        private System.Windows.Forms.Button btn_obtresp;
    }
}

