using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using OMMS.Reporting;
using OMMS.Enums;
//using Hamza_Oil_Milles.Forms;

namespace OMMS
{
    public partial class frmPurchase : Form
    {
        SqlDataReader reader;
        // Create Object of DBAdapter Class
        DbAdapter db = new DbAdapter();
        Validation validate = new Validation();
        // Create Object of FormValidation Class
        //FormValidationClass validate = new FormValidationClass();
        public frmPurchase()
        {
            InitializeComponent();
        }
        /*#################################### First Tab Codding   ####################################*/
        private void SuppliersForm_Load(object sender, EventArgs e)
        {
            getMax();
            getEpenceAC();
            dataGridView1.RowTemplate.MinimumHeight = 30;
            
           // dataGridView3.RowTemplate.MinimumHeight = 40;
           // GetDataFirstDataGridView();
           // countingMathod();
        }
        public void getEpenceAC()
        {
            try
            {
                string sql = "select AcTitle, ACCode  from Accounts where AcTitle !='Carage' OR AcType ='Cash'";
                reader = db.selectQuery(sql);
                while (reader.Read())
                {
                    comboExpenceAccount.Items.Add(reader[0]);
                }
                db.ConnectionClose();
                comboExpenceAccount.SelectedIndex = 0;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*#################################### Code for  Combo Box And ID genrater ####################################*/
        public void getMax()
        {
            String sql = "select MAX(ID)   from Purchases";
            String sql2 = "select (AcTitle) from Accounts where AcType='Supplier'";
            try
            {
                reader = db.selectQuery(sql);
                if (reader.Read()){
                    if (Convert.ToString(reader[0]) != "")
                    {
                        txtSeedID.Text = (Convert.ToInt32(reader[0]) + 1).ToString();
                    }
                    else {
                        txtSeedID.Text = "" + 1;            
                           }
                }
                db.ConnectionClose();
                reader = db.selectQuery(sql2);
                factoryCombo1.Items.Clear();
                while (reader.Read())
                {
                    factoryCombo1.Items.Add(reader["AcTitle"]);
                }
                db.ConnectionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getAccountType()
        {
            string sql = "select distinct (AcTitle) from Accounts where AcType='Supplier' ";
            reader = db.selectQuery(sql);
           // cmbAcType.Items.Clear();
            while (reader.Read())
            {
              //  cmbAcType.Items.Add(reader[0]);
            }
            db.ConnectionClose();
        }
        /*#################################### Get Data For First Data Grid View ####################################*/
    /*    public void GetDataFirstDataGridView()
        {
            String sql = "select ID,Date,FactoryName,Quantity,Rate,TotalAmount from HamzaDb.dbo.Purchases order by ID DESC";
            try
            {
                dataGridView3.Rows.Clear();
                reader = db.selectQuery(sql);
                while (reader.Read())
                {
                    dataGridView3.Rows.Add(reader[0], reader[1].ToString().Substring(0, 10), reader[2], reader[3], reader[4], reader[5]);
                }
                db.ConnectionClose();
                for (int i = 0; i <= dataGridView3.RowCount - 1; i++)
                {
                    if (i % 2 != 0)
                    {
                        dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.Gainsboro;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
         try}
        }
        /*#################################### Mathod Call For Header Color ####################################*/
        private void dataGridView3_Paint(object sender, PaintEventArgs e)
        {
           // validate.DataGridSetColor(dataGridView3);
        }
        /*#################################### Mathod Call For Header Row Number  ####################################*/
        private void dataGridView3_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
          //  validate.rowNumberMathod(e, dataGridView3, this);
        }
       

        /*#################################### Code for  New  Button ####################################*/
        private void btnNew_Click_1(object sender, EventArgs e)
        {
            ClearDataMathod();
        }

        private void ClearDataMathod()
        {
            txtWeight2.Clear();
            txtSeedID.Clear();
            factoryCombo1.Text = "";
            txtBiltyNo.Clear();
            txtLabor.Clear();
            txtLaborAmount.Clear();
            txtGariNo.Clear();
            txtQty.Clear();
            txtWeight.Clear();
            txtRate.Clear();
            txtNotes.Clear();
            txtTax.Clear();
            txtTaxPer.Text=""+0;
            txtTotalAmount.Clear();
            txtAmount.Text=""+0;
            txtCareage.Clear();
            getMax();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
        }
        /*#################################### Save Button Codding ####################################*/
        private void btnSave_Click_1(object sender, EventArgs e)
        {
         if (factoryCombo1.Text == "")
            {
                MessageBox.Show("Plese Enter the Factory Name..", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtBiltyNo.Text == "")
            {
                MessageBox.Show("Plese Enter the Supplier Address..", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtGariNo.Text == "")
            {
                MessageBox.Show("Plese Enter the Supplier City..", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtQty.Text == "")
            {
                MessageBox.Show("Plese Enter the Supplier Conntect No..", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtWeight.Text == "")
            {
                MessageBox.Show("Plese Enter the Supplier Conntect No ..", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                String query = "insert into Purchases values('" + txtSeedID.Text + "','" + dpSeed.Value.ToString("MM-dd-yyyy") + "'," + txtSupplierID.Text + ",'" + txtBiltyNo.Text + "','" + txtGariNo.Text + "'," + txtQty.Text + "," + txtWeight2.Text + "," + txtWeight.Text + "," + txtRate.Text + "," + txtAmount.Text + "," + txtLabor.Text + "," + txtLaborAmount.Text + "," + txtCareage.Text + "," + txtTax.Text + "," + txtTotalAmount.Text + ",'" + txtNotes.Text + "') ";
                if (db.Execute(query) > 0)
                {
                    //for voucher
                    String sql3 = "insert into Vouchers(VocNo,VocType,VocDate) values(" + txtSeedID.Text + ",'" + VoucherType.PV + "','" + dpSeed.Value.ToString("MM-dd-yyyy") + "')";
                    if (db.Execute(sql3) > 0) 
                    {
                        String Narration = "Cotton Seed " + factoryCombo1.Text + "@WT" + txtWeight.Text + "Kg " + "@Rate" + txtRate.Text;
                        String Narration2 = "Carage pay to " + factoryCombo1.Text+" Vehicle Driver";
                        double FacAmount = (Convert.ToDouble(txtTotalAmount.Text) - Convert.ToDouble(txtCareage.Text));
                        //Credit Entry for Purchase
                        sql3 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtSeedID.Text + ",'" + VoucherType.PV+ "'," + txtSupplierID.Text + ",0," +FacAmount+ ",'" + Narration + "')";
                        db.Execute(sql3);
                        //Debit Entry for Purchase 
                        sql3 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtSeedID.Text + ",'" + VoucherType.PV+ "',"+Accounts.PurchaseAccount.GetHashCode()+"," + txtTotalAmount.Text + ",0,'" + Narration + "')";
                        db.Execute(sql3);
                        //Carege Entry for Purchase 
                        Narration2 = "Carage Add to " + comboExpenceAccount.Text + " Vehicle Account";
                        sql3 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtSeedID.Text + ",'" + VoucherType.PV + "'," + Accounts.Carage.GetHashCode() + "," + txtCareage.Text + ",0,'" + Narration2 + "')";
                        db.Execute(sql3);

                        string NaL = "Labour Pay To " + factoryCombo1.Text + "@Bill No:" + txtBiltyNo.Text;
                        string sqlL = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtSeedID.Text + ",'" + VoucherType.PV + "'," + Accounts.SeedLaborPay.GetHashCode() + "," + txtLaborAmount.Text + ",0,'" + NaL + "')";
                        db.Execute(sqlL);

                        MessageBox.Show("Saved Successfully", "Saved Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("VouCher Not Saved", "Saved Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
                else 
                    MessageBox.Show("No Record Saved", "Saved Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
  
                getMax();
                ClearDataMathod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /*#################################### Update Button Codding Codding ####################################*/
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (factoryCombo1.Text == "")
            {
                MessageBox.Show("Plese Enter the Factory Name..", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            String query = "update  sims.supplier_tb  set SupplierName ='" + txtSupplierID.Text + "',Address ='" + txtBiltyNo.Text + "',City ='" + txtGariNo.Text + "',ContectNo ='" + txtQty.Text + "',AltContectNo ='" + txtWeight.Text + "',Email ='" + txtRate.Text + "',Notes ='" + txtNotes.Text + "' where SupplierID = '" + txtSeedID.Text + "' ";
            db.Execute(query);
            dataGridView1.Rows.Clear();
        }
        /*#################################### Quantity Validate Codding ####################################*/
        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.digitValidationMathod(e, txtQty);
        }
        /*#################################### Rate Validate Codding ####################################*/
        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.DecimalValiation(e, txtRate);
        }
        /*#################################### Carege Validate Codding ####################################*/
        private void txtCareage_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.DecimalValiation(e, txtCareage);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SupPrintPreviewDialog.Document = SupPrintDocument;
            SupPrintPreviewDialog.ShowDialog();
        }
        /*#################################### Calculate Weight Codding ####################################*/
        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            //if (txtQty.Text != "")
//txtWeight.Text = (Convert.ToInt32(txtQty.Text) * 37.324).ToString();
         //   else
            //    txtWeight.Text = "0";
        }
        /*#################################### Calculate Labor Amount Codding ####################################*/
        private void txtLabor_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (txtLabor.Text != "")
                {
                    Double a = Convert.ToDouble(txtQty.Text);
                    Double b = Convert.ToDouble(txtLabor.Text);

                    txtLaborAmount.Text = Decimal.Round(Convert.ToDecimal((a * b)),0).ToString();
                }
                //else
                    //txtTotalLaborPay.Text = "" + 0;
                if (txtAmount.Text != "" && txtLaborAmount.Text != "" && txtCareage.Text != "" && txtTax.Text != "")
                {
                    txtTotalAmount.Text = (Convert.ToDouble(txtAmount.Text) + Convert.ToDouble(txtLaborAmount.Text) + Convert.ToDouble(txtCareage.Text) + Convert.ToDouble(txtTax.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        /*#################################### Calculate Amount With Laboe Amount Codding ####################################*/
        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtRate.Text != "" && txtQty.Text != "")
                {
                    double a = Convert.ToDouble(txtQty.Text);
                    double b = Convert.ToDouble(txtRate.Text);
                    double c = Convert.ToDouble(txtWeight.Text);
                    double amount = a * b;
                    txtAmount.Text = "" + Decimal.Round(Convert.ToDecimal((c / 37.324 * b)),0);

                }
                else
                    txtAmount.Text = "" + 0;

                if (txtAmount.Text != "" && txtLaborAmount.Text != "" && txtCareage.Text != "" && txtTax.Text != "")
                {
                    txtTotalAmount.Text = (Convert.ToDouble(txtAmount.Text) + Convert.ToDouble(txtLaborAmount.Text) + Convert.ToDouble(txtCareage.Text) + Convert.ToDouble(txtTax.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*#################################### Calculate Total Amount Codding ####################################*/
        private void txtCareage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCareage.Text != "" && txtAmount.Text != "")
                {
                    txtTotalAmount.Text = (Convert.ToDouble(txtAmount.Text) + Convert.ToDouble(txtCareage.Text) + Convert.ToDouble(txtLaborAmount.Text)).ToString();
                }
                else
                    txtTotalAmount.Text = "" + 0;
                if (txtAmount.Text != "" && txtLaborAmount.Text != "" && txtCareage.Text != "" && txtTax.Text != "")
                {
                    txtTotalAmount.Text = (Convert.ToDouble(txtAmount.Text) + Convert.ToDouble(txtLaborAmount.Text) + Convert.ToDouble(txtCareage.Text) + Convert.ToDouble(txtTax.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*#################################### Second Tab Codding ####################################*/
        /*#################################### data Grid View Edit && Delete Button Codding ####################################*/
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 15)
            {
                try
                {
                    tabPageAddSeed.Show();
                    tabPageSeedDetails.Hide();
                    txtSeedID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    factoryCombo1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtGariNo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtBiltyNo.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtQty.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtWeight2.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    txtWeight.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    txtRate.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    txtAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                    txtLabor.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                    txtLaborAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                    txtTax.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
                    txtCareage.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                    txtTotalAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
                    txtNotes.Text = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = true;
                    //btnDalete.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Row is Empty \n" + ex.Message);
                }
            }
            if (e.ColumnIndex == 16)
            {
                if (MessageBox.Show("Do You really Want to Delete this Value", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    String sql = "delete from Purchases where ID = " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + " ";
                    String sql2 = "delete from VoucherDetails where VocNo = " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "AND VocType='" + VoucherType.PV+ "' ";
                    String sql3 = "delete from Vouchers where VocNo = " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + " AND VocType='" + VoucherType.PV+ "' ";
                    if (db.Execute(sql) > 0)
                    {
                        db.Execute(sql2);
                        db.Execute(sql3);
                        MessageBox.Show("Deleted Successfully", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("No Record Delete", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getMax();
                }
            }
        }
        /*#################################### Data Grid View Fill Codding ####################################*/
           private void btnSearch_Click(object sender, EventArgs e)
        {
            double totQty = 0;
            double totWeight = 0;
            double totCage = 0;
            double totTotalAmount = 0;
            double totLabotPay = 0;
            double totAmount = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(db.cs))
                {
                    SqlCommand cmd = new SqlCommand("SP_GetPurchase", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StartDate", string.IsNullOrEmpty(dtStartDate.Value.ToString()) ? (object)DBNull.Value : dtStartDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@EndDate", string.IsNullOrEmpty(dtEndDate.Value.ToString()) ? (object)DBNull.Value : dtEndDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Factory", DBNull.Value);//string.IsNullOrEmpty(ddFactory.SelectedValue.ToString()) ? (object)DBNull.Value : ddFactory.SelectedValue);
                    cmd.Parameters.AddWithValue("@BillNo", string.IsNullOrEmpty(txtInvoiceNo.Text) ? (object)DBNull.Value : txtInvoiceNo.Text);
                    SqlDataAdapter adt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adt.Fill(dt);
                    dataGridView1.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        dataGridView1.Rows.Add(row["ID"], Convert.ToDateTime(row["CreateDate"]).ToString("dd-MM-yyyy"), row["FactoryName"], row["BiltyNo"], row["GariNo"], row["Quantity"], row["AvWeight"], row["Weight"], row["Rate"], row["Amount"], row["Laborpay"], row["LaborAmount"], row["Carege"], row["PurTax"], row["TotalAmount"], "Edit", "Delete", row["Notes"]);
                        totQty = totQty + Convert.ToDouble(row["Quantity"]);
                        totWeight = totWeight + Convert.ToDouble(row["Weight"]);
                        totAmount = totAmount + Convert.ToDouble(row["Amount"]);
                        totCage = totCage + Convert.ToDouble(row["Carege"]);
                        totLabotPay = totLabotPay + Convert.ToDouble(row["LaborAmount"]);
                        totTotalAmount = totTotalAmount + Convert.ToDouble(row["TotalAmount"]);
                    }
                    txtTotalGari.Text = String.Format("{0:0.00}", (totQty / 250));
                    txtTotalQty.Text = String.Format("{0:0.00}", totQty);
                    txtTotalCarege.Text = String.Format("{0:0.00}", +totCage);
                    txtTotalWeight.Text = String.Format("{0:0.00}", totWeight);
                    ////txtTotalLaborPay.Text =String.Format("{0:0.00}",totLabotPay);
                    txtAmount1.Text = String.Format("{0:0.00}", totAmount);
                    txtTotalAmount1.Text = String.Format("{0:0.00}", totTotalAmount);
                    txtAvrageRate.Text = String.Format("{0:0.00}", (totAmount / (totWeight / 37.324)));

                    for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                    {
                        if (i % 2 != 0)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*#################################### Data Grid View Header Codding  ####################################*/
        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            validate.DataGridSetColor(dataGridView1);
        }
        /*#################################### Data Grid View Row Number  Codding #################################*/
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            validate.rowNumberMathod(e, dataGridView1, this);
        }
        /*#################################### Seleted Factory Get Data Codding ####################################*/
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                double FacAmount = (Convert.ToDouble(txtTotalAmount.Text) - Convert.ToDouble(txtCareage.Text));
                String Narration = "Cotton Seed "+factoryCombo1.Text +"@WT " + txtWeight.Text + " Kg " + "@Rate " + txtRate.Text;
                String query = "update Purchases set CreateDate = '" + dpSeed.Value.ToString("MM-dd-yyyy") + "',FactoryID = '" + txtSupplierID.Text + "',BiltyNo = '" + txtBiltyNo.Text + "',GariNo = '" + txtGariNo.Text + "',Quantity = " + txtQty.Text + ",AvWeight = " + txtWeight2.Text + ",Weight = " + txtWeight.Text + ",Laborpay = " + txtLabor.Text + ",LaborAmount = " + txtLaborAmount.Text + ", Rate = " + txtRate.Text + ",Carege = " + txtCareage.Text + ",PurTax = " + txtTax.Text + ",TotalAmount = " + txtTotalAmount.Text + ", Notes = '" + txtNotes.Text + "' where ID = " + txtSeedID.Text + " ";
                String sql3 = "update  VoucherDetails set Debit=" + txtTotalAmount.Text + " ,Narration='" + Narration + "' where  VocNo=" + txtSeedID.Text + " AND VocType='" + VoucherType.PV + "' AND AcCode=" + Accounts.PurchaseAccount.GetHashCode() + " AND Credit=0";
                String sql4 = "update  VoucherDetails set Credit=" + txtCareage.Text + " ,Narration='" + Narration + "' where  VocNo=" + txtSeedID.Text + " AND VocType='" + VoucherType.PV + "' AND AcCode= " + Accounts.CashInHand.GetHashCode() + " AND Debit=0";
                String sql5 = "update  VoucherDetails set Credit=" + FacAmount + " ,Narration='" + Narration + "' where  VocNo=" + txtSeedID.Text + " AND VocType='" + VoucherType.PV+ "' AND AcCode=" + txtSupplierID.Text + " AND Debit=0";
                String sql6 = "update  VoucherDetails set Debit=" + txtCareage.Text + " ,Narration='" + Narration + "' where  VocNo=" + txtSeedID.Text + " AND VocType='" + VoucherType.PV + "' AND AcCode=" + Accounts.Carage.GetHashCode() + " AND Credit=0";
                string NaL = "Labour Pay To " + factoryCombo1.Text + "@Bill No:" + txtBiltyNo.Text;
                string sqlL = "update  VoucherDetails set Debit=" + txtLaborAmount.Text + ",Credit=0,Narration='" + NaL + "' Where  VocNo=" + txtSeedID.Text + " AND VocType='" + VoucherType.PV + "' AND AcCode=" + Accounts.SeedLaborPay.GetHashCode() + "";
                if (db.Execute(query) > 0)
                {
                    db.Execute(sql3);
                    db.Execute(sql4);
                    db.Execute(sql5);
                    db.Execute(sql6);
                    db.Execute(sqlL);
                    MessageBox.Show("Updated Successfully", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("No Record Update", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearDataMathod();
                getMax();
                btnUpdate.Enabled = false;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtLabor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.DecimalValiation(e, txtLabor);
        }
        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtQty.Text != "" && txtWeight.Text != "")
                {
                    txtWeight2.Text =Decimal.Round(Convert.ToDecimal(Convert.ToDouble(txtWeight.Text) / Convert.ToDouble(txtQty.Text)),2).ToString();
                }
                if (txtAmount.Text != "" && txtLaborAmount.Text != "" && txtCareage.Text != "")
                {
                    txtTotalAmount.Text = Decimal.Round(Convert.ToDecimal(Convert.ToDouble(txtAmount.Text) + Convert.ToDouble(txtLaborAmount.Text) + Convert.ToDouble(txtCareage.Text)),0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtTexPer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtWeight.Text != "" && txtTaxPer.Text !="")
                {
                    txtTax.Text =Decimal.Round(Convert.ToDecimal((Convert.ToDouble(txtWeight.Text) / 40) * Convert.ToDouble(txtTaxPer.Text)),0).ToString();
                }
                if (txtAmount.Text != "" && txtLaborAmount.Text != "" && txtCareage.Text != "")
                {
                    txtTotalAmount.Text = Decimal.Round(Convert.ToDecimal(Convert.ToDouble(txtAmount.Text) + Convert.ToDouble(txtLaborAmount.Text) + Convert.ToDouble(txtCareage.Text)),0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter Valid Inputs","input Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void txtTax_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtAmount.Text != "" && txtLaborAmount.Text != "" && txtCareage.Text != "" && txtTax.Text != "")
                {
                    txtTotalAmount.Text = (Convert.ToDouble(txtAmount.Text) + Convert.ToDouble(txtLaborAmount.Text) + Convert.ToDouble(txtCareage.Text) + Convert.ToDouble(txtTax.Text)).ToString();
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAccountNew frm = new frmAccountNew();
            DataHolder.checkForm = "Purchase";
            frm.Show();
            frm.Sup();
        }

        private void factoryCombo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select (AcCode) from Accounts where AcType='Supplier' and AcTitle='" + factoryCombo1.Text + "' ";
            reader = db.selectQuery(sql);
            if (reader.Read()) 
            {
            txtSupplierID.Text = reader[0].ToString();
            }
            db.ConnectionClose();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.rptViewer.ReportSource = new PurchaseRpt();
            frm.Show();
        }

        private void factoryCombo1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void txtBiltyNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void txtGariNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
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

        private void txtRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void txtLabor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void txtTaxPer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void txtCareage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void txtNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void comboExpenceAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select (AcCode) from Accounts where AcTitle='" + comboExpenceAccount.Text + "'";
                reader = db.selectQuery(sql);
                if (reader.Read())
                {
                    txtCashAcCode.Text = reader[0].ToString();
                }
                db.ConnectionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTaxPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.DecimalValiation(e, txtTaxPer);
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.DecimalValiation(e, txtWeight);
        }

   

       
      

        

       
    }
}
