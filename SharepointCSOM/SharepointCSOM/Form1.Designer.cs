namespace SharepointCSOM
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtSigortaEttiren = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSigortali = new System.Windows.Forms.TextBox();
			this.dtDogumT = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dtSigortaBaslangic = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.dtSigortaBitis = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.dtTanzim = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtTaban = new System.Windows.Forms.TextBox();
			this.txtGenelMaliyetler = new System.Windows.Forms.TextBox();
			this.txtKarlilik = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblIOnerilen = new System.Windows.Forms.Label();
			this.lblMax = new System.Windows.Forms.Label();
			this.lblMin = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(75, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Sigorta Ettiren";
			// 
			// txtSigortaEttiren
			// 
			this.txtSigortaEttiren.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSigortaEttiren.Location = new System.Drawing.Point(234, 20);
			this.txtSigortaEttiren.MaxLength = 50;
			this.txtSigortaEttiren.Name = "txtSigortaEttiren";
			this.txtSigortaEttiren.Size = new System.Drawing.Size(121, 31);
			this.txtSigortaEttiren.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(75, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Sigortalı";
			// 
			// txtSigortali
			// 
			this.txtSigortali.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSigortali.Location = new System.Drawing.Point(234, 65);
			this.txtSigortali.MaxLength = 50;
			this.txtSigortali.Name = "txtSigortali";
			this.txtSigortali.Size = new System.Drawing.Size(121, 31);
			this.txtSigortali.TabIndex = 5;
			// 
			// dtDogumT
			// 
			this.dtDogumT.Location = new System.Drawing.Point(234, 120);
			this.dtDogumT.Name = "dtDogumT";
			this.dtDogumT.Size = new System.Drawing.Size(200, 20);
			this.dtDogumT.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(75, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Sigortalı Doğum Tarihi";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Özel Sağlık Sigortası",
            "Tamamlayıcı Sağlık Sigortası",
            "Hayat Sigortası"});
			this.comboBox1.Location = new System.Drawing.Point(234, 174);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(75, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Sigorta Konusu";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(75, 239);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(122, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Sigortalı Başlangıç Tarihi";
			// 
			// dtSigortaBaslangic
			// 
			this.dtSigortaBaslangic.Location = new System.Drawing.Point(234, 239);
			this.dtSigortaBaslangic.Name = "dtSigortaBaslangic";
			this.dtSigortaBaslangic.Size = new System.Drawing.Size(200, 20);
			this.dtSigortaBaslangic.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(520, 242);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Sigortalı Bitiş Tarihi";
			// 
			// dtSigortaBitis
			// 
			this.dtSigortaBitis.Location = new System.Drawing.Point(632, 235);
			this.dtSigortaBitis.Name = "dtSigortaBitis";
			this.dtSigortaBitis.Size = new System.Drawing.Size(200, 20);
			this.dtSigortaBitis.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(300, 281);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Tanzim Tarihi";
			// 
			// dtTanzim
			// 
			this.dtTanzim.Location = new System.Drawing.Point(376, 281);
			this.dtTanzim.Name = "dtTanzim";
			this.dtTanzim.Size = new System.Drawing.Size(200, 20);
			this.dtTanzim.TabIndex = 14;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(163, 307);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(634, 54);
			this.button1.TabIndex = 16;
			this.button1.Text = "Formu Kaydet";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(586, 24);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(63, 13);
			this.label8.TabIndex = 17;
			this.label8.Text = "Taban Fiyat";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(567, 66);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(82, 13);
			this.label9.TabIndex = 18;
			this.label9.Text = "Genel Maliyetler";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(577, 114);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(60, 13);
			this.label11.TabIndex = 20;
			this.label11.Text = "Karlılık (%) :";
			// 
			// txtTaban
			// 
			this.txtTaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtTaban.Location = new System.Drawing.Point(710, 21);
			this.txtTaban.Name = "txtTaban";
			this.txtTaban.Size = new System.Drawing.Size(100, 27);
			this.txtTaban.TabIndex = 21;
			this.txtTaban.TextChanged += new System.EventHandler(this.txtTaban_TextChanged);
			this.txtTaban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaban_KeyPress);
			// 
			// txtGenelMaliyetler
			// 
			this.txtGenelMaliyetler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtGenelMaliyetler.Location = new System.Drawing.Point(710, 69);
			this.txtGenelMaliyetler.Name = "txtGenelMaliyetler";
			this.txtGenelMaliyetler.Size = new System.Drawing.Size(100, 27);
			this.txtGenelMaliyetler.TabIndex = 22;
			this.txtGenelMaliyetler.TextChanged += new System.EventHandler(this.txtGenelMaliyetler_TextChanged);
			this.txtGenelMaliyetler.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGenelMaliyetler_KeyPress);
			// 
			// txtKarlilik
			// 
			this.txtKarlilik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtKarlilik.Location = new System.Drawing.Point(710, 114);
			this.txtKarlilik.Name = "txtKarlilik";
			this.txtKarlilik.Size = new System.Drawing.Size(100, 27);
			this.txtKarlilik.TabIndex = 23;
			this.txtKarlilik.TextChanged += new System.EventHandler(this.txtKarlilik_TextChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.dtSigortaBitis);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtKarlilik);
			this.panel1.Controls.Add(this.txtSigortaEttiren);
			this.panel1.Controls.Add(this.txtGenelMaliyetler);
			this.panel1.Controls.Add(this.txtTaban);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.txtSigortali);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.dtDogumT);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.dtSigortaBaslangic);
			this.panel1.Controls.Add(this.dtTanzim);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Location = new System.Drawing.Point(69, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1167, 625);
			this.panel1.TabIndex = 25;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblIOnerilen);
			this.groupBox1.Controls.Add(this.lblMax);
			this.groupBox1.Controls.Add(this.lblMin);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Location = new System.Drawing.Point(195, 383);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(569, 230);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			// 
			// lblIOnerilen
			// 
			this.lblIOnerilen.AutoSize = true;
			this.lblIOnerilen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblIOnerilen.Location = new System.Drawing.Point(238, 177);
			this.lblIOnerilen.Name = "lblIOnerilen";
			this.lblIOnerilen.Size = new System.Drawing.Size(0, 22);
			this.lblIOnerilen.TabIndex = 5;
			// 
			// lblMax
			// 
			this.lblMax.AutoSize = true;
			this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblMax.Location = new System.Drawing.Point(48, 103);
			this.lblMax.Name = "lblMax";
			this.lblMax.Size = new System.Drawing.Size(0, 22);
			this.lblMax.TabIndex = 4;
			// 
			// lblMin
			// 
			this.lblMin.AutoSize = true;
			this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblMin.Location = new System.Drawing.Point(400, 94);
			this.lblMin.Name = "lblMin";
			this.lblMin.Size = new System.Drawing.Size(0, 22);
			this.lblMin.TabIndex = 3;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label13.Location = new System.Drawing.Point(400, 48);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(124, 22);
			this.label13.TabIndex = 2;
			this.label13.Text = "Minimum Fiyat";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label12.Location = new System.Drawing.Point(30, 48);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(129, 22);
			this.label12.TabIndex = 1;
			this.label12.Text = "Maximum Fiyat";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label10.Location = new System.Drawing.Point(220, 140);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(127, 22);
			this.label10.TabIndex = 0;
			this.label10.Text = "Önerilen Fiyat ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(1350, 669);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Sigortalı Kayıt Formu";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSigortaEttiren;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSigortali;
		private System.Windows.Forms.DateTimePicker dtDogumT;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtSigortaBaslangic;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtSigortaBitis;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dtTanzim;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtTaban;
		private System.Windows.Forms.TextBox txtGenelMaliyetler;
		private System.Windows.Forms.TextBox txtKarlilik;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblIOnerilen;
		private System.Windows.Forms.Label lblMax;
		private System.Windows.Forms.Label lblMin;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
	}
}

