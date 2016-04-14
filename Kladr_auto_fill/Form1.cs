using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
//using System.Data.SQLite;
using System.Data.SqlClient;


namespace Kladr_auto_fill
{
    public partial class Form1 : Form
    {
        OleDbConnection ConnectionString = new OleDbConnection();
        DataSet ds;
        OleDbDataAdapter adapter_OLEDB;
       // FolderBrowserDialog fbd = new FolderBrowserDialog();
       // OpenFileDialog ofd = new OpenFileDialog();
        string region;
        string rayon;
        string gorod;
        string ulica;
        string dom;
        public Form1()
        {
            InitializeComponent();
        }
         OleDbConnection Con = new OleDbConnection();

        private void button1_Click(object sender, EventArgs e)
        {
            tb_REGION.Text = "";
            tb_RAYON.Text = "";
            tb_GOROD.Text = "";
            tb_ULICA.Text = "";
            tb_REGION_SKR.Text = "";
            tb_RAYON_SKR.Text = "";
            tb_GOROD_SKR.Text = "";
          //  tb_ULICA_SKR.Text = "";
            richTextBox1.Text = "";

            ConnectionString = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\\BASE_KLADR; Extended Properties=DBASE IV");
           ConnectionString.Open();
           status_Connection.Text = "Connected";

        }

          private void btn_DISCONNECT_Click(object sender, EventArgs e)
        {
            if (status_Connection.Text == "БД отключена")
            {
                MessageBox.Show("Не от чего отсоединяться!!!");
                return;
            }

            try
            {
                ConnectionString.Close();
                status_Connection.Text = "БД отключена";              
                dataGridView1.DataSource = null;            
            }
            catch (Exception ex) //блок отрображения ошибок, если есть
            {
                MessageBox.Show("Ошибка отсоединения БД: " + ex.Message);
            }
          }

         

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (status_Connection.Text != "Connected")
            {
              //  tb_REGION.Text = "";
                MessageBox.Show("Соединитесь с БД!!!");                
                return;
            }

          //  if (tb_REGION.Text.Length == 1)
          //  {
          //      tb_REGION.Text.ToUpper();
          //  }

            string SQL_String = "select * from kladr where kladr.name like '" + tb_REGION.Text + "%' and right(kladr.code,11)='00000000000'";
            OleDbCommand cmd = new OleDbCommand(SQL_String, ConnectionString);           
            adapter_OLEDB = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            adapter_OLEDB.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            if (dataGridView1.RowCount==1)
            { 
              MessageBox.Show("Некорректныей ввод данных");
              tb_REGION.Text = "";
              return;
            }
            richTextBox1.Text = " ";
            richTextBox1.AppendText(this.dataGridView1.CurrentRow.Cells[0].Value.ToString() + " ");
            richTextBox1.AppendText(this.dataGridView1.CurrentRow.Cells[1].Value.ToString());
            region = richTextBox1.Text;
            tb_REGION_SKR.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }          

