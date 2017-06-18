namespace HL7
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rtbMensagem = new System.Windows.Forms.RichTextBox();
            this.txtVersao = new System.Windows.Forms.TextBox();
            this.txtTipoMensagem = new System.Windows.Forms.TextBox();
            this.txtNrSegmentos = new System.Windows.Forms.TextBox();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(543, 124);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(363, 116);
            this.listBox1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Versão da norma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tipo de mensagem";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(364, 80);
            this.button1.TabIndex = 15;
            this.button1.Text = "Carregar Mensagem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbMensagem
            // 
            this.rtbMensagem.Location = new System.Drawing.Point(176, 249);
            this.rtbMensagem.Margin = new System.Windows.Forms.Padding(4);
            this.rtbMensagem.Name = "rtbMensagem";
            this.rtbMensagem.Size = new System.Drawing.Size(729, 219);
            this.rtbMensagem.TabIndex = 14;
            this.rtbMensagem.Text = "";
            // 
            // txtVersao
            // 
            this.txtVersao.Location = new System.Drawing.Point(176, 188);
            this.txtVersao.Margin = new System.Windows.Forms.Padding(4);
            this.txtVersao.Name = "txtVersao";
            this.txtVersao.Size = new System.Drawing.Size(113, 22);
            this.txtVersao.TabIndex = 11;
            // 
            // txtTipoMensagem
            // 
            this.txtTipoMensagem.Location = new System.Drawing.Point(176, 139);
            this.txtTipoMensagem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoMensagem.Name = "txtTipoMensagem";
            this.txtTipoMensagem.Size = new System.Drawing.Size(224, 22);
            this.txtTipoMensagem.TabIndex = 12;
            // 
            // txtNrSegmentos
            // 
            this.txtNrSegmentos.Location = new System.Drawing.Point(176, 80);
            this.txtNrSegmentos.Margin = new System.Windows.Forms.Padding(4);
            this.txtNrSegmentos.Name = "txtNrSegmentos";
            this.txtNrSegmentos.Size = new System.Drawing.Size(113, 22);
            this.txtNrSegmentos.TabIndex = 13;
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(176, 25);
            this.txtCaminho.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(343, 22);
            this.txtCaminho.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mensagem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Número de Segmentos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ficheiro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 494);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbMensagem);
            this.Controls.Add(this.txtVersao);
            this.Controls.Add(this.txtTipoMensagem);
            this.Controls.Add(this.txtNrSegmentos);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbMensagem;
        private System.Windows.Forms.TextBox txtVersao;
        private System.Windows.Forms.TextBox txtTipoMensagem;
        private System.Windows.Forms.TextBox txtNrSegmentos;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

