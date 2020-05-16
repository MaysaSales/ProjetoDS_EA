using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoDS_EA;

namespace UI_ProjetoDS_EA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 telaLogin = new Form2();
            telaLogin.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 telaCadastro = new Form3();
            telaCadastro.ShowDialog();
        }
    }
}
