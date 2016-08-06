
using OMMS.Enums;
using OMMS.Reporting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace OMMS
{
    public partial class frmSales : Form
    {
        //################################################ created object of defferent classes ############################// 
        Validation validate = new Validation();
        DbAdapter db = new DbAdapter();
        SqlDataReader reader;
        string currentType = "SV";
        int affactedRows = 0;
        int rowIndex = -1;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmSales()
        {
            InitializeComponent();
        }
        //############################################ From Load Event ############################//
        private void frmCottonCake_Load(object sender, EventArgs e)
        {
            atuoKeyGenrate();
            chKDecimal.Checked = true;
            getCusData();
            getLaborPay();
            comboProduct.SelectedIndex = 0;
            CusRecorddataGridView.RowTemplate.MinimumHeight = 25;
            btnInvoiceUpdate.Enabled = false;
        }

        private void getLaborPay()
        {
            string sql = "select (LaborRate) from LaborRate_tb";
            reader = db.selectQuery(sql);
            if (reader.Read())
            {
                txtLaborPay.Text = reader[0].ToString();
            }
            //db.ConnectionClose();
        }
        #region All Mhothod That Use in This form
        //############################################ auto Key Genrate for Invoice ############################//
        public void atuoKeyGenrate()
        {
            string sql = "select max(InvoiceID) from Sales";
            reader = db.selectQuery(sql);
            if (reader.Read())
            {
                if (Convert.ToString(reader[0]) != "")
                {
                    txtInvoiceId.Text = "" + (Convert.ToInt64(reader[0]) + 1);
                }
                else
                {
                    txtInvoiceId.Text = 1 + "";
                }
            }
        }
        //############################################Save Record in Database Mathod ############################//
        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars = "123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
        //############################################ Get customer Data Mathod ############################//
        public void getCusData()
        {
            string sql = "select AcTitle as CustomerName, ACCode As CustomerID from Accounts";
            reader = db.selectQuery(sql);
            comboCusName.Items.Clear();
            ddCustomer.Items.Clear();
            while (reader.Read())
            {
                comboCusName.Items.Add(reader[0]);
                ddCustomer.Items.Add(reader[0]);
            }
            comboCusName.SelectedIndex = 0;
            // db.ConnectionClose();
        }
        //############################################ button Clear ############################//
        public void txtClear()
        {
            txtName.Clear();
            comboCusName.SelectedIndex = 0;
            txtPayment.Text = "" + 0;
            txtQty.Clear();
            txtWeight.Clear();
            txtTotalWeight.Text = "" + 0;
            txtAmount.Text = "" + 0;
            txtBardana2.Text = "" + 0;
            txtSotari.Text = "" + 0;
            txtLaborAmount.Text = "" + 0;
            txtTotalAmount.Text = "" + 0;
            txtCartAmount.Text = "" + 0;
            txtCartWeight.Text = "" + 0;
            txtPayment.Text = "" + 0;
            txtDuePayment.Text = "" + 0;
            //comboCusName.Text = "";
            txtCartQty.Clear();
            txtCartBardana.Clear();
            txtCartSotari.Clear();
            txtCartLaborPay.Clear();
            //txtCusID.Clear();
            txtQty.Focus();
            dataGridViewShopingCart.Rows.Clear();
        }
        public void txtClear2()
        {
            txtQty.Clear();
            txtWeight.Clear();
            txtTotalWeight.Text = "" + 0;
            txtAmount.Text = "" + 0;
            txtTotalAmount.Text = "" + 0;
            txtBardana2.Text = "" + 0;
            txtSotari.Text = "" + 0;
            txtLaborAmount.Text = "" + 0;
            txtQty.Focus();
        }
        //############################################ Count total Amount Mathod ############################//
        private void countCartCount()
        {
            int i, j = 0;
            decimal cartAmount, cartWeight, cartQty, cartLabor, cartSotari, cartBardana;
            cartAmount = cartWeight = cartQty = cartLabor = cartSotari = cartBardana = 0;
            try
            {
                j = dataGridViewShopingCart.Rows.Count - 1;
                for (i = 0; i <= j; i++)
                {
                    cartAmount = cartAmount + Decimal.Round(Convert.ToDecimal(dataGridViewShopingCart.Rows[i].Cells[9].Value), 0);
                    cartWeight = cartWeight + Decimal.Round(Convert.ToDecimal(dataGridViewShopingCart.Rows[i].Cells[4].Value), 0);
                    cartQty = cartQty + Decimal.Round(Convert.ToDecimal(dataGridViewShopingCart.Rows[i].Cells[1].Value), 0);
                    cartLabor = cartLabor + Decimal.Round(Convert.ToDecimal(dataGridViewShopingCart.Rows[i].Cells[6].Value), 0);
                    cartSotari = cartSotari + Decimal.Round(Convert.ToDecimal(dataGridViewShopingCart.Rows[i].Cells[8].Value), 0);
                    cartBardana = cartBardana + Decimal.Round(Convert.ToDecimal(dataGridViewShopingCart.Rows[i].Cells[7].Value), 0);
                }
                txtCartAmount.Text = cartAmount.ToString();
                txtCartWeight.Text = cartWeight.ToString();
                txtCartQty.Text = cartQty.ToString();
                txtCartLaborPay.Text = cartLabor.ToString();
                txtCartSotari.Text = cartSotari.ToString();
                txtCartBardana.Text = cartBardana.ToString();
                txtPayment.Text = cartAmount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region All Textboxes Counting Events
        //############################################ Count Payment event ############################//



        //############################################ Count Bardana event ############################//
        private void txtBardana_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (txtLaborPay.Text != "" && txtBardana2.Text != "" && txtSotari.Text != "" && txtAmount.Text != "" && txtQty.Text != "")
                {
                    double labor = Convert.ToDouble(txtLaborAmount.Text);
                    double bardana = Convert.ToDouble(Convert.ToDouble(txtBardana2.Text) * Convert.ToDouble(txtQty.Text));
                    double sotari = Convert.ToDouble(txtSotari.Text);
                    double amount = Convert.ToDouble(txtAmount.Text);
                    txtBardana.Text = Convert.ToDouble(Convert.ToDouble(txtBardana2.Text) * Convert.ToDouble(txtQty.Text)).ToString();
                    txtTotalAmount.Text = "" + (labor + bardana + sotari + amount);
                }
                else
                    txtTotalAmount.Text = "" + 0;
                if (txtBardana2.Text == "" || txtBardana2.Text == "0")
                {
                    txtBardana.Text = "" + 0;
                }
                if (txtAmount.Text != "" && txtLaborAmount.Text != "" && txtBardana.Text != "" && txtSotari.Text != "")
                {
                    double amount = Convert.ToDouble(txtAmount.Text);
                    double laborAmount = Convert.ToDouble(txtLaborAmount.Text);
                    double bardana = Convert.ToDouble(txtBardana.Text);
                    double sotari = Convert.ToDouble(txtSotari.Text);
                    txtTotalAmount.Text = (amount + laborAmount + bardana + sotari).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //############################################ calculate total weight from Quantity ############################//
        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (chKDecimal.Checked == true)
                {
                    if (txtQty.Text != "" && txtWeight.Text != "")
                    {
                        Int64 qty = Convert.ToInt64(txtQty.Text);
                        double weight = Convert.ToDouble(txtWeight.Text);
                        txtTotalWeight.Text = String.Format("{0:0.00}", (qty * weight));
                        txtAmount.Text = String.Format("{0:0.00}", (qty * weight / 37.324 * Convert.ToInt64(txtRate.Text)));
                    }
                    else
                        txtTotalWeight.Text = "" + 0;
                }
                else
                {
                    if (txtQty.Text != "" && txtWeight.Text != "")
                    {
                        Int64 qty = Convert.ToInt64(txtQty.Text);
                        double weight = Convert.ToDouble(txtWeight.Text);
                        txtTotalWeight.Text = String.Format("{0:0.00}", (qty * weight));
                        txtAmount.Text = String.Format("{0:0.00}", (qty * weight / 37 * Convert.ToInt64(txtRate.Text)));
                    }
                    else
                        txtTotalWeight.Text = "" + 0;


                }
                if (txtWeight.Text == "")
                {
                    txtAmount.Text = "" + 0;
                }
                if (txtAmount.Text != "" && txtLaborAmount.Text != "" && txtBardana.Text != "" && txtSotari.Text != "")
                {
                    double amount = Convert.ToDouble(txtAmount.Text);
                    double laborAmount = Convert.ToDouble(txtLaborAmount.Text);
                    double bardana = Convert.ToDouble(txtBardana.Text);
                    double sotari = Convert.ToDouble(txtSotari.Text);
                    txtTotalAmount.Text = String.Format("{0:0.00}", (amount + laborAmount + bardana + sotari));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //############################################ Count Sotari event ############################//
        private void txtSotari_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (txtLaborPay.Text != "" && txtSotari.Text != "")
                {
                    double labor = Convert.ToDouble(txtLaborAmount.Text);
                    double sotari = Convert.ToDouble(txtSotari.Text);
                    double amount = Convert.ToDouble(txtAmount.Text);
                    double bardana = Convert.ToDouble(txtBardana2.Text);
                    txtTotalAmount.Text = (labor + sotari + amount + bardana).ToString();
                }
                else
                    txtTotalAmount.Text = "" + 0;
                if (txtAmount.Text != "" && txtLaborAmount.Text != "" && txtBardana.Text != "" && txtSotari.Text != "")
                {
                    double amount = Convert.ToDouble(txtAmount.Text);
                    double laborAmount = Convert.ToDouble(txtLaborAmount.Text);
                    double bardana = Convert.ToDouble(txtBardana.Text);
                    double sotari = Convert.ToDouble(txtSotari.Text);
                    txtTotalAmount.Text = String.Format("{0:0.00}", (amount + laborAmount + bardana + sotari));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //############################################ Count total Amount from Qty and Rate ############################//
        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtQty.Text != "" && txtLaborPay.Text != "")
                {
                    txtLaborAmount.Text = String.Format("{0:0.00}", (Convert.ToDouble(txtQty.Text) * Convert.ToDouble(txtLaborPay.Text)));

                    // Int64 weight = Convert.ToInt64(txtWeight.Text);
                    //txtAmount.Text = "" + (qty * weight / 37.324 * Convert.ToInt64(txtRate.Text));
                    //  txtTotalAmount.Text = "" + ( bar + sotari + laboAmount);
                }
                if (txtQty.Text != "" && txtWeight.Text != "")
                {
                    Int64 qty = Convert.ToInt64(txtQty.Text);
                    double weight = Convert.ToDouble(txtWeight.Text);
                    txtTotalWeight.Text = "" + (qty * weight);
                    txtAmount.Text = "" + (qty * weight / 37.324 * Convert.ToInt64(txtRate.Text));
                }
                else
                    txtAmount.Text = "" + 0;
                if (txtQty.Text == "")
                {
                    txtAmount.Text = "" + 0;
                }
                if (txtAmount.Text != "" && txtLaborAmount.Text != "" && txtBardana.Text != "" && txtSotari.Text != "")
                {
                    double amount = Convert.ToDouble(txtAmount.Text);
                    double laborAmount = Convert.ToDouble(txtLaborAmount.Text);
                    double bardana = Convert.ToDouble(txtBardana.Text);
                    double sotari = Convert.ToDouble(txtSotari.Text);
                    txtTotalAmount.Text = String.Format("{0:0.00}", (amount + laborAmount + bardana + sotari));
                }
                /*   else
                       txtLaborAmount.Text = "" + 0;

                   if (txtQty.Text != "" && txtWeight.Text != "")
                   {
                       Int64 qty = Convert.ToInt64(txtQty.Text);
                       double weight = Convert.ToDouble(txtWeight.Text);
                       txtTotalWeight.Text = "" + (qty * weight);
                   }
                   else
                       txtTotalWeight.Text = "" + 0;
                   if (txtQty.Text == "")
                   {
                       Int64 bar = Convert.ToInt64(txtBardana2.Text);
                       Int64 sotari = Convert.ToInt64(txtSotari.Text);
                       Int64 laboAmount = Convert.ToInt64(txtLaborAmount.Text);
                       txtTotalAmount.Text = "" + (bar + sotari + laboAmount);
                   } */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //############################################ Count total Amount Mathod ############################//
        private void txtRate_TextChanged_1(object sender, EventArgs e)
        {

        }
        //############################################ Count total labor pay ############################//
        private void txtLaborPay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtLaborPay.Text != "" && txtQty.Text != "")
                {
                    Int64 a = Convert.ToInt64(txtQty.Text);
                    Double b = Convert.ToDouble(txtLaborPay.Text);


                    txtLaborAmount.Text = (a * b).ToString();

                }
                if (txtAmount.Text != "" && txtLaborAmount.Text != "" && txtBardana.Text != "" && txtSotari.Text != "")
                {
                    double amount = Convert.ToDouble(txtAmount.Text);
                    double laborAmount = Convert.ToDouble(txtLaborAmount.Text);
                    double bardana = Convert.ToDouble(txtBardana.Text);
                    double sotari = Convert.ToDouble(txtSotari.Text);
                    txtTotalAmount.Text = String.Format("{0:0.00}", (amount + laborAmount + bardana + sotari));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region All Button Click Events
        //############################################ text box Clear Button ############################//
        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            txtClear();
            atuoKeyGenrate();
            btnInvoiceSave.Enabled = true;



        }
        //############################################ datagrid Clear Button ############################//
        private void btnClearData_Click(object sender, EventArgs e)
        {
            CusRecorddataGridView.Rows.Clear();
        }
        //############################################ Get All data of Customer ############################//
        private void btnSearch_Click(object sender, EventArgs e)
        {
            double tQty = 0;
            double totWeight = 0;
            double TotalLaborPay = 0;
            double totTotalAmount = 0;
            double amount = 0;
            using (SqlConnection con = new SqlConnection(db.cs))
            {
                SqlCommand cmd = new SqlCommand("SP_GetSales", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StartDate", string.IsNullOrEmpty(dtStartDate.Value.ToString()) ? (object)DBNull.Value : dtStartDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@EndDate", string.IsNullOrEmpty(dtEndDate.Value.ToString()) ? (object)DBNull.Value : dtEndDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@AccountID", DBNull.Value);
                cmd.Parameters.AddWithValue("@InvoiceID", string.IsNullOrEmpty(txtInvoiceNo.Text) ? (object)DBNull.Value : txtInvoiceNo.Text);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                CusRecorddataGridView.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    CusRecorddataGridView.Rows.Add(row["InvoiceID"], row["InvoiceDate"], row["CustomerName"], row["ProductName"], row["Quantity"], row["Rate"], row["Weight"], row["SubTotalWeight"], row["LaborPay"], row["LaborPayAmount"], row["Bardana"], row["Sotari"], row["SubTotalAmount"], "Edit", "Delete");
                    tQty = tQty + Convert.ToDouble(row["Quantity"]);
                    totWeight = totWeight + Convert.ToDouble(row["SubTotalWeight"]);
                    TotalLaborPay = TotalLaborPay + Convert.ToDouble(row["LaborPayAmount"]);
                    totTotalAmount = totTotalAmount + Convert.ToDouble(row["SubTotalAmount"]);
                    amount = amount + (Convert.ToDouble(row["SubTotalWeight"]) / 37.324) * Convert.ToDouble(row["Rate"]);
                }
                for (int i = 0; i <= CusRecorddataGridView.RowCount - 1; i++)
                {
                    if (i % 2 != 0)
                    {
                        CusRecorddataGridView.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
                txtTotalQty.Text = "" + tQty;
                txtCusTotalWeight.Text = "" + totWeight;
                txtCusTotalLaborPay.Text = "" + TotalLaborPay;
                txtCusTotalAmount.Text = "" + totTotalAmount;
                txtCusAvgRate.Text = String.Format("{0:0.00}", amount / (totWeight / 37.324));

            }
        }
        private void txtInvoiceNo_TextChanged(object sender, EventArgs e)
        {
            double tQty = 0;
            double totWeight = 0;
            double TotalLaborPay = 0;
            double totTotalAmount = 0;
            double amount = 0;
            using (SqlConnection con = new SqlConnection(db.cs))
            {
                SqlCommand cmd = new SqlCommand("SP_GetSales", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StartDate", DBNull.Value);
                cmd.Parameters.AddWithValue("@EndDate", DBNull.Value);
                cmd.Parameters.AddWithValue("@AccountID", DBNull.Value);
                cmd.Parameters.AddWithValue("@InvoiceID", txtInvoiceNo.Text);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                CusRecorddataGridView.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    CusRecorddataGridView.Rows.Add(row["InvoiceID"], row["InvoiceDate"], row["CustomerName"], row["ProductName"], row["Quantity"], row["Rate"], row["Weight"], row["SubTotalWeight"], row["LaborPay"], row["LaborPayAmount"], row["Bardana"], row["Sotari"], row["SubTotalAmount"], "Edit", "Delete");
                    tQty = tQty + Convert.ToDouble(row["Quantity"]);
                    totWeight = totWeight + Convert.ToDouble(row["SubTotalWeight"]);
                    TotalLaborPay = TotalLaborPay + Convert.ToDouble(row["LaborPayAmount"]);
                    totTotalAmount = totTotalAmount + Convert.ToDouble(row["SubTotalAmount"]);
                    amount = amount + (Convert.ToDouble(row["SubTotalWeight"]) / 37.324) * Convert.ToDouble(row["Rate"]);
                }
                for (int i = 0; i <= CusRecorddataGridView.RowCount - 1; i++)
                {
                    if (i % 2 != 0)
                    {
                        CusRecorddataGridView.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
                txtTotalQty.Text = "" + tQty;
                txtCusTotalWeight.Text = "" + totWeight;
                txtCusTotalLaborPay.Text = "" + TotalLaborPay;
                txtCusTotalAmount.Text = "" + totTotalAmount;
                txtCusAvgRate.Text = String.Format("{0:0.00}", amount / (totWeight / 37.324));

            }
        }
        private void GetAllCusData()
        {
            string sql = "select SalesDetails.InvoiceID,InvoiceDate,Sales.CustomerName,ProductName,Quantity,Weight,SubTotalWeight,Rate,LaborPay,LaborPayAmount,Bardana,Sotari,SubTotalAmount from Sales,SalesDetails where Sales.InvoiceID = SalesDetails.InvoiceID order by SalesDetails.InvoiceID ";
            double tQty = 0;
            double totWeight = 0;
            double TotalLaborPay = 0;
            double totTotalAmount = 0;
            double amount = 0;
            try
            {
                reader = db.selectQuery(sql);
                CusRecorddataGridView.Rows.Clear();
                while (reader.Read())
                {
                    CusRecorddataGridView.Rows.Add(reader["InvoiceID"], reader["InvoiceDate"], reader["CustomerName"], reader["ProductName"], reader["Quantity"], reader["Rate"], reader["Weight"], reader["SubTotalWeight"], reader["LaborPay"], reader["LaborPayAmount"], reader["Bardana"], reader["Sotari"], reader["SubTotalAmount"], "Edit", "Delete");
                    tQty = tQty + Convert.ToDouble(reader["Quantity"]);
                    totWeight = totWeight + Convert.ToDouble(reader["SubTotalWeight"]);
                    TotalLaborPay = TotalLaborPay + Convert.ToDouble(reader["LaborPayAmount"]);
                    totTotalAmount = totTotalAmount + Convert.ToDouble(reader["SubTotalAmount"]);
                    amount = amount + (Convert.ToDouble(reader["SubTotalWeight"]) / 37.324) * Convert.ToDouble(reader["Rate"]);
                }
                db.ConnectionClose();
                for (int i = 0; i <= CusRecorddataGridView.RowCount - 1; i++)
                {
                    if (i % 2 != 0)
                    {
                        CusRecorddataGridView.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
                txtTotalQty.Text = "" + tQty;
                txtCusTotalWeight.Text = "" + totWeight;
                txtCusTotalLaborPay.Text = "" + TotalLaborPay;
                txtCusTotalAmount.Text = "" + totTotalAmount;
                txtCusAvgRate.Text = String.Format("{0:0.00}", amount / (totWeight / 37.324));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //############################################ Count Total && Weight Total Amount ############################//
        private void btnRemove_Click(object sender, EventArgs e)
        {
            /*   try
               {
                   if (ListView1.Items.Count == 0)
                   {
                       MessageBox.Show("No items to remove", "Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   }
                   else
                   {
                       int itemcount = 0;
                       int i = 0;
                       int t = 0;
                       ListView1.FocusedItem.Remove();
                       itemcount = ListView1.Items.Count;
                       t = 1;
                       for (i = 1; i <= itemcount + 1; i++)
                       {
                           t = t + 1;
                       }
                       countCartCount();
                   }
                   btnRemove.Enabled = false;
                   if (ListView1.Items.Count == 0)
                   {
                       txtCartAmount.Text = 0 + "";
                       txtCartWeight.Text = 0 + "";
                   }
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               } */
        }
        //############################################ BUTTON CLEAR ############################//
        private void button3_Click(object sender, EventArgs e)
        {
            txtClear();
        }
        //############################################ Add to Cart button ############################//
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            AddToCart();
        }

        private void AddToCart()
        {
            //try
            //{
            if (comboCusName.Text == "")
            {
                MessageBox.Show("Please Select Customer Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboCusName.Focus();
                return;
            }

            if (comboProduct.Text == "")
            {
                MessageBox.Show("Please Select product name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboProduct.Focus();
                return;
            }
            if (txtQty.Text == "")
            {
                MessageBox.Show("Please enter product sale quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQty.Focus();
                return;
            }
            if (txtWeight.Text == "")
            {

                MessageBox.Show("Please Enter the Weight", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtWeight.Focus();
                return;
            }

            if (dataGridViewShopingCart.Rows.Count == 0)
            {
                dataGridViewShopingCart.Rows.Add(comboProduct.Text, txtQty.Text, txtWeight.Text, txtRate.Text, txtTotalWeight.Text, txtLaborPay.Text, txtLaborAmount.Text, txtBardana.Text, txtSotari.Text, Decimal.Round(Convert.ToDecimal(txtTotalAmount.Text), 0), "", "Delete");
                txtCartAmount.Text = Decimal.Round(Convert.ToDecimal(txtTotalAmount.Text), 0).ToString();
                txtCartWeight.Text = Decimal.Round(Convert.ToDecimal(txtTotalWeight.Text), 0).ToString();
                txtCartQty.Text = txtQty.Text;
                txtCartLaborPay.Text = Decimal.Round(Convert.ToDecimal(txtLaborAmount.Text), 0).ToString();
                txtCartBardana.Text = Decimal.Round(Convert.ToDecimal(txtBardana.Text), 0).ToString();
                txtCartSotari.Text = Decimal.Round(Convert.ToDecimal(txtSotari.Text), 0).ToString();
                txtPayment.Text = Decimal.Round(Convert.ToDecimal(txtTotalAmount.Text), 0).ToString();
                txtClear2();
                btnInvoiceSave.Focus();
                return;
            }
            if (dataGridViewShopingCart.Rows.Count != 0)
            {
                dataGridViewShopingCart.Rows.Add(comboProduct.Text, txtQty.Text, txtWeight.Text, txtRate.Text, txtTotalWeight.Text, txtLaborPay.Text, txtLaborAmount.Text, txtBardana.Text, txtSotari.Text, Decimal.Round(Convert.ToDecimal(txtTotalAmount.Text), 0), "", "delete");
                countCartCount();
                txtClear2();
                return;
            }


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        #endregion

        #region All Combo Box Event
        //############################################ Customer Combo Box ############################//
        private void comboCusName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboCusName.Text == "")
            {
                txtCusID.Focus();
                return;
            }
            GetCusID();
            GetDuePayment();
        }

        private void GetDuePayment()
        {
            try
            {
                string sql = "select sum(debit-Credit) from GeneralLagerRpt where AcCode=" + txtCusID.Text + " AND AcType != 'Cash' ";
                reader = db.selectQuery(sql);
                if (reader.Read())
                {
                    if (Convert.ToString(reader[0]) != "")
                    {
                        txtTotalDueOfCus.Text = String.Format("{0:0.00}", reader[0]);
                    }
                    else
                    {
                        txtTotalDueOfCus.Text = "0";
                    }
                    txtRate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetCusID()
        {
            string sql = "select AcCode as CustomerID from Accounts where AcTitle = '" + comboCusName.Text + "'";
            try
            {
                reader = db.selectQuery(sql);
                if (reader.Read())
                {
                    txtCusID.Text = reader[0].ToString();
                }
                if (Convert.ToString(reader[0]) == "")
                {
                    txtCusID.Text = "" + 0;
                }
                db.ConnectionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //############################################ Customer Combo box Key Pess Event ############################//

        #endregion

        #region TextBox Validation Key Events

        private void txtQty_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validate.DecimalValiation(e, txtQty);
        }
        private void txtWeight_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validate.DecimalValiation(e, txtWeight);
        }
        private void txtPayment_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validate.DecimalValiation2(e, txtPayment);
        }
        private void txtLaborPay_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validate.DecimalValiation(e, txtLaborPay);
        }
        private void txtSotari_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validate.DecimalValiation(e, txtSotari);
        }
        private void txtBardana_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.DecimalValiation(e, txtBardana2);
        }


        #endregion

        #region All Combo Box Events
        //############################################ Product Change Index event ############################//
        private void comboProduct_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboProduct.Text == "Cotton Oil" || comboProduct.Text == "Cotton Dirty")
            {
                frmCottonOil frm = new frmCottonOil();
                frm.ShowDialog();

            }

            if (comboProduct.Text == "Cotton Cake")
            {
                string sql = "select * from CottonCake_tb";
                reader = db.selectQuery(sql);
                if (reader.Read())
                {
                    txtRate.Text = reader[1].ToString();
                }
                db.ConnectionClose();
            }



        }
        //############################################ Get Cuscustomer data on index Change Event ############################//
        private void ComboCusFetchData_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select SalesDetails.InvoiceID,InvoiceDate,Sales.CustomerName,ProductName,Quantity,Weight,SubTotalWeight,Rate,LaborPay,LaborPayAmount,Bardana,Sotari,SubTotalAmount from Sales,SalesDetails where Sales.InvoiceID = SalesDetails.InvoiceID AND Sales.CustomerName = '" + ddCustomer.Text + "' order by Sales.InvoiceID DESC ";
            double tQty = 0;
            double totWeight = 0;
            double TotalLaborPay = 0;
            double totTotalAmount = 0;
            double totPayment = 0;
            double amount = 0;
            try
            {
                reader = db.selectQuery(sql);
                CusRecorddataGridView.Rows.Clear();
                while (reader.Read())
                {
                    CusRecorddataGridView.Rows.Add(reader["InvoiceID"], reader["InvoiceDate"], reader["CustomerName"], reader["ProductName"], reader["Quantity"], reader["Rate"], reader["Weight"], reader["SubTotalWeight"], reader["LaborPay"], reader["LaborPayAmount"], reader["Bardana"], reader["Sotari"], reader["SubTotalAmount"], "Edit", "Delete");
                    tQty = tQty + Convert.ToDouble(reader["Quantity"]);
                    totWeight = totWeight + Convert.ToDouble(reader["SubTotalWeight"]);
                    TotalLaborPay = TotalLaborPay + Convert.ToDouble(reader["LaborPayAmount"]);
                    totTotalAmount = totTotalAmount + Convert.ToDouble(reader["SubTotalAmount"]);
                    amount = amount + (Convert.ToDouble(reader["SubTotalWeight"]) / 37.324) * Convert.ToDouble(reader["Rate"]);
                }
                db.ConnectionClose();
                for (int i = 0; i <= CusRecorddataGridView.RowCount - 1; i++)
                {
                    if (i % 2 != 0)
                    {
                        CusRecorddataGridView.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
                txtTotalQty.Text = "" + tQty;
                txtCusTotalWeight.Text = "" + totWeight;
                txtCusTotalLaborPay.Text = "" + TotalLaborPay;
                txtCusTotalAmount.Text = "" + totTotalAmount;
                txtCusAvgRate.Text = String.Format("{0:0.00}", amount / (totWeight / 37.324));
            }
            catch (Exception ex)
            {
                MessageBox.Show("No have about this customer !!!", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Customer DataGridView Codding Area
        //############################################ DataGridView Paint ############################//
        private void CusRecorddataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //validate.rowNumberMathod(e, CusRecorddataGridView, this);
        }
        //############################################ DataGridView Row Painting ############################//
        private void CusRecorddataGridView_Paint(object sender, PaintEventArgs e)
        {
            validate.DataGridSetColor(CusRecorddataGridView);
        }
        #endregion
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void dataGridViewProductRecord_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //validate.rowNumberMathod(e, dataGridViewProductRecord, this);
        }
        private void CusRecorddataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlDataReader readr;
            if (e.ColumnIndex == 13)
            {
                string sql = "select * from Sales where InvoiceID = " + CusRecorddataGridView.Rows[e.RowIndex].Cells[0].Value + "";
                string sql2 = "select * from SalesDetails where InvoiceID = " + CusRecorddataGridView.Rows[e.RowIndex].Cells[0].Value + "";
                try
                {
                    readr = db.selectQuery(sql2);
                    dataGridViewShopingCart.Rows.Clear();
                    while (readr.Read())
                    {
                        dataGridViewShopingCart.Rows.Add(readr["ProductName"], readr["Quantity"], readr["Weight"], readr["Rate"], readr["SubTotalWeight"], readr["LaborPay"], readr["LaborPayAmount"], readr["Bardana"], readr["Sotari"], readr["SubTotalAmount"], "", "Delete");
                    }
                    db.ConnectionClose();
                    countCartCount();

                    readr = db.selectQuery(sql);
                    if (readr.Read())
                    {
                        txtInvoiceId.Text = readr["InvoiceID"].ToString();
                        DataHolder.InvoiceNo = Convert.ToInt32(readr["InvoiceID"]);
                        dpInvoice.Value = Convert.ToDateTime(readr["InvoiceDate"]);
                        txtCusID.Text = readr["CustomerID"].ToString();
                        comboCusName.Text = readr["CustomerName"].ToString();
                        if (Convert.ToString(readr["Payment"]) != "")
                        {
                            txtPayment.Text = Convert.ToDouble(readr["Payment"]).ToString();
                        }
                        else
                        {
                            txtPayment.Text = "" + 0;
                        }
                        txtComments.Text = readr["Comments"].ToString();
                    }
                    //db.ConnectionClose();
                    tabPage2.Hide();
                    tabPage1.Show();
                    tabPage1.Focus();
                    btnInvoiceSave.Enabled = false;
                    btnInvoiceUpdate.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (e.ColumnIndex == 14)
            {
                try
                {
                    DialogResult dig = MessageBox.Show("Really you want to delete this record !!!!!", "Delete Record Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dig == DialogResult.Yes)
                    {

                        string sql = "delete from SalesDetails where InvoiceID = " + CusRecorddataGridView.Rows[e.RowIndex].Cells[0].Value + " ";
                        string sql2 = "delete from Sales where InvoiceID = " + CusRecorddataGridView.Rows[e.RowIndex].Cells[0].Value + " ";
                        string sql3 = "delete from VoucherDetails where VocNo =" + CusRecorddataGridView.Rows[e.RowIndex].Cells[0].Value + " AND VocType = '" + currentType + "'";
                        string sql4 = "delete from vouchers where VocNo =" + CusRecorddataGridView.Rows[e.RowIndex].Cells[0].Value + " AND VocType = '" + currentType + "' ";
                        string sql5 = "delete from Delivery_tb where BilllNo=" + CusRecorddataGridView.Rows[e.RowIndex].Cells[0].Value + "";
                        affactedRows = db.Execute(sql2);
                        if (affactedRows > 0)
                        {
                            db.Execute(sql);
                            db.Execute(sql3);
                            db.Execute(sql4);
                            db.Execute(sql5);
                            MessageBox.Show("Deleted Successfully!!!", "Delete Record Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CusRecorddataGridView.Rows.Clear();
                            txtInvoiceNo.Clear();
                            txtInvoiceNo.Focus();
                        }
                        else
                        {
                            MessageBox.Show(" No Record Delete !!!", "Delete Record Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        atuoKeyGenrate();
                        GetAllCusData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void btnInvoiceSave_Click(object sender, EventArgs e)
        {
            if (comboCusName.Text == "")
            {
                comboCusName.Focus();
                MessageBox.Show("Please Select Customer Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (comboProduct.Text == "")
            {
                MessageBox.Show("Please Select product name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPayment.Text == "")
            {

                MessageBox.Show("Please Enter the payment amount", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPayment.Focus();
                return;
            }
            if (dataGridViewShopingCart.Rows.Count == 0)
            {
                MessageBox.Show("Please Enter the Sale Order", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (comboCusName.Text == "Cash In Hand" && txtPayment.Text != txtCartAmount.Text)
            {
                MessageBox.Show("You not allow duepayment in Cash In Hand Account !!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (comboProduct.Text != "Cotton Cake")
            {
                MessageBox.Show("Please select the Cotton Cake", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (chKNotDliver.Checked == true && comboCusName.Text != "Cash In Hand")
                {
                    for (int i = 0; i < dataGridViewShopingCart.Rows.Count; i++)
                    {
                        if (db.Execute("Insert into Delivery_tb (BilllNo,Date,CusID,ProductName,Quantity,Weight,Rate,TotalWeight) values(" + txtInvoiceId.Text + ",'" + dpInvoice.Value.ToString("yyyy-MM-dd") + "','" + txtCusID.Text + "','" + dataGridViewShopingCart.Rows[i].Cells[0].Value + "'," + dataGridViewShopingCart.Rows[i].Cells[1].Value + "," + dataGridViewShopingCart.Rows[i].Cells[2].Value + "," + dataGridViewShopingCart.Rows[i].Cells[3].Value + "," + dataGridViewShopingCart.Rows[i].Cells[4].Value + ") ") > 0)
                        {
                            MessageBox.Show("Saved Successfully !!!");
                        }
                        else
                            MessageBox.Show("Not Saved!!!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            String Narration = null;
            string cusName = comboCusName.Text + " " + txtName.Text;

            string sql = "insert into Sales(InvoiceID,InvoiceDate,CustomerID,CustomerName,TotalWeight,TotalAmount,Payment,Comments) values(" + txtInvoiceId.Text + ",'" + dpInvoice.Value.ToString("yyyy-MM-dd") + "'," + txtCusID.Text + ",'" + cusName + "'," + txtCartWeight.Text + "," + txtCartAmount.Text + "," + txtPayment.Text + ",'" + txtComments.Text + "')";
            if (db.Execute(sql) > 0)
            {
                for (int i = 0; i < dataGridViewShopingCart.Rows.Count; i++)
                {
                    String sql2 = "insert into SalesDetails (InvoiceID,ProductName,Quantity,Weight,Rate,SubTotalWeight,LaborPay,LaborPayAmount,Bardana,Sotari,SubTotalAmount) values(" + txtInvoiceId.Text + ",'" + dataGridViewShopingCart.Rows[i].Cells[0].Value + "'," + dataGridViewShopingCart.Rows[i].Cells[1].Value + "," + dataGridViewShopingCart.Rows[i].Cells[2].Value + "," + dataGridViewShopingCart.Rows[i].Cells[3].Value + "," + dataGridViewShopingCart.Rows[i].Cells[4].Value + "," + dataGridViewShopingCart.Rows[i].Cells[5].Value + "," + dataGridViewShopingCart.Rows[i].Cells[6].Value + "," + dataGridViewShopingCart.Rows[i].Cells[7].Value + "," + dataGridViewShopingCart.Rows[i].Cells[8].Value + "," + dataGridViewShopingCart.Rows[i].Cells[9].Value + ")";
                    db.Execute(sql2);
                }
                //for voucher
                String sql3 = "insert into Vouchers(VocNo,VocType,VocDate) values(" + txtInvoiceId.Text + ",'" + VoucherType.SV + "','" + dpInvoice.Value.ToString("yyyy-MM-dd") + "')";
                if (db.Execute(sql3) > 0)
                {
                    //Debit Entry for sales entery
                    Narration = "Cotton Cake A/C " + comboCusName.Text + " @WT " + txtCartWeight.Text + " Kg @Rate " + txtRate.Text + " BillNO : " + txtInvoiceId.Text;
                    String sql4 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtInvoiceId.Text + ",'" + VoucherType.SV + "'," + txtCusID.Text + "," + txtCartAmount.Text + ",0,'" + Narration + "')";
                    if (db.Execute(sql4) > 0)
                    {
                        //Credit Entry for sales
                        Narration = "Cotton Cake A/C Sales Account Entry @WT :" + txtCartWeight.Text + " Kg @Rate " + txtRate.Text + " BillNO : " + txtInvoiceId.Text;
                        String sql5 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtInvoiceId.Text + ",'" + VoucherType.SV + "'," + Accounts.SalesAccount.GetHashCode() + ",0," + txtCartAmount.Text + ",'" + Narration + "')";
                        if (db.Execute(sql5) > 0)
                        {
                            string Na = "Bardana Sale To" + comboCusName.Text + "@Bill No:" + txtInvoiceId.Text;
                            double bardanaSotari = (Convert.ToDouble(txtCartBardana.Text) + Convert.ToDouble(txtCartSotari.Text));
                            string sqlB = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtInvoiceId.Text + ",'" + VoucherType.SV + "'," + Accounts.BardanaSale.GetHashCode() + "," + bardanaSotari + ",0,'" + Na + "')";
                            db.Execute(sqlB);
                            string NaL = "Labour Pay Recive From " + comboCusName.Text + "@Bill No:" + txtInvoiceId.Text;
                            string sqlL = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtInvoiceId.Text + ",'" + VoucherType.SV + "'," + Accounts.CottonCakeLabourPay.GetHashCode() + "," + txtCartLaborPay.Text + ",0,'" + NaL + "')";
                            db.Execute(sqlL);
                            DataHolder.InvoiceNo = Convert.ToInt32(txtInvoiceId.Text);
                            MessageBox.Show("Saved Successfully!!!", "Record Saved Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Record Not Saved !!!", "Record Saved Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            if (Convert.ToDouble(txtPayment.Text) != 0 && txtPayment.Text != "" && comboCusName.Text != "Cash In Hand")
            {
                //Debit Entry for payment entery
                Narration = "Cash Recive From" + comboCusName.Text + "Against Cotton Cake BillNo:" + txtInvoiceId.Text;
                string sql6 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtInvoiceId.Text + ",'" + VoucherType.SV + "'," + Accounts.CashInHand.GetHashCode() + "," + txtPayment.Text + ",0,'" + Narration + "')";
                db.Execute(sql6);
                //Credit Entry for payment
                string sql7 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtInvoiceId.Text + ",'" + VoucherType.SV + "'," + txtCusID.Text + ",0," + txtPayment.Text + ",'" + Narration + "')";
                db.Execute(sql7);
            }
            txtClear();
            atuoKeyGenrate();

        }

        private void dataGridViewShopingCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                try
                {
                    dataGridViewShopingCart.Rows.RemoveAt(rowIndex);
                    countCartCount();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Select any Row Then Pess It", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //############################################ Print Invoice Button ############################//
        private void btnInvoice_Click(object sender, EventArgs e)
        {
            db.Execute("delete from Temp");
            db.Execute("insert into Temp (F1) values(" + DataHolder.InvoiceNo + ")");
            frmReport frm = new frmReport();
            frm.rptViewer.ReportSource = new Invoice();
            frm.Text = "Inovice";
            frm.Show();
            //frm.rptViewer.PrintReport();

            // InvPrintPreviewDialog.Document = InvPrintDocument;
            // InvPrintPreviewDialog.ShowDialog();
        }

        private void btnInvoiceUpdate_Click(object sender, EventArgs e)
        {
            string sql = "update Sales set  CustomerID = '" + txtCusID.Text + "',CustomerName = '" + comboCusName.Text + "',TotalWeight=" + txtCartWeight.Text + ",TotalAmount=" + txtCartAmount.Text + ",Payment=" + txtPayment.Text + ",Comments='" + txtComments.Text + "'    where InvoiceID = " + txtInvoiceId.Text + " ";
            try
            {
                if (db.Execute(sql) > 0)
                {

                    if (db.Execute("delete from SalesDetails where InvoiceID = " + txtInvoiceId.Text + "") > 0)
                    {
                        for (int i = 0; i < dataGridViewShopingCart.Rows.Count; i++)
                        {
                            String sql2 = "insert into SalesDetails (InvoiceID,ProductName,Quantity,Weight,Rate,SubTotalWeight,LaborPay,LaborPayAmount,Bardana,Sotari,SubTotalAmount) values(" + txtInvoiceId.Text + ",'" + dataGridViewShopingCart.Rows[i].Cells[0].Value + "'," + dataGridViewShopingCart.Rows[i].Cells[1].Value + "," + dataGridViewShopingCart.Rows[i].Cells[2].Value + "," + dataGridViewShopingCart.Rows[i].Cells[3].Value + "," + dataGridViewShopingCart.Rows[i].Cells[4].Value + "," + dataGridViewShopingCart.Rows[i].Cells[5].Value + "," + dataGridViewShopingCart.Rows[i].Cells[6].Value + "," + dataGridViewShopingCart.Rows[i].Cells[7].Value + "," + dataGridViewShopingCart.Rows[i].Cells[8].Value + "," + dataGridViewShopingCart.Rows[i].Cells[9].Value + ")";
                            db.Execute(sql2);
                        }
                    }

                    string Narration = "Cotton Cake A/C " + comboCusName.Text + " @WT " + txtCartWeight.Text + " Kg @Rate " + txtRate.Text + "Bill:" + txtInvoiceId.Text;

                    String sql4 = "update VoucherDetails set  Debit=" + txtCartAmount.Text + ",Narration='" + Narration + "' where  VocNo=" + txtInvoiceId.Text + " AND VocType='" + VoucherType.SV + "' AND AcCode=" + txtCusID.Text + " AND Credit=0 And Debit !=0";
                    if (db.Execute(sql4) > 0)
                    {
                        //Credit Entry for sales
                        String sql5 = "update  VoucherDetails set  Debit=0,Credit=" + txtCartAmount.Text + ", Narration='" + Narration + "' where VocNo=" + txtInvoiceId.Text + " AND VocType='" + VoucherType.SV + "' AND AcCode=2";

                        if (db.Execute(sql5) > 0)
                        {
                            string Na = "Bardana Sale To" + comboCusName.Text + "@Bill No:" + txtInvoiceId.Text;
                            double bardanaSotari = (Convert.ToDouble(txtCartBardana.Text) + Convert.ToDouble(txtCartSotari.Text));
                            string sqlB = "update VoucherDetails set Debit=" + bardanaSotari + ",Credit=0,Narration='" + Na + "' where VocNo=" + txtInvoiceId.Text + " AND VocType='" + VoucherType.SV + "' AND AcCode="+Accounts.BardanaSale.GetHashCode()+"";
                            db.Execute(sqlB);
                            string NaL = "Labour Pay Recive From " + comboCusName.Text + "@Bill No:" + txtInvoiceId.Text;
                            string sqlL = "update VoucherDetails set Debit=" + txtLaborAmount.Text + ",Credit=0,Narration='" + NaL + "' where VocNo=" + txtInvoiceId.Text + " AND VocType='" + VoucherType.SV + "' AND AcCode="+Accounts.CottonCakeLabourPay.GetHashCode()+"";
                            db.Execute(sqlL);
                            MessageBox.Show("Update  Successfully!!!", "Record Saved Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Record Not Update !!!", "Record Saved Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                if (txtPayment.Text != "" && Convert.ToInt32(txtCusID.Text) != 1)
                {
                    //Debit Entry for payment entery
                    string Narr = "@Cash Cash Recive From " + comboCusName.Text + " Against Cotton Cake BillNo:  " + txtInvoiceId.Text;
                    string sql6 = "update VoucherDetails set Debit=" + txtPayment.Text + ",Credit=0,Narration='" + Narr + "' where  VocNo=" + txtInvoiceId.Text + " AND VocType='" + VoucherType.SV + "' AND AcCode="+Accounts.CashInHand.GetHashCode()+"";
                    Narr = "@Amount Added " + comboCusName.Text + " Accounts Against Cotton Cake BillNo:  " + txtInvoiceId.Text;
                    string sql7 = "update VoucherDetails set Credit=" + txtPayment.Text + ",Narration='" + Narr + "' where  VocNo=" + txtInvoiceId.Text + " AND VocType='" + VoucherType.SV + "' AND AcCode=" + txtCusID.Text + " AND Debit=0";
                    if (db.Execute(sql7) > 0 && db.Execute(sql6) > 0)
                    {
                        MessageBox.Show("Update Succssfully Customers Account");
                    }
                    else
                    {
                        string Narration = "@Cash Cash Recive From " + comboCusName.Text + " Against Cotton Cake BillNo:  " + txtInvoiceId.Text;
                        //Debit Entry for payment
                        sql6 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtInvoiceId.Text + ",'" + VoucherType.SV + "',1," + txtPayment.Text + ",0,'" + Narration + "')";
                        db.Execute(sql6);
                        //Credit Entry for payment
                        Narration = "@Amount Added " + comboCusName.Text + " Accounts Against Cotton Cake BillNo:  " + txtInvoiceId.Text;
                        string sqli = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtInvoiceId.Text + ",'" + VoucherType.SV + "'," + txtCusID.Text + ",0," + txtPayment.Text + ",'" + Narration + "')";
                        db.Execute(sqli);
                        MessageBox.Show("Insert Succssfully Customers Account");
                    }
                }
                btnInvoiceUpdate.Enabled = false;
                txtClear();
                atuoKeyGenrate();
                btnInvoiceSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void dataGridViewShopingCart_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            validate.rowNumberMathod(e, dataGridViewShopingCart, this);
            validate.DataGridSetColor(dataGridViewShopingCart);
        }
        private void dataGridViewShopingCart_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAccountNew frm = new frmAccountNew();
            DataHolder.checkForm = "Sale";
            frm.Show();
            frm.Cus();

        }

        private void txtSotari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddToCart();
            }
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInvoiceNo.Text != "" && Convert.ToInt32(txtInvoiceNo.Text) != 0)
                {
                    DataHolder.InvoiceNo = Convert.ToInt32(txtInvoiceNo.Text);
                    db.Execute("delete from Temp");
                    db.Execute("insert into Temp (F1) values(" + DataHolder.InvoiceNo + ")");
                    frmReport frm = new frmReport();
                    frm.rptViewer.ReportSource = new Invoice();
                    frm.Text = "Inovice";
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Please Enter Bill Number", "Bill Number Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void txtWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void txtLaborPay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }
        private void txtRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQty.Focus();
            }
        }
        private void chkWeight_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWeight.Checked == true)
            {
                txtTotalWeight.ReadOnly = false;
                txtQty.Text = "" + 0;
                txtWeight.Text = "" + 0;
            }
            else
            {
                txtTotalWeight.ReadOnly = true;
                txtQty.Clear();
                txtWeight.Clear();
            }

        }

        private void txtTotalWeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTotalWeight.Text != "" && chkWeight.Checked == true)
                {
                    txtAmount.Text = String.Format("{0:0.00}", (Convert.ToDouble(txtTotalWeight.Text) / 37.324) * Convert.ToDouble(txtRate.Text));
                    txtTotalAmount.Text = String.Format("{0:0.00}", (Convert.ToDouble(txtTotalWeight.Text) / 37.324) * Convert.ToDouble(txtRate.Text));
                }
                else
                    txtAmount.Text = "" + 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOilSearch_Click(object sender, EventArgs e)
        {
            GetOilData();
        }

        private void GetOilData()
        {
            try
            {
                decimal totWeight = 0;
                decimal totAmount = 0;
                string sql = "select * from OilSales ";
                reader = db.selectQuery(sql);
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["OilID"], reader["InvoiceDate"], reader["CustomerName"], reader["ProductName"], reader["Rate"], reader["Weight"], reader["OilCommision"], reader["TotalAmount"], reader["Payment"], reader["DuePayment"], "Edit", "Delete");
                    totWeight = (totWeight + Convert.ToDecimal(reader["Weight"]));
                    totAmount = (totAmount + Convert.ToDecimal(reader["TotalAmount"]));
                }
                txtOilToAmount.Text = Decimal.Round(totAmount, 0).ToString();
                txtOilTotalWt.Text = Decimal.Round(totWeight, 0).ToString();
                if (totAmount > 0 && totWeight > 0)
                    txtOilAvgRate.Text = Decimal.Round(totAmount / (totWeight / Convert.ToDecimal(37.324)), 0).ToString();
                else txtOilAvgRate.Text = "" + 0;
                db.ConnectionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Oil data fetching..
        private void comboOilProduct_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                double totWeight = 0;
                double totAmount = 0;
                double avgRate = 0;
                string sql = "select * from OilSales where ProductName='" + comboOilProduct.Text + "'";
                reader = db.selectQuery(sql);
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["OilID"], reader["InvoiceDate"], reader["CustomerName"], reader["ProductName"], reader["Rate"], reader["Weight"], reader["OilCommision"], reader["TotalAmount"], reader["Payment"], reader["DuePayment"]);
                    totWeight = (totWeight + Convert.ToDouble(reader["Weight"]));
                    totAmount = (totAmount + Convert.ToDouble(reader["TotalAmount"]));
                }
                txtOilToAmount.Text = totAmount.ToString();
                txtOilTotalWt.Text = totWeight.ToString();
                txtOilAvgRate.Text = (totAmount / (totWeight / 37.324)).ToString();
                db.ConnectionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnInvoiceSave.Focus();
            }
        }

        private void txtBardana2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCartAmount.Text != "" && txtPayment.Text != "")
                {
                    double totalAmount = Convert.ToDouble(txtCartAmount.Text);
                    double payAmount = Convert.ToDouble(txtPayment.Text);
                    if (payAmount < totalAmount)
                    {
                        txtDuePayment.Text = Decimal.Round(Convert.ToDecimal((Convert.ToDouble(txtCartAmount.Text) - Convert.ToDouble(txtPayment.Text)))).ToString();
                    }
                    else
                    {
                        txtDuePayment.Text = "" + 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                if (dataGridView1.RowCount >= 1)
                {
                    GetRecord(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
                    GetOilData();
                }
            }
            if (e.ColumnIndex == 11)
            {
                if (dataGridView1.RowCount >= 1)
                {
                    int affactedRows = 0;
                    try
                    {
                        string sql = "delete from OilSales where OilID = " + dataGridView1.Rows[e.RowIndex].Cells[0].Value + " ";
                        string sql4 = "delete from vouchers where VocNo =" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + " AND VocType = '" + VoucherType.Oil + "' ";
                        string sql3 = "delete from VoucherDetails where VocNo =" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + " AND VocType = '" + VoucherType.Oil + "'";
                        affactedRows = db.Execute(sql3);
                        if (affactedRows > 0)
                        {
                            db.Execute(sql);
                            db.Execute(sql4);
                            MessageBox.Show("Deleted Successfully!!!", "Delete Record Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetOilData();
                        }
                        else
                        {
                            MessageBox.Show(" No Record Delete !!!", "Delete Record Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void GetRecord(Int32 VocNo)
        {
            frmCottonOil frm = new frmCottonOil();
            SqlDataReader redr;
            try
            {
                string sql = "select * from OilSales where OilID=" + VocNo + "";
                redr = db.selectQuery(sql);
                if (redr.Read())
                {
                    frm.txtInvoiceId.Text = redr["OilID"].ToString();
                    frm.dpInvoice.Value = Convert.ToDateTime(redr["InvoiceDate"]);
                    frm.txtCusID.Text = redr["CusID"].ToString();
                    frm.comboCusName.Text = redr["CustomerName"].ToString();
                    frm.comboProduct.Text = redr["ProductName"].ToString();
                    frm.txtRate.Text = redr["Rate"].ToString();
                    frm.txtWeight.Text = redr["Weight"].ToString();
                    frm.txtOilTotalAmount.Text = redr["Amount"].ToString();
                    frm.txtCommission.Text = redr["OilCommision"].ToString();
                    frm.txtAmount.Text = redr["TotalAmount"].ToString();
                    frm.txtOilPayment.Text = redr["Payment"].ToString();
                    frm.txtDuepayment.Text = redr["DuePayment"].ToString();
                }
                else
                {
                    MessageBox.Show("Record not Found !!!", "Record Found Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                redr.Close();
                // db.ConnectionClose();
                frm.btnUpdate.Enabled = true;
                frm.btnDelete.Enabled = true;
                frm.btnSave.Enabled = false;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}



