
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace OMMS
{
    public partial class frmProfitLoss : Form
    {
        SqlDataReader reader;
        DbAdapter db = new DbAdapter();
        Validation validate = new Validation();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        double totWeightCake = 0;
        double amountCake = 0;
        double totWeightSeed = 0;
        double totAmountSeed = 0;
        double totWeightOil = 0;
        double totAmountOil = 0;
        double totWeightDirtyOil = 0;
        double totAmountDirtyOil = 0;
        double expenceAmount = 0;
        double totSalary = 0;
        double totCarage = 0;
        public frmProfitLoss()
        {
            InitializeComponent();
        }
        private void Grid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            validate.DataGridSetColor2(Grid, Color.FromArgb(0, 152, 0));
            //validate.rowNumberMathod(e,Grid,this);
        }

        private void frmAccountLager_Load(object sender, EventArgs e)
        {
            Grid.RowTemplate.MinimumHeight = 30;
            getSeedData();
            GetCakeData();
            getOilData();
            getDirtyOilData();
            GetExpenceData();
            getSalaryData();
         
            FillGrid();
            getBalanceData();
        }

        private void getBalanceData()
        {
            try
            {
                double balance = 0;
                double debit = 0;
                double credit = 0;
                for (int i = 1; i <= 7; i++)
                {

                    balance = (Convert.ToDouble(Grid.Rows[i - 1].Cells[3].Value.ToString().Substring(0,Grid.Rows[i - 1].Cells[3].Value.ToString().Length-2)) + Convert.ToDouble(Grid.Rows[i].Cells[1].Value)) - Convert.ToDouble(Grid.Rows[i].Cells[2].Value);
                    if (balance > 0)
                    {
                        Grid.Rows[i].Cells[3].Value = String.Format("{0:0.00}", balance+"Dr");
                    }
                    else
                    {
                        Grid.Rows[i].Cells[3].Value = String.Format("{0:0.00}", balance + "Cr");
                    }
                    debit = debit + Convert.ToDouble(Grid.Rows[i].Cells[1].Value);
                    credit = credit + Convert.ToDouble(Grid.Rows[i].Cells[2].Value);
                    if (i % 2 != 0)
                    {
                        Grid.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
                txtCredit.Text = String.Format("{0:0.00}", credit);
                txtdebit.Text = String.Format("{0:0.00}", debit);
                txtBalnce.Text = String.Format("{0:0.00}", balance);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillGrid()
        {
            try
            {
                // Cotton Cake Amount
                Grid.Rows.Add();
                Grid.Rows[0].Cells[0].Value = "@ Opening Balance ";
                Grid.Rows[0].Cells[1].Value = 0;
                Grid.Rows[0].Cells[2].Value =  0;
                Grid.Rows[0].Cells[3].Value = 0+"OP";
                // Cotton Cake Amount
                Grid.Rows.Add();
                Grid.Rows[1].Cells[0].Value = "@ Cotton Cake @WT  " + totWeightCake + "Kg" + "  @Rate " + String.Format("{0:0.00}", amountCake / (totWeightCake / 37.324)) + " &Total Amount";
                Grid.Rows[1].Cells[1].Value = String.Format("{0:0.00}", amountCake);
                Grid.Rows[1].Cells[2].Value = "" + 0;
                // Cotton Oil Amount
                Grid.Rows.Add();
                Grid.Rows[2].Cells[0].Value = "@ Cotton Oil @WT  " + totWeightOil + "Kg" + "  @Rate " + String.Format("{0:0.00}", (totAmountOil / (totWeightOil / 37.324))) + " &Total Amount";
                Grid.Rows[2].Cells[1].Value = String.Format("{0:0.00}", totAmountOil);
                Grid.Rows[2].Cells[2].Value = "" + 0;
                // Cotton Dirty Oil Amount
                Grid.Rows.Add();
                Grid.Rows[3].Cells[0].Value = "@ Cotton Dirty Oil @WT  " + totWeightDirtyOil + "Kg" + "  @Rate " + String.Format("{0:0.00}", (totAmountDirtyOil / (totWeightDirtyOil / 40))) + " &Total Amount";
                Grid.Rows[3].Cells[1].Value = String.Format("{0:0.00}", totAmountDirtyOil);
                Grid.Rows[3].Cells[2].Value = "" + 0;
                // Cotton Seed Amount
                Grid.Rows.Add();
                Grid.Rows[4].Cells[0].Value = "@ Cotton Seed @WT  " + totWeightSeed + "Kg" + "  @Rate " + String.Format("{0:0.00}", (totAmountSeed / (totWeightSeed / 37.324))) + " &Total Amount";
                Grid.Rows[4].Cells[1].Value = "" + 0;
                Grid.Rows[4].Cells[2].Value = String.Format("{0:0.00}", totAmountSeed);
                //All Expence Amount 
                Grid.Rows.Add();
                Grid.Rows[5].Cells[0].Value = "@ All Expences";
                Grid.Rows[5].Cells[1].Value = "" + 0;
                Grid.Rows[5].Cells[2].Value = String.Format("{0:0.00}", expenceAmount);
                //Employee Salary Amount 
                Grid.Rows.Add();
                Grid.Rows[6].Cells[0].Value = "@ All Employee Salary Amount";
                Grid.Rows[6].Cells[1].Value = "" + 0;
                Grid.Rows[6].Cells[2].Value = String.Format("{0:0.00}", totSalary);
                //Employee Salary Amount 
                Grid.Rows.Add();
                Grid.Rows[7].Cells[0].Value = "@ Cotton Seed Total Carage Amount";
                Grid.Rows[7].Cells[1].Value = "" + 0;
                Grid.Rows[7].Cells[2].Value = String.Format("{0:0.00}", totCarage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void GetCakeData()
        {
            string sql = "select  SubTotalWeight,Rate from SalesDetails ";
            try
            {
                reader = db.selectQuery(sql);
                while (reader.Read())
                {
                    totWeightCake = totWeightCake + Convert.ToDouble(reader["SubTotalWeight"]);
                    amountCake = amountCake + (Convert.ToDouble(reader["SubTotalWeight"]) / 37.324) * Convert.ToDouble(reader["Rate"]);
                }
                db.ConnectionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void getSeedData()
        {
            String query = "select * from Purchases";
            try
            {
                reader = db.selectQuery(query);
                while (reader.Read())
                {

                    totWeightSeed = totWeightSeed + Convert.ToDouble(reader["Weight"]);
                    totAmountSeed = totAmountSeed + Convert.ToDouble(reader["Amount"]);
                    totCarage = totCarage + Convert.ToDouble(reader["Carege"]);
                }
                db.ConnectionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void getOilData()
        {
            try
            {
                string sql = "select * from OilSales where ProductName='Cotton Oil'";
                reader = db.selectQuery(sql);
                while (reader.Read())
                {
                    totWeightOil = (totWeightOil + Convert.ToDouble(reader["Weight"]));
                    totAmountOil = (totAmountOil + Convert.ToDouble(reader["TotalAmount"]));
                }
                db.ConnectionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         public void getDirtyOilData()
        {
            try
            {
                string sql = "select * from OilSales where ProductName='Cotton Dirty' ";
                reader = db.selectQuery(sql);
                while (reader.Read())
                {
                    totWeightDirtyOil = (totWeightDirtyOil + Convert.ToDouble(reader["Weight"]));
                    totAmountDirtyOil = (totAmountDirtyOil + Convert.ToDouble(reader["TotalAmount"]));
                }
                db.ConnectionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         private void GetExpenceData()
         {
             string sql = "select * from Expence";
             reader = db.selectQuery(sql);
             while (reader.Read())
             {
                 expenceAmount = (expenceAmount + Convert.ToDouble(reader["ExpenceAmount"]));
             }
             db.ConnectionClose();
         }
       public void getSalaryData()
        {
          try
            {
                string sql = "select sum(PayAmount) from EmpPay_tb";
                reader = db.selectQuery(sql);
               
                while (reader.Read())
                {
                    totSalary = Convert.ToDouble(reader[0]);
                }
                db.ConnectionClose();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Found Any Salary Amount","Output Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

       private void button5_Click(object sender, EventArgs e)
       {
           frmMain frm = new frmMain();
           frm.Show();
           this.Close();
       }

       private void panel1_MouseDown(object sender, MouseEventArgs e)
       {
           if (e.Button == MouseButtons.Left)
           {
               ReleaseCapture();
               SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
           }
       }

       private void btnClose_Click_1(object sender, EventArgs e)
       {
           this.Close();


       }

    }
}
