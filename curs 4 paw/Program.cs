using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs_4_paw
{

    class F_mea : Form {

        Button btn; //am definit o referinta la calsa button 
        public F_mea()
        {
            this.Text = "Prima aplicatie WF"; //mi a denumit tabul

            btn = new Button();
            btn .Text = "Apasa";
            btn.Location = new System.Drawing.Point(10,10);

            btn.Click += Btn_Click;
            
            this.Controls.Add(btn);


        }

        private void Btn_Click(object sender, EventArgs e) 
            // sender este obiectul care a transmis evenimentul (aici intra btn)
            // e este bun pt ca sunt anumite evenimente care furnizeaza informatii suplimentare 
        {
            Button button = (Button)sender;
            MessageBox.Show("Bravo, frate! Ai apasat: " + button.Text);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new F_mea());


        }
    }
}
