using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaFlix
{
    public partial class Szemelyek : Form
    {
        CinemaFlixEntities context = new CinemaFlixEntities();
        public Szemelyek()
        {
            InitializeComponent();

            context.Szemely.Load();
            szemelyBindingSource.DataSource = context.Szemely.Local;

            btnRegisztracio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegisztracio.FlatAppearance.BorderSize = 3;
            btnRegisztracio.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRegisztracio.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRegisztracio.BackColor = Color.Transparent;
            btnRegisztracio.Text = "\uE77B";

            btnMentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMentes.FlatAppearance.BorderSize = 3;
            btnMentes.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMentes.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMentes.BackColor = Color.Transparent;
            btnMentes.Text = "\uE74E";

            btnCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCSV.FlatAppearance.BorderSize = 3;
            btnCSV.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCSV.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCSV.BackColor = Color.Transparent;
            btnCSV.Text = "\uE70B";


        }

        private void btnRegisztracio_Click(object sender, EventArgs e)
        {
            Regisztracio reg = new Regisztracio();
            DialogResult result = reg.ShowDialog();

            if (result == DialogResult.OK && reg.checkBox1.Checked)
            {
                Szemely szemely = new Szemely();

                szemely.Nev = reg.nevTextBox.Text;
                szemely.Telefonszam = Convert.ToDecimal(reg.telefonszamTextBox.Text);
                szemely.Email = reg.emailTextBox.Text;

                szemelyBindingSource.Add(szemely);
                context.SaveChanges();
            }

            else
                MessageBox.Show("El kell fogadni a feltételeket/Kitöltetlen adatok!");
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            szemelyBindingSource.EndEdit();

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            szemelyDataGridView.Refresh();
        }

        private void btnCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                foreach (var s in context.Szemely)
                {
                    sw.Write(s.SzemelyID);
                    sw.Write(" - ");
                    sw.Write(s.Nev);
                    sw.Write(" - ");
                    sw.Write(s.Email);
                    sw.Write(" - ");
                    sw.Write("06"+s.Telefonszam);
                    sw.WriteLine();
                }
            }
        }
    }
}
