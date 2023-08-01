namespace CinemaFlix
{
    partial class Regisztracio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label jelszo;
            System.Windows.Forms.Label jelszo2;
            System.Windows.Forms.Label email2;
            System.Windows.Forms.Label telefonszamLabel;
            System.Windows.Forms.Label nevLabel;
            System.Windows.Forms.Label emailLabel;
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnMegse = new System.Windows.Forms.Button();
            this.btnVeglegesites = new System.Windows.Forms.Button();
            this.tbemail2 = new System.Windows.Forms.TextBox();
            this.tbjelszo = new System.Windows.Forms.TextBox();
            this.tbjelszo2 = new System.Windows.Forms.TextBox();
            this.telefonszamTextBox = new System.Windows.Forms.TextBox();
            this.szemelyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nevTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            jelszo = new System.Windows.Forms.Label();
            jelszo2 = new System.Windows.Forms.Label();
            email2 = new System.Windows.Forms.Label();
            telefonszamLabel = new System.Windows.Forms.Label();
            nevLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.szemelyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // jelszo
            // 
            jelszo.AutoSize = true;
            jelszo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            jelszo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            jelszo.Location = new System.Drawing.Point(38, 207);
            jelszo.Name = "jelszo";
            jelszo.Size = new System.Drawing.Size(60, 24);
            jelszo.TabIndex = 7;
            jelszo.Text = "Jelszó:";
            // 
            // jelszo2
            // 
            jelszo2.AutoSize = true;
            jelszo2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            jelszo2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            jelszo2.Location = new System.Drawing.Point(284, 207);
            jelszo2.Name = "jelszo2";
            jelszo2.Size = new System.Drawing.Size(105, 24);
            jelszo2.TabIndex = 8;
            jelszo2.Text = "Jelszó ismét:";
            // 
            // email2
            // 
            email2.AutoSize = true;
            email2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            email2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            email2.Location = new System.Drawing.Point(283, 120);
            email2.Name = "email2";
            email2.Size = new System.Drawing.Size(101, 24);
            email2.TabIndex = 34;
            email2.Text = "Email ismét:";
            // 
            // telefonszamLabel
            // 
            telefonszamLabel.AutoSize = true;
            telefonszamLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            telefonszamLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            telefonszamLabel.Location = new System.Drawing.Point(282, 32);
            telefonszamLabel.Name = "telefonszamLabel";
            telefonszamLabel.Size = new System.Drawing.Size(109, 24);
            telefonszamLabel.TabIndex = 5;
            telefonszamLabel.Text = "Telefonszám:";
            // 
            // nevLabel
            // 
            nevLabel.AutoSize = true;
            nevLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            nevLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nevLabel.Location = new System.Drawing.Point(36, 32);
            nevLabel.Name = "nevLabel";
            nevLabel.Size = new System.Drawing.Size(45, 24);
            nevLabel.TabIndex = 1;
            nevLabel.Text = "Név:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            emailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            emailLabel.Location = new System.Drawing.Point(38, 120);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(56, 24);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(42, 311);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(340, 21);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "*Elolvastam és elfogadom a CinemaFlix feltételeit.";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Validated += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // btnMegse
            // 
            this.btnMegse.CausesValidation = false;
            this.btnMegse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMegse.Font = new System.Drawing.Font("Arial Narrow", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMegse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMegse.Location = new System.Drawing.Point(287, 387);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(150, 75);
            this.btnMegse.TabIndex = 33;
            this.btnMegse.Text = "Mégse";
            this.btnMegse.UseVisualStyleBackColor = true;
            // 
            // btnVeglegesites
            // 
            this.btnVeglegesites.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnVeglegesites.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVeglegesites.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVeglegesites.Location = new System.Drawing.Point(90, 387);
            this.btnVeglegesites.Name = "btnVeglegesites";
            this.btnVeglegesites.Size = new System.Drawing.Size(150, 75);
            this.btnVeglegesites.TabIndex = 32;
            this.btnVeglegesites.Text = "Véglegesítés";
            this.btnVeglegesites.UseVisualStyleBackColor = true;
            // 
            // tbemail2
            // 
            this.tbemail2.Location = new System.Drawing.Point(288, 147);
            this.tbemail2.Name = "tbemail2";
            this.tbemail2.Size = new System.Drawing.Size(200, 22);
            this.tbemail2.TabIndex = 35;
            this.tbemail2.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            this.tbemail2.Validating += new System.ComponentModel.CancelEventHandler(this.tbemail2_Validating);
            // 
            // tbjelszo
            // 
            this.tbjelszo.Location = new System.Drawing.Point(42, 234);
            this.tbjelszo.Name = "tbjelszo";
            this.tbjelszo.Size = new System.Drawing.Size(200, 22);
            this.tbjelszo.TabIndex = 36;
            this.tbjelszo.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            this.tbjelszo.Validating += new System.ComponentModel.CancelEventHandler(this.tbjelszo_Validating);
            // 
            // tbjelszo2
            // 
            this.tbjelszo2.Location = new System.Drawing.Point(287, 234);
            this.tbjelszo2.Name = "tbjelszo2";
            this.tbjelszo2.Size = new System.Drawing.Size(200, 22);
            this.tbjelszo2.TabIndex = 37;
            this.tbjelszo2.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            this.tbjelszo2.Validating += new System.ComponentModel.CancelEventHandler(this.tbjelszo2_Validating);
            // 
            // telefonszamTextBox
            // 
            this.telefonszamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.szemelyBindingSource, "Telefonszam", true));
            this.telefonszamTextBox.Location = new System.Drawing.Point(287, 59);
            this.telefonszamTextBox.Name = "telefonszamTextBox";
            this.telefonszamTextBox.Size = new System.Drawing.Size(198, 22);
            this.telefonszamTextBox.TabIndex = 6;
            this.telefonszamTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            this.telefonszamTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.telefonszamTextBox_Validating);
            // 
            // szemelyBindingSource
            // 
            this.szemelyBindingSource.DataSource = typeof(CinemaFlix.Szemely);
            // 
            // nevTextBox
            // 
            this.nevTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.szemelyBindingSource, "Nev", true));
            this.nevTextBox.Location = new System.Drawing.Point(40, 59);
            this.nevTextBox.Name = "nevTextBox";
            this.nevTextBox.Size = new System.Drawing.Size(200, 22);
            this.nevTextBox.TabIndex = 2;
            this.nevTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            this.nevTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nevTextBox_Validating);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.szemelyBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(42, 147);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 22);
            this.emailTextBox.TabIndex = 4;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            this.emailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailTextBox_Validating);
            // 
            // Regisztracio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(534, 498);
            this.Controls.Add(this.tbjelszo2);
            this.Controls.Add(this.tbjelszo);
            this.Controls.Add(this.tbemail2);
            this.Controls.Add(email2);
            this.Controls.Add(this.btnMegse);
            this.Controls.Add(this.btnVeglegesites);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(jelszo2);
            this.Controls.Add(jelszo);
            this.Controls.Add(telefonszamLabel);
            this.Controls.Add(this.telefonszamTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(nevLabel);
            this.Controls.Add(this.nevTextBox);
            this.Name = "Regisztracio";
            this.Text = "Regisztracio";
            ((System.ComponentModel.ISupportInitialize)(this.szemelyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource szemelyBindingSource;
        private System.Windows.Forms.Button btnMegse;
        private System.Windows.Forms.Button btnVeglegesites;
        public System.Windows.Forms.TextBox tbemail2;
        public System.Windows.Forms.TextBox tbjelszo;
        public System.Windows.Forms.TextBox tbjelszo2;
        public System.Windows.Forms.TextBox telefonszamTextBox;
        public System.Windows.Forms.TextBox nevTextBox;
        public System.Windows.Forms.TextBox emailTextBox;
        public System.Windows.Forms.CheckBox checkBox1;
    }
}