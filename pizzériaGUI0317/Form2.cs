using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pizzériaGUI0317
{


    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var file = File.ReadAllLines("pizzak2.txt");

            string[] adatok = new string[file.Length];

            string[,] pizzaarak = new string[adatok.Length, 3];

            for (int i = 0; i < file.Length; i++)
            {
                var reszek = file[i].Split(';');

                for (int x = 0; x < reszek.Length; x++)
                {
                    pizzaarak[i, x] = reszek[x];
                }
            }

          
            Label lblMenu = new Label();
            lblMenu.Text = "MENÜVÁLASZTÉK";
            lblMenu.Size = new Size(200, 20);
            lblMenu.Location = new Point(350, 50);
            Controls.Add(lblMenu);
            /*
          foreach (string s in pizzaarak)
          {
              txbMenu.Text += s;
          }
          */

            for (int i = 0; i < pizzaarak.GetLength(0); i++)
            {
                int xloc = 30;
                int spos = 100;
                CheckBox chbP = new CheckBox();
                chbP.Location = new Point(100, spos + i * xloc);
                chbP.Size = new Size(15, 20);
                Controls.Add(chbP);

                Label lblP = new Label();
                lblP.Location = new Point(115, spos + i * xloc);
                lblP.Text = pizzaarak[i, 0];
                lblP.Size = new Size(100, 20);
                Controls.Add(lblP);

                RadioButton rdbk = new RadioButton();
                rdbk.Location = new Point(300, spos + i * xloc);
                rdbk.Size = new Size(20, 20);
                Controls.Add(rdbk);

                Label lblkAr = new Label();
                lblkAr.Location = new Point(350, spos + i * xloc);
                lblkAr.Size = new Size(100, 20);
                lblkAr.Text = $"{pizzaarak[i, 1]} \tFt";
                Controls.Add(lblkAr);

                RadioButton rdbn = new RadioButton();
                rdbn.Location = new Point(500, spos + i * xloc);
                rdbn.Size = new Size(20, 20);
                Controls.Add(rdbn);

                Label lblnAr = new Label();
                lblnAr.Location = new Point(550, spos + i * xloc);
                lblnAr.Size = new Size(100, 20);
                lblnAr.Text = $"{pizzaarak[i, 2]} \tFt";
                Controls.Add(lblnAr);

                TextBox txbDb = new TextBox();
                txbDb.Location = new Point(650, spos + i * xloc);
                txbDb.Size = new Size(40, 20);
                Controls.Add(txbDb);

                Label lblDb = new Label();
                lblDb.Location = new Point(700, spos + i * xloc);
                lblDb.Text = "darab";
                lblDb.Size = new Size(50, 20);
                Controls.Add(lblDb);
            }

    
            Button btnSzamitas = new Button();
            btnSzamitas.Location = new Point(100, 1800);
            btnSzamitas.Size = new Size(50, 50);
            btnSzamitas.Text = "Számol";
            btnSzamitas.Click += BtnSzamitas_Click;
            Controls.Add(btnSzamitas);

            Button btnTorles = new Button();
            btnSzamitas.Location = new Point(100, 1800);
            btnSzamitas.Size = new Size(50, 50);
            btnSzamitas.Text = "Számol";
            btnSzamitas.Click += BtnSzamitas_Click;
            Controls.Add(btnSzamitas);

        }


        private void BtnSzamitas_Click(object sender, EventArgs e)
        {
            
        }
    }
}
