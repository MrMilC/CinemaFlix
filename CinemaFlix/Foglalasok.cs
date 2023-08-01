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
    public partial class Foglalasok : Form
    {
        CinemaFlixEntities context = new CinemaFlixEntities();
        public Foglalasok()
        {
            InitializeComponent();

            btnFilmAdatok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFilmAdatok.FlatAppearance.BorderSize = 3;
            btnFilmAdatok.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFilmAdatok.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnFilmAdatok.BackColor = Color.Transparent;

            btnFoglalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFoglalas.FlatAppearance.BorderSize = 3;
            btnFoglalas.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFoglalas.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnFoglalas.BackColor = Color.Transparent;

            btnElvalaszto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnElvalaszto.FlatAppearance.MouseDownBackColor = Color.White;
            btnElvalaszto.FlatAppearance.MouseOverBackColor = Color.White;
            btnElvalaszto.BackColor = Color.White;

            btnElvalaszto2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnElvalaszto2.FlatAppearance.MouseDownBackColor = Color.White;
            btnElvalaszto2.FlatAppearance.MouseOverBackColor = Color.White;
            btnElvalaszto2.BackColor = Color.White;

            btnElvalaszto3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnElvalaszto3.FlatAppearance.MouseDownBackColor = Color.White;
            btnElvalaszto3.FlatAppearance.MouseOverBackColor = Color.White;
            btnElvalaszto3.BackColor = Color.White;

            btnMentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMentes.FlatAppearance.BorderSize = 3;
            btnMentes.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMentes.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMentes.BackColor = Color.Transparent;

            btnTorles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTorles.FlatAppearance.BorderSize = 3;
            btnTorles.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTorles.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTorles.BackColor = Color.Transparent;

            btnFrissites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFrissites.FlatAppearance.BorderSize = 3;
            btnFrissites.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFrissites.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnFrissites.BackColor = Color.Transparent;

            btnFilmAdatok.Text = "\uF142";
            btnMentes.Text = "\uE74E";
            btnTorles.Text = "\uE74D";
            btnFrissites.Text = "\uE72C";
            label1.Text = "\uE71E";
            label3.Text = "\uE71E";

            //------------------------------------------------------------------------------------------------

            context.Szemely.Load();
            context.Eloadas.Load();
            context.Film.Load();
            context.Terem.Load();
            context.Eloadastipus.Load();
            szemelyBindingSource.DataSource = context.Szemely.Local;
            eloadasBindingSource.DataSource = context.Eloadas.Local;
            filmBindingSource.DataSource = context.Film.Local;
            teremBindingSource.DataSource = context.Terem.Local;
            eloadastipusBindingSource.DataSource = context.Eloadastipus.Local;

            tbFoglalasDatuma.Text = DateTime.Now.ToString("yyyy. MM. dd. HH:mm:ss");
            
            lbSzemelyek.DisplayMember = "Nev";
            lbEloadasok.DisplayMember = "EloadasID";
        }

        private void tbSzemelyek_TextChanged(object sender, EventArgs e)
        {
            SzemelySzures();
        }


        private void SzemelySzures()
        {
            lbSzemelyek.DataSource = (from s in context.Szemely
                                      where s.Nev.Contains(tbSzemelyek.Text)
                                      select s).ToList();
        }

        private void EloadasIDSzures()
        {
            lbEloadasok.DataSource = (from e in context.Eloadas
                                      where e.EloadasID.ToString().Contains(tbEloadasok.Text)
                                      select e).ToList();
        }

        private void btnFilmAdatok_Click(object sender, EventArgs e)
        {
            FilmAdatok filmAdatok = new FilmAdatok();
            filmAdatok.Show();
        }

        private void lbSzemelyek_SelectedIndexChanged(object sender, EventArgs e)
        {
            Szemely szemely = (Szemely)lbSzemelyek.SelectedItem;

            var foglalasok = from f in context.Foglalas
                             where f.SzemelyFK == szemely.SzemelyID

                             select new
                             {
                                 f.FoglalasID,
                                 f.Eloadas.Film.Cim,
                                 f.Eloadas.Terem.TeremNev,
                                 f.Eloadas.Eloadastipus.Megnevezes,
                                 f.Eloadas.IdoSav,
                                 f.Eloadas.Datum,
                                 f.Eloadas.Nap,
                                 f.Eloadas.Szinkron,
                                 f.Eloadas.Felirat,
                                 f.FoglalasDatum,
                                 f.JegyDarab,
                                 f.FoglalasErtek,
                                 f.Kedvezmenyes
                             };

            bindingSource1.DataSource = foglalasok.ToList();
        }

        private void tbEloadasok_TextChanged(object sender, EventArgs e)
        {
            EloadasIDSzures();
        }

        private void btnFoglalas_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !String.IsNullOrWhiteSpace(cbJegydarab.Text))
            {
                Foglalas foglalas = new Foglalas();
                foglalas.SzemelyFK = ((Szemely)lbSzemelyek.SelectedItem).SzemelyID;
                foglalas.EloadasFK = ((Eloadas)lbEloadasok.SelectedItem).EloadasID;
                foglalas.JegyDarab = Convert.ToDecimal(cbJegydarab.Text);
                foglalas.Kedvezmenyes = cbKedvezmeny.Checked;
                foglalas.FoglalasErtek = Convert.ToDecimal(tbFoglalasErteke.Text);
                foglalas.FoglalasDatum = Convert.ToDateTime(DateTime.Now.ToString("yyyy. MM. dd. HH:mm:ss"));

                context.Foglalas.Add(foglalas);
                context.SaveChanges();
                SzemelySzures();
            }

            else
            {
                MessageBox.Show("El kell fogadni a feltételeket/Válasszon jegydarabot!");
            }
        }

        private void lbEloadasok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Eloadas eloadas = (Eloadas)lbEloadasok.SelectedItem;
            var Ar = (from et in context.Eloadastipus
                     where et.EloadastipusID == ((Eloadas)lbEloadasok.SelectedItem).EloadastipusFK
                     select et.Ar).FirstOrDefault();
            tbAr.Text = Ar.ToString();
        }

        private void tbAr_TextChanged(object sender, EventArgs e)
        {
            Szorzas(); 
        }

        private void Szorzas()
        {
            decimal ar, jegydb;

            if (!decimal.TryParse(tbAr.Text, out ar) || !decimal.TryParse(cbJegydarab.Text, out jegydb))
                return;

            decimal osszertek = ar * jegydb;

            if (cbKedvezmeny.Checked)
                osszertek = (ar * jegydb) - (jegydb * 500);
            else
                osszertek = ar * jegydb;

            tbFoglalasErteke.Text = osszertek.ToString();
        }

        private void btnFrissites_Click(object sender, EventArgs e)
        {
            tbFoglalasDatuma.Text = DateTime.Now.ToString("yyyy. MM. dd. HH:mm:ss");
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dataGridView1.Refresh();
        }

        private void cbKedvezmeny_CheckedChanged(object sender, EventArgs e)
        {
            Szorzas();
        }

        private void Foglalasok_Load(object sender, EventArgs e)
        {
            SzemelySzures();
            EloadasIDSzures();
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            dynamic kivalasztott = bindingSource1.Current;
            int rid = kivalasztott.FoglalasID;
            var torles = (from t in context.Foglalas
                          where rid == t.FoglalasID
                          select t).FirstOrDefault();
            context.Foglalas.Remove(torles);
            context.SaveChanges();
            SzemelySzures();
        }

        private void cbJegydarab_SelectedIndexChanged(object sender, EventArgs e)
        {
            Szorzas();
        }
    }
}
