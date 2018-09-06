namespace Generator_Lokalizacji
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
            this.components = new System.ComponentModel.Container();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.btnDrukuj = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboIleNaKoszyk = new System.Windows.Forms.ComboBox();
            this.rdoKoszyki = new System.Windows.Forms.RadioButton();
            this.rdoPodloga = new System.Windows.Forms.RadioButton();
            this.rdoRegaly = new System.Windows.Forms.RadioButton();
            this.txtData = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDrukarki = new System.Windows.Forms.ComboBox();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(516, 292);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(75, 23);
            this.btnZamknij.TabIndex = 0;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // btnDrukuj
            // 
            this.btnDrukuj.Location = new System.Drawing.Point(516, 208);
            this.btnDrukuj.Name = "btnDrukuj";
            this.btnDrukuj.Size = new System.Drawing.Size(75, 75);
            this.btnDrukuj.TabIndex = 1;
            this.btnDrukuj.Text = "Drukuj";
            this.btnDrukuj.UseVisualStyleBackColor = true;
            this.btnDrukuj.Click += new System.EventHandler(this.btnDrukuj_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "*.*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboIleNaKoszyk);
            this.groupBox1.Controls.Add(this.rdoKoszyki);
            this.groupBox1.Controls.Add(this.rdoPodloga);
            this.groupBox1.Controls.Add(this.rdoRegaly);
            this.groupBox1.Location = new System.Drawing.Point(168, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 107);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rodzaj etykiety";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ilość etykiet na koszyku:";
            // 
            // cboIleNaKoszyk
            // 
            this.cboIleNaKoszyk.FormattingEnabled = true;
            this.cboIleNaKoszyk.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboIleNaKoszyk.Location = new System.Drawing.Point(251, 64);
            this.cboIleNaKoszyk.Name = "cboIleNaKoszyk";
            this.cboIleNaKoszyk.Size = new System.Drawing.Size(63, 21);
            this.cboIleNaKoszyk.TabIndex = 3;
            this.cboIleNaKoszyk.Text = "1";
            this.cboIleNaKoszyk.SelectedIndexChanged += new System.EventHandler(this.cboIleNaKoszyk_SelectedIndexChanged);
            // 
            // rdoKoszyki
            // 
            this.rdoKoszyki.AutoSize = true;
            this.rdoKoszyki.Location = new System.Drawing.Point(18, 65);
            this.rdoKoszyki.Name = "rdoKoszyki";
            this.rdoKoszyki.Size = new System.Drawing.Size(61, 17);
            this.rdoKoszyki.TabIndex = 2;
            this.rdoKoszyki.TabStop = true;
            this.rdoKoszyki.Text = "Koszyki";
            this.rdoKoszyki.UseVisualStyleBackColor = true;
            // 
            // rdoPodloga
            // 
            this.rdoPodloga.AutoSize = true;
            this.rdoPodloga.Location = new System.Drawing.Point(18, 42);
            this.rdoPodloga.Name = "rdoPodloga";
            this.rdoPodloga.Size = new System.Drawing.Size(66, 17);
            this.rdoPodloga.TabIndex = 1;
            this.rdoPodloga.TabStop = true;
            this.rdoPodloga.Text = "Podłoga";
            this.rdoPodloga.UseVisualStyleBackColor = true;
            // 
            // rdoRegaly
            // 
            this.rdoRegaly.AutoSize = true;
            this.rdoRegaly.Checked = true;
            this.rdoRegaly.Location = new System.Drawing.Point(18, 19);
            this.rdoRegaly.Name = "rdoRegaly";
            this.rdoRegaly.Size = new System.Drawing.Size(60, 17);
            this.rdoRegaly.TabIndex = 0;
            this.rdoRegaly.TabStop = true;
            this.rdoRegaly.Text = "Regały";
            this.rdoRegaly.UseVisualStyleBackColor = true;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(12, 27);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(150, 288);
            this.txtData.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(608, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtStatus
            // 
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(516, 27);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "Nowy";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(516, 56);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Otwórz...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(516, 85);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Zapisz...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(516, 114);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 13;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Wybierz drukarkę:";
            // 
            // cboDrukarki
            // 
            this.cboDrukarki.FormattingEnabled = true;
            this.cboDrukarki.Items.AddRange(new object[] {
            "\\\\192.168.1.186\\e_mags2",
            "\\\\192.168.1.189\\e_mags",
            "\\\\192.168.1.235\\E_magh",
            "\\\\192.168.2.11\\E_MAGM",
            "\\\\192.168.2.127\\e_magm2",
            "\\\\192.168.2.21\\e_magb",
            "\\\\192.168.2.24\\e_magJ2",
            "\\\\192.168.2.31\\e_magc",
            "\\\\192.168.2.41\\e_magd",
            "\\\\192.168.2.51\\e_magi",
            "\\\\192.168.2.62\\e_magf",
            "\\\\192.168.2.74\\e_magj",
            "\\\\192.168.2.81\\e_magk",
            "\\\\192.168.2.86\\e_magk2",
            "\\\\10.30.50.121\\sklad",
            "\\\\192.168.2.91\\e_magl",
            "\\\\192.168.2.92\\e_magl2",
            "\\\\192.168.5.13\\e_magv",
            "\\\\drukarki\\E_MAG003",
            "\\\\drukarki\\E_MAG004",
            "\\\\drukarki\\E_MAG005"});
            this.cboDrukarki.Location = new System.Drawing.Point(280, 168);
            this.cboDrukarki.Name = "cboDrukarki";
            this.cboDrukarki.Size = new System.Drawing.Size(218, 21);
            this.cboDrukarki.TabIndex = 15;
            this.cboDrukarki.SelectedIndexChanged += new System.EventHandler(this.cboDrukarki_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 366);
            this.Controls.Add(this.cboDrukarki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDrukuj);
            this.Controls.Add(this.btnZamknij);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Generator Lokalizacji";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Button btnDrukuj;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoKoszyki;
        private System.Windows.Forms.RadioButton rdoPodloga;
        private System.Windows.Forms.RadioButton rdoRegaly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboIleNaKoszyk;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtStatus;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDrukarki;
        private System.Windows.Forms.BindingSource bindingSource;
    }
}

