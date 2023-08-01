using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaFlix
{
    public partial class Bejelentkezes : Form
    {
        public Bejelentkezes()
        {
            InitializeComponent();

            btnBelepes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBelepes.FlatAppearance.BorderSize = 3;
            btnBelepes.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBelepes.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBelepes.BackColor = Color.Transparent;

            btnFastLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFastLogin.FlatAppearance.BorderSize = 3;
            btnFastLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFastLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnFastLogin.BackColor = Color.Transparent;

            btnFastLogin.Text = "\uF3B1";
        }

        private void btnBelepes_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(loginEmail.Text) || String.IsNullOrWhiteSpace(loginJelszo.Text))
                MessageBox.Show("Kitöltetlen adatok!");

            else
            {
                MessageBox.Show("Köszöntjük a CFMS 0.1-es verziójában!");
                Form1 fomenu = new Form1();
                fomenu.ShowDialog();
            }
        }

        private void Bejelentkezes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztos ki szeretne lépni?", "Megerősítés", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void loginEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"(^cfmanagement@cinemaflix.hu$)");

            if (regex.IsMatch(loginEmail.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(loginEmail.Text))
                    loginEmail.BackColor = Color.LightGreen;
                else
                    loginEmail.BackColor = Color.White;
            }

            else
            {
                e.Cancel = true;
                loginEmail.BackColor = Color.MediumVioletRed;
            }
        }

        private void loginJelszo_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"(^CFlogin2020$)");

            if (regex.IsMatch(loginJelszo.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(loginJelszo.Text))
                    loginJelszo.BackColor = Color.LightGreen;
                else
                    loginJelszo.BackColor = Color.White;
            }

            else
            {
                e.Cancel = true;
                loginJelszo.BackColor = Color.MediumVioletRed;
            }
        }

        private void loginEmail_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void loginJelszo_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
            loginJelszo.PasswordChar = '*';
        }

        private void btnFastLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Köszöntjük a CFMS 0.1-es verziójában!");
            Form1 fomenu = new Form1();
            fomenu.ShowDialog();
        }
    }
}
