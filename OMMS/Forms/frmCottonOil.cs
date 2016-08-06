
using OMMS.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMMS
{
    public partial class frmCottonOil : Form
    {
        Validation validate = new Validation();
        DbAdapter db = new DbAdapter();
        SqlDataReader reader;
        frmMain main;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmCottonOil()
        {
            InitializeComponent();

            comboProduct.SelectedIndex = 0;
            getCusData();
            atuoKeyGenrate();
        }
        private void frmCottonOil_Load(object sender, EventArgs e)
        {
           
        }
        public void atuoKeyGenrate()
        {
            string sql = "select max(OilID) from OilSales";
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboProduct.Text == "Cotton Oil" && txtWeight.Text != "")
                {
                    double amount = (Convert.ToDouble(txtWeight.Text) / 37.324) * Convert.ToDouble(txtRate.Text);
                    double comission = ((amount / 100) * .25);
                    txtCommission.Text =Decimal.Round(Convert.ToDecimal(comission)).ToString();
                    txtOilTotalAmount.Text = Decimal.Round(Convert.ToDecimal(amount)).ToString();
                    txtAmount.Text = Decimal.Round(Convert.ToDecimal(amount)).ToString();
                    txtOilPayment.Text = Decimal.Round(Convert.ToDecimal(amount)).ToString();
                    if (txtWeight.Text == "")
                    {
                        txtAmount.Text = "" + 0;
                        txtCommission.Text = "" + 0;
                        txtOilPayment.Text = "" + 0;
                    }
                    return;
                }
                if (comboProduct.Text == "Cotton Dirty" && txtWeight.Text != "")
                {
                    double amount = (Convert.ToDouble(txtWeight.Text) / 40) * Convert.ToDouble(txtRate.Text);
                    txtAmount.Text = String.Format("{0:0.00}", amount);
                    txtOilPayment.Text = String.Format("{0:0.00}", amount);
                    if (txtWeight.Text == "")
                    {
                        txtAmount.Text = "" + 0;
                        txtOilPayment.Text = "" + 0;
                    }

                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void getCusData()
        {
            string sql = "select AcTitle as CustomerName, ACCode As CustomerID from Accounts";
            reader = db.selectQuery(sql);
            comboCusName.Items.Clear();
            while (reader.Read())
            {
                comboCusName.Items.Add(reader[0]);
            }
            comboCusName.SelectedIndex = 0;
            //db.ConnectionClose();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtClear();
        }

        private void txtClear()
        {
            comboCusName.SelectedIndex = 0;
            txtRate.Clear();
            txtCommission.Text = "" + 0;
            txtWeight.Clear();
            txtAmount.Text = "" + 0;
            txtOilTotalAmount.Text = "" + 0;
            txtOilPayment.Text=""+0;
            txtInvoiceId.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            atuoKeyGenrate();
        }

        private void comboCusName_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCusID();
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

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.digitValidationMathod(e,txtRate);
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.digitValidationMathod(e, txtWeight);
        }

        private void comboCusName_KeyDown(object sender, KeyEventArgs e)
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

        private void txtWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
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
            if (txtOilPayment.Text == "")
            {

                MessageBox.Show("Please Enter the payment amount", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOilPayment.Focus();
                return;
            }
                String Narration = null;
                string sql = "insert into OilSales(OilID,InvoiceDate,CusID,CustomerName,ProductName,Rate,Weight,Amount,OilCommision,TotalAmount,Payment,DuePayment) values(" + txtInvoiceId.Text + ",'" + dpInvoice.Value.ToString("MM-dd-yyyy") + "'," + txtCusID.Text + ",'" + comboCusName.Text + "','" + comboProduct.Text + "'," + txtRate.Text + "," + txtWeight.Text + "," + txtOilTotalAmount.Text + "," + txtCommission.Text + "," + txtAmount.Text + "," + txtOilPayment.Text + ","+txtDuepayment.Text+" )";
                if (db.Execute(sql) > 0)
                {
                    DataHolder.InvoiceNo = Convert.ToInt32(txtInvoiceId.Text);
                    //for voucher
                    String sql3 = "insert into Vouchers(VocNo,VocType,VocDate) values(" + txtInvoiceId.Text + ",'"+VoucherType.Oil+"','" + dpInvoice.Value.ToString("MM-dd-yyyy") + "')";
                    if (db.Execute(sql3) > 0)
                    {
                        //Debit Entry for sales entery
                        Narration = comboProduct.Text+"Added to" + comboCusName.Text + " Account @WT= " + txtWeight.Text + " @Rate= " + txtRate.Text + "@BillNo: " + txtInvoiceId.Text;
                        String sql4 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtInvoiceId.Text + ",'"+VoucherType.Oil+"'," + txtCusID.Text + "," + txtAmount.Text + ",0,'" + Narration + "')";
                        if (db.Execute(sql4) > 0)
                        {
                            //Credit Entry for sales
                            Narration =  "Added to Sale Account @WT= " + txtWeight.Text + "@Rate= " + txtRate.Text + "@BillNo: " + txtInvoiceId.Text;
                            String sql5 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtInvoiceId.Text + ",'"+VoucherType.Oil+"',"+Accounts.SalesAccount.GetHashCode()+",0," + txtAmount.Text + ",'" + Narration + "')";

                            if (db.Execute(sql5) > 0)
                            {
                                DataHolder.InvoiceNo = Convert.ToInt32(txtInvoiceId.Text);
                                MessageBox.Show("Saved Successfully!!!", "Record Saved Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Record Not Saved !!!", "Record Saved Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                if (Convert.ToDouble(txtOilPayment.Text) != 0 && txtOilPayment.Text != "" && comboCusName.Text != "Cash In Hand")
                {
                    //Debit Entry for payment entery
                    Narration = "Cash Recive From " + comboCusName.Text + " Against Cotton Oil BillNo: " + txtInvoiceId.Text;
                    string sql6 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtInvoiceId.Text + ",'"+VoucherType.Oil+"',"+Accounts.CashInHand.GetHashCode()+"," + txtOilPayment.Text + ",0,'" + Narration + "')";
                    db.Execute(sql6);
                    //Credit Entry for payment
                    Narration = "Cash Added to " + comboCusName.Text + " Account Against Cotton Oil BillNo: " + txtInvoiceId.Text;
                    string sql7 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtInvoiceId.Text + ",'"+VoucherType.Oil+"'," + txtCusID.Text + ",0," + txtOilPayment.Text + ",'" + Narration + "')";
                    db.Execute(sql7);
                    MessageBox.Show("Saved Successfully");
                }
                txtClear();
                atuoKeyGenrate();
               
        }
        private void txtPayment_KeyDown(object sender, KeyEventArgs e)
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
                if (txtAmount.Text != "" && txtOilPayment.Text != "")
                {
                    txtDuepayment.Text = Decimal.Round(Convert.ToDecimal(txtAmount.Text) - Convert.ToDecimal(txtOilPayment.Text),0).ToString();
                }
                else
                    txtDuepayment.Text = "" + 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
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
            if (txtOilPayment.Text == "")
            {

                MessageBox.Show("Please Enter the payment amount", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOilPayment.Focus();
                return;
            }
            String Narration = null;
            string sql = "update  OilSales set InvoiceDate='" + dpInvoice.Value.ToString("MM-dd-yyyy") + "',CusID=" + txtCusID.Text + ",CustomerName='" + comboCusName.Text + "',ProductName='" + comboProduct.Text + "',Rate=" + txtRate.Text + ",Weight=" + txtWeight.Text + ",Amount=" + txtOilTotalAmount.Text + ",OilCommision=" + txtCommission.Text + ",TotalAmount=" + txtAmount.Text + ",Payment=" + txtOilPayment.Text + ",DuePayment=" + txtDuepayment.Text + " where OilID = " + txtInvoiceId.Text + "";
            if (db.Execute(sql) > 0)
            {
                DataHolder.InvoiceNo = Convert.ToInt32(txtInvoiceId.Text);
                //for voucher
                    //Debit Entry for sales entery
                    Narration = comboProduct.Text + "Added to" + comboCusName.Text + " Account @WT= " + txtWeight.Text + " @Rate= " + txtRate.Text + " @BillNo: " + txtInvoiceId.Text;
                    String sql4 = "update VoucherDetails set Debit=" + txtAmount.Text + ",Narration='" + Narration + "'  where VocNo=" + txtInvoiceId.Text + " AND VocType='" + VoucherType.Oil + "' AND AcCode=" + txtCusID.Text + " AND Credit=0 And Debit !=0";
                    if (db.Execute(sql4) > 0)
                    {
                        //Credit Entry for sales
                        Narration = "Added to Sale Account @WT= " + txtWeight.Text + " @Rate= " + txtRate.Text + " @BillNo: " + txtInvoiceId.Text;
                        String sql5 = "update VoucherDetails set Debit=0,Credit=" + txtAmount.Text + ", Narration='" + Narration + "'  where VocNo=" + txtInvoiceId.Text + " AND VocType='"+VoucherType.Oil+"' AND AcCode="+Accounts.SalesAccount.GetHashCode()+"";

                        if (db.Execute(sql5) > 0)
                        {
                            DataHolder.InvoiceNo = Convert.ToInt32(txtInvoiceId.Text);
                            MessageBox.Show("Update Successfully Successfully!!!", "Record Saved Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Record Not Saved !!!", "Record Update Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

            if (Convert.ToInt32(txtOilPayment.Text) != 0 && Convert.ToInt32(txtCusID.Text) != 1)
            {
                //Debit Entry for payment entery
                string Narr = "@Cash Cash Recive From " + comboCusName.Text + " Against Cotton Cake BillNo:  " + txtInvoiceId.Text;
                string sql6 = "update VoucherDetails set Debit=" + txtOilPayment.Text + ",Credit=0,Narration='" + Narr + "' where  VocNo=" + txtInvoiceId.Text + " AND VocType='" + VoucherType.Oil + "' AND AcCode=" + Accounts.CashInHand.GetHashCode() + "";
                Narr = "@Amount Added " + comboCusName.Text + " Accounts Against Cotton Cake BillNo:  " + txtInvoiceId.Text;
                string sql7 = "update VoucherDetails set Credit=" + txtOilPayment.Text + ",Narration='" + Narr + "' where  VocNo=" + txtInvoiceId.Text + " AND VocType='" + VoucherType.Oil + "' AND AcCode=" + txtCusID.Text + " AND Debit=0";
                if (db.Execute(sql7) > 0 && db.Execute(sql6) > 0)
                {
                    MessageBox.Show("Update Succssfully Customers Account");
                }
                else {
                    //Debit Entry for payment entery
                    Narration = "Cash Recive From " + comboCusName.Text + " Against Cotton Oil BillNo:" + txtInvoiceId.Text;
                    string sql8 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtInvoiceId.Text + ",'"+VoucherType.Oil+"',"+Accounts.CashInHand.GetHashCode()+"," + txtOilPayment.Text + ",0,'" + Narration + "')";
                    db.Execute(sql8);
                    //Credit Entry for payment
                    Narration = "Cash Added To " + comboCusName.Text + " Accounr Against Cotton Oil BillNo:" + txtInvoiceId.Text;
                    string sql9 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtInvoiceId.Text + ",'"+VoucherType.Oil+"'," + txtCusID.Text + ",0," + txtOilPayment.Text + ",'" + Narration + "')";
                    db.Execute(sql9);
                    MessageBox.Show("Saved Successfully");
                }
            }
            txtClear();
            atuoKeyGenrate();
            
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
