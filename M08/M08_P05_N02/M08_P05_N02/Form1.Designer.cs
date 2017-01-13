namespace M08_P05_N02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_tpagar = new System.Windows.Forms.TextBox();
            this.lb_tpagar = new System.Windows.Forms.Label();
            this.lb_vrecebido = new System.Windows.Forms.Label();
            this.tb_vrecebido = new System.Windows.Forms.TextBox();
            this.lb_troco = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.Pb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_tpagar
            // 
            this.tb_tpagar.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.tb_tpagar.Location = new System.Drawing.Point(504, 32);
            this.tb_tpagar.Name = "tb_tpagar";
            this.tb_tpagar.Size = new System.Drawing.Size(117, 22);
            this.tb_tpagar.TabIndex = 0;
            this.tb_tpagar.TextChanged += new System.EventHandler(this.tb_tpagar_TextChanged);
            // 
            // lb_tpagar
            // 
            this.lb_tpagar.AutoSize = true;
            this.lb_tpagar.Location = new System.Drawing.Point(400, 35);
            this.lb_tpagar.Name = "lb_tpagar";
            this.lb_tpagar.Size = new System.Drawing.Size(98, 17);
            this.lb_tpagar.TabIndex = 1;
            this.lb_tpagar.Text = "Total a Pagar:";
            // 
            // lb_vrecebido
            // 
            this.lb_vrecebido.AutoSize = true;
            this.lb_vrecebido.Location = new System.Drawing.Point(400, 73);
            this.lb_vrecebido.Name = "lb_vrecebido";
            this.lb_vrecebido.Size = new System.Drawing.Size(104, 17);
            this.lb_vrecebido.TabIndex = 3;
            this.lb_vrecebido.Text = "Valor recebido:";
            // 
            // tb_vrecebido
            // 
            this.tb_vrecebido.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.tb_vrecebido.Location = new System.Drawing.Point(504, 70);
            this.tb_vrecebido.Name = "tb_vrecebido";
            this.tb_vrecebido.Size = new System.Drawing.Size(117, 22);
            this.tb_vrecebido.TabIndex = 2;
            // 
            // lb_troco
            // 
            this.lb_troco.AutoSize = true;
            this.lb_troco.Location = new System.Drawing.Point(484, 178);
            this.lb_troco.Name = "lb_troco";
            this.lb_troco.Size = new System.Drawing.Size(66, 17);
            this.lb_troco.TabIndex = 4;
            this.lb_troco.Text = "Troco: -€";
            this.lb_troco.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(452, 112);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(137, 51);
            this.btn_calc.TabIndex = 5;
            this.btn_calc.Text = "CALCULAR";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_calc_MouseClick);
            // 
            // Pb_logo
            // 
            this.Pb_logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Pb_logo.InitialImage")));
            this.Pb_logo.Location = new System.Drawing.Point(12, 12);
            this.Pb_logo.Name = "Pb_logo";
            this.Pb_logo.Size = new System.Drawing.Size(368, 185);
            this.Pb_logo.TabIndex = 6;
            this.Pb_logo.TabStop = false;
            this.Pb_logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 205);
            this.Controls.Add(this.Pb_logo);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.lb_troco);
            this.Controls.Add(this.lb_vrecebido);
            this.Controls.Add(this.tb_vrecebido);
            this.Controls.Add(this.lb_tpagar);
            this.Controls.Add(this.tb_tpagar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_tpagar;
        private System.Windows.Forms.Label lb_tpagar;
        private System.Windows.Forms.Label lb_vrecebido;
        private System.Windows.Forms.TextBox tb_vrecebido;
        private System.Windows.Forms.Label lb_troco;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.PictureBox Pb_logo;
    }
}

