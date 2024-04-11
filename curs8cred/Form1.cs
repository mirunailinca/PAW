using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs8cred
{
    
    public partial class Form1 : Form
    {
        bool vb;
        public Form1()
        {
            InitializeComponent();
            vb = false;
            this.ResizeRedraw = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            vb = true;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e); //base e Form
            Graphics g = e.Graphics;
            Rectangle rf = this.ClientRectangle ;//suprafata ferestrei de lucru 
            string s = "Lucru in mod grafic";
            btn.Location = new Point(rf.Right - btn.Size.Width,rf.Y); //ducem butonul in colt dreapta sus

            if (vb) { 
                g.DrawLine(Pens.Red, rf.X, rf.Y, rf.Right, rf.Bottom); //la zona de trasare grafica coltul din stanga sus al ferestrei e 0 0, colt dreapta jos are maxim maxim

                Size sz = TextRenderer.MeasureText(s,this.Font); //vrem sa gasim lungimea textului ca sa il putem pune pe mijloc 

                //g.DrawString("Lucru in mod grafic", this.Font, Brushes.Blue, rf.X+rf.Width/2, rf.Y+rf.Height/2);//fct care traseaza un text in fereastra // vreau sa traseze in mijlocul ferestei ----> textul incepedea din mijloc dar nu era centrat frumos

                g.DrawString("Lucru in mod grafic", this.Font, Brushes.Blue, rf.X + rf.Width / 2 - sz.Width/2, rf.Y + rf.Height / 2); // ---> asa il fac sa fie centrat si textul nu doar sa inceapa din mijloc
            }

        }
    }
}
