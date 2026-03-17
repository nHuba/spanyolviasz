using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pizzériaGUI0317
{
    public partial class Pizzéria : Form
    {
        public Pizzéria()
        {
            InitializeComponent();
        }

        private void Pizzéria_Load(object sender, EventArgs e)
        {
            btnAdatb.Click += btnAdatb_click;
        }

        private void btnAdatb_click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
            this.Close();
        }

    }

}
