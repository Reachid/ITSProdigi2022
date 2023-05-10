using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.IO;

namespace LabirintoWinForm
{
    public partial class Form1 : Form
    {
        private Point puntoPrecedente = new Point(0, 0); 
        public Form1()
        {
            InitializeComponent();
            Bitmap nuova = new Bitmap(1000, 1000);
            pcbLabirinto.Image = nuova; 
            Graphics pennello = Graphics.FromImage(pcbLabirinto.Image);
            pennello.Clear(Color.White);
        }

        private void pcbLabirinto_MouseMove(object sender, MouseEventArgs e)
        {

            Point attuale = new Point(e.X, e.Y); 
            lstSoluzioni.Items.Clear();
            lstSoluzioni.Items.Add($"{e.Location}\t{e.Button}");
            if (e.Button == MouseButtons.Left )
            {
                
                
                //Bitmap attuale = (Bitmap)pcbLabirinto.Image;
                Graphics pennello = Graphics.FromImage(pcbLabirinto.Image);
                Pen tratto = new Pen(Color.Black, 10);
                pennello.DrawLine(tratto, attuale, puntoPrecedente); 
                //attuale.SetPixel(e.X, e.Y, Color.Black); 
                pcbLabirinto.Invalidate();
            }
            puntoPrecedente = attuale; 
        }

        private void aPriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = digApri.ShowDialog();
            if(dr == DialogResult.OK)
            {
                pcbLabirinto.Image = Bitmap.FromFile(digApri.FileName); 
                
            }
        }

        private void menuEsci_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Sei sicuro di voler uscire?", "Conferma", MessageBoxButtons.OK); 
            if(dr == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        private void menuSalva_Click(object sender, EventArgs e)
        {
            DialogResult dr = digSalva.ShowDialog();
            if(dr == DialogResult.OK)
            {
                Bitmap salva = (Bitmap)pcbLabirinto.Image.Clone();
                pcbLabirinto.Image = null;
                pcbLabirinto.Invalidate();
                salva.Save(digSalva.FileName, ImageFormat.Jpeg);
                

                //salva.Save(digSalva.FileName, ImageFormat.Jpeg);
                
                
            }
        }

        

        private void btnRisolvi_Click(object sender, EventArgs e)
        {

        }
    }
}
