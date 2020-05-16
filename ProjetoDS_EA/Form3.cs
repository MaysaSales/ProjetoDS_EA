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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 telaLogin = new Form2();
            telaLogin.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 telaInicial = new Form1();
            telaInicial.ShowDialog();
        }

        private void CadastroEnviar_Click(object sender, EventArgs e)
        {
            Cadastro_DTO obj = new Cadastro_DTO();
            obj.Nome = textBoxNome.Text;
            obj.Usuario = textBoxUsuario.Text;
            obj.Email = textBoxEmail.Text;
            obj.CPF = textBoxCPF.Text;
            obj.Senha = textBoxSenha.Text;
            obj.Confirmar = textBoxConfirmar.Text;
            Cadastro_BLL.ValidarCadastro(obj);
            Form1 telaInicial = new Form1();
            telaInicial.ShowDialog();
        }
        catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }
