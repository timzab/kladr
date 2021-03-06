﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Simple_KLADR
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        OleDbConnection ConnectionString;      
        DataSet ds;
        OleDbDataAdapter adapter_OLEDB;     
      
        string index ="";
        string region = "";
        string reg = "";
        string rayon = "";
        string gorod = "";
        string nas_punkt = "";
        string ulica = "";
        string dom = "";
        int counter;
        string SQL_String;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (tb_db_Location.Text == "") //проверка заполнения поля формы
            {
                tb_db_Location.Focus();
                MessageBox.Show("Введите путь к папке с файлами БД!!!");
                return;
            }
            try
            {
                ConnectionString = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + tb_db_Location.Text + "; Extended Properties=DBASE IV");

                clear_func();
                dataGridView1.DataSource = null;

                if (ConnectionString.State == ConnectionState.Open)
                {
                    ConnectionString.Close();
                }

                ConnectionString.Open();


                SQL_String = "select top 1 * from Kladr"; //Проверка, есть ли в папке  файл с Кладр?
                connection_func();
                ConnectionString.Close();
                dataGridView1.DataSource = null;
       
                status_Connection.Text = "Connected"; //если есть - Connected, если нет переходим к обработке ошибки.
                tb_db_Location.Enabled = false;
                btn_Connect.Enabled = false;
                btn_Disconnect.Enabled = true;
            }
            catch (Exception ex) //блок отрображения ошибок, если есть
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            if (status_Connection.Text == "БД отключена")
            {
                MessageBox.Show("Не от чего отсоединяться!!!");
                return;
            }

            try
            {
                clear_func();
                tb_db_Location.Enabled = true; 
                dataGridView1.DataSource = null;
                ConnectionString.Close();
                btn_Connect.Enabled = true;
                btn_Disconnect.Enabled = false;
                status_Connection.Text = "БД отключена!";
            }

            catch (Exception ex) //блок отрображения ошибок, если есть
            {
                MessageBox.Show("Ошибка отсоединения БД: " + ex.Message);
            }
        }

        //*****************************Region             
        private void tb_REGION_Click(object sender, EventArgs e)
        {
            if (status_Connection.Text != "Connected")
            {
                MessageBox.Show("Соединитесь с БД!!!");
                return;
            }

            SQL_String = "select name, socr, code from kladr where right(kladr.code,11)='00000000000'";

            connection_func();

            if (dataGridView1.RowCount == 1)
            {
                MessageBox.Show("Некорректныей ввод данных");
                tb_REGION.Text = "";
                return;
            }

            lb_count_rows.Text = "Найдено " + (dataGridView1.RowCount - 1).ToString() + " строк(и)";
            counter = 1;
        }

        //******************************Rayon
        private void tb_RAYON_Click(object sender, EventArgs e)
        {
            reg = tb_REGION_SKR.Text.Remove(2);
            SQL_String = "select * from kladr where kladr.code like '" + reg
            + "%' and kladr.code not like '" + reg
            + "000%' and right(kladr.code,8)='00000000' and kladr.status='0'";

            connection_func();

            if (dataGridView1.RowCount == 1)
            {
                MessageBox.Show("Некорректныей ввод данных");
                tb_RAYON.Text = "";
                return;
            }

            lb_count_rows.Text = "Найдено " + (dataGridView1.RowCount - 1).ToString() + " строк(и)";
            counter = 2;
        }

        //*****************************Gorod
        private void tb_GOROD_Click(object sender, EventArgs e)
        {
            if (tb_RAYON.Text == "") //Город не районного подчинения
            {
                reg = tb_REGION_SKR.Text.Remove(2);

                SQL_String = "select * from kladr where (kladr.code like '" + reg
                + "000%' or (kladr.code like '" + reg + "%' and kladr.status='1')) and kladr.code not like '"
                + tb_REGION_SKR.Text + "' and kladr.name like '"
                + tb_GOROD.Text + "%' and right(kladr.code,5)='00000'";

                connection_func();

                if (dataGridView1.RowCount == 1)
                {
                    MessageBox.Show("Некорректныей ввод данных");
                    tb_GOROD.Text = "";
                    return;
                }
            }

            else
            {
                reg = tb_RAYON_SKR.Text.Remove(5); //город районного подчинения

                SQL_String = "select * from kladr where kladr.code like '" + reg
                + "%' and kladr.status='0' and kladr.code not like '"
                + tb_RAYON_SKR.Text + "'  and kladr.name like '"
                + tb_GOROD.Text + "%' and right(kladr.code,5)='00000'";

                connection_func();

                if (dataGridView1.RowCount == 1)
                {
                    MessageBox.Show("Некорректныей ввод данных");
                    tb_GOROD.Text = "";
                    return;
                }
            }

            lb_count_rows.Text = "Найдено " + (dataGridView1.RowCount - 1).ToString() + " строк(и)";
            counter = 3;
        }

        //***********************Nas Punkt
        private void tb_NASPUNKT_Click(object sender, EventArgs e)
        {
            if (tb_RAYON.Text == "" & tb_GOROD.Text == "") //для Москвы и федеральных городов
            {
                reg = tb_REGION_SKR.Text.Remove(2);

                SQL_String = "select * from kladr where kladr.code like '" + reg
                + "000000%'  and kladr.code not like '"
                + tb_REGION_SKR.Text + "' and kladr.name like '"
                + tb_NASPUNKT.Text + "%' and right(kladr.code,2)='00'";

                connection_func();
            }

            else if (tb_RAYON.Text != "" & tb_GOROD.Text == "") // для регионов с районным делением
            {
                reg = tb_RAYON_SKR.Text.Remove(5);

                SQL_String = "select * from kladr where kladr.code like '" + reg
                + "%'  and kladr.code not like '"
                + tb_RAYON_SKR.Text + "%'  and kladr.name like '"
                + tb_NASPUNKT.Text + "%' and right(kladr.code,2)='00'";

                connection_func();
            }
            else if (tb_RAYON.Text == "" & tb_GOROD.Text != "") // для городов  с подчиненными населенными пунктами
            {
                reg = tb_GOROD_SKR.Text.Remove(8);

                SQL_String = "select * from kladr where kladr.code like '" + reg
                + "%'  and kladr.code not like '"
                + tb_GOROD_SKR.Text + "%' and kladr.name like '"
                + tb_NASPUNKT.Text + "%' and right(kladr.code,2)='00'";

                connection_func();
            }

            if (dataGridView1.RowCount == 1)
            {
                tb_NASPUNKT.Enabled = false;
                tb_NASPUNKT_SOCR.Enabled = false;
                tb_NASPUNKT_SKR.Enabled = false;
            }

            lb_count_rows.Text = "Найдено " + (dataGridView1.RowCount - 1).ToString() + " строк(и)";
            counter = 4;
        }

        //***************************Ulica        
        private void tb_ULICA_Click(object sender, EventArgs e)
        {
            if (tb_NASPUNKT.Text != "")//для регионов с районным делением
            {
                reg = tb_NASPUNKT_SKR.Text.Remove(11);

                SQL_String = "select * from  street s where s.code like '" + reg
                + "%'  and s.name like '"
                + tb_ULICA.Text + "%'  and right(s.code,2)='00'";

                connection_func();

                if (dataGridView1.RowCount == 1)
                {
                    tb_ULICA.Enabled = false;
                    tb_ULICA_SOCR.Enabled = false;
                    tb_ULICA_SKR.Enabled = false;
                    tb_DOM.Enabled = false;
                    tb_DOM_SOCR.Enabled = false;
                    tb_DOM_SKR.Enabled = false;
                }
            }

            else if (tb_NASPUNKT.Text == "" & tb_GOROD.Text != "")//для городов не входящих в районы
            {
                reg = tb_GOROD_SKR.Text.Remove(11);

                SQL_String = "select * from  street s where s.code like '" + reg + "%'  and s.name like '" + tb_ULICA.Text + "%' and right(s.code,2)='00'";

                connection_func();

                if (dataGridView1.RowCount == 1)
                {
                    tb_ULICA.Enabled = false;
                    tb_ULICA_SOCR.Enabled = false;
                    tb_ULICA_SKR.Enabled = false;
                    tb_DOM.Enabled = false;
                    tb_DOM_SOCR.Enabled = false;
                    tb_DOM_SKR.Enabled = false;
                }
            }

            else if (tb_RAYON.Text == "" && tb_GOROD.Text == "" && tb_NASPUNKT.Text == "") //для Москвы и городов Федерального значения
            {
                reg = tb_REGION_SKR.Text.Remove(11);

                SQL_String = "select * from  street s where s.code like '"
                + reg + "%'  and s.name like '"
                + tb_ULICA.Text + "%' and right(s.code, 2)= '00'";

                connection_func();

                if (dataGridView1.RowCount == 1)
                {
                    tb_ULICA.Enabled = false;
                    tb_ULICA_SOCR.Enabled = false;
                    tb_ULICA_SKR.Enabled = false;
                    tb_DOM.Enabled = false;
                    tb_DOM_SOCR.Enabled = false;
                    tb_DOM_SKR.Enabled = false;
                }
            }

            lb_count_rows.Text = "Найдено " + (dataGridView1.RowCount - 1).ToString() + " строк(и)";
            counter = 5;
        }

        //***************************Dom  
        private void tb_DOM_Click(object sender, EventArgs e)
        {
            reg = tb_ULICA_SKR.Text;


            SQL_String = "select d.name, d.KORP, d.socr, d.code, d.INDEX, d.GNINMB, d.OCATD from  doma d where d.code like '"
            + reg + "%'  and d.name like '"
            + tb_DOM.Text + "%'";

            connection_func();

            if (dataGridView1.RowCount == 1)
            {
                tb_DOM.Enabled = false;
                tb_DOM_SOCR.Enabled = false;
                tb_DOM_SKR.Enabled = false;
                MessageBox.Show("Нет данных");
            }

            lb_count_rows.Text = "Найдено " + (dataGridView1.RowCount - 1).ToString() + " строк(и)";
            counter = 6;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) // запрет клика по заголовку таблицы
            { return; }
            var item = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            if (counter == 1)
            {
                clear_func();

                tb_REGION.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_REGION_SOCR.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_REGION_SKR.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                region = tb_REGION.Text + " " + tb_REGION_SOCR.Text;
                if (tb_REGION_SOCR.Text == "г")
                {
                    tb_RAYON.Enabled = false;
                    tb_RAYON_SOCR.Enabled = false;
                    tb_RAYON_SKR.Enabled = false;
                    tb_GOROD.Enabled = false;
                    tb_GOROD_SOCR.Enabled = false;
                    tb_GOROD_SKR.Enabled = false;
                }
                else
                {
                    tb_RAYON.Enabled = true;
                    tb_RAYON_SOCR.Enabled = true;
                    tb_RAYON_SKR.Enabled = true;
                    tb_GOROD.Enabled = true;
                    tb_GOROD_SOCR.Enabled = true;
                    tb_GOROD_SKR.Enabled = true;
                }
            }

            else if (counter == 2)
            {
                rayon = "";
                gorod = "";
                nas_punkt = "";
                ulica = "";
                dom = "";

                tb_RAYON.Text = "";
                tb_RAYON_SOCR.Text = "";
                tb_RAYON_SKR.Text = "";

                tb_GOROD.Text = "";
                tb_GOROD_SOCR.Text = "";
                tb_GOROD_SKR.Text = "";

                tb_NASPUNKT.Text = "";
                tb_NASPUNKT_SOCR.Text = "";
                tb_NASPUNKT_SKR.Text = "";

                tb_ULICA.Text = "";
                tb_ULICA_SOCR.Text = "";
                tb_ULICA_SKR.Text = "";

                tb_DOM.Text = "";
                tb_DOM_SOCR.Text = "";
                tb_DOM_SKR.Text = "";

                tb_RAYON.Enabled = true;
                tb_RAYON_SOCR.Enabled = true;
                tb_RAYON_SKR.Enabled = true;
                tb_GOROD.Enabled = true;
                tb_GOROD_SOCR.Enabled = true;
                tb_GOROD_SKR.Enabled = true;
                tb_NASPUNKT.Enabled = true;
                tb_NASPUNKT_SOCR.Enabled = true;
                tb_NASPUNKT_SKR.Enabled = true;
                tb_ULICA.Enabled = true;
                tb_ULICA_SOCR.Enabled = true;
                tb_ULICA_SKR.Enabled = true;
                tb_DOM.Enabled = true;
                tb_DOM_SOCR.Enabled = true;
                tb_DOM_SKR.Enabled = true;

                tb_RAYON.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_RAYON_SOCR.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_RAYON_SKR.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                rayon = tb_RAYON.Text + " " + tb_RAYON_SOCR.Text;
                tb_GOROD.Enabled = false;
                tb_GOROD_SOCR.Enabled = false;
                tb_GOROD_SKR.Enabled = false;
            }

            else if (counter == 3)
            {
                gorod = "";
                nas_punkt = "";
                ulica = "";
                dom = "";

                tb_GOROD.Text = "";
                tb_GOROD_SOCR.Text = "";
                tb_GOROD_SKR.Text = "";

                tb_NASPUNKT.Text = "";
                tb_NASPUNKT_SOCR.Text = "";
                tb_NASPUNKT_SKR.Text = "";

                tb_ULICA.Text = "";
                tb_ULICA_SOCR.Text = "";
                tb_ULICA_SKR.Text = "";

                tb_DOM.Text = "";
                tb_DOM_SOCR.Text = "";
                tb_DOM_SKR.Text = "";
           
                tb_GOROD.Enabled = true;
                tb_GOROD_SOCR.Enabled = true;
                tb_GOROD_SKR.Enabled = true;
                tb_NASPUNKT.Enabled = true;
                tb_NASPUNKT_SOCR.Enabled = true;
                tb_NASPUNKT_SKR.Enabled = true;
                tb_ULICA.Enabled = true;
                tb_ULICA_SOCR.Enabled = true;
                tb_ULICA_SKR.Enabled = true;
                tb_DOM.Enabled = true;
                tb_DOM_SOCR.Enabled = true;
                tb_DOM_SKR.Enabled = true;

                tb_GOROD.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_GOROD_SOCR.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_GOROD_SKR.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                gorod = tb_GOROD.Text + " " + tb_GOROD_SOCR.Text;             
            }

            else if (counter == 4)
            {
                nas_punkt = "";
                ulica = "";
                dom = "";

                tb_NASPUNKT.Text = "";
                tb_NASPUNKT_SOCR.Text = "";
                tb_NASPUNKT_SKR.Text = "";

                tb_ULICA.Text = "";
                tb_ULICA_SOCR.Text = "";
                tb_ULICA_SKR.Text = "";

                tb_DOM.Text = "";
                tb_DOM_SOCR.Text = "";
                tb_DOM_SKR.Text = "";
                               
                tb_NASPUNKT.Enabled = true;
                tb_NASPUNKT_SOCR.Enabled = true;
                tb_NASPUNKT_SKR.Enabled = true;
                tb_ULICA.Enabled = true;
                tb_ULICA_SOCR.Enabled = true;
                tb_ULICA_SKR.Enabled = true;
                tb_DOM.Enabled = true;
                tb_DOM_SOCR.Enabled = true;
                tb_DOM_SKR.Enabled = true;

                tb_NASPUNKT.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_NASPUNKT_SOCR.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_NASPUNKT_SKR.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                nas_punkt = tb_NASPUNKT.Text + " " + tb_NASPUNKT_SOCR.Text;
                lb_INDEX_R.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                lb_GNI_R.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                lb_OCATD_R.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                index = lb_INDEX_R.Text;
            }

            else if (counter == 5)
            {
                ulica = "";
                dom = "";       

                tb_DOM.Text = "";
                tb_DOM_SOCR.Text = "";
                tb_DOM_SKR.Text = "";
                               
                tb_ULICA.Enabled = true;
                tb_ULICA_SOCR.Enabled = true;
                tb_ULICA_SKR.Enabled = true;
                tb_DOM.Enabled = true;
                tb_DOM_SOCR.Enabled = true;
                tb_DOM_SKR.Enabled = true;

                tb_ULICA.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_ULICA_SOCR.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_ULICA_SKR.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                ulica = tb_ULICA.Text + " " + tb_ULICA_SOCR.Text;
                lb_INDEX_R.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                lb_GNI_R.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                lb_OCATD_R.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                index = lb_INDEX_R.Text;
            }

            else if (counter == 6)
            {
                dom = "";

                tb_DOM.Enabled = true;
                tb_DOM_SOCR.Enabled = true;
                tb_DOM_SKR.Enabled = true;

                tb_DOM.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_DOM_SOCR.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_DOM_SKR.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                dom = tb_DOM_SOCR.Text + " " + tb_DOM.Text;
                lb_INDEX_R.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                lb_GNI_R.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                lb_OCATD_R.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                index = lb_INDEX_R.Text;
            }

            richTextBox1.Text = index + ", " + region + ", " + rayon + ", " + gorod + ", " + nas_punkt + ", " + ulica + ", " + dom;
        }

        private void connection_func()
        {
            OleDbCommand cmd = new OleDbCommand(SQL_String, ConnectionString);
            adapter_OLEDB = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            adapter_OLEDB.Fill(ds);
            ConnectionString.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void clear_func()
        {
            region = "";
            reg = "";
            rayon = "";
            gorod = "";
            nas_punkt = "";
            ulica = "";
            dom = "";

            tb_REGION.Text = "";
            tb_REGION_SOCR.Text = "";
            tb_REGION_SKR.Text = "";

            tb_RAYON.Text = "";
            tb_RAYON_SOCR.Text = "";
            tb_RAYON_SKR.Text = "";

            tb_GOROD.Text = "";
            tb_GOROD_SOCR.Text = "";
            tb_GOROD_SKR.Text = "";

            tb_NASPUNKT.Text = "";
            tb_NASPUNKT_SOCR.Text = "";
            tb_NASPUNKT_SKR.Text = "";

            tb_ULICA.Text = "";
            tb_ULICA_SOCR.Text = "";
            tb_ULICA_SKR.Text = "";

            tb_DOM.Text = "";
            tb_DOM_SOCR.Text = "";
            tb_DOM_SKR.Text = "";

            richTextBox1.Text = "";

            lb_INDEX_R.Text = "";
            lb_GNI_R.Text = "";
            lb_OCATD_R.Text = "";
            lb_count_rows.Text = null;

            tb_REGION.Enabled = true;
            tb_REGION_SOCR.Enabled = true;
            tb_REGION_SKR.Enabled = true;
            tb_RAYON.Enabled = true;
            tb_RAYON_SOCR.Enabled = true;
            tb_RAYON_SKR.Enabled = true;
            tb_GOROD.Enabled = true;
            tb_GOROD_SOCR.Enabled = true;
            tb_GOROD_SKR.Enabled = true;
            tb_NASPUNKT.Enabled = true;
            tb_NASPUNKT_SOCR.Enabled = true;
            tb_NASPUNKT_SKR.Enabled = true;
            tb_ULICA.Enabled = true;
            tb_ULICA_SOCR.Enabled = true;
            tb_ULICA_SKR.Enabled = true;
            tb_DOM.Enabled = true;
            tb_DOM_SOCR.Enabled = true;
            tb_DOM_SKR.Enabled = true;
        }           

        private void tb_db_Location_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
              tb_db_Location.Text = "";                            
              tb_db_Location.AppendText(fbd.SelectedPath);
            //  string db_connectiom_path = tb_db_Location.Text;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void лицензияToolStripMenuItem_Click(object sender, EventArgs e)
        {
              MessageBox.Show("Программа предназанчена для свободного распостранения. При желании можно отблагодарить автора  -  WebMoney (cчет R623561216899, Z268001125501 или E164732259639) или Яндекс-деньги (счет 41001627136483).\n" +       
                             "C вопросами по работе программы, ее дорабоке или разработке новых программ можно писать на a_t_i@mail.ru", "Лицензионное соглашение");
        }

        private void оПрограммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Программа Simple KLADR предназначена для корректного заполнения адресов физических лиц при формировании налоговой отчетности или получения достоверного почтового адреса." +
                            "\n Программа может работать на любом компьютере с операционной средой Windows." +
                 "\n Для работы программы достаточно скачать архивный файл базы данных КЛАДР (BASE.arj) c сайта ГНИВЦ http://www.gnivc.ru/inf_provision/classifiers_reference/kladr/ и разархивировать его содержание в любую папку на вашем компьютерном диске.", "О программе");
        }   
    }
}