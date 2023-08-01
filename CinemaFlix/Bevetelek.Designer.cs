namespace CinemaFlix
{
    partial class Bevetelek
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lOsszbevetel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMozik = new System.Windows.Forms.TextBox();
            this.lbMozik = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FoglalasID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeremNev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Megnevezes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdoSav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Szinkron = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Felirat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoglalasDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JegyDarab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoglalasErtek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kedvezmenyes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.foglalasokErtekeDataGridView = new System.Windows.Forms.DataGridView();
            this.lMozibevetele = new System.Windows.Forms.Label();
            this.lMozifoglalasokSzama = new System.Windows.Forms.Label();
            this.lMoziAtlagbevetele = new System.Windows.Forms.Label();
            this.lFoglalasokSzama = new System.Windows.Forms.Label();
            this.lAtlagosbevetel = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foglalasokErtekeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foglalasokErtekeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foglalasokErtekeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lOsszbevetel
            // 
            this.lOsszbevetel.AutoSize = true;
            this.lOsszbevetel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lOsszbevetel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lOsszbevetel.Location = new System.Drawing.Point(325, 636);
            this.lOsszbevetel.Name = "lOsszbevetel";
            this.lOsszbevetel.Size = new System.Drawing.Size(126, 24);
            this.lOsszbevetel.TabIndex = 22;
            this.lOsszbevetel.Text = "Összbevétel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mozik";
            // 
            // tbMozik
            // 
            this.tbMozik.Location = new System.Drawing.Point(23, 50);
            this.tbMozik.Name = "tbMozik";
            this.tbMozik.Size = new System.Drawing.Size(160, 22);
            this.tbMozik.TabIndex = 24;
            this.tbMozik.TextChanged += new System.EventHandler(this.tbMozik_TextChanged);
            // 
            // lbMozik
            // 
            this.lbMozik.FormattingEnabled = true;
            this.lbMozik.ItemHeight = 16;
            this.lbMozik.Location = new System.Drawing.Point(23, 78);
            this.lbMozik.Name = "lbMozik";
            this.lbMozik.Size = new System.Drawing.Size(160, 100);
            this.lbMozik.TabIndex = 25;
            this.lbMozik.SelectedIndexChanged += new System.EventHandler(this.lbMozik_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(189, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoglalasID,
            this.Cim,
            this.TeremNev,
            this.Megnevezes,
            this.IdoSav,
            this.Datum,
            this.Nap,
            this.Szinkron,
            this.Felirat,
            this.FoglalasDatum,
            this.JegyDarab,
            this.FoglalasErtek,
            this.Kedvezmenyes});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(23, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(651, 191);
            this.dataGridView1.TabIndex = 34;
            // 
            // FoglalasID
            // 
            this.FoglalasID.DataPropertyName = "FoglalasID";
            this.FoglalasID.HeaderText = "FoglalasID";
            this.FoglalasID.MinimumWidth = 6;
            this.FoglalasID.Name = "FoglalasID";
            this.FoglalasID.Width = 125;
            // 
            // Cim
            // 
            this.Cim.DataPropertyName = "Cim";
            this.Cim.HeaderText = "Film címe";
            this.Cim.MinimumWidth = 6;
            this.Cim.Name = "Cim";
            this.Cim.Width = 125;
            // 
            // TeremNev
            // 
            this.TeremNev.DataPropertyName = "TeremNev";
            this.TeremNev.HeaderText = "Terem";
            this.TeremNev.MinimumWidth = 6;
            this.TeremNev.Name = "TeremNev";
            this.TeremNev.Width = 125;
            // 
            // Megnevezes
            // 
            this.Megnevezes.DataPropertyName = "Megnevezes";
            this.Megnevezes.HeaderText = "Előadástípus";
            this.Megnevezes.MinimumWidth = 6;
            this.Megnevezes.Name = "Megnevezes";
            this.Megnevezes.Width = 125;
            // 
            // IdoSav
            // 
            this.IdoSav.DataPropertyName = "IdoSav";
            this.IdoSav.HeaderText = "Idősáv";
            this.IdoSav.MinimumWidth = 6;
            this.IdoSav.Name = "IdoSav";
            this.IdoSav.Width = 125;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Dátum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.Width = 125;
            // 
            // Nap
            // 
            this.Nap.DataPropertyName = "Nap";
            this.Nap.HeaderText = "Nap";
            this.Nap.MinimumWidth = 6;
            this.Nap.Name = "Nap";
            this.Nap.Width = 125;
            // 
            // Szinkron
            // 
            this.Szinkron.DataPropertyName = "Szinkron";
            this.Szinkron.HeaderText = "Szinkron";
            this.Szinkron.MinimumWidth = 6;
            this.Szinkron.Name = "Szinkron";
            this.Szinkron.Width = 125;
            // 
            // Felirat
            // 
            this.Felirat.DataPropertyName = "Felirat";
            this.Felirat.HeaderText = "Felirat";
            this.Felirat.MinimumWidth = 6;
            this.Felirat.Name = "Felirat";
            this.Felirat.Width = 125;
            // 
            // FoglalasDatum
            // 
            this.FoglalasDatum.DataPropertyName = "FoglalasDatum";
            this.FoglalasDatum.HeaderText = "Foglalás dátuma";
            this.FoglalasDatum.MinimumWidth = 6;
            this.FoglalasDatum.Name = "FoglalasDatum";
            this.FoglalasDatum.Width = 125;
            // 
            // JegyDarab
            // 
            this.JegyDarab.DataPropertyName = "JegyDarab";
            this.JegyDarab.HeaderText = "Jegyek száma";
            this.JegyDarab.MinimumWidth = 6;
            this.JegyDarab.Name = "JegyDarab";
            this.JegyDarab.Width = 125;
            // 
            // FoglalasErtek
            // 
            this.FoglalasErtek.DataPropertyName = "FoglalasErtek";
            this.FoglalasErtek.HeaderText = "Foglalás összértéke";
            this.FoglalasErtek.MinimumWidth = 6;
            this.FoglalasErtek.Name = "FoglalasErtek";
            this.FoglalasErtek.Width = 125;
            // 
            // Kedvezmenyes
            // 
            this.Kedvezmenyes.DataPropertyName = "Kedvezmenyes";
            this.Kedvezmenyes.HeaderText = "Kedvezmény";
            this.Kedvezmenyes.MinimumWidth = 6;
            this.Kedvezmenyes.Name = "Kedvezmenyes";
            this.Kedvezmenyes.Width = 125;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.foglalasokErtekeBindingSource;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(680, 184);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueMember = "Teremnev";
            series2.YValueMembers = "FErteke";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(472, 389);
            this.chart1.TabIndex = 35;
            this.chart1.Text = "chart1";
            // 
            // foglalasokErtekeDataGridView
            // 
            this.foglalasokErtekeDataGridView.AutoGenerateColumns = false;
            this.foglalasokErtekeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foglalasokErtekeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.foglalasokErtekeDataGridView.DataSource = this.foglalasokErtekeBindingSource;
            this.foglalasokErtekeDataGridView.Location = new System.Drawing.Point(23, 381);
            this.foglalasokErtekeDataGridView.Name = "foglalasokErtekeDataGridView";
            this.foglalasokErtekeDataGridView.RowHeadersWidth = 51;
            this.foglalasokErtekeDataGridView.RowTemplate.Height = 24;
            this.foglalasokErtekeDataGridView.Size = new System.Drawing.Size(651, 192);
            this.foglalasokErtekeDataGridView.TabIndex = 35;
            // 
            // lMozibevetele
            // 
            this.lMozibevetele.AutoSize = true;
            this.lMozibevetele.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lMozibevetele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lMozibevetele.Location = new System.Drawing.Point(325, 120);
            this.lMozibevetele.Name = "lMozibevetele";
            this.lMozibevetele.Size = new System.Drawing.Size(139, 24);
            this.lMozibevetele.TabIndex = 36;
            this.lMozibevetele.Text = "Mozi bevétele";
            // 
            // lMozifoglalasokSzama
            // 
            this.lMozifoglalasokSzama.AutoSize = true;
            this.lMozifoglalasokSzama.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lMozifoglalasokSzama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lMozifoglalasokSzama.Location = new System.Drawing.Point(325, 78);
            this.lMozifoglalasokSzama.Name = "lMozifoglalasokSzama";
            this.lMozifoglalasokSzama.Size = new System.Drawing.Size(217, 24);
            this.lMozifoglalasokSzama.TabIndex = 37;
            this.lMozifoglalasokSzama.Text = "Mozifoglalások száma";
            // 
            // lMoziAtlagbevetele
            // 
            this.lMoziAtlagbevetele.AutoSize = true;
            this.lMoziAtlagbevetele.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lMoziAtlagbevetele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lMoziAtlagbevetele.Location = new System.Drawing.Point(676, 120);
            this.lMoziAtlagbevetele.Name = "lMoziAtlagbevetele";
            this.lMoziAtlagbevetele.Size = new System.Drawing.Size(185, 24);
            this.lMoziAtlagbevetele.TabIndex = 39;
            this.lMoziAtlagbevetele.Text = "Mozi átlagbevétele";
            // 
            // lFoglalasokSzama
            // 
            this.lFoglalasokSzama.AutoSize = true;
            this.lFoglalasokSzama.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lFoglalasokSzama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lFoglalasokSzama.Location = new System.Drawing.Point(325, 594);
            this.lFoglalasokSzama.Name = "lFoglalasokSzama";
            this.lFoglalasokSzama.Size = new System.Drawing.Size(178, 24);
            this.lFoglalasokSzama.TabIndex = 40;
            this.lFoglalasokSzama.Text = "Foglalások száma";
            // 
            // lAtlagosbevetel
            // 
            this.lAtlagosbevetel.AutoSize = true;
            this.lAtlagosbevetel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lAtlagosbevetel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lAtlagosbevetel.Location = new System.Drawing.Point(676, 636);
            this.lAtlagosbevetel.Name = "lAtlagosbevetel";
            this.lAtlagosbevetel.Size = new System.Drawing.Size(156, 24);
            this.lAtlagosbevetel.TabIndex = 41;
            this.lAtlagosbevetel.Text = "Átlagos bevétel";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Teremnev";
            this.dataGridViewTextBoxColumn1.HeaderText = "Teremnev";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FErteke";
            this.dataGridViewTextBoxColumn2.HeaderText = "FErteke";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // foglalasokErtekeBindingSource
            // 
            this.foglalasokErtekeBindingSource.DataSource = typeof(CinemaFlix.FoglalasokErteke);
            // 
            // Bevetelek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.lAtlagosbevetel);
            this.Controls.Add(this.lFoglalasokSzama);
            this.Controls.Add(this.lMoziAtlagbevetele);
            this.Controls.Add(this.lMozifoglalasokSzama);
            this.Controls.Add(this.lMozibevetele);
            this.Controls.Add(this.foglalasokErtekeDataGridView);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMozik);
            this.Controls.Add(this.tbMozik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lOsszbevetel);
            this.Name = "Bevetelek";
            this.Text = "Bevetelek";
            this.Load += new System.EventHandler(this.Bevetelek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foglalasokErtekeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foglalasokErtekeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lOsszbevetel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMozik;
        private System.Windows.Forms.ListBox lbMozik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoglalasID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeremNev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Megnevezes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdoSav;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Szinkron;
        private System.Windows.Forms.DataGridViewTextBoxColumn Felirat;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoglalasDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn JegyDarab;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoglalasErtek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kedvezmenyes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource foglalasokErtekeBindingSource;
        private System.Windows.Forms.DataGridView foglalasokErtekeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lMozibevetele;
        private System.Windows.Forms.Label lMozifoglalasokSzama;
        private System.Windows.Forms.Label lMoziAtlagbevetele;
        private System.Windows.Forms.Label lFoglalasokSzama;
        private System.Windows.Forms.Label lAtlagosbevetel;
    }
}