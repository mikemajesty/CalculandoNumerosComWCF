namespace WCF_Operacoes
{
    partial class frm_Operacoes
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
            this.btn_Subtrair = new System.Windows.Forms.Button();
            this.btn_Dividir = new System.Windows.Forms.Button();
            this.btn_Multiplicacao = new System.Windows.Forms.Button();
            this.btn_Somar = new System.Windows.Forms.Button();
            this.txt_Valor1 = new System.Windows.Forms.TextBox();
            this.txt_Valor2 = new System.Windows.Forms.TextBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.btn_Minusculo = new System.Windows.Forms.Button();
            this.btn_Maiusculo = new System.Windows.Forms.Button();
            this.txt_texto = new System.Windows.Forms.TextBox();
            this.txt_resultadoFinal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Subtrair
            // 
            this.btn_Subtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Subtrair.Location = new System.Drawing.Point(77, 96);
            this.btn_Subtrair.Name = "btn_Subtrair";
            this.btn_Subtrair.Size = new System.Drawing.Size(44, 34);
            this.btn_Subtrair.TabIndex = 4;
            this.btn_Subtrair.Text = "-";
            this.btn_Subtrair.UseVisualStyleBackColor = true;
            this.btn_Subtrair.Click += new System.EventHandler(this.btn_Subtrair_Click);
            // 
            // btn_Dividir
            // 
            this.btn_Dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dividir.Location = new System.Drawing.Point(127, 96);
            this.btn_Dividir.Name = "btn_Dividir";
            this.btn_Dividir.Size = new System.Drawing.Size(44, 34);
            this.btn_Dividir.TabIndex = 5;
            this.btn_Dividir.Text = "/";
            this.btn_Dividir.UseVisualStyleBackColor = true;
            this.btn_Dividir.Click += new System.EventHandler(this.btn_Dividir_Click);
            // 
            // btn_Multiplicacao
            // 
            this.btn_Multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Multiplicacao.Location = new System.Drawing.Point(177, 96);
            this.btn_Multiplicacao.Name = "btn_Multiplicacao";
            this.btn_Multiplicacao.Size = new System.Drawing.Size(44, 34);
            this.btn_Multiplicacao.TabIndex = 6;
            this.btn_Multiplicacao.Text = "*";
            this.btn_Multiplicacao.UseVisualStyleBackColor = true;
            this.btn_Multiplicacao.Click += new System.EventHandler(this.btn_Multiplicacao_Click);
            // 
            // btn_Somar
            // 
            this.btn_Somar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Somar.Location = new System.Drawing.Point(27, 96);
            this.btn_Somar.Name = "btn_Somar";
            this.btn_Somar.Size = new System.Drawing.Size(44, 34);
            this.btn_Somar.TabIndex = 3;
            this.btn_Somar.Text = "+";
            this.btn_Somar.UseVisualStyleBackColor = true;
            this.btn_Somar.Click += new System.EventHandler(this.btn_Somar_Click);
            // 
            // txt_Valor1
            // 
            this.txt_Valor1.Location = new System.Drawing.Point(27, 18);
            this.txt_Valor1.Name = "txt_Valor1";
            this.txt_Valor1.Size = new System.Drawing.Size(194, 20);
            this.txt_Valor1.TabIndex = 0;
            // 
            // txt_Valor2
            // 
            this.txt_Valor2.Location = new System.Drawing.Point(27, 44);
            this.txt_Valor2.Name = "txt_Valor2";
            this.txt_Valor2.Size = new System.Drawing.Size(194, 20);
            this.txt_Valor2.TabIndex = 1;
            // 
            // txt_Total
            // 
            this.txt_Total.Enabled = false;
            this.txt_Total.Location = new System.Drawing.Point(27, 70);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(194, 20);
            this.txt_Total.TabIndex = 2;
            // 
            // btn_Minusculo
            // 
            this.btn_Minusculo.Location = new System.Drawing.Point(146, 191);
            this.btn_Minusculo.Name = "btn_Minusculo";
            this.btn_Minusculo.Size = new System.Drawing.Size(75, 23);
            this.btn_Minusculo.TabIndex = 7;
            this.btn_Minusculo.Text = "Maiusculo";
            this.btn_Minusculo.UseVisualStyleBackColor = true;
            this.btn_Minusculo.Click += new System.EventHandler(this.btn_Minusculo_Click);
            // 
            // btn_Maiusculo
            // 
            this.btn_Maiusculo.Location = new System.Drawing.Point(27, 191);
            this.btn_Maiusculo.Name = "btn_Maiusculo";
            this.btn_Maiusculo.Size = new System.Drawing.Size(75, 23);
            this.btn_Maiusculo.TabIndex = 7;
            this.btn_Maiusculo.Text = "Minusculo";
            this.btn_Maiusculo.UseVisualStyleBackColor = true;
            this.btn_Maiusculo.Click += new System.EventHandler(this.btn_Maiusculo_Click);
            // 
            // txt_texto
            // 
            this.txt_texto.Location = new System.Drawing.Point(27, 137);
            this.txt_texto.Name = "txt_texto";
            this.txt_texto.Size = new System.Drawing.Size(194, 20);
            this.txt_texto.TabIndex = 8;
            // 
            // txt_resultadoFinal
            // 
            this.txt_resultadoFinal.Enabled = false;
            this.txt_resultadoFinal.Location = new System.Drawing.Point(27, 165);
            this.txt_resultadoFinal.Name = "txt_resultadoFinal";
            this.txt_resultadoFinal.Size = new System.Drawing.Size(194, 20);
            this.txt_resultadoFinal.TabIndex = 8;
            // 
            // frm_Operacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 236);
            this.Controls.Add(this.txt_resultadoFinal);
            this.Controls.Add(this.txt_texto);
            this.Controls.Add(this.btn_Maiusculo);
            this.Controls.Add(this.btn_Minusculo);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.txt_Valor2);
            this.Controls.Add(this.txt_Valor1);
            this.Controls.Add(this.btn_Multiplicacao);
            this.Controls.Add(this.btn_Dividir);
            this.Controls.Add(this.btn_Somar);
            this.Controls.Add(this.btn_Subtrair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Operacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Operacoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Subtrair;
        private System.Windows.Forms.Button btn_Dividir;
        private System.Windows.Forms.Button btn_Multiplicacao;
        private System.Windows.Forms.Button btn_Somar;
        private System.Windows.Forms.TextBox txt_Valor1;
        private System.Windows.Forms.TextBox txt_Valor2;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Button btn_Minusculo;
        private System.Windows.Forms.Button btn_Maiusculo;
        private System.Windows.Forms.TextBox txt_texto;
        private System.Windows.Forms.TextBox txt_resultadoFinal;
    }
}