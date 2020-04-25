namespace Sprawdzanie_Trojkatow
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
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxBokPierwszy = new System.Windows.Forms.TextBox();
            this.textBoxBok2 = new System.Windows.Forms.TextBox();
            this.textBoxBok3 = new System.Windows.Forms.TextBox();
            this.labelBok1 = new System.Windows.Forms.Label();
            this.labelBok2 = new System.Windows.Forms.Label();
            this.labelBok3 = new System.Windows.Forms.Label();
            this.buttonLiczenie = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuPlik = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeToolStripMenuInformacje = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyśćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twórcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBokPierwszy
            // 
            this.textBoxBokPierwszy.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxBokPierwszy.Location = new System.Drawing.Point(101, 163);
            this.textBoxBokPierwszy.Name = "textBoxBokPierwszy";
            this.textBoxBokPierwszy.Size = new System.Drawing.Size(100, 40);
            this.textBoxBokPierwszy.TabIndex = 1;
            // 
            // textBoxBok2
            // 
            this.textBoxBok2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxBok2.Location = new System.Drawing.Point(569, 163);
            this.textBoxBok2.Name = "textBoxBok2";
            this.textBoxBok2.Size = new System.Drawing.Size(100, 40);
            this.textBoxBok2.TabIndex = 2;
            // 
            // textBoxBok3
            // 
            this.textBoxBok3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxBok3.Location = new System.Drawing.Point(335, 163);
            this.textBoxBok3.Name = "textBoxBok3";
            this.textBoxBok3.Size = new System.Drawing.Size(100, 40);
            this.textBoxBok3.TabIndex = 3;
            // 
            // labelBok1
            // 
            this.labelBok1.AutoSize = true;
            this.labelBok1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBok1.Location = new System.Drawing.Point(62, 129);
            this.labelBok1.Name = "labelBok1";
            this.labelBok1.Size = new System.Drawing.Size(178, 31);
            this.labelBok1.TabIndex = 4;
            this.labelBok1.Text = "Bok Pierwszy";
            // 
            // labelBok2
            // 
            this.labelBok2.AutoSize = true;
            this.labelBok2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBok2.Location = new System.Drawing.Point(318, 129);
            this.labelBok2.Name = "labelBok2";
            this.labelBok2.Size = new System.Drawing.Size(133, 31);
            this.labelBok2.TabIndex = 5;
            this.labelBok2.Text = "Bok Drugi";
            // 
            // labelBok3
            // 
            this.labelBok3.AutoSize = true;
            this.labelBok3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBok3.Location = new System.Drawing.Point(550, 129);
            this.labelBok3.Name = "labelBok3";
            this.labelBok3.Size = new System.Drawing.Size(143, 31);
            this.labelBok3.TabIndex = 6;
            this.labelBok3.Text = "Bok Trzeci";
            // 
            // buttonLiczenie
            // 
            this.buttonLiczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLiczenie.Location = new System.Drawing.Point(314, 279);
            this.buttonLiczenie.Name = "buttonLiczenie";
            this.buttonLiczenie.Size = new System.Drawing.Size(137, 46);
            this.buttonLiczenie.TabIndex = 7;
            this.buttonLiczenie.Text = "Oblicz";
            this.buttonLiczenie.UseVisualStyleBackColor = true;
            this.buttonLiczenie.Click += new System.EventHandler(this.buttonLiczenie_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuPlik,
            this.informacjeToolStripMenuInformacje});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 38);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuPlik
            // 
            this.plikToolStripMenuPlik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyczyśćToolStripMenuItem});
            this.plikToolStripMenuPlik.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plikToolStripMenuPlik.Name = "plikToolStripMenuPlik";
            this.plikToolStripMenuPlik.Size = new System.Drawing.Size(57, 34);
            this.plikToolStripMenuPlik.Text = "Plik";
            // 
            // informacjeToolStripMenuInformacje
            // 
            this.informacjeToolStripMenuInformacje.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.twórcaToolStripMenuItem});
            this.informacjeToolStripMenuInformacje.Name = "informacjeToolStripMenuInformacje";
            this.informacjeToolStripMenuInformacje.Size = new System.Drawing.Size(124, 34);
            this.informacjeToolStripMenuInformacje.Text = "Informacje";
            // 
            // wyczyśćToolStripMenuItem
            // 
            this.wyczyśćToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyczyśćToolStripMenuItem.Name = "wyczyśćToolStripMenuItem";
            this.wyczyśćToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.wyczyśćToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wyczyśćToolStripMenuItem.Text = "Wyczyść";
            this.wyczyśćToolStripMenuItem.Click += new System.EventHandler(this.wyczyśćToolStripMenuItem_Click);
            // 
            // twórcaToolStripMenuItem
            // 
            this.twórcaToolStripMenuItem.Name = "twórcaToolStripMenuItem";
            this.twórcaToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.twórcaToolStripMenuItem.Text = "Twórca...";
            this.twórcaToolStripMenuItem.Click += new System.EventHandler(this.twórcaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.buttonLiczenie);
            this.Controls.Add(this.labelBok3);
            this.Controls.Add(this.labelBok2);
            this.Controls.Add(this.labelBok1);
            this.Controls.Add(this.textBoxBok3);
            this.Controls.Add(this.textBoxBok2);
            this.Controls.Add(this.textBoxBokPierwszy);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sprawdzanie Trójkątów";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxBokPierwszy;
        private System.Windows.Forms.TextBox textBoxBok2;
        private System.Windows.Forms.TextBox textBoxBok3;
        private System.Windows.Forms.Label labelBok1;
        private System.Windows.Forms.Label labelBok2;
        private System.Windows.Forms.Label labelBok3;
        private System.Windows.Forms.Button buttonLiczenie;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuPlik;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjeToolStripMenuInformacje;
        private System.Windows.Forms.ToolStripMenuItem twórcaToolStripMenuItem;
    }
}

