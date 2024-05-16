namespace BatePapo
{
    partial class Form1
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
            groupBoxMensagens = new GroupBox();
            buttonEnviarMensagem = new Button();
            label4 = new Label();
            label3 = new Label();
            textBoxPorta = new TextBox();
            textBoxIP = new TextBox();
            richTextBoxMensagensParaEnviar = new RichTextBox();
            label2 = new Label();
            richTextBoxMensagens = new RichTextBox();
            textBoxMeuNome = new TextBox();
            label1 = new Label();
            groupBoxConfig = new GroupBox();
            buttonAplicarConfigServidor = new Button();
            textBoxPortaDoServidor = new TextBox();
            label5 = new Label();
            groupBoxMensagens.SuspendLayout();
            groupBoxConfig.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMensagens
            // 
            groupBoxMensagens.Controls.Add(buttonEnviarMensagem);
            groupBoxMensagens.Controls.Add(label4);
            groupBoxMensagens.Controls.Add(label3);
            groupBoxMensagens.Controls.Add(textBoxPorta);
            groupBoxMensagens.Controls.Add(textBoxIP);
            groupBoxMensagens.Controls.Add(richTextBoxMensagensParaEnviar);
            groupBoxMensagens.Controls.Add(label2);
            groupBoxMensagens.Controls.Add(richTextBoxMensagens);
            groupBoxMensagens.Controls.Add(textBoxMeuNome);
            groupBoxMensagens.Controls.Add(label1);
            groupBoxMensagens.Location = new Point(22, 12);
            groupBoxMensagens.Name = "groupBoxMensagens";
            groupBoxMensagens.Size = new Size(704, 443);
            groupBoxMensagens.TabIndex = 0;
            groupBoxMensagens.TabStop = false;
            groupBoxMensagens.Text = "Mensagens";
            // 
            // buttonEnviarMensagem
            // 
            buttonEnviarMensagem.Location = new Point(235, 383);
            buttonEnviarMensagem.Name = "buttonEnviarMensagem";
            buttonEnviarMensagem.Size = new Size(180, 41);
            buttonEnviarMensagem.TabIndex = 9;
            buttonEnviarMensagem.Text = "Enviar Mensagem";
            buttonEnviarMensagem.UseVisualStyleBackColor = true;
            buttonEnviarMensagem.Click += buttonEnviarMensagem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 323);
            label4.Name = "label4";
            label4.Size = new Size(148, 25);
            label4.TabIndex = 8;
            label4.Text = "Porta de contato:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 323);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 7;
            label3.Text = "IP de contanto:";
            // 
            // textBoxPorta
            // 
            textBoxPorta.Location = new Point(484, 323);
            textBoxPorta.Name = "textBoxPorta";
            textBoxPorta.Size = new Size(89, 31);
            textBoxPorta.TabIndex = 6;
            // 
            // textBoxIP
            // 
            textBoxIP.Location = new Point(144, 323);
            textBoxIP.Name = "textBoxIP";
            textBoxIP.Size = new Size(150, 31);
            textBoxIP.TabIndex = 5;
            // 
            // richTextBoxMensagensParaEnviar
            // 
            richTextBoxMensagensParaEnviar.Location = new Point(235, 248);
            richTextBoxMensagensParaEnviar.Name = "richTextBoxMensagensParaEnviar";
            richTextBoxMensagensParaEnviar.Size = new Size(338, 66);
            richTextBoxMensagensParaEnviar.TabIndex = 4;
            richTextBoxMensagensParaEnviar.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 251);
            label2.Name = "label2";
            label2.Size = new Size(198, 25);
            label2.TabIndex = 3;
            label2.Text = "Mensagens para enviar:";
            // 
            // richTextBoxMensagens
            // 
            richTextBoxMensagens.Enabled = false;
            richTextBoxMensagens.Location = new Point(0, 98);
            richTextBoxMensagens.Name = "richTextBoxMensagens";
            richTextBoxMensagens.Size = new Size(573, 144);
            richTextBoxMensagens.TabIndex = 2;
            richTextBoxMensagens.Text = "";
            // 
            // textBoxMeuNome
            // 
            textBoxMeuNome.Location = new Point(154, 42);
            textBoxMeuNome.Name = "textBoxMeuNome";
            textBoxMeuNome.Size = new Size(419, 31);
            textBoxMeuNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 45);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 0;
            label1.Text = "Meu nome: ";
            // 
            // groupBoxConfig
            // 
            groupBoxConfig.Controls.Add(buttonAplicarConfigServidor);
            groupBoxConfig.Controls.Add(textBoxPortaDoServidor);
            groupBoxConfig.Controls.Add(label5);
            groupBoxConfig.Location = new Point(22, 461);
            groupBoxConfig.Name = "groupBoxConfig";
            groupBoxConfig.Size = new Size(602, 150);
            groupBoxConfig.TabIndex = 1;
            groupBoxConfig.TabStop = false;
            groupBoxConfig.Text = "Configurações do servidor";
            // 
            // buttonAplicarConfigServidor
            // 
            buttonAplicarConfigServidor.Location = new Point(26, 80);
            buttonAplicarConfigServidor.Name = "buttonAplicarConfigServidor";
            buttonAplicarConfigServidor.Size = new Size(218, 44);
            buttonAplicarConfigServidor.TabIndex = 2;
            buttonAplicarConfigServidor.Text = "Aplicar configurações";
            buttonAplicarConfigServidor.UseVisualStyleBackColor = true;
            buttonAplicarConfigServidor.Click += buttonAplicarConfigServidor_Click;
            // 
            // textBoxPortaDoServidor
            // 
            textBoxPortaDoServidor.Location = new Point(174, 36);
            textBoxPortaDoServidor.Name = "textBoxPortaDoServidor";
            textBoxPortaDoServidor.Size = new Size(150, 31);
            textBoxPortaDoServidor.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 39);
            label5.Name = "label5";
            label5.Size = new Size(158, 25);
            label5.TabIndex = 0;
            label5.Text = "Porta do servidor: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 657);
            Controls.Add(groupBoxConfig);
            Controls.Add(groupBoxMensagens);
            MaximumSize = new Size(822, 713);
            MinimumSize = new Size(822, 713);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            groupBoxMensagens.ResumeLayout(false);
            groupBoxMensagens.PerformLayout();
            groupBoxConfig.ResumeLayout(false);
            groupBoxConfig.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMensagens;
        private GroupBox groupBoxConfig;
        private RichTextBox richTextBoxMensagens;
        private TextBox textBoxMeuNome;
        private Label label1;
        private RichTextBox richTextBoxMensagensParaEnviar;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox textBoxPorta;
        private TextBox textBoxIP;
        private Button buttonEnviarMensagem;
        private Button buttonAplicarConfigServidor;
        private TextBox textBoxPortaDoServidor;
        private Label label5;
    }
}
