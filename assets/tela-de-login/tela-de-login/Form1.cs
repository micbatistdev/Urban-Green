using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Drawing2D;
using tela_de_login.UserControls;
using tela_de_logins;

namespace tela_de_login
{
    public partial class Containner : Form
    {
        public Containner()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            // Definir o fundo translúcido
            panel2.BackColor = Color.FromArgb(30, 0, 0, 0); // Fundo translúcido (Preto com transparência)

            // Criar bordas arredondadas para o panel2
            int radius = 20; // Raio para bordas arredondadas
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, panel2.Width, panel2.Height);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Canto superior esquerdo
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90); // Canto superior direito
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90); // Canto inferior direito
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90); // Canto inferior esquerdo
            path.CloseFigure();

            panel2.Region = new Region(path); // Definir a região do painel com bordas arredondadas
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            link_email.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        private void LinkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            link_endereco.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        private void LinkLabel18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel18.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        // Botão p/ Fechar Janela
        private void Win_close_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha a janela
        }

        private void Icon_logo_Click(object sender, EventArgs e)
        {

        }

        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Botão de login
        private void Button_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (input_user.Text.Equals("admin") && input_senha.Text.Equals("1234"))
                {
                    // Ir para tela inicial da aplicação
                    TelaInicial telaInicial = new TelaInicial(); // Certifique-se de que TelaInicial é a tela que você deseja mostrar
                    this.Hide(); // Oculta a tela de login
                    telaInicial.Show(); // Mostra a tela inicial
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.",
                                    "Erro!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe!",
                                ex.Message,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                input_user.Focus(); // Coloca o foco no campo de usuário
                input_senha.Text = ""; // Limpa o campo de senha
            }
        }

        private void min_win_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void max_win_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void link_senha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
