﻿namespace Simple_KLADR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_REGION = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.status_Connection = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_RAYON = new System.Windows.Forms.TextBox();
            this.lb_REGION = new System.Windows.Forms.Label();
            this.lb_RAYON = new System.Windows.Forms.Label();
            this.lb_GOROD = new System.Windows.Forms.Label();
            this.tb_GOROD = new System.Windows.Forms.TextBox();
            this.tb_ULICA = new System.Windows.Forms.TextBox();
            this.lb_ULICA = new System.Windows.Forms.Label();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.tb_REGION_SKR = new System.Windows.Forms.TextBox();
            this.tb_RAYON_SKR = new System.Windows.Forms.TextBox();
            this.tb_GOROD_SKR = new System.Windows.Forms.TextBox();
            this.tb_ULICA_SKR = new System.Windows.Forms.TextBox();
            this.tb_DOM = new System.Windows.Forms.TextBox();
            this.lb_DOM = new System.Windows.Forms.Label();
            this.tb_DOM_SKR = new System.Windows.Forms.TextBox();
            this.tb_NASPUNKT = new System.Windows.Forms.TextBox();
            this.lb_NASPUNKT = new System.Windows.Forms.Label();
            this.tb_NASPUNKT_SKR = new System.Windows.Forms.TextBox();
            this.lb_count_rows = new System.Windows.Forms.Label();
            this.lb_INDEX = new System.Windows.Forms.Label();
            this.lb_GNI = new System.Windows.Forms.Label();
            this.lb_OKATD = new System.Windows.Forms.Label();
            this.lb_INDEX_R = new System.Windows.Forms.Label();
            this.lb_GNI_R = new System.Windows.Forms.Label();
            this.lb_OCATD_R = new System.Windows.Forms.Label();
            this.tb_REGION_SOCR = new System.Windows.Forms.TextBox();
            this.tb_RAYON_SOCR = new System.Windows.Forms.TextBox();
            this.tb_GOROD_SOCR = new System.Windows.Forms.TextBox();
            this.tb_NASPUNKT_SOCR = new System.Windows.Forms.TextBox();
            this.tb_ULICA_SOCR = new System.Windows.Forms.TextBox();
            this.tb_DOM_SOCR = new System.Windows.Forms.TextBox();
            this.tb_db_Location = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лицензияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_REGION
            // 
            this.tb_REGION.Location = new System.Drawing.Point(122, 31);
            this.tb_REGION.Name = "tb_REGION";
            this.tb_REGION.Size = new System.Drawing.Size(200, 20);
            this.tb_REGION.TabIndex = 0;
            this.tb_REGION.Click += new System.EventHandler(this.tb_REGION_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 226);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(759, 34);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // status_Connection
            // 
            this.status_Connection.AutoSize = true;
            this.status_Connection.Location = new System.Drawing.Point(9, 608);
            this.status_Connection.Name = "status_Connection";
            this.status_Connection.Size = new System.Drawing.Size(80, 13);
            this.status_Connection.TabIndex = 2;
            this.status_Connection.Text = "БД отключена";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(615, 58);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 3;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 316);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tb_RAYON
            // 
            this.tb_RAYON.Location = new System.Drawing.Point(122, 57);
            this.tb_RAYON.Name = "tb_RAYON";
            this.tb_RAYON.Size = new System.Drawing.Size(200, 20);
            this.tb_RAYON.TabIndex = 5;
            this.tb_RAYON.Click += new System.EventHandler(this.tb_RAYON_Click);
            // 
            // lb_REGION
            // 
            this.lb_REGION.AutoSize = true;
            this.lb_REGION.Location = new System.Drawing.Point(12, 34);
            this.lb_REGION.Name = "lb_REGION";
            this.lb_REGION.Size = new System.Drawing.Size(43, 13);
            this.lb_REGION.TabIndex = 6;
            this.lb_REGION.Text = "Регион";
            // 
            // lb_RAYON
            // 
            this.lb_RAYON.AutoSize = true;
            this.lb_RAYON.Location = new System.Drawing.Point(12, 60);
            this.lb_RAYON.Name = "lb_RAYON";
            this.lb_RAYON.Size = new System.Drawing.Size(38, 13);
            this.lb_RAYON.TabIndex = 7;
            this.lb_RAYON.Text = "Район";
            // 
            // lb_GOROD
            // 
            this.lb_GOROD.AutoSize = true;
            this.lb_GOROD.Location = new System.Drawing.Point(12, 86);
            this.lb_GOROD.Name = "lb_GOROD";
            this.lb_GOROD.Size = new System.Drawing.Size(37, 13);
            this.lb_GOROD.TabIndex = 8;
            this.lb_GOROD.Text = "Город";
            // 
            // tb_GOROD
            // 
            this.tb_GOROD.Location = new System.Drawing.Point(122, 83);
            this.tb_GOROD.Name = "tb_GOROD";
            this.tb_GOROD.Size = new System.Drawing.Size(200, 20);
            this.tb_GOROD.TabIndex = 9;
            this.tb_GOROD.Click += new System.EventHandler(this.tb_GOROD_Click);
            // 
            // tb_ULICA
            // 
            this.tb_ULICA.Location = new System.Drawing.Point(122, 136);
            this.tb_ULICA.Name = "tb_ULICA";
            this.tb_ULICA.Size = new System.Drawing.Size(200, 20);
            this.tb_ULICA.TabIndex = 10;
            this.tb_ULICA.Click += new System.EventHandler(this.tb_ULICA_Click);
            // 
            // lb_ULICA
            // 
            this.lb_ULICA.AutoSize = true;
            this.lb_ULICA.Location = new System.Drawing.Point(12, 139);
            this.lb_ULICA.Name = "lb_ULICA";
            this.lb_ULICA.Size = new System.Drawing.Size(39, 13);
            this.lb_ULICA.TabIndex = 11;
            this.lb_ULICA.Text = "Улица";
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(615, 86);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_Disconnect.TabIndex = 12;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // tb_REGION_SKR
            // 
            this.tb_REGION_SKR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_REGION_SKR.Location = new System.Drawing.Point(366, 31);
            this.tb_REGION_SKR.Name = "tb_REGION_SKR";
            this.tb_REGION_SKR.Size = new System.Drawing.Size(227, 20);
            this.tb_REGION_SKR.TabIndex = 15;
            // 
            // tb_RAYON_SKR
            // 
            this.tb_RAYON_SKR.Location = new System.Drawing.Point(366, 57);
            this.tb_RAYON_SKR.Name = "tb_RAYON_SKR";
            this.tb_RAYON_SKR.Size = new System.Drawing.Size(227, 20);
            this.tb_RAYON_SKR.TabIndex = 16;
            // 
            // tb_GOROD_SKR
            // 
            this.tb_GOROD_SKR.Location = new System.Drawing.Point(366, 83);
            this.tb_GOROD_SKR.Name = "tb_GOROD_SKR";
            this.tb_GOROD_SKR.Size = new System.Drawing.Size(227, 20);
            this.tb_GOROD_SKR.TabIndex = 17;
            // 
            // tb_ULICA_SKR
            // 
            this.tb_ULICA_SKR.Location = new System.Drawing.Point(366, 135);
            this.tb_ULICA_SKR.Name = "tb_ULICA_SKR";
            this.tb_ULICA_SKR.Size = new System.Drawing.Size(227, 20);
            this.tb_ULICA_SKR.TabIndex = 18;
            // 
            // tb_DOM
            // 
            this.tb_DOM.Location = new System.Drawing.Point(122, 162);
            this.tb_DOM.Name = "tb_DOM";
            this.tb_DOM.Size = new System.Drawing.Size(200, 20);
            this.tb_DOM.TabIndex = 19;
            this.tb_DOM.Click += new System.EventHandler(this.tb_DOM_Click);
            // 
            // lb_DOM
            // 
            this.lb_DOM.AutoSize = true;
            this.lb_DOM.Location = new System.Drawing.Point(12, 165);
            this.lb_DOM.Name = "lb_DOM";
            this.lb_DOM.Size = new System.Drawing.Size(30, 13);
            this.lb_DOM.TabIndex = 20;
            this.lb_DOM.Text = "Дом";
            // 
            // tb_DOM_SKR
            // 
            this.tb_DOM_SKR.Location = new System.Drawing.Point(366, 161);
            this.tb_DOM_SKR.Name = "tb_DOM_SKR";
            this.tb_DOM_SKR.Size = new System.Drawing.Size(227, 20);
            this.tb_DOM_SKR.TabIndex = 21;
            // 
            // tb_NASPUNKT
            // 
            this.tb_NASPUNKT.Location = new System.Drawing.Point(122, 110);
            this.tb_NASPUNKT.Name = "tb_NASPUNKT";
            this.tb_NASPUNKT.Size = new System.Drawing.Size(200, 20);
            this.tb_NASPUNKT.TabIndex = 22;
            this.tb_NASPUNKT.Click += new System.EventHandler(this.tb_NASPUNKT_Click);
            // 
            // lb_NASPUNKT
            // 
            this.lb_NASPUNKT.AutoSize = true;
            this.lb_NASPUNKT.Location = new System.Drawing.Point(12, 113);
            this.lb_NASPUNKT.Name = "lb_NASPUNKT";
            this.lb_NASPUNKT.Size = new System.Drawing.Size(102, 13);
            this.lb_NASPUNKT.TabIndex = 23;
            this.lb_NASPUNKT.Text = "Населенный пункт";
            // 
            // tb_NASPUNKT_SKR
            // 
            this.tb_NASPUNKT_SKR.Location = new System.Drawing.Point(366, 109);
            this.tb_NASPUNKT_SKR.Name = "tb_NASPUNKT_SKR";
            this.tb_NASPUNKT_SKR.Size = new System.Drawing.Size(227, 20);
            this.tb_NASPUNKT_SKR.TabIndex = 24;
            // 
            // lb_count_rows
            // 
            this.lb_count_rows.AutoSize = true;
            this.lb_count_rows.Location = new System.Drawing.Point(529, 608);
            this.lb_count_rows.Name = "lb_count_rows";
            this.lb_count_rows.Size = new System.Drawing.Size(92, 13);
            this.lb_count_rows.TabIndex = 25;
            this.lb_count_rows.Text = "Найдено 0 строк";
            // 
            // lb_INDEX
            // 
            this.lb_INDEX.AutoSize = true;
            this.lb_INDEX.Location = new System.Drawing.Point(12, 194);
            this.lb_INDEX.Name = "lb_INDEX";
            this.lb_INDEX.Size = new System.Drawing.Size(96, 13);
            this.lb_INDEX.TabIndex = 26;
            this.lb_INDEX.Text = "Почтовый индекс";
            // 
            // lb_GNI
            // 
            this.lb_GNI.AutoSize = true;
            this.lb_GNI.Location = new System.Drawing.Point(180, 194);
            this.lb_GNI.Name = "lb_GNI";
            this.lb_GNI.Size = new System.Drawing.Size(78, 13);
            this.lb_GNI.TabIndex = 27;
            this.lb_GNI.Text = "Номер ИФНС";
            // 
            // lb_OKATD
            // 
            this.lb_OKATD.AutoSize = true;
            this.lb_OKATD.Location = new System.Drawing.Point(339, 194);
            this.lb_OKATD.Name = "lb_OKATD";
            this.lb_OKATD.Size = new System.Drawing.Size(44, 13);
            this.lb_OKATD.TabIndex = 28;
            this.lb_OKATD.Text = "ОКАТО";
            // 
            // lb_INDEX_R
            // 
            this.lb_INDEX_R.AutoSize = true;
            this.lb_INDEX_R.Location = new System.Drawing.Point(115, 194);
            this.lb_INDEX_R.Name = "lb_INDEX_R";
            this.lb_INDEX_R.Size = new System.Drawing.Size(43, 13);
            this.lb_INDEX_R.TabIndex = 29;
            this.lb_INDEX_R.Text = "000000";
            // 
            // lb_GNI_R
            // 
            this.lb_GNI_R.AutoSize = true;
            this.lb_GNI_R.Location = new System.Drawing.Point(264, 194);
            this.lb_GNI_R.Name = "lb_GNI_R";
            this.lb_GNI_R.Size = new System.Drawing.Size(31, 13);
            this.lb_GNI_R.TabIndex = 30;
            this.lb_GNI_R.Text = "0000";
            // 
            // lb_OCATD_R
            // 
            this.lb_OCATD_R.AutoSize = true;
            this.lb_OCATD_R.Location = new System.Drawing.Point(392, 193);
            this.lb_OCATD_R.Name = "lb_OCATD_R";
            this.lb_OCATD_R.Size = new System.Drawing.Size(73, 13);
            this.lb_OCATD_R.TabIndex = 31;
            this.lb_OCATD_R.Text = "00000000000";
            // 
            // tb_REGION_SOCR
            // 
            this.tb_REGION_SOCR.Location = new System.Drawing.Point(328, 31);
            this.tb_REGION_SOCR.Name = "tb_REGION_SOCR";
            this.tb_REGION_SOCR.Size = new System.Drawing.Size(32, 20);
            this.tb_REGION_SOCR.TabIndex = 32;
            // 
            // tb_RAYON_SOCR
            // 
            this.tb_RAYON_SOCR.Location = new System.Drawing.Point(328, 57);
            this.tb_RAYON_SOCR.Name = "tb_RAYON_SOCR";
            this.tb_RAYON_SOCR.Size = new System.Drawing.Size(32, 20);
            this.tb_RAYON_SOCR.TabIndex = 33;
            // 
            // tb_GOROD_SOCR
            // 
            this.tb_GOROD_SOCR.Location = new System.Drawing.Point(328, 83);
            this.tb_GOROD_SOCR.Name = "tb_GOROD_SOCR";
            this.tb_GOROD_SOCR.Size = new System.Drawing.Size(32, 20);
            this.tb_GOROD_SOCR.TabIndex = 34;
            // 
            // tb_NASPUNKT_SOCR
            // 
            this.tb_NASPUNKT_SOCR.Location = new System.Drawing.Point(328, 110);
            this.tb_NASPUNKT_SOCR.Name = "tb_NASPUNKT_SOCR";
            this.tb_NASPUNKT_SOCR.Size = new System.Drawing.Size(32, 20);
            this.tb_NASPUNKT_SOCR.TabIndex = 35;
            // 
            // tb_ULICA_SOCR
            // 
            this.tb_ULICA_SOCR.Location = new System.Drawing.Point(328, 136);
            this.tb_ULICA_SOCR.Name = "tb_ULICA_SOCR";
            this.tb_ULICA_SOCR.Size = new System.Drawing.Size(32, 20);
            this.tb_ULICA_SOCR.TabIndex = 36;
            // 
            // tb_DOM_SOCR
            // 
            this.tb_DOM_SOCR.Location = new System.Drawing.Point(328, 162);
            this.tb_DOM_SOCR.Name = "tb_DOM_SOCR";
            this.tb_DOM_SOCR.Size = new System.Drawing.Size(32, 20);
            this.tb_DOM_SOCR.TabIndex = 37;
            // 
            // tb_db_Location
            // 
            this.tb_db_Location.Location = new System.Drawing.Point(615, 31);
            this.tb_db_Location.Name = "tb_db_Location";
            this.tb_db_Location.Size = new System.Drawing.Size(144, 20);
            this.tb_db_Location.TabIndex = 38;
            this.toolTip1.SetToolTip(this.tb_db_Location, "Кликните поле для выбора папки с  файлами БД КЛАДР");
            this.tb_db_Location.Click += new System.EventHandler(this.tb_db_Location_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммуToolStripMenuItem,
            this.лицензияToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.оПрограммеToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммуToolStripMenuItem
            // 
            this.оПрограммуToolStripMenuItem.Name = "оПрограммуToolStripMenuItem";
            this.оПрограммуToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.оПрограммуToolStripMenuItem.Text = "О программe";
            this.оПрограммуToolStripMenuItem.Click += new System.EventHandler(this.оПрограммуToolStripMenuItem_Click);
            // 
            // лицензияToolStripMenuItem
            // 
            this.лицензияToolStripMenuItem.Name = "лицензияToolStripMenuItem";
            this.лицензияToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.лицензияToolStripMenuItem.Text = "Лицензия";
            this.лицензияToolStripMenuItem.Click += new System.EventHandler(this.лицензияToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 630);
            this.Controls.Add(this.tb_db_Location);
            this.Controls.Add(this.tb_DOM_SOCR);
            this.Controls.Add(this.tb_ULICA_SOCR);
            this.Controls.Add(this.tb_NASPUNKT_SOCR);
            this.Controls.Add(this.tb_GOROD_SOCR);
            this.Controls.Add(this.tb_RAYON_SOCR);
            this.Controls.Add(this.tb_REGION_SOCR);
            this.Controls.Add(this.lb_OCATD_R);
            this.Controls.Add(this.lb_GNI_R);
            this.Controls.Add(this.lb_INDEX_R);
            this.Controls.Add(this.lb_OKATD);
            this.Controls.Add(this.lb_GNI);
            this.Controls.Add(this.lb_INDEX);
            this.Controls.Add(this.lb_count_rows);
            this.Controls.Add(this.tb_NASPUNKT_SKR);
            this.Controls.Add(this.lb_NASPUNKT);
            this.Controls.Add(this.tb_NASPUNKT);
            this.Controls.Add(this.tb_DOM_SKR);
            this.Controls.Add(this.lb_DOM);
            this.Controls.Add(this.tb_DOM);
            this.Controls.Add(this.tb_ULICA_SKR);
            this.Controls.Add(this.tb_GOROD_SKR);
            this.Controls.Add(this.tb_RAYON_SKR);
            this.Controls.Add(this.tb_REGION_SKR);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.lb_ULICA);
            this.Controls.Add(this.tb_ULICA);
            this.Controls.Add(this.tb_GOROD);
            this.Controls.Add(this.lb_GOROD);
            this.Controls.Add(this.lb_RAYON);
            this.Controls.Add(this.lb_REGION);
            this.Controls.Add(this.tb_RAYON);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.status_Connection);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tb_REGION);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Simple KLADR (Работа с БД Кладр)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_REGION;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label status_Connection;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_RAYON;
        private System.Windows.Forms.Label lb_REGION;
        private System.Windows.Forms.Label lb_RAYON;
        private System.Windows.Forms.Label lb_GOROD;
        private System.Windows.Forms.TextBox tb_GOROD;
        private System.Windows.Forms.TextBox tb_ULICA;
        private System.Windows.Forms.Label lb_ULICA;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.TextBox tb_REGION_SKR;
        private System.Windows.Forms.TextBox tb_RAYON_SKR;
        private System.Windows.Forms.TextBox tb_GOROD_SKR;
        private System.Windows.Forms.TextBox tb_ULICA_SKR;
        private System.Windows.Forms.TextBox tb_DOM;
        private System.Windows.Forms.Label lb_DOM;
        private System.Windows.Forms.TextBox tb_DOM_SKR;
        private System.Windows.Forms.TextBox tb_NASPUNKT;
        private System.Windows.Forms.Label lb_NASPUNKT;
        private System.Windows.Forms.TextBox tb_NASPUNKT_SKR;
        private System.Windows.Forms.Label lb_count_rows;
        private System.Windows.Forms.Label lb_INDEX;
        private System.Windows.Forms.Label lb_GNI;
        private System.Windows.Forms.Label lb_OKATD;
        private System.Windows.Forms.Label lb_INDEX_R;
        protected internal System.Windows.Forms.Label lb_GNI_R;
        private System.Windows.Forms.Label lb_OCATD_R;
        private System.Windows.Forms.TextBox tb_REGION_SOCR;
        private System.Windows.Forms.TextBox tb_RAYON_SOCR;
        private System.Windows.Forms.TextBox tb_GOROD_SOCR;
        private System.Windows.Forms.TextBox tb_NASPUNKT_SOCR;
        private System.Windows.Forms.TextBox tb_ULICA_SOCR;
        private System.Windows.Forms.TextBox tb_DOM_SOCR;
        private System.Windows.Forms.TextBox tb_db_Location;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лицензияToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

