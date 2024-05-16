using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace BatePapo
{
    public partial class Form1 : Form
    {
        TcpListener? listener;
        TcpClient? client;
        Thread? ServidorThread;
        bool podePararThreadServidor;
        public Form1()
        {
            InitializeComponent();
            listener = null;
            client = null;
            ServidorThread = null;
            podePararThreadServidor = false;

        }

        private void buttonEnviarMensagem_Click(object sender, EventArgs e)
        {
            try
            {
                //criar cliente para se conectar a algum servidor
                TcpClient tcpClient = new TcpClient(textBoxIP.Text, Convert.ToInt32(textBoxPorta.Text));
                NetworkStream ns = tcpClient.GetStream();

                //Enviando Mensagem
                string mensagem = textBoxMeuNome.Text + ": " + richTextBoxMensagensParaEnviar.Text;
                byte[] mensagemBytes = Encoding.UTF8.GetBytes(mensagem);
                ns.Write(mensagemBytes, 0, mensagemBytes.Length);

                //Fechando Conexão
                tcpClient.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAplicarConfigServidor_Click(object sender, EventArgs e)
        {
            paraServidor();


            ServidorThread = new Thread(() =>
            {
                listener = new TcpListener(IPAddress.Any, Convert.ToInt32(textBoxPortaDoServidor.Text));
                listener.Start();
                do
                {
                    try
                    {
                        client = listener.AcceptTcpClient();
                        NetworkStream ns = client.GetStream();

                        //Lendo mensagemdo client
                        byte[] bufferMensagemRecebida = new byte[256];
                        int bytesRecebidos = ns.Read(bufferMensagemRecebida, 0, bufferMensagemRecebida.Length);
                        string strMensagemRecebida = Encoding.UTF8.GetString(bufferMensagemRecebida, 0, bytesRecebidos);

                        AtualizaRichTextBox("\r\n" + strMensagemRecebida);
                    }
                    catch (SocketException ex)
                    {
                        if ((SocketError)ex.ErrorCode != SocketError.Interrupted)
                        {
                            MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } while (podePararThreadServidor == false);
            });
            ServidorThread.Start();
        }

        public void AtualizaRichTextBox(string pMensagem)
        {
            if (richTextBoxMensagens.InvokeRequired)
            {
                richTextBoxMensagens.Invoke((MethodInvoker)(() => AtualizaRichTextBox(pMensagem)));
            }
            else
            {
                richTextBoxMensagens.Text += pMensagem;
            }
        }

        public void paraServidor()
        {
            try
            {
                podePararThreadServidor = true;
                if (listener != null)
                {
                    listener.Stop();
                    listener = null;
                }
                if (client != null)
                {
                    client.Close();
                    client = null;
                }
                if (ServidorThread != null)
                {
                    ServidorThread.Join();
                }
                podePararThreadServidor = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            paraServidor();
        }
    }
}
