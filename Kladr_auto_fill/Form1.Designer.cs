﻿namespace Kladr_auto_fill
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
            this.tb_REGION = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.status_Connection = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_RAYON = new System.Windows.Forms.TextBox();
            this.lb_REGION = new System.Windows.Forms.Label();
            this.lb_RAYON = new System.Windows.Forms.Label();
            this.lb_GOROD = new System.Windows.Forms.Label();
            this.tb_GOROD = new System.Windows.Forms.TextBox();
            this.tb_ULICA = new System.Windows.Forms.TextBox();
            this.lb_ULICA = new System.Windows.Forms.Label();
            this.btn_DISCONNECT = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_REGION
            // 
            this.tb_REGION.Location = new System.Drawing.Point(122, 31);
            this.tb_REGION.Name = "tb_REGION";
            this.tb_REGION.Size = new System.Drawing.Size(236, 20);
            this.tb_REGION.TabIndex = 0;
            this.tb_REGION.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(61, 226);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(650, 34);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // status_Connection
            // 
            this.status_Connection.AutoSize = true;
            this.status_Connection.Location = new System.Drawing.Point(9, 669);
            this.status_Connection.Name = "status_Connection";
            this.status_Connection.Size = new System.Drawing.Size(80, 13);
            this.status_Connection.TabIndex = 2;
            this.status_Connection.Text = "БД отключена";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 379);
            this.dataGridView1.TabIndex = 4;
            // 
            // tb_RAYON
            // 
            this.tb_RAYON.Location = new System.Drawing.Point(122, 57);
            this.tb_RAYON.Name = "tb_RAYON";
            this.tb_RAYON.Size = new System.Drawing.Size(236, 20);
            this.tb_RAYON.TabIndex = 5;
            this.tb_RAYON.TextChanged += new System.EventHandler(this.tb_RAYON_TextChanged_1);
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
            this.tb_GOROD.Size = new System.Drawing.Size(236, 20);
            this.tb_GOROD.TabIndex = 9;
            this.tb_GOROD.TextChanged += new System.EventHandler(this.tb_GOROD_TextChanged);
            // 
            // tb_ULICA
            // 
            this.tb_ULICA.Location = new System.Drawing.Point(122, 136);
            this.tb_ULICA.Name = "tb_ULICA";
            this.tb_ULICA.Size = new System.Drawing.Size(236, 20);
            this.tb_ULICA.TabIndex = 10;
            this.tb_ULICA.TextChanged += new System.EventHandler(this.tb_ULICA_TextChanged);
            // 
            // lb_ULICA
            // 
            this.lb_ULICA.AutoSize = true;
            this.lb_ULICA.Location = new System.Drawing.Point(12, 134);
            this.lb_ULICA.Name = "lb_ULICA";
            this.lb_ULICA.Size = new System.Drawing.Size(39, 13);
            this.lb_ULICA.TabIndex = 11;
            this.lb_ULICA.Text = "Улица";
            // 
            // btn_DISCONNECT
            // 
            this.btn_DISCONNECT.Location = new System.Drawing.Point(400, 64);
            this.btn_DISCONNECT.Name = "btn_DISCONNECT";
            this.btn_DISCONNECT.Size = new System.Drawing.Size(75, 23);
            this.btn_DISCONNECT.TabIndex = 12;
            this.btn_DISCONNECT.Text = "Disconnect";
            this.btn_DISCONNECT.UseVisualStyleBackColor = true;
            this.btn_DISCONNECT.Click += new System.EventHandler(this.btn_DISCONNECT_Click);
            // 
            // tb_REGION_SKR
            // 
            this.tb_REGION_SKR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_REGION_SKR.Location = new System.Drawing.Point(547, 34);
            this.tb_REGION_SKR.Name = "tb_REGION_SKR";
            this.tb_REGION_SKR.Size = new System.Drawing.Size(164, 20);
            this.tb_REGION_SKR.TabIndex = 15;
            // 
            // tb_RAYON_SKR
            // 
            this.tb_RAYON_SKR.Location = new System.Drawing.Point(547, 60);
            this.tb_RAYON_SKR.Name = "tb_RAYON_SKR";
            this.tb_RAYON_SKR.Size = new System.Drawing.Size(164, 20);
            this.tb_RAYON_SKR.TabIndex = 16;
            // 
            // tb_GOROD_SKR
            // 
            this.tb_GOROD_SKR.Location = new System.Drawing.Point(547, 86);
            this.tb_GOROD_SKR.Name = "tb_GOROD_SKR";
            this.tb_GOROD_SKR.Size = new System.Drawing.Size(164, 20);
            this.tb_GOROD_SKR.TabIndex = 17;
            // 
            // tb_ULICA_SKR
            // 
            this.tb_ULICA_SKR.Location = new System.Drawing.Point(547, 136);
            this.tb_ULICA_SKR.Name = "tb_ULICA_SKR";
            this.tb_ULICA_SKR.Size = new System.Drawing.Size(164, 20);
            this.tb_ULICA_SKR.TabIndex = 18;
            // 
            // tb_DOM
            // 
            this.tb_DOM.Location = new System.Drawing.Point(122, 162);
            this.tb_DOM.Name = "tb_DOM";
            this.tb_DOM.Size = new System.Drawing.Size(236, 20);
            this.tb_DOM.TabIndex = 19;
            this.tb_DOM.TextChanged += new System.EventHandler(this.tb_DOM_TextChanged);
            // 
            // lb_DOM
            // 
            this.lb_DOM.AutoSize = true;
            this.lb_DOM.Location = new System.Drawing.Point(12, 157);
            this.lb_DOM.Name = "lb_DOM";
            this.lb_DOM.Size = new System.Drawing.Size(30, 13);
            this.lb_DOM.TabIndex = 20;
            this.lb_DOM.Text = "Дом";
            // 
            // tb_DOM_SKR
            // 
            this.tb_DOM_SKR.Location = new System.Drawing.Point(547, 162);
            this.tb_DOM_SKR.Name = "tb_DOM_SKR";
            this.tb_DOM_SKR.Size = new System.Drawing.Size(164, 20);
            this.tb_DOM_SKR.TabIndex = 21;
            this.tb_DOM_SKR.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_NASPUNKT
            // 
            this.tb_NASPUNKT.Location = new System.Drawing.Point(122, 110);
            this.tb_NASPUNKT.Name = "tb_NASPUNKT";
            this.tb_NASPUNKT.Size = new System.Drawing.Size(236, 20);
            this.tb_NASPUNKT.TabIndex = 22;
            // 
            // lb_NASPUNKT
            // 
            this.lb_NASPUNKT.AutoSize = true;
            this.lb_NASPUNKT.Location = new System.Drawing.Point(12, 110);
            this.lb_NASPUNKT.Name = "lb_NASPUNKT";
            this.lb_NASPUNKT.Size = new System.Drawing.Size(102, 13);
            this.lb_NASPUNKT.TabIndex = 23;
            this.lb_NASPUNKT.Text = "Населенный пункт";
            // 
            // tb_NASPUNKT_SKR
            // 
            this.tb_NASPUNKT_SKR.Location = new System.Drawing.Point(547, 110);
            this.tb_NASPUNKT_SKR.Name = "tb_NASPUNKT_SKR";
            this.tb_NASPUNKT_SKR.Size = new System.Drawing.Size(164, 20);
            this.tb_NASPUNKT_SKR.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 691);
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
            this.Controls.Add(this.btn_DISCONNECT);
            this.Controls.Add(this.lb_ULICA);
            this.Controls.Add(this.tb_ULICA);
            this.Controls.Add(this.tb_GOROD);
            this.Controls.Add(this.lb_GOROD);
            this.Controls.Add(this.lb_RAYON);
            this.Controls.Add(this.lb_REGION);
            this.Controls.Add(this.tb_RAYON);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.status_Connection);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tb_REGION);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_REGION;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label status_Connection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_RAYON;
        private System.Windows.Forms.Label lb_REGION;
        private System.Windows.Forms.Label lb_RAYON;
        private System.Windows.Forms.Label lb_GOROD;
        private System.Windows.Forms.TextBox tb_GOROD;
        private System.Windows.Forms.TextBox tb_ULICA;
        private System.Windows.Forms.Label lb_ULICA;
        private System.Windows.Forms.Button btn_DISCONNECT;
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
    }
}

