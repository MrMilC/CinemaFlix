using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaFlix
{
    public partial class Form1 : Form
    {
        CinemaFlixEntities context = new CinemaFlixEntities();
        public Form1()
        {
            InitializeComponent();

            //Átlátszó "Foglalás" gomb
            btnFoglalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFoglalas.FlatAppearance.BorderSize = 3;
            btnFoglalas.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFoglalas.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnFoglalas.BackColor = Color.Transparent;

            //Átlátszó "Személy" gomb
            btnSzemely.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSzemely.FlatAppearance.BorderSize = 3;
            btnSzemely.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSzemely.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSzemely.BackColor = Color.Transparent;

            //Átlátszó "Bevételek" gomb
            btnBevetelek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBevetelek.FlatAppearance.BorderSize = 3;
            btnBevetelek.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBevetelek.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBevetelek.BackColor = Color.Transparent;

            label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label1.BackColor = Color.Transparent;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label2.BackColor = Color.Transparent;
            label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label3.BackColor = Color.Transparent;
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            Filmek filmek = new Filmek();
            filmek.ShowDialog();
        }

        private void btnEloadas_Click(object sender, EventArgs e)
        {
            Eloadasok eloadasok = new Eloadasok();
            eloadasok.ShowDialog();
        }

        private void btnFoglalas_Click(object sender, EventArgs e)
        {
            Foglalasok foglalasok = new Foglalasok();
            foglalasok.ShowDialog();
        }

        private void btnSzemely_Click(object sender, EventArgs e)
        {
            Szemelyek szemelyek = new Szemelyek();
            szemelyek.ShowDialog();
        }

        private void btnBevetelek_Click(object sender, EventArgs e)
        {
            Bevetelek bevetelek = new Bevetelek();
            bevetelek.ShowDialog();
        }
    }
}
