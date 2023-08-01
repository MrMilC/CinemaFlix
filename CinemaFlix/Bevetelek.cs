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
    public partial class Bevetelek : Form
    {
        CinemaFlixEntities context = new CinemaFlixEntities();
        public Bevetelek()
        {
            InitializeComponent();

            label2.Text = "\uE71E";

            var osszbevetel = (from f in context.Foglalas
                               select f.FoglalasErtek).Sum();
            lOsszbevetel.Text = $"Összbevétel: {osszbevetel} Ft";

            var foglalasokszama = (from f in context.Foglalas
                                   select f.FoglalasErtek).Count();
            lFoglalasokSzama.Text = $"Foglalások száma: {foglalasokszama}";

            var atlagbevetel = (from f in context.Foglalas
                                select f.FoglalasErtek).Average();
            lAtlagosbevetel.Text = $"Átlagos bevétel: {Math.Round(Convert.ToDecimal(atlagbevetel), 2)} Ft";
        }

        private void MoziSzures()
        {
            lbMozik.DataSource = (from m in context.Mozi
                                  where m.MoziNev.Contains(tbMozik.Text)
                                  select m).ToList();
            lbMozik.DisplayMember = "MoziNev";
        }

        private void Bevetelek_Load(object sender, EventArgs e)
        {
            MoziSzures();
        }

        private void tbMozik_TextChanged(object sender, EventArgs e)
        {
            MoziSzures();
        }

        private void lbMozik_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mozi mozi = (Mozi)lbMozik.SelectedItem;

            var mozifoglalasok = from f in context.Foglalas
                                 where (f.EloadasFK==f.Eloadas.EloadasID
                                 && f.Eloadas.TeremFK==f.Eloadas.Terem.TeremID 
                                 && f.Eloadas.Terem.MoziFK==mozi.MoziID)

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

            bindingSource1.DataSource = mozifoglalasok.ToList();

            var foglalasokErteke = from m in mozifoglalasok
                                   group m by new { m.TeremNev } into g
                                   select new FoglalasokErteke()
                                   {
                                       Teremnev = g.Key.TeremNev,
                                       FErteke = (from m in g select m.FoglalasErtek).Sum()
                                   };

            foglalasokErtekeBindingSource.DataSource = foglalasokErteke.ToList();
            chart1.DataBind();

            var mozibevetel = (from f in context.Foglalas
                               where (f.EloadasFK == f.Eloadas.EloadasID
                               && f.Eloadas.TeremFK == f.Eloadas.Terem.TeremID
                               && f.Eloadas.Terem.MoziFK == mozi.MoziID)
                               select f.FoglalasErtek).Sum();
            lMozibevetele.Text = $"Mozi bevétele: {mozibevetel} Ft";

            var atlagmozibevetel = (from f in context.Foglalas
                                    where (f.EloadasFK == f.Eloadas.EloadasID
                                    && f.Eloadas.TeremFK == f.Eloadas.Terem.TeremID
                                    && f.Eloadas.Terem.MoziFK == mozi.MoziID)
                                    select f.FoglalasErtek).Average();
            lMoziAtlagbevetele.Text = $"Mozi átlagos bevétele: {Math.Round(Convert.ToDecimal(atlagmozibevetel), 2)} Ft";

            var foglalasokszama = (from f in context.Foglalas
                                   where (f.EloadasFK == f.Eloadas.EloadasID
                                   && f.Eloadas.TeremFK == f.Eloadas.Terem.TeremID
                                   && f.Eloadas.Terem.MoziFK == mozi.MoziID)
                                   select f.FoglalasErtek).Count();
            lMozifoglalasokSzama.Text= $"Mozifoglalások száma: {foglalasokszama}";
        }
    }
}
