using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_ProjetoDS_EA;

namespace ProjetoDS_EA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 telaCadastro = new Form3();
            telaCadastro.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 telaInicial = new Form1();
            telaInicial.ShowDialog();
        }

        private void LoginEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Login_DTO obj = new Login_DTO();
                obj.Usuario = textBoxUsuario.Text;
                obj.Senha = textBoxSenha.Text;
                Login_BLL.ValidarLogin(obj);
                Form1 telaInicial = new Form1();
                telaInicial.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
