using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.TextLength == 0)
                MessageBox.Show("Por favor digite algo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxNome.Focus();
            {
                cmbLista.Items.Add(textBoxNome.Text);
                textBoxNome.Clear();
                textBoxNome.Focus();
                
            }
                
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(cmbLista.SelectedIndex == 0)
                MessageBox.Show("Por favor selecione um item","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Error);
            {
                cmbLista.Items.Remove(cmbLista.SelectedItem);
                cmbLista.SelectedIndex = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbLista.SelectedIndex = 0;
        }
    }
}
