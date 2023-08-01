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
    public partial class FilmAdatok : Form
    {
        CinemaFlixEntities context = new CinemaFlixEntities();
        public FilmAdatok()
        {
            InitializeComponent();

            label2.Text = "\uE71E";
            context.Film.Load();
            lbFilmek.DisplayMember = "Cim";
            FilmSzures();
        }

        private void FilmSzures()
        {
            lbFilmek.DataSource = (from f in context.Film
                                   where f.Cim.Contains(tbFilmek.Text)
                                   select f).ToList();
        }

        private void tbFilmek_TextChanged(object sender, EventArgs e)
        {
            FilmSzures();
        }

        private void lbFilmek_SelectedIndexChanged(object sender, EventArgs e)
        {
            mufajTextBox.Text = ((Film)lbFilmek.SelectedItem).Mufaj;
            hossz_percbenTextBox.Text = (((Film)lbFilmek.SelectedItem).Hossz_percben).ToString();
            besorolasTextBox.Text = ((Film)lbFilmek.SelectedItem).Besorolas;
            megjelenesEveTextBox.Text = (((Film)lbFilmek.SelectedItem).MegjelenesEve).ToString();
        }
    }
}
