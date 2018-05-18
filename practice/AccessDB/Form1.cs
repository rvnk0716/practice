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
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AccessDB
{
    public partial class Form1 : Form
    {
        BindingSource BindingSource1;
        public Form1()
        {
            InitializeComponent();
            BindingSource1 = new BindingSource();
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            //第一步：設定連線字串
            String strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=company.accdb";

            //第二步：建立資料庫連線物件
            OleDbConnection cn = new OleDbConnection(strConnectionString);

            //第三步：開啟資料庫連線
            cn.Open();

            //第四步：取得資料並填入 DataSet
            OleDbDataAdapter oleda = new OleDbDataAdapter("SELECT * FROM 客戶", cn);
            DataSet ds = new DataSet("ds_客戶");
            oleda.Fill(ds, "ds_客戶");

            //第五步：設定 DataSource
            BindingSource1.DataSource = ds.Tables[0];
            DataGridView1.DataSource = BindingSource1;
            BindingNavigator1.BindingSource = BindingSource1;

            //第六步：關閉資料庫連線
            cn.Close();
        }

        private void btnAccessInsert_Click(object sender, EventArgs e)
        {
            //第一步：設定連線字串
            String strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=company.accdb";

            //第二步：建立資料庫連線物件
            OleDbConnection cn = new OleDbConnection(strConnectionString);

            //第三步：開啟資料庫連線
            cn.Open();

            //★ 第四步：利用 OleDbCommand 執行 SQL 語法
            String strSQL = "INSERT INTO 客戶(客戶編號,公司名稱,連絡人) VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";

            OleDbCommand cmdLiming = new OleDbCommand(strSQL, cn);
            cmdLiming.ExecuteNonQuery();

            //第五步：取得資料並填入 DataSet
            OleDbDataAdapter oleda = new OleDbDataAdapter("SELECT * FROM 客戶", cn);
            DataSet ds = new DataSet("ds_客戶");
            oleda.Fill(ds, "ds_客戶");

            //第六步：設定 DataSource
            BindingSource1.DataSource = ds.Tables[0];
            DataGridView1.DataSource = BindingSource1;
            BindingNavigator1.BindingSource = BindingSource1;

            //第七步：關閉資料庫連線
            cn.Close();

            MessageBox.Show("Insert successfully");
            DataGridView1.CurrentCell = DataGridView1.Rows[DataGridView1.RowCount - 2].Cells[0];
            DataGridView1.Rows[DataGridView1.CurrentRow.Index].Selected = true;
        }

        private void btnAccessUpdate_Click(object sender, EventArgs e)
        {
            //第一步：設定連線字串
            String strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=company.accdb";

            //第二步：建立資料庫連線物件
            OleDbConnection cn = new OleDbConnection(strConnectionString);

            //第三步：開啟資料庫連線
            cn.Open();

            //★ 第四步：利用 OleDbCommand 執行 SQL 語法
            String strSQL = "UPDATE 客戶 SET 公司名稱='" + txtUpdate_Name.Text + "', 連絡人='" + txtUpdate_Contact.Text + "' WHERE 客戶編號='" + txtUpdate_NO.Text + "'";

            OleDbCommand cmdLiming = new OleDbCommand(strSQL, cn);
            cmdLiming.ExecuteNonQuery();

            //第五步：取得資料並填入 DataSet
            OleDbDataAdapter oleda = new OleDbDataAdapter("SELECT * FROM 客戶", cn);
            DataSet ds = new DataSet("ds_客戶");
            oleda.Fill(ds, "ds_客戶");

            //第六步：設定 DataSource
            BindingSource1.DataSource = ds.Tables[0];
            DataGridView1.DataSource = BindingSource1;
            BindingNavigator1.BindingSource = BindingSource1;

            //第七步：關閉資料庫連線
            cn.Close();

            MessageBox.Show("Update successfully");
            DataGridView1.CurrentCell = DataGridView1.Rows[DataGridView1.RowCount - 2].Cells[0];
        
        }

        private void btnAccessDelete_Click(object sender, EventArgs e)
        {
            //第一步：設定連線字串
            String strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=company.accdb";

            //第二步：建立資料庫連線物件
            OleDbConnection cn = new OleDbConnection(strConnectionString);

            //第三步：開啟資料庫連線
            cn.Open();

            //★ 第四步：利用 OleDbCommand 執行 SQL 語法
            String strSQL = "DELETE FROM 客戶 WHERE 客戶編號='" + txtDelete_NO.Text + "'";

            OleDbCommand cmdLiming = new OleDbCommand(strSQL, cn);
            cmdLiming.ExecuteNonQuery();
            //第五步：取得資料並填入 DataSet
            OleDbDataAdapter oleda = new OleDbDataAdapter("SELECT * FROM 客戶", cn);
            DataSet ds = new DataSet("ds_客戶");
            oleda.Fill(ds, "ds_客戶");

            //第六步：設定 DataSource
            BindingSource1.DataSource = ds.Tables[0];
            DataGridView1.DataSource = BindingSource1;
            BindingNavigator1.BindingSource = BindingSource1;

            //第七步：關閉資料庫連線
            cn.Close();

            MessageBox.Show("Delete successfully");
            DataGridView1.CurrentCell = DataGridView1.Rows[DataGridView1.RowCount - 2].Cells[0];
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try 
            { 
                int selected_row = DataGridView1.CurrentRow.Index;
                txtUpdate_NO.Text = DataGridView1.Rows[selected_row].Cells[0].FormattedValue.ToString();
                txtUpdate_Name.Text = DataGridView1.Rows[selected_row].Cells[1].FormattedValue.ToString();
                txtUpdate_Contact.Text = DataGridView1.Rows[selected_row].Cells[2].FormattedValue.ToString();

                txtDelete_NO.Text = DataGridView1.Rows[selected_row].Cells[0].FormattedValue.ToString();
            }
            catch (Exception ee) 
            {
                txtUpdate_NO.Text = "";
                txtUpdate_Name.Text = "";
                txtUpdate_Contact.Text = "";

                txtDelete_NO.Text = "";            
            }
        }

        private void btnAccessQuery_Click(object sender, EventArgs e)
        {
            //第一步：設定連線字串
            String strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=company.accdb";

            //第二步：建立資料庫連線物件
            OleDbConnection cn = new OleDbConnection(strConnectionString);

            //第三步：開啟資料庫連線
            cn.Open();

            //★ 第四步：利用 OleDbCommand 執行 SQL 語法
            String sql = "SELECT * FROM 客戶 WHERE ";
            
            if(TextBox4.Text!=""||TextBox5.Text!="")
            {
                if(TextBox4.Text == "")
                {sql+="連絡人 like '" + TextBox5.Text + "'";}
                else if(TextBox5.Text == "")
                {sql+="客戶編號 like '" + TextBox4.Text + "'";}
                else if(TextBox4.Text != "" && TextBox5.Text != "")
                {
                    sql += "客戶編號 like '" + TextBox4.Text + "'";
                    sql += " and ";
                    sql += "連絡人 like '" + TextBox5.Text + "'";
                }
            }

            //第五步：取得資料並填入 DataSet
            OleDbDataAdapter oleda = new OleDbDataAdapter(sql, cn);
            DataSet ds = new DataSet("ds_客戶");
            oleda.Fill(ds, "ds_客戶");

            //第六步：設定 DataSource
            BindingSource1.DataSource = ds.Tables[0];
            DataGridView1.DataSource = BindingSource1;
            BindingNavigator1.BindingSource = BindingSource1;

            //第七步：關閉資料庫連線
            cn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Paint(object sender, PaintEventArgs e)
        {
            Rectangle Rtg_LT = new Rectangle();
            Rectangle Rtg_RT = new Rectangle();
            Rectangle Rtg_LB = new Rectangle();
            Rectangle Rtg_RB = new Rectangle();
            Rtg_LT.X = 0; Rtg_LT.Y = 7; Rtg_LT.Width = 10; Rtg_LT.Height = 10;
            Rtg_RT.X = e.ClipRectangle.Width - 11; Rtg_RT.Y = 7; Rtg_RT.Width = 10; Rtg_RT.Height = 10;
            Rtg_LB.X = 0; Rtg_LB.Y = e.ClipRectangle.Height - 11; Rtg_LB.Width = 10; Rtg_LB.Height = 10;
            Rtg_RB.X = e.ClipRectangle.Width - 11; Rtg_RB.Y = e.ClipRectangle.Height - 11; Rtg_RB.Width = 10; Rtg_RB.Height = 10;

            Color color = Color.FromArgb(51, 94, 168);
            Pen Pen_AL = new Pen(color, 1);
            Pen_AL.Color = color;
            Brush brush = new HatchBrush(HatchStyle.Divot, color);

            e.Graphics.DrawString(GroupBox2.Text, GroupBox2.Font, brush, 6, 0);
            e.Graphics.DrawArc(Pen_AL, Rtg_LT, 180, 90);
            e.Graphics.DrawArc(Pen_AL, Rtg_RT, 270, 90);
            e.Graphics.DrawArc(Pen_AL, Rtg_LB, 90, 90);
            e.Graphics.DrawArc(Pen_AL, Rtg_RB, 0, 90);
            e.Graphics.DrawLine(Pen_AL, 5, 7, 6, 7);
            e.Graphics.DrawLine(Pen_AL, e.Graphics.MeasureString(GroupBox2.Text, GroupBox2.Font).Width + 3, 7, e.ClipRectangle.Width - 7, 7);
            e.Graphics.DrawLine(Pen_AL, 0, 13, 0, e.ClipRectangle.Height - 7);
            e.Graphics.DrawLine(Pen_AL, 6, e.ClipRectangle.Height - 1, e.ClipRectangle.Width - 7, e.ClipRectangle.Height - 1);
            e.Graphics.DrawLine(Pen_AL, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 7, e.ClipRectangle.Width - 1, 13);
        }
    }
}
