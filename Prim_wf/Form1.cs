using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prim_wf
{
    public partial class Form1 : Form
    {
        CElement obe;
        public Form1()
        {
            InitializeComponent();
            obe = new CElement();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ai primit un pup!");
            obe.Vlement = Int32.Parse(tbv.Text);
            textBox2.Text = obe.PElement.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //aici pun codul care se executa inainte de a se vizualiza fereastra 
            tbv.Text = obe.Vlement.ToString();
        }
    }
}