        private void tb_RAYON_TextChanged_1(object sender, EventArgs e)
        {
            string reg = tb_REGION_SKR.Text.Remove(2);
          //  string check_rayon = tb_REGION_SKR.Text.Remove(5);
          //  string take_3 = check_rayon.Substring(2, 3);

          //  string SQL_String = "select * from kladr where kladr.code like '" + reg + "%' and SOCR='р-н' and kladr.name like '" + tb_RAYON.Text + "%'";
           // string SQL_String = "select * from kladr where kladr.code like '" + reg + "%' and '" + take_3 + "'!='000' and kladr.name like '" + tb_RAYON.Text + "%'";
            string SQL_String = "select * from kladr where kladr.code like '" + reg + "%' and kladr.code not like '" + reg + "000%' and right(kladr.code,8)='00000000' and kladr.status='0' and kladr.name like '" + tb_RAYON.Text + "%'";
          
            OleDbCommand cmd = new OleDbCommand(SQL_String, ConnectionString);           
            adapter_OLEDB = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            adapter_OLEDB.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            if (dataGridView1.RowCount == 1)
            {
                MessageBox.Show("Некорректныей ввод данных");
                tb_RAYON.Text = "";
                return;
            }       
            richTextBox1.Text = "";
            richTextBox1.AppendText(region +", " + this.dataGridView1.CurrentRow.Cells[0].Value.ToString() + " ");
            richTextBox1.AppendText(this.dataGridView1.CurrentRow.Cells[1].Value.ToString());
            rayon = richTextBox1.Text;
            tb_RAYON_SKR.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void tb_GOROD_TextChanged(object sender, EventArgs e)
        {
            if (tb_RAYON.Text == "")
            {
                string reg = tb_REGION_SKR.Text.Remove(2);
                
               // string SQL_String = "select * from kladr where kladr.code like '" + reg + "000%' and kladr.name like '" + tb_GOROD.Text + "%'";
              
                string SQL_String = "select * from kladr where (kladr.code like '" + reg + "000%' or (kladr.code like '" + reg + "%' and kladr.status='1')) and kladr.name like '" + tb_GOROD.Text + "%'";
               
                
                OleDbCommand cmd = new OleDbCommand(SQL_String, ConnectionString);
                adapter_OLEDB = new OleDbDataAdapter(cmd);
                ds = new DataSet();
                adapter_OLEDB.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                if (dataGridView1.RowCount == 1)
                {
                    MessageBox.Show("Некорректныей ввод данных");
                    tb_GOROD.Text = "";
                    return;
                }
                richTextBox1.Text = "";
                richTextBox1.AppendText(region+", " + ", " + this.dataGridView1.CurrentRow.Cells[0].Value.ToString() + " ");
                richTextBox1.AppendText(this.dataGridView1.CurrentRow.Cells[1].Value.ToString());
                gorod = richTextBox1.Text;
                tb_GOROD_SKR.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                string reg = tb_RAYON_SKR.Text.Remove(5);

              //  string SQL_String = "select * from kladr where (kladr.code like '" + reg + "000%' or (kladr.code like '" + reg +"%' and kladr.status='1')) and kladr.name like '" + tb_GOROD.Text + "%'";
                string SQL_String = "select * from kladr where kladr.code like '" + reg + "000%' and kladr.name like '" + tb_GOROD.Text + "%'";

                OleDbCommand cmd = new OleDbCommand(SQL_String, ConnectionString);
                adapter_OLEDB = new OleDbDataAdapter(cmd);
                ds = new DataSet();
                adapter_OLEDB.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                if (dataGridView1.RowCount == 1)
                {
                    MessageBox.Show("Некорректныей ввод данных");
                    tb_GOROD.Text = "";
                    return;
                }
                richTextBox1.Text = "";
                richTextBox1.AppendText(rayon + ", " + this.dataGridView1.CurrentRow.Cells[0].Value.ToString() + " ");
                richTextBox1.AppendText(this.dataGridView1.CurrentRow.Cells[1].Value.ToString());
                gorod = richTextBox1.Text;
                tb_GOROD_SKR.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void tb_NASPUNKT_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void tb_ULICA_TextChanged(object sender, EventArgs e)
        {
            string reg = tb_GOROD_SKR.Text.Remove(11);

            // string SQL_String = "select * from kladr where kladr.code like '" + reg + "000%' and kladr.name like '" + tb_GOROD.Text + "%'";

           // string SQL_String = "select * from kladr where (kladr.code like '" + reg + "000%' or (kladr.code like '" + reg + "%' and kladr.status='1')) and kladr.name like '" + tb_GOROD.Text + "%'";

           // string SQL_String = "select s.name, s.socr, s.code from kladr k, street s  where left(k.code,11)=left(s.code,11) and k.code like '"+ reg + "%'  and s.name like '" + tb_ULICA.Text + "%'";

            string SQL_String = "select s.name, s.socr, s.code from  street s where s.code like '" + reg + "%'  and s.name like '" + tb_ULICA.Text + "%'";


            OleDbCommand cmd = new OleDbCommand(SQL_String, ConnectionString);
            adapter_OLEDB = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            adapter_OLEDB.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            if (dataGridView1.RowCount == 1)
            {
                MessageBox.Show("Некорректныей ввод данных");
                tb_GOROD.Text = "";
                return;
            }
            richTextBox1.Text = "";
            richTextBox1.AppendText(gorod + ", " + this.dataGridView1.CurrentRow.Cells[0].Value.ToString() + " ");
            richTextBox1.AppendText(this.dataGridView1.CurrentRow.Cells[1].Value.ToString());
            ulica = richTextBox1.Text;
            tb_ULICA_SKR.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

       

        private void tb_DOM_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}