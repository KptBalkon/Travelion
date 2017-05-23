namespace Travelion
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart_Wyniki = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trackBar_Imprezy = new System.Windows.Forms.TrackBar();
            this.trackBar_Widoki = new System.Windows.Forms.TrackBar();
            this.trackBar_Jedzenie = new System.Windows.Forms.TrackBar();
            this.trackBar_Pobyt = new System.Windows.Forms.TrackBar();
            this.trackBar_Cena = new System.Windows.Forms.TrackBar();
            this.trackBar_Cywilizacja = new System.Windows.Forms.TrackBar();
            this.label_Imprezy = new System.Windows.Forms.Label();
            this.label_Widoki = new System.Windows.Forms.Label();
            this.label_Jedzenie = new System.Windows.Forms.Label();
            this.label_Pobyt = new System.Windows.Forms.Label();
            this.label_Cena = new System.Windows.Forms.Label();
            this.label_Cywilizacja = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_Muzea = new System.Windows.Forms.Label();
            this.trackBar_Muzea = new System.Windows.Forms.TrackBar();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox_All = new System.Windows.Forms.CheckBox();
            this.checkBox_Europe = new System.Windows.Forms.CheckBox();
            this.checkBox_SAmerica = new System.Windows.Forms.CheckBox();
            this.checkBox_NAmerica = new System.Windows.Forms.CheckBox();
            this.checkBox_Africa = new System.Windows.Forms.CheckBox();
            this.checkBox_Asia = new System.Windows.Forms.CheckBox();
            this.checkBox_Australia = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Wyniki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Imprezy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Widoki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Jedzenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Pobyt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Cena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Cywilizacja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Muzea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjeToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // chart_Wyniki
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Wyniki.ChartAreas.Add(chartArea1);
            this.chart_Wyniki.Location = new System.Drawing.Point(285, 38);
            this.chart_Wyniki.Name = "chart_Wyniki";
            this.chart_Wyniki.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Zdobyte Punkty";
            this.chart_Wyniki.Series.Add(series1);
            this.chart_Wyniki.Size = new System.Drawing.Size(431, 334);
            this.chart_Wyniki.TabIndex = 1;
            this.chart_Wyniki.Text = "chart1";
            // 
            // trackBar_Imprezy
            // 
            this.trackBar_Imprezy.LargeChange = 1;
            this.trackBar_Imprezy.Location = new System.Drawing.Point(161, 38);
            this.trackBar_Imprezy.Maximum = 5;
            this.trackBar_Imprezy.Minimum = 1;
            this.trackBar_Imprezy.Name = "trackBar_Imprezy";
            this.trackBar_Imprezy.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Imprezy.TabIndex = 2;
            this.trackBar_Imprezy.Value = 1;
            // 
            // trackBar_Widoki
            // 
            this.trackBar_Widoki.LargeChange = 1;
            this.trackBar_Widoki.Location = new System.Drawing.Point(161, 89);
            this.trackBar_Widoki.Maximum = 5;
            this.trackBar_Widoki.Minimum = 1;
            this.trackBar_Widoki.Name = "trackBar_Widoki";
            this.trackBar_Widoki.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Widoki.TabIndex = 3;
            this.trackBar_Widoki.Value = 1;
            // 
            // trackBar_Jedzenie
            // 
            this.trackBar_Jedzenie.LargeChange = 1;
            this.trackBar_Jedzenie.Location = new System.Drawing.Point(161, 140);
            this.trackBar_Jedzenie.Maximum = 5;
            this.trackBar_Jedzenie.Minimum = 1;
            this.trackBar_Jedzenie.Name = "trackBar_Jedzenie";
            this.trackBar_Jedzenie.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Jedzenie.TabIndex = 4;
            this.trackBar_Jedzenie.Value = 1;
            // 
            // trackBar_Pobyt
            // 
            this.trackBar_Pobyt.LargeChange = 1;
            this.trackBar_Pobyt.Location = new System.Drawing.Point(161, 191);
            this.trackBar_Pobyt.Maximum = 5;
            this.trackBar_Pobyt.Minimum = 1;
            this.trackBar_Pobyt.Name = "trackBar_Pobyt";
            this.trackBar_Pobyt.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Pobyt.TabIndex = 5;
            this.trackBar_Pobyt.Value = 1;
            // 
            // trackBar_Cena
            // 
            this.trackBar_Cena.LargeChange = 1;
            this.trackBar_Cena.Location = new System.Drawing.Point(161, 242);
            this.trackBar_Cena.Maximum = 5;
            this.trackBar_Cena.Minimum = 1;
            this.trackBar_Cena.Name = "trackBar_Cena";
            this.trackBar_Cena.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Cena.TabIndex = 6;
            this.trackBar_Cena.Value = 1;
            // 
            // trackBar_Cywilizacja
            // 
            this.trackBar_Cywilizacja.LargeChange = 1;
            this.trackBar_Cywilizacja.Location = new System.Drawing.Point(161, 293);
            this.trackBar_Cywilizacja.Maximum = 5;
            this.trackBar_Cywilizacja.Minimum = 1;
            this.trackBar_Cywilizacja.Name = "trackBar_Cywilizacja";
            this.trackBar_Cywilizacja.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Cywilizacja.TabIndex = 7;
            this.trackBar_Cywilizacja.Value = 1;
            // 
            // label_Imprezy
            // 
            this.label_Imprezy.AutoSize = true;
            this.label_Imprezy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Imprezy.Location = new System.Drawing.Point(20, 38);
            this.label_Imprezy.Name = "label_Imprezy";
            this.label_Imprezy.Size = new System.Drawing.Size(120, 20);
            this.label_Imprezy.TabIndex = 8;
            this.label_Imprezy.Text = "Epickie Imprezy";
            this.label_Imprezy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Widoki
            // 
            this.label_Widoki.AutoSize = true;
            this.label_Widoki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Widoki.Location = new System.Drawing.Point(20, 89);
            this.label_Widoki.Name = "label_Widoki";
            this.label_Widoki.Size = new System.Drawing.Size(128, 20);
            this.label_Widoki.TabIndex = 9;
            this.label_Widoki.Text = "Poetyckie Widoki";
            this.label_Widoki.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Jedzenie
            // 
            this.label_Jedzenie.AutoSize = true;
            this.label_Jedzenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Jedzenie.Location = new System.Drawing.Point(20, 140);
            this.label_Jedzenie.Name = "label_Jedzenie";
            this.label_Jedzenie.Size = new System.Drawing.Size(128, 20);
            this.label_Jedzenie.TabIndex = 10;
            this.label_Jedzenie.Text = "Pyszne Jedzenie";
            this.label_Jedzenie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Pobyt
            // 
            this.label_Pobyt.AutoSize = true;
            this.label_Pobyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Pobyt.Location = new System.Drawing.Point(20, 191);
            this.label_Pobyt.Name = "label_Pobyt";
            this.label_Pobyt.Size = new System.Drawing.Size(134, 20);
            this.label_Pobyt.TabIndex = 11;
            this.label_Pobyt.Text = "Bezpieczny Pobyt";
            this.label_Pobyt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Cena
            // 
            this.label_Cena.AutoSize = true;
            this.label_Cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Cena.Location = new System.Drawing.Point(21, 242);
            this.label_Cena.Name = "label_Cena";
            this.label_Cena.Size = new System.Drawing.Size(107, 20);
            this.label_Cena.TabIndex = 12;
            this.label_Cena.Text = "Niziutka Cena";
            this.label_Cena.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Cywilizacja
            // 
            this.label_Cywilizacja.AutoSize = true;
            this.label_Cywilizacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Cywilizacja.Location = new System.Drawing.Point(21, 293);
            this.label_Cywilizacja.Name = "label_Cywilizacja";
            this.label_Cywilizacja.Size = new System.Drawing.Size(84, 20);
            this.label_Cywilizacja.TabIndex = 13;
            this.label_Cywilizacja.Text = "Cywilizacja";
            this.label_Cywilizacja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "Powiedz gdzie jechać!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(161, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 41);
            this.button2.TabIndex = 15;
            this.button2.Text = "Dej mie oferty!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_Muzea
            // 
            this.label_Muzea.AutoSize = true;
            this.label_Muzea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Muzea.Location = new System.Drawing.Point(21, 344);
            this.label_Muzea.Name = "label_Muzea";
            this.label_Muzea.Size = new System.Drawing.Size(112, 20);
            this.label_Muzea.TabIndex = 17;
            this.label_Muzea.Text = "Muzea/Zabytki";
            this.label_Muzea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBar_Muzea
            // 
            this.trackBar_Muzea.LargeChange = 1;
            this.trackBar_Muzea.Location = new System.Drawing.Point(161, 344);
            this.trackBar_Muzea.Maximum = 5;
            this.trackBar_Muzea.Minimum = 1;
            this.trackBar_Muzea.Name = "trackBar_Muzea";
            this.trackBar_Muzea.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Muzea.TabIndex = 16;
            this.trackBar_Muzea.Value = 1;
            // 
            // checkBox_All
            // 
            this.checkBox_All.AutoSize = true;
            this.checkBox_All.Location = new System.Drawing.Point(304, 392);
            this.checkBox_All.Name = "checkBox_All";
            this.checkBox_All.Size = new System.Drawing.Size(101, 17);
            this.checkBox_All.TabIndex = 18;
            this.checkBox_All.Text = "Wszystkie Kraje";
            this.checkBox_All.UseVisualStyleBackColor = true;
            this.checkBox_All.CheckedChanged += new System.EventHandler(this.checkBox_All_CheckedChanged);
            // 
            // checkBox_Europe
            // 
            this.checkBox_Europe.AutoSize = true;
            this.checkBox_Europe.Location = new System.Drawing.Point(411, 392);
            this.checkBox_Europe.Name = "checkBox_Europe";
            this.checkBox_Europe.Size = new System.Drawing.Size(60, 17);
            this.checkBox_Europe.TabIndex = 19;
            this.checkBox_Europe.Text = "Europa";
            this.checkBox_Europe.UseVisualStyleBackColor = true;
            // 
            // checkBox_SAmerica
            // 
            this.checkBox_SAmerica.AutoSize = true;
            this.checkBox_SAmerica.Location = new System.Drawing.Point(496, 418);
            this.checkBox_SAmerica.Name = "checkBox_SAmerica";
            this.checkBox_SAmerica.Size = new System.Drawing.Size(127, 17);
            this.checkBox_SAmerica.TabIndex = 21;
            this.checkBox_SAmerica.Text = "Ameryka Południowa";
            this.checkBox_SAmerica.UseVisualStyleBackColor = true;
            // 
            // checkBox_NAmerica
            // 
            this.checkBox_NAmerica.AutoSize = true;
            this.checkBox_NAmerica.Location = new System.Drawing.Point(496, 392);
            this.checkBox_NAmerica.Name = "checkBox_NAmerica";
            this.checkBox_NAmerica.Size = new System.Drawing.Size(117, 17);
            this.checkBox_NAmerica.TabIndex = 20;
            this.checkBox_NAmerica.Text = "Ameryka Północna";
            this.checkBox_NAmerica.UseVisualStyleBackColor = true;
            // 
            // checkBox_Africa
            // 
            this.checkBox_Africa.AutoSize = true;
            this.checkBox_Africa.Location = new System.Drawing.Point(619, 418);
            this.checkBox_Africa.Name = "checkBox_Africa";
            this.checkBox_Africa.Size = new System.Drawing.Size(56, 17);
            this.checkBox_Africa.TabIndex = 23;
            this.checkBox_Africa.Text = "Afryka";
            this.checkBox_Africa.UseVisualStyleBackColor = true;
            // 
            // checkBox_Asia
            // 
            this.checkBox_Asia.AutoSize = true;
            this.checkBox_Asia.Location = new System.Drawing.Point(411, 418);
            this.checkBox_Asia.Name = "checkBox_Asia";
            this.checkBox_Asia.Size = new System.Drawing.Size(46, 17);
            this.checkBox_Asia.TabIndex = 22;
            this.checkBox_Asia.Text = "Azja";
            this.checkBox_Asia.UseVisualStyleBackColor = true;
            // 
            // checkBox_Australia
            // 
            this.checkBox_Australia.AutoSize = true;
            this.checkBox_Australia.Location = new System.Drawing.Point(619, 392);
            this.checkBox_Australia.Name = "checkBox_Australia";
            this.checkBox_Australia.Size = new System.Drawing.Size(66, 17);
            this.checkBox_Australia.TabIndex = 24;
            this.checkBox_Australia.Text = "Australia";
            this.checkBox_Australia.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(24, 439);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 41);
            this.button5.TabIndex = 27;
            this.button5.Text = "Edytuj Kraje";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 517);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.checkBox_Australia);
            this.Controls.Add(this.checkBox_Africa);
            this.Controls.Add(this.checkBox_Asia);
            this.Controls.Add(this.checkBox_SAmerica);
            this.Controls.Add(this.checkBox_NAmerica);
            this.Controls.Add(this.checkBox_Europe);
            this.Controls.Add(this.checkBox_All);
            this.Controls.Add(this.label_Muzea);
            this.Controls.Add(this.trackBar_Muzea);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Cywilizacja);
            this.Controls.Add(this.label_Cena);
            this.Controls.Add(this.label_Pobyt);
            this.Controls.Add(this.label_Jedzenie);
            this.Controls.Add(this.label_Widoki);
            this.Controls.Add(this.label_Imprezy);
            this.Controls.Add(this.trackBar_Cywilizacja);
            this.Controls.Add(this.trackBar_Cena);
            this.Controls.Add(this.trackBar_Pobyt);
            this.Controls.Add(this.trackBar_Jedzenie);
            this.Controls.Add(this.trackBar_Widoki);
            this.Controls.Add(this.trackBar_Imprezy);
            this.Controls.Add(this.chart_Wyniki);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Travelion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Wyniki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Imprezy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Widoki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Jedzenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Pobyt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Cena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Cywilizacja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Muzea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar_Imprezy;
        private System.Windows.Forms.TrackBar trackBar_Widoki;
        private System.Windows.Forms.TrackBar trackBar_Jedzenie;
        private System.Windows.Forms.TrackBar trackBar_Pobyt;
        private System.Windows.Forms.TrackBar trackBar_Cena;
        private System.Windows.Forms.TrackBar trackBar_Cywilizacja;
        private System.Windows.Forms.Label label_Imprezy;
        private System.Windows.Forms.Label label_Widoki;
        private System.Windows.Forms.Label label_Jedzenie;
        private System.Windows.Forms.Label label_Pobyt;
        private System.Windows.Forms.Label label_Cena;
        private System.Windows.Forms.Label label_Cywilizacja;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_Muzea;
        private System.Windows.Forms.TrackBar trackBar_Muzea;
        private System.Windows.Forms.BindingSource bindingSource1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart_Wyniki;
        public System.Windows.Forms.CheckBox checkBox_All;
        public System.Windows.Forms.CheckBox checkBox_Europe;
        public System.Windows.Forms.CheckBox checkBox_SAmerica;
        public System.Windows.Forms.CheckBox checkBox_NAmerica;
        public System.Windows.Forms.CheckBox checkBox_Africa;
        public System.Windows.Forms.CheckBox checkBox_Asia;
        public System.Windows.Forms.CheckBox checkBox_Australia;
        private System.Windows.Forms.Button button5;
    }
}

