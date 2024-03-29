﻿using ClassLibrary3.Modele.Ludzie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dziekanat
{
    public partial class MenuPracownik : Form
    {
        public PersonModel p { get; set; }
        public MenuPracownik(PersonModel model)
        {
            p = model;
            InitializeComponent();
        }

        private void DodajOcLabel_Click(object sender, EventArgs e)
        {

            (new WstawOceny(p)).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Plan(p)).Show();
        }

        private void WylogujLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            (new Logowanie()).Show();
        }

        private void ZmienOcLabel_Click(object sender, EventArgs e)
        {
            ZmienOceny zo = new ZmienOceny();
            zo.Show();

        }
    }
}
