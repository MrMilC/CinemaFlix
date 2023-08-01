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
    public partial class Regisztracio : Form
    {
        public Regisztracio()
        {
            InitializeComponent();

            btnVeglegesites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVeglegesites.FlatAppearance.BorderSize = 3;
            btnVeglegesites.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnVeglegesites.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnVeglegesites.BackColor = Color.Transparent;

            btnMegse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMegse.FlatAppearance.BorderSize = 3;
            btnMegse.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMegse.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMegse.BackColor = Color.Transparent;

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"(^$)|(^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$)");

            if (regex.IsMatch(emailTextBox.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(emailTextBox.Text))
                    emailTextBox.BackColor = Color.LightGreen;
                else
                    emailTextBox.BackColor = Color.White;
            }

            else
            {
                e.Cancel = true;
                emailTextBox.BackColor = Color.MediumVioletRed;
            }
        }

        private void tbemail2_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(emailTextBox.Text);

            if (regex.IsMatch(tbemail2.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(tbemail2.Text))
                    tbemail2.BackColor = Color.LightGreen;
                else
                    tbemail2.BackColor = Color.White;
            }

            else
            {
                e.Cancel = true;
                tbemail2.BackColor = Color.MediumVioletRed;
            }
        }

        private void tbjelszo_Validating(object sender, CancelEventArgs e)
        {
            tbjelszo.PasswordChar = '*';

            e.Cancel = false;

            if (!String.IsNullOrWhiteSpace(tbjelszo.Text))
                tbjelszo.BackColor = Color.LightGreen;
            else
                tbjelszo.BackColor = Color.White;
        }

        private void tbjelszo2_Validating(object sender, CancelEventArgs e)
        {
            tbjelszo2.PasswordChar = '*';

            Regex regex = new Regex(tbjelszo.Text);

            if (regex.IsMatch(tbjelszo2.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(tbjelszo2.Text))
                    tbjelszo2.BackColor = Color.LightGreen;
                else
                    tbjelszo2.BackColor = Color.White;
            }

            else
            {
                e.Cancel = true;
                tbjelszo2.BackColor = Color.MediumVioletRed;
            }
        }

        private void nevTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"[A-ZÖÜÓŐÚÉÁŰ]{1}[a-zöüóőúéáű]{1,}[ ]{1}[A-ZÖÜÓŐÚÉÁŰ]{1}[a-zöüóőúéáű]{1,}");

            if (regex.IsMatch(nevTextBox.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(nevTextBox.Text))
                    nevTextBox.BackColor = Color.LightGreen;
                else
                    nevTextBox.BackColor = Color.White;
            }

            else
            {
                e.Cancel = true;
                nevTextBox.BackColor = Color.MediumVioletRed;
            }
        }

        private void telefonszamTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^(20|30|70)[0-9]{3}?[0-9]{4}?$");

            if (regex.IsMatch(telefonszamTextBox.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(telefonszamTextBox.Text))
                    telefonszamTextBox.BackColor = Color.LightGreen;
                else
                    telefonszamTextBox.BackColor = Color.White;
            }

            else
            {
                e.Cancel = true;
                telefonszamTextBox.BackColor = Color.MediumVioletRed;
            }
        }
    }
}
