namespace CinemaFlix
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBevetelek = new System.Windows.Forms.Button();
            this.btnSzemely = new System.Windows.Forms.Button();
            this.btnFoglalas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(876, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Copyright © 2020 CinemaFlix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(957, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "CinemaFlix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 25.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(546, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 52);
            this.label1.TabIndex = 14;
            this.label1.Text = "- FŐMENÜ -";
            // 
            // btnBevetelek
            // 
            this.btnBevetelek.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBevetelek.Location = new System.Drawing.Point(539, 387);
            this.btnBevetelek.Name = "btnBevetelek";
            this.btnBevetelek.Size = new System.Drawing.Size(240, 100);
            this.btnBevetelek.TabIndex = 13;
            this.btnBevetelek.Text = "Bevételek";
            this.btnBevetelek.UseVisualStyleBackColor = true;
            this.btnBevetelek.Click += new System.EventHandler(this.btnBevetelek_Click);
            // 
            // btnSzemely
            // 
            this.btnSzemely.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzemely.Location = new System.Drawing.Point(413, 281);
            this.btnSzemely.Name = "btnSzemely";
            this.btnSzemely.Size = new System.Drawing.Size(240, 100);
            this.btnSzemely.TabIndex = 12;
            this.btnSzemely.Text = "Személyek / Regisztráció";
            this.btnSzemely.UseVisualStyleBackColor = true;
            this.btnSzemely.Click += new System.EventHandler(this.btnSzemely_Click);
            // 
            // btnFoglalas
            // 
            this.btnFoglalas.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFoglalas.Location = new System.Drawing.Point(659, 281);
            this.btnFoglalas.Name = "btnFoglalas";
            this.btnFoglalas.Size = new System.Drawing.Size(240, 100);
            this.btnFoglalas.TabIndex = 10;
            this.btnFoglalas.Text = "Foglalások";
            this.btnFoglalas.UseVisualStyleBackColor = true;
            this.btnFoglalas.Click += new System.EventHandler(this.btnFoglalas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1332, 804);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBevetelek);
            this.Controls.Add(this.btnSzemely);
            this.Controls.Add(this.btnFoglalas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBevetelek;
        private System.Windows.Forms.Button btnSzemely;
        private System.Windows.Forms.Button btnFoglalas;
    }
}

