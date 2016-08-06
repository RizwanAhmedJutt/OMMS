using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace OMMS
{

    public partial class frmMasterEntry : Form
    {
        //Object of the DBAdapter Class
        DbAdapter db = new DbAdapter();
        //Object of the FormValidation  Class
        Validation validate = new Validation();
        public frmMain main;
        SqlDataReader reader = null;
        public frmMasterEntry()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            Reset();
            MasterTab();
            checkCakeRate();
            checkSeedRate();
            checkOilRate();
            checkDirtyOilRate();
            checkLaborRate();
            dataGridViewExpenceType.Hide();
            dataGridViewExpenceType.RowTemplate.MinimumHeight = 30;
            btnExpenceDelete.Enabled = false;
            btnExpenceUpdate.Enabled = false;
            btnOilUpdate.Enabled = false;
        }
           
        /*############## combo Boxes fill Mathod Coding  ##############*/
        public void checkCakeRate() 
        {
            String query = "select * from CottonCake_tb";
            try
            {
                reader = db.selectQuery(query);
                if (reader.Read())
                {
                    categorySave.Enabled = false;
                }
                else
                {
                    categorySave.Enabled = true;
                }
                db.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void   checkSeedRate()
           {
               String query = "select * from SeedRate_tb";
            try
            {
                reader = db.selectQuery(query);
                if (reader.Read())
                {
                    companySave.Enabled = false;
                }
                else
                {
                    companySave.Enabled = true;
                }
                db.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void checkOilRate()
        {
            String query = "select * from oilRate_tb";
            try
            {
                reader = db.selectQuery(query);
                if (reader.Read())
                {
                    btnOilSave.Enabled = false;
                }
                else
                {
                    btnOilSave.Enabled = true;
                }
                db.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void checkDirtyOilRate()
        {
            String query = "select * from DirtyRate_tb";
            try
            {
                reader = db.selectQuery(query);
                if (reader.Read())
                {
                    btnDirtyOilSave.Enabled = false;
                  
                }
                else
                {
                    btnDirtyOilSave.Enabled = true;
                }
                db.ConnectionClose();
                btnDirtyOilUpdate.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void checkLaborRate()
        {
            String query = "select * from LaborRate_tb";
            try
            {
                reader = db.selectQuery(query);
                if (reader.Read())
                {
                    btnLaborSave.Enabled = false;

                }
                else
                {
                    btnLaborSave.Enabled = true;
                }
                db.ConnectionClose();
                btnLaborUpdate.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*############## Master Entries Control Coding  ##############*/
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you realy want Exit the Application ", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Close();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }
        /*############## Reset Mathod Coding  ##############*/
        public void Reset()
        { //Config Reset
            ResetItemConfig();
                
            updateCakeRate.Enabled = false;
            companyUpdate.Enabled = false;
            updateCakeRate.Enabled = false;
           
            txtCakeRate.Focus();
          
           // setID();
        }


        /* #####################################       Mastter Enteries Category Codding       #######################################*/

        /*############## Category Save Button Coding  ##############*/
        private void button20_Click(object sender, EventArgs e)
        {
            if (txtCakeRate.Text == "")
            {
                MessageBox.Show("Please fill the textfiled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            String query1 = "INSERT INTO CottonCake_tb (CakeID,CakeRate) VALUES('"+txtCakeId.Text+"','" + txtCakeRate.Text + "')";
            if (db.Execute(query1) > 0)
            {
                MessageBox.Show("Saved Successfully", "Saved Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Record Saved", "Saved Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtCakeRate.Clear();
        }
        /*############## Category Delete Button Coding  ##############*/
        private void button19_Click(object sender, EventArgs e)
        {

        }
        /*############## Category Update Button Coding  ##############*/
        private void updateCategory_Click(object sender, EventArgs e)
        {
            String query = "update CottonCake_tb set CakeRate='" + txtCakeRate.Text + "' where CakeId='" + txtCakeId.Text + "' ";
            if (db.Execute(query) > 0)
            {
                MessageBox.Show("Updated Successfully", "Updated Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Record Updated", "Updated Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtCakeRate.Clear();
            btnGetData.Enabled = true;
        }

      
         
        /*############## Category New Button Coding  ##############*/
        private void categoryNew_Click(object sender, EventArgs e)
        {
            String query = "select * from CottonCake_tb";
            try
            {
                reader = db.selectQuery(query);
                while (reader.Read())
                {
                    txtCakeRate.Text = (reader[1].ToString());
                    txtCakeId.Text = (reader[0].ToString());
                }
                db.conn.Close();
              
                updateCakeRate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* #####################################       Mastter Enteries Company Codding       #######################################*/


        /*############## Company Save Button Coding  ##############*/
        private void button15_Click(object sender, EventArgs e)
        {
            if (companytxt.Text == "")
            {
                MessageBox.Show("Please fill the textfiled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            String query = "INSERT INTO SeedRate_tb(SeedID,SeedRate)  VALUES('" + textBox3.Text + "','" + companytxt.Text + "')";
            db.Execute(query);
            companytxt.Clear();
        }
       
        /*############## Company Update Button Coding  ##############*/
        private void companyUpdate_Click(object sender, EventArgs e)
        {
            if (companytxt.Text == "")
            {
                MessageBox.Show("Please fill the textfiled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            String query = "update SeedRate_tb set SeedRate='" + companytxt.Text + "' where SeedID='" + textBox3.Text + "' ";
            if (db.Execute(query) > 0)
            {
                MessageBox.Show("Updated Successfully", "Updated Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Record Updated", "Updated Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            companytxt.Clear();
            companyUpdate.Enabled = false;
           
        }
        /*############## Company GetData Button Coding  ##############*/
     
  
        /*############## Company New Button Coding  ##############*/
        private void companyNew_Click(object sender, EventArgs e)
        {
            String query = "select * from SeedRate_tb";
            try
            {
                reader = db.selectQuery(query);
                while (reader.Read())
                {
                    textBox3.Text = (reader[0].ToString());
                    companytxt.Text = (reader[1].ToString());
                }
                db.conn.Close();
                companyUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /* #####################################       Mastter Enteries Configration Codding       #######################################*/

        /*############## Company new Button Coding  ##############*/
        private void button1_Click(object sender, EventArgs e)
        {
            ResetItemConfig();
            //setID();
        }

        private void ResetItemConfig()
        {
          
           
           
        }
        /*############## Price Text Field Coding  ##############*/
        private void itemPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
           // validate.digitValidationMathod(e);
        }
        public void MasterTab()
        {
            tabPage1.Hide();
            tabPage2.Hide();
            tabPage4.Show();
        }
        private void configGetData_Click(object sender, EventArgs e)
        {
            tabPage4.Hide();
            tabItemRecord.Show();

            //ProductRecordForm frm = new ProductRecordForm();
            //frm.Show();
            //this.Hide();
        }

        private void companytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
           // validate.nameValidationMathod(e);
        }

        private void categoryTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  validate.nameValidationMathod(e);
        }

        private void productCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  validate.digitNameValidationMathod(e);
        }
        private void btnOilGetData_Click(object sender, EventArgs e)
        {
            String query = "select * from OilRate_tb";
            try
            {
                reader = db.selectQuery(query);
                while (reader.Read())
                {
                    txtOilRate.Text = (reader[1].ToString());
                    txtOilId.Text = (reader[0].ToString());
                }
                db.conn.Close();
                btnOilGetData.Enabled = false;
                btnOilUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOilSave_Click(object sender, EventArgs e)
        {
            if (txtOilRate.Text == "")
            {
                MessageBox.Show("Please fill the textfiled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            String query1 = "INSERT INTO oilRate_tb (OilID,OilRate) VALUES('" + txtOilId.Text + "','" + txtOilRate.Text + "')";
            if (db.Execute(query1) > 0)
            {
                MessageBox.Show("Saved Successfully", "Saved Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Record Saved", "Saved Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtOilRate.Clear();
        }

        private void btnOilUpdate_Click(object sender, EventArgs e)
        {
            if (txtOilRate.Text == "")
            {
                MessageBox.Show("Please fill the textfiled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            String query = "update oilRate_tb set OilRate='" + txtOilRate.Text + "' where OilID='" + txtOilId.Text + "' ";
            if (db.Execute(query) > 0)
            {
                MessageBox.Show("Updated Successfully", "Updated Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Record Updated", "Updated Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtOilRate.Clear();
            btnOilUpdate.Enabled = false;
            btnOilGetData.Enabled = true;
        }

        private void btnDirtyOilGetData_Click(object sender, EventArgs e)
        {
            String query = "select * from DirtyRate_tb";
            try
            {
                reader = db.selectQuery(query);
                while (reader.Read())
                {
                    txtDirtyOil.Text = (reader[1].ToString());
                    txtDirtyId.Text = (reader[0].ToString());
                }
                db.conn.Close();
                btnDirtyOilGetData.Enabled = false;
                btnDirtyOilUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDirtyOilSave_Click(object sender, EventArgs e)
        {
            if (txtDirtyOil.Text == "")
            {
                MessageBox.Show("Please fill the textfiled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            String query1 = "INSERT INTO DirtyRate_tb (DirtyID,DirtyRate) VALUES('" + txtDirtyId.Text + "','" + txtDirtyOil.Text + "')";
            db.Execute(query1);
            txtDirtyOil.Clear();
            btnDirtyOilSave.Enabled = false;
        }

        private void btnDirtyOilUpdate_Click(object sender, EventArgs e)
        {
            if (txtDirtyOil.Text == "")
            {
                MessageBox.Show("Please fill the textfiled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            String query = "update DirtyRate_tb set DirtyRate='" + txtDirtyOil.Text + "' where DirtyID='" + txtDirtyId.Text + "' ";
            if (db.Execute(query) > 0)
            {
                MessageBox.Show("Updated Successfully", "Updated Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Record Updated", "Updated Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtDirtyOil.Clear();
            btnDirtyOilUpdate.Enabled = false;
            btnDirtyOilGetData.Enabled = true;
        }

        private void btnLaborSave_Click(object sender, EventArgs e)
        {
            if (txtLabor.Text == "")
            {
                MessageBox.Show("Please fill the textfiled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            String query1 = "INSERT INTO LaborRate_tb (LaborId,LaborRate) VALUES('" + txtLaborId.Text + "','" + txtLabor.Text + "')";
            if (db.Execute(query1) > 0)
            {
                MessageBox.Show("Saved Successfully", "Saved Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Record Saved", "Saved Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtLabor.Clear();
            btnLaborSave.Enabled = false;
        }

        private void btnLaborGetdata_Click(object sender, EventArgs e)
        {
            String query = "select * from LaborRate_tb";
            try
            {
                reader = db.selectQuery(query);
                while (reader.Read())
                {
                    txtLabor.Text = (reader[1].ToString());
                    txtLaborId.Text = (reader[0].ToString());
                }
                db.conn.Close();
                btnLaborGetdata.Enabled = false;
                btnLaborUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLaborUpdate_Click(object sender, EventArgs e)
        {
            if (txtLabor.Text == "")
            {
                MessageBox.Show("Please fill the textfiled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            String query = "update LaborRate_tb set LaborRate='" + txtLabor.Text + "' where LaborId='" + txtLaborId.Text + "' ";
            if (db.Execute(query) > 0)
            {
                MessageBox.Show("Updated Successfully", "Updated Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Record Updated", "Updated Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtLabor.Clear();
            btnLaborUpdate.Enabled = false;
            btnLaborGetdata.Enabled = true;
        }

        private void btnExpenceSave_Click(object sender, EventArgs e)
        {
            if (db.Execute("insert into ExpenceType(ExpenceType) values('" + txtExpenceType.Text + "')") > 0)
            {
                MessageBox.Show("Record Successfully Saved !!", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtExpenceType.Clear();
            }
            else 
            {
                MessageBox.Show("Record Not Saved !!", "Saved Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

          
        }

        private void btnExpenceDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.Execute("delete from ExpenceType where ExpenceTypeID=" + txtExpenceID.Text + " ") > 0)
                {
                    MessageBox.Show("Record Has Been Deleted Successfully!!", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtExpenceType.Clear();
                }
                else
                {
                    MessageBox.Show("Record Not Deleted !!", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExpenceUpdate_Click(object sender, EventArgs e)
        {
            if (db.Execute("update  ExpenceType set ExpenceType='"+txtExpenceType.Text+"' where  ExpenceTypeID=" + txtExpenceID.Text + " ") > 0)
            {
                MessageBox.Show("Record Has Been Updated Successfully!!", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtExpenceType.Clear();
            }
            else
            {
                MessageBox.Show("Record Not Updated !!", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExpenceGetData_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewExpenceType.Show();
                reader = db.selectQuery("select * from ExpenceType");
                dataGridViewExpenceType.Rows.Clear();
                while (reader.Read())
                {
                    dataGridViewExpenceType.Rows.Add(reader["ExpenceTypeID"], reader["ExpenceType"], "Edit");
                }
                db.ConnectionClose();
                for (int i = 0; i < dataGridViewExpenceType.RowCount; i++)
                {
                    if (i % 2 != 0)
                    {
                        dataGridViewExpenceType.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewExpenceType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            { 
             txtExpenceID.Text = dataGridViewExpenceType.Rows[e.RowIndex].Cells[0].Value.ToString();
             txtExpenceType.Text = dataGridViewExpenceType.Rows[e.RowIndex].Cells[1].Value.ToString();
             dataGridViewExpenceType.Hide();
             btnExpenceUpdate.Enabled = true;
             btnExpenceSave.Enabled = false;
             btnExpenceDelete.Enabled = true;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtExpenceType.Clear();
            btnExpenceDelete.Enabled = false;
            btnExpenceUpdate.Enabled = false;
            btnExpenceSave.Enabled = true;
            dataGridViewExpenceType.Hide();

        }

        private void dataGridViewExpenceType_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            validate.DataGridSetColor2(dataGridViewExpenceType, Color.LightSkyBlue);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }


      

       
     










        
    }
    }

