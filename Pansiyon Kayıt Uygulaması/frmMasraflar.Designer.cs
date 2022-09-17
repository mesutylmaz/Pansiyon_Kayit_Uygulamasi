
namespace Pansiyon_Kayıt_Uygulaması
{
    partial class frmMasraflar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpFaturalar = new System.Windows.Forms.GroupBox();
            this.nmrInternet = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nmrSu = new System.Windows.Forms.NumericUpDown();
            this.nmrElektrik = new System.Windows.Forms.NumericUpDown();
            this.nmrDogalgaz = new System.Windows.Forms.NumericUpDown();
            this.dtpFaturaTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKaydetFatura = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmrAtistirma = new System.Windows.Forms.NumericUpDown();
            this.nmrIcecek = new System.Windows.Forms.NumericUpDown();
            this.nmrGida = new System.Windows.Forms.NumericUpDown();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpFaturalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrInternet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrElektrik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDogalgaz)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAtistirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrIcecek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGida)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-136, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gıda Tutarı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-143, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "İçecek Tutarı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-181, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Atıştırmalık Tutarı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-159, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alışveriş Tarihi : ";
            // 
            // grpFaturalar
            // 
            this.grpFaturalar.Controls.Add(this.nmrInternet);
            this.grpFaturalar.Controls.Add(this.label13);
            this.grpFaturalar.Controls.Add(this.nmrSu);
            this.grpFaturalar.Controls.Add(this.nmrElektrik);
            this.grpFaturalar.Controls.Add(this.nmrDogalgaz);
            this.grpFaturalar.Controls.Add(this.dtpFaturaTarih);
            this.grpFaturalar.Controls.Add(this.label5);
            this.grpFaturalar.Controls.Add(this.listView2);
            this.grpFaturalar.Controls.Add(this.label4);
            this.grpFaturalar.Controls.Add(this.btnKaydetFatura);
            this.grpFaturalar.Controls.Add(this.label6);
            this.grpFaturalar.Controls.Add(this.label3);
            this.grpFaturalar.Controls.Add(this.label7);
            this.grpFaturalar.Controls.Add(this.label2);
            this.grpFaturalar.Controls.Add(this.label8);
            this.grpFaturalar.Controls.Add(this.label1);
            this.grpFaturalar.Location = new System.Drawing.Point(680, 2);
            this.grpFaturalar.Name = "grpFaturalar";
            this.grpFaturalar.Size = new System.Drawing.Size(567, 497);
            this.grpFaturalar.TabIndex = 63;
            this.grpFaturalar.TabStop = false;
            this.grpFaturalar.Text = "Faturalar";
            // 
            // nmrInternet
            // 
            this.nmrInternet.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrInternet.Location = new System.Drawing.Point(201, 132);
            this.nmrInternet.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrInternet.Name = "nmrInternet";
            this.nmrInternet.Size = new System.Drawing.Size(209, 26);
            this.nmrInternet.TabIndex = 73;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(83, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 19);
            this.label13.TabIndex = 72;
            this.label13.Text = "İnternet Tutarı :";
            // 
            // nmrSu
            // 
            this.nmrSu.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrSu.Location = new System.Drawing.Point(201, 95);
            this.nmrSu.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrSu.Name = "nmrSu";
            this.nmrSu.Size = new System.Drawing.Size(209, 26);
            this.nmrSu.TabIndex = 71;
            // 
            // nmrElektrik
            // 
            this.nmrElektrik.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrElektrik.Location = new System.Drawing.Point(201, 59);
            this.nmrElektrik.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrElektrik.Name = "nmrElektrik";
            this.nmrElektrik.Size = new System.Drawing.Size(209, 26);
            this.nmrElektrik.TabIndex = 70;
            // 
            // nmrDogalgaz
            // 
            this.nmrDogalgaz.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrDogalgaz.Location = new System.Drawing.Point(201, 24);
            this.nmrDogalgaz.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrDogalgaz.Name = "nmrDogalgaz";
            this.nmrDogalgaz.Size = new System.Drawing.Size(209, 26);
            this.nmrDogalgaz.TabIndex = 69;
            // 
            // dtpFaturaTarih
            // 
            this.dtpFaturaTarih.CalendarFont = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFaturaTarih.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFaturaTarih.Location = new System.Drawing.Point(201, 169);
            this.dtpFaturaTarih.Name = "dtpFaturaTarih";
            this.dtpFaturaTarih.Size = new System.Drawing.Size(209, 26);
            this.dtpFaturaTarih.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 68;
            this.label5.Text = "Fatura Tarihi : ";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listView2.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 249);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(567, 248);
            this.listView2.TabIndex = 67;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "#";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 46;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Doğalgaz";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 74;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Elektrik";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 74;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Su";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 69;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "İnternet";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 93;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Tarih";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 124;
            // 
            // btnKaydetFatura
            // 
            this.btnKaydetFatura.BackColor = System.Drawing.Color.DarkOrange;
            this.btnKaydetFatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydetFatura.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydetFatura.Location = new System.Drawing.Point(221, 207);
            this.btnKaydetFatura.Name = "btnKaydetFatura";
            this.btnKaydetFatura.Size = new System.Drawing.Size(120, 28);
            this.btnKaydetFatura.TabIndex = 65;
            this.btnKaydetFatura.Text = "Kaydet";
            this.btnKaydetFatura.UseVisualStyleBackColor = false;
            this.btnKaydetFatura.Click += new System.EventHandler(this.btnKaydetFatura_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 64;
            this.label6.Text = "Su Tutarı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 63;
            this.label7.Text = "Elektrik Tutarı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 19);
            this.label8.TabIndex = 62;
            this.label8.Text = "Doğalgaz Tutarı :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nmrAtistirma);
            this.groupBox1.Controls.Add(this.nmrIcecek);
            this.groupBox1.Controls.Add(this.nmrGida);
            this.groupBox1.Controls.Add(this.dtpTarih);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 497);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stoklar";
            // 
            // nmrAtistirma
            // 
            this.nmrAtistirma.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrAtistirma.Location = new System.Drawing.Point(201, 119);
            this.nmrAtistirma.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrAtistirma.Name = "nmrAtistirma";
            this.nmrAtistirma.Size = new System.Drawing.Size(209, 26);
            this.nmrAtistirma.TabIndex = 82;
            // 
            // nmrIcecek
            // 
            this.nmrIcecek.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrIcecek.Location = new System.Drawing.Point(201, 79);
            this.nmrIcecek.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrIcecek.Name = "nmrIcecek";
            this.nmrIcecek.Size = new System.Drawing.Size(209, 26);
            this.nmrIcecek.TabIndex = 81;
            // 
            // nmrGida
            // 
            this.nmrGida.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrGida.Location = new System.Drawing.Point(201, 40);
            this.nmrGida.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrGida.Name = "nmrGida";
            this.nmrGida.Size = new System.Drawing.Size(209, 26);
            this.nmrGida.TabIndex = 80;
            // 
            // dtpTarih
            // 
            this.dtpTarih.CalendarFont = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTarih.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTarih.Location = new System.Drawing.Point(201, 159);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(209, 26);
            this.dtpTarih.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(83, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 19);
            this.label9.TabIndex = 79;
            this.label9.Text = "Alışveriş Tarihi : ";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 249);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(569, 248);
            this.listView1.TabIndex = 78;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 52;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gıdalar";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İçecekler";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Atıştırmalıklar";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 106;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tarih";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 119;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Saat";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 95;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkOrange;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(221, 203);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 28);
            this.btnKaydet.TabIndex = 76;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(61, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 19);
            this.label10.TabIndex = 75;
            this.label10.Text = "Atıştırmalık Tutarı :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(99, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 19);
            this.label11.TabIndex = 74;
            this.label11.Text = "İçecek Tutarı :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(106, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 19);
            this.label12.TabIndex = 73;
            this.label12.Text = "Gıda Tutarı :";
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.DarkRed;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKapat.Location = new System.Drawing.Point(596, 22);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(55, 40);
            this.btnKapat.TabIndex = 83;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Saat";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 85;
            // 
            // frmMasraflar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1247, 499);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpFaturalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMasraflar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMasraflar";
            this.Load += new System.EventHandler(this.frmStoklar_Load);
            this.grpFaturalar.ResumeLayout(false);
            this.grpFaturalar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrInternet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrElektrik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDogalgaz)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAtistirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrIcecek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpFaturalar;
        private System.Windows.Forms.NumericUpDown nmrSu;
        private System.Windows.Forms.NumericUpDown nmrElektrik;
        private System.Windows.Forms.NumericUpDown nmrDogalgaz;
        private System.Windows.Forms.DateTimePicker dtpFaturaTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button btnKaydetFatura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.NumericUpDown nmrAtistirma;
        private System.Windows.Forms.NumericUpDown nmrIcecek;
        private System.Windows.Forms.NumericUpDown nmrGida;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nmrInternet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ColumnHeader columnHeader13;
    }
}