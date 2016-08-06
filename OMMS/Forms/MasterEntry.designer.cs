namespace OMMS
{
    partial class frmMasterEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RightOptions = new System.Windows.Forms.Timer(this.components);
            this.Options = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.masterTb = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtCakeId = new System.Windows.Forms.TextBox();
            this.updateCakeRate = new System.Windows.Forms.Button();
            this.categorySave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetData = new System.Windows.Forms.Button();
            this.txtCakeRate = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.companyUpdate = new System.Windows.Forms.Button();
            this.companySave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.companyNew = new System.Windows.Forms.Button();
            this.companytxt = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtOilId = new System.Windows.Forms.TextBox();
            this.btnOilUpdate = new System.Windows.Forms.Button();
            this.btnOilSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOilGetData = new System.Windows.Forms.Button();
            this.txtOilRate = new System.Windows.Forms.TextBox();
            this.tabItemRecord = new System.Windows.Forms.TabPage();
            this.txtDirtyId = new System.Windows.Forms.TextBox();
            this.btnDirtyOilUpdate = new System.Windows.Forms.Button();
            this.btnDirtyOilSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDirtyOilGetData = new System.Windows.Forms.Button();
            this.txtDirtyOil = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtLaborId = new System.Windows.Forms.TextBox();
            this.btnLaborUpdate = new System.Windows.Forms.Button();
            this.btnLaborSave = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnLaborGetdata = new System.Windows.Forms.Button();
            this.txtLabor = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtExpenceID = new System.Windows.Forms.TextBox();
            this.btnExpenceGetData = new System.Windows.Forms.Button();
            this.btnExpenceUpdate = new System.Windows.Forms.Button();
            this.btnExpenceDelete = new System.Windows.Forms.Button();
            this.btnExpenceSave = new System.Windows.Forms.Button();
            this.dataGridViewExpenceType = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtExpenceType = new System.Windows.Forms.TextBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.masterTb.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabItemRecord.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenceType)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.masterTb);
            this.pnlMain.Controls.Add(this.lblCopyright);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1182, 614);
            this.pnlMain.TabIndex = 16;
            // 
            // masterTb
            // 
            this.masterTb.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.masterTb.Controls.Add(this.tabPage1);
            this.masterTb.Controls.Add(this.tabPage2);
            this.masterTb.Controls.Add(this.tabPage4);
            this.masterTb.Controls.Add(this.tabItemRecord);
            this.masterTb.Controls.Add(this.tabPage3);
            this.masterTb.Controls.Add(this.tabPage5);
            this.masterTb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.masterTb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterTb.Location = new System.Drawing.Point(59, 108);
            this.masterTb.Name = "masterTb";
            this.masterTb.SelectedIndex = 0;
            this.masterTb.Size = new System.Drawing.Size(1062, 472);
            this.masterTb.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.txtCakeId);
            this.tabPage1.Controls.Add(this.updateCakeRate);
            this.tabPage1.Controls.Add(this.categorySave);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1054, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cotton Cake";
            // 
            // txtCakeId
            // 
            this.txtCakeId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCakeId.ForeColor = System.Drawing.Color.White;
            this.txtCakeId.Location = new System.Drawing.Point(727, 46);
            this.txtCakeId.Name = "txtCakeId";
            this.txtCakeId.Size = new System.Drawing.Size(100, 22);
            this.txtCakeId.TabIndex = 30;
            // 
            // updateCakeRate
            // 
            this.updateCakeRate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.updateCakeRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCakeRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCakeRate.ForeColor = System.Drawing.Color.White;
            this.updateCakeRate.Location = new System.Drawing.Point(537, 288);
            this.updateCakeRate.Name = "updateCakeRate";
            this.updateCakeRate.Size = new System.Drawing.Size(101, 34);
            this.updateCakeRate.TabIndex = 27;
            this.updateCakeRate.Text = "Update";
            this.updateCakeRate.UseVisualStyleBackColor = false;
            this.updateCakeRate.Click += new System.EventHandler(this.updateCategory_Click);
            // 
            // categorySave
            // 
            this.categorySave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.categorySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categorySave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorySave.ForeColor = System.Drawing.Color.White;
            this.categorySave.Location = new System.Drawing.Point(419, 288);
            this.categorySave.Name = "categorySave";
            this.categorySave.Size = new System.Drawing.Size(101, 34);
            this.categorySave.TabIndex = 29;
            this.categorySave.Text = "Save";
            this.categorySave.UseVisualStyleBackColor = false;
            this.categorySave.Click += new System.EventHandler(this.button20_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetData);
            this.groupBox1.Controls.Add(this.txtCakeRate);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(274, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cotton Cake Rate";
            // 
            // btnGetData
            // 
            this.btnGetData.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.ForeColor = System.Drawing.Color.White;
            this.btnGetData.Location = new System.Drawing.Point(417, 34);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(82, 29);
            this.btnGetData.TabIndex = 34;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = false;
            this.btnGetData.Click += new System.EventHandler(this.categoryNew_Click);
            // 
            // txtCakeRate
            // 
            this.txtCakeRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCakeRate.Location = new System.Drawing.Point(22, 37);
            this.txtCakeRate.Name = "txtCakeRate";
            this.txtCakeRate.Size = new System.Drawing.Size(376, 25);
            this.txtCakeRate.TabIndex = 0;
            this.txtCakeRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.categoryTxt_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.companyUpdate);
            this.tabPage2.Controls.Add(this.companySave);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1054, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cotton Seed";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(840, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 31;
            // 
            // companyUpdate
            // 
            this.companyUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.companyUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.companyUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyUpdate.ForeColor = System.Drawing.Color.White;
            this.companyUpdate.Location = new System.Drawing.Point(506, 296);
            this.companyUpdate.Name = "companyUpdate";
            this.companyUpdate.Size = new System.Drawing.Size(101, 34);
            this.companyUpdate.TabIndex = 27;
            this.companyUpdate.Text = "Update";
            this.companyUpdate.UseVisualStyleBackColor = false;
            this.companyUpdate.Click += new System.EventHandler(this.companyUpdate_Click);
            // 
            // companySave
            // 
            this.companySave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.companySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.companySave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companySave.ForeColor = System.Drawing.Color.White;
            this.companySave.Location = new System.Drawing.Point(383, 296);
            this.companySave.Name = "companySave";
            this.companySave.Size = new System.Drawing.Size(101, 34);
            this.companySave.TabIndex = 29;
            this.companySave.Text = "Save";
            this.companySave.UseVisualStyleBackColor = false;
            this.companySave.Click += new System.EventHandler(this.button15_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.companyNew);
            this.groupBox2.Controls.Add(this.companytxt);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(274, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 84);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cotton Seed Rate";
            // 
            // companyNew
            // 
            this.companyNew.BackColor = System.Drawing.Color.LightSkyBlue;
            this.companyNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.companyNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNew.ForeColor = System.Drawing.Color.White;
            this.companyNew.Location = new System.Drawing.Point(417, 34);
            this.companyNew.Name = "companyNew";
            this.companyNew.Size = new System.Drawing.Size(82, 29);
            this.companyNew.TabIndex = 35;
            this.companyNew.Text = "Get Data";
            this.companyNew.UseVisualStyleBackColor = false;
            this.companyNew.Click += new System.EventHandler(this.companyNew_Click);
            // 
            // companytxt
            // 
            this.companytxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companytxt.Location = new System.Drawing.Point(22, 37);
            this.companytxt.Name = "companytxt";
            this.companytxt.Size = new System.Drawing.Size(376, 25);
            this.companytxt.TabIndex = 0;
            this.companytxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.companytxt_KeyPress);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage4.Controls.Add(this.txtOilId);
            this.tabPage4.Controls.Add(this.btnOilUpdate);
            this.tabPage4.Controls.Add(this.btnOilSave);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 37);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1054, 490);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cotton Oil";
            // 
            // txtOilId
            // 
            this.txtOilId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOilId.ForeColor = System.Drawing.SystemColors.Window;
            this.txtOilId.Location = new System.Drawing.Point(519, 53);
            this.txtOilId.Name = "txtOilId";
            this.txtOilId.Size = new System.Drawing.Size(100, 25);
            this.txtOilId.TabIndex = 32;
            this.txtOilId.TabStop = false;
            // 
            // btnOilUpdate
            // 
            this.btnOilUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOilUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOilUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOilUpdate.ForeColor = System.Drawing.Color.White;
            this.btnOilUpdate.Location = new System.Drawing.Point(537, 330);
            this.btnOilUpdate.Name = "btnOilUpdate";
            this.btnOilUpdate.Size = new System.Drawing.Size(101, 34);
            this.btnOilUpdate.TabIndex = 30;
            this.btnOilUpdate.Text = "Update";
            this.btnOilUpdate.UseVisualStyleBackColor = false;
            this.btnOilUpdate.Click += new System.EventHandler(this.btnOilUpdate_Click);
            // 
            // btnOilSave
            // 
            this.btnOilSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOilSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOilSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOilSave.ForeColor = System.Drawing.Color.White;
            this.btnOilSave.Location = new System.Drawing.Point(414, 330);
            this.btnOilSave.Name = "btnOilSave";
            this.btnOilSave.Size = new System.Drawing.Size(101, 34);
            this.btnOilSave.TabIndex = 31;
            this.btnOilSave.Text = "Save";
            this.btnOilSave.UseVisualStyleBackColor = false;
            this.btnOilSave.Click += new System.EventHandler(this.btnOilSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOilGetData);
            this.groupBox3.Controls.Add(this.txtOilRate);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox3.Location = new System.Drawing.Point(274, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 84);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cotton Oil Rate";
            // 
            // btnOilGetData
            // 
            this.btnOilGetData.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOilGetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOilGetData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOilGetData.ForeColor = System.Drawing.Color.White;
            this.btnOilGetData.Location = new System.Drawing.Point(417, 34);
            this.btnOilGetData.Name = "btnOilGetData";
            this.btnOilGetData.Size = new System.Drawing.Size(82, 29);
            this.btnOilGetData.TabIndex = 35;
            this.btnOilGetData.Text = "Get Rate";
            this.btnOilGetData.UseVisualStyleBackColor = false;
            this.btnOilGetData.Click += new System.EventHandler(this.btnOilGetData_Click);
            // 
            // txtOilRate
            // 
            this.txtOilRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOilRate.Location = new System.Drawing.Point(22, 37);
            this.txtOilRate.Name = "txtOilRate";
            this.txtOilRate.Size = new System.Drawing.Size(376, 25);
            this.txtOilRate.TabIndex = 0;
            // 
            // tabItemRecord
            // 
            this.tabItemRecord.BackColor = System.Drawing.Color.White;
            this.tabItemRecord.Controls.Add(this.txtDirtyId);
            this.tabItemRecord.Controls.Add(this.btnDirtyOilUpdate);
            this.tabItemRecord.Controls.Add(this.btnDirtyOilSave);
            this.tabItemRecord.Controls.Add(this.groupBox4);
            this.tabItemRecord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabItemRecord.Location = new System.Drawing.Point(4, 37);
            this.tabItemRecord.Name = "tabItemRecord";
            this.tabItemRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tabItemRecord.Size = new System.Drawing.Size(1054, 490);
            this.tabItemRecord.TabIndex = 4;
            this.tabItemRecord.Text = "Dirty Oil";
            // 
            // txtDirtyId
            // 
            this.txtDirtyId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDirtyId.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDirtyId.Location = new System.Drawing.Point(770, 40);
            this.txtDirtyId.Name = "txtDirtyId";
            this.txtDirtyId.Size = new System.Drawing.Size(100, 18);
            this.txtDirtyId.TabIndex = 34;
            this.txtDirtyId.TabStop = false;
            // 
            // btnDirtyOilUpdate
            // 
            this.btnDirtyOilUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDirtyOilUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirtyOilUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirtyOilUpdate.ForeColor = System.Drawing.Color.White;
            this.btnDirtyOilUpdate.Location = new System.Drawing.Point(514, 261);
            this.btnDirtyOilUpdate.Name = "btnDirtyOilUpdate";
            this.btnDirtyOilUpdate.Size = new System.Drawing.Size(101, 34);
            this.btnDirtyOilUpdate.TabIndex = 32;
            this.btnDirtyOilUpdate.Text = "Update";
            this.btnDirtyOilUpdate.UseVisualStyleBackColor = false;
            this.btnDirtyOilUpdate.Click += new System.EventHandler(this.btnDirtyOilUpdate_Click);
            // 
            // btnDirtyOilSave
            // 
            this.btnDirtyOilSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDirtyOilSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirtyOilSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirtyOilSave.ForeColor = System.Drawing.Color.White;
            this.btnDirtyOilSave.Location = new System.Drawing.Point(391, 261);
            this.btnDirtyOilSave.Name = "btnDirtyOilSave";
            this.btnDirtyOilSave.Size = new System.Drawing.Size(101, 34);
            this.btnDirtyOilSave.TabIndex = 33;
            this.btnDirtyOilSave.Text = "Save";
            this.btnDirtyOilSave.UseVisualStyleBackColor = false;
            this.btnDirtyOilSave.Click += new System.EventHandler(this.btnDirtyOilSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDirtyOilGetData);
            this.groupBox4.Controls.Add(this.txtDirtyOil);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox4.Location = new System.Drawing.Point(274, 127);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(507, 84);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dirty Oil Rate";
            // 
            // btnDirtyOilGetData
            // 
            this.btnDirtyOilGetData.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDirtyOilGetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirtyOilGetData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirtyOilGetData.ForeColor = System.Drawing.Color.White;
            this.btnDirtyOilGetData.Location = new System.Drawing.Point(417, 34);
            this.btnDirtyOilGetData.Name = "btnDirtyOilGetData";
            this.btnDirtyOilGetData.Size = new System.Drawing.Size(82, 29);
            this.btnDirtyOilGetData.TabIndex = 35;
            this.btnDirtyOilGetData.Text = "Get Data";
            this.btnDirtyOilGetData.UseVisualStyleBackColor = false;
            this.btnDirtyOilGetData.Click += new System.EventHandler(this.btnDirtyOilGetData_Click);
            // 
            // txtDirtyOil
            // 
            this.txtDirtyOil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirtyOil.Location = new System.Drawing.Point(22, 37);
            this.txtDirtyOil.Name = "txtDirtyOil";
            this.txtDirtyOil.Size = new System.Drawing.Size(376, 25);
            this.txtDirtyOil.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.txtLaborId);
            this.tabPage3.Controls.Add(this.btnLaborUpdate);
            this.tabPage3.Controls.Add(this.btnLaborSave);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1054, 490);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Labor Payment";
            // 
            // txtLaborId
            // 
            this.txtLaborId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLaborId.ForeColor = System.Drawing.Color.White;
            this.txtLaborId.Location = new System.Drawing.Point(680, 46);
            this.txtLaborId.Name = "txtLaborId";
            this.txtLaborId.Size = new System.Drawing.Size(100, 25);
            this.txtLaborId.TabIndex = 37;
            // 
            // btnLaborUpdate
            // 
            this.btnLaborUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLaborUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaborUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaborUpdate.ForeColor = System.Drawing.Color.White;
            this.btnLaborUpdate.Location = new System.Drawing.Point(514, 254);
            this.btnLaborUpdate.Name = "btnLaborUpdate";
            this.btnLaborUpdate.Size = new System.Drawing.Size(101, 34);
            this.btnLaborUpdate.TabIndex = 35;
            this.btnLaborUpdate.Text = "Update";
            this.btnLaborUpdate.UseVisualStyleBackColor = false;
            this.btnLaborUpdate.Click += new System.EventHandler(this.btnLaborUpdate_Click);
            // 
            // btnLaborSave
            // 
            this.btnLaborSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLaborSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaborSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaborSave.ForeColor = System.Drawing.Color.White;
            this.btnLaborSave.Location = new System.Drawing.Point(391, 254);
            this.btnLaborSave.Name = "btnLaborSave";
            this.btnLaborSave.Size = new System.Drawing.Size(101, 34);
            this.btnLaborSave.TabIndex = 36;
            this.btnLaborSave.Text = "Save";
            this.btnLaborSave.UseVisualStyleBackColor = false;
            this.btnLaborSave.Click += new System.EventHandler(this.btnLaborSave_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnLaborGetdata);
            this.groupBox5.Controls.Add(this.txtLabor);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox5.Location = new System.Drawing.Point(274, 120);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(507, 84);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Labor Pay  Rate";
            // 
            // btnLaborGetdata
            // 
            this.btnLaborGetdata.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLaborGetdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaborGetdata.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaborGetdata.ForeColor = System.Drawing.Color.White;
            this.btnLaborGetdata.Location = new System.Drawing.Point(417, 34);
            this.btnLaborGetdata.Name = "btnLaborGetdata";
            this.btnLaborGetdata.Size = new System.Drawing.Size(82, 29);
            this.btnLaborGetdata.TabIndex = 35;
            this.btnLaborGetdata.Text = "Get Data";
            this.btnLaborGetdata.UseVisualStyleBackColor = false;
            this.btnLaborGetdata.Click += new System.EventHandler(this.btnLaborGetdata_Click);
            // 
            // txtLabor
            // 
            this.txtLabor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabor.Location = new System.Drawing.Point(22, 37);
            this.txtLabor.Name = "txtLabor";
            this.txtLabor.Size = new System.Drawing.Size(376, 25);
            this.txtLabor.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.txtExpenceID);
            this.tabPage5.Controls.Add(this.btnExpenceGetData);
            this.tabPage5.Controls.Add(this.btnExpenceUpdate);
            this.tabPage5.Controls.Add(this.btnExpenceDelete);
            this.tabPage5.Controls.Add(this.btnExpenceSave);
            this.tabPage5.Controls.Add(this.dataGridViewExpenceType);
            this.tabPage5.Controls.Add(this.groupBox6);
            this.tabPage5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage5.ForeColor = System.Drawing.Color.Black;
            this.tabPage5.Location = new System.Drawing.Point(4, 37);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1054, 431);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "Expence Type";
            // 
            // txtExpenceID
            // 
            this.txtExpenceID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExpenceID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtExpenceID.Location = new System.Drawing.Point(541, 56);
            this.txtExpenceID.Name = "txtExpenceID";
            this.txtExpenceID.Size = new System.Drawing.Size(100, 18);
            this.txtExpenceID.TabIndex = 41;
            this.txtExpenceID.TabStop = false;
            // 
            // btnExpenceGetData
            // 
            this.btnExpenceGetData.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExpenceGetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenceGetData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenceGetData.ForeColor = System.Drawing.Color.White;
            this.btnExpenceGetData.Location = new System.Drawing.Point(504, 248);
            this.btnExpenceGetData.Name = "btnExpenceGetData";
            this.btnExpenceGetData.Size = new System.Drawing.Size(101, 34);
            this.btnExpenceGetData.TabIndex = 37;
            this.btnExpenceGetData.Text = "Get Data";
            this.btnExpenceGetData.UseVisualStyleBackColor = false;
            this.btnExpenceGetData.Click += new System.EventHandler(this.btnExpenceGetData_Click);
            // 
            // btnExpenceUpdate
            // 
            this.btnExpenceUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExpenceUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenceUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenceUpdate.ForeColor = System.Drawing.Color.White;
            this.btnExpenceUpdate.Location = new System.Drawing.Point(378, 248);
            this.btnExpenceUpdate.Name = "btnExpenceUpdate";
            this.btnExpenceUpdate.Size = new System.Drawing.Size(101, 34);
            this.btnExpenceUpdate.TabIndex = 38;
            this.btnExpenceUpdate.Text = "Update";
            this.btnExpenceUpdate.UseVisualStyleBackColor = false;
            this.btnExpenceUpdate.Click += new System.EventHandler(this.btnExpenceUpdate_Click);
            // 
            // btnExpenceDelete
            // 
            this.btnExpenceDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExpenceDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenceDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenceDelete.ForeColor = System.Drawing.Color.White;
            this.btnExpenceDelete.Location = new System.Drawing.Point(258, 248);
            this.btnExpenceDelete.Name = "btnExpenceDelete";
            this.btnExpenceDelete.Size = new System.Drawing.Size(101, 34);
            this.btnExpenceDelete.TabIndex = 39;
            this.btnExpenceDelete.Text = "Delete";
            this.btnExpenceDelete.UseVisualStyleBackColor = false;
            this.btnExpenceDelete.Click += new System.EventHandler(this.btnExpenceDelete_Click);
            // 
            // btnExpenceSave
            // 
            this.btnExpenceSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExpenceSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenceSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenceSave.ForeColor = System.Drawing.Color.White;
            this.btnExpenceSave.Location = new System.Drawing.Point(139, 248);
            this.btnExpenceSave.Name = "btnExpenceSave";
            this.btnExpenceSave.Size = new System.Drawing.Size(101, 34);
            this.btnExpenceSave.TabIndex = 40;
            this.btnExpenceSave.Text = "Save";
            this.btnExpenceSave.UseVisualStyleBackColor = false;
            this.btnExpenceSave.Click += new System.EventHandler(this.btnExpenceSave_Click);
            // 
            // dataGridViewExpenceType
            // 
            this.dataGridViewExpenceType.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewExpenceType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExpenceType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewExpenceType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExpenceType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewExpenceType.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewExpenceType.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridViewExpenceType.Location = new System.Drawing.Point(655, 0);
            this.dataGridViewExpenceType.Name = "dataGridViewExpenceType";
            this.dataGridViewExpenceType.Size = new System.Drawing.Size(396, 428);
            this.dataGridViewExpenceType.TabIndex = 36;
            this.dataGridViewExpenceType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExpenceType_CellContentClick);
            this.dataGridViewExpenceType.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewExpenceType_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Expence ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Expence Type";
            this.Column2.Name = "Column2";
            this.Column2.Width = 220;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Edit";
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnNew);
            this.groupBox6.Controls.Add(this.txtExpenceType);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox6.Location = new System.Drawing.Point(142, 110);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(507, 84);
            this.groupBox6.TabIndex = 35;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Enter Expence Type";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(417, 34);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(82, 29);
            this.btnNew.TabIndex = 35;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtExpenceType
            // 
            this.txtExpenceType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpenceType.Location = new System.Drawing.Point(22, 37);
            this.txtExpenceType.Name = "txtExpenceType";
            this.txtExpenceType.Size = new System.Drawing.Size(376, 25);
            this.txtExpenceType.TabIndex = 0;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.White;
            this.lblCopyright.Location = new System.Drawing.Point(403, 624);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(219, 21);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "Copyright @ Technoxen, 2014";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(103, 98);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(434, 259);
            this.textBox1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.Label1);
            this.panel4.Location = new System.Drawing.Point(7, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1166, 41);
            this.panel4.TabIndex = 134;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::OMMS.Properties.Resources.close_2;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(1119, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 41);
            this.btnClose.TabIndex = 174;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(371, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(310, 39);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Master Entry Form";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMasterEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 614);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmMasterEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.masterTb.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabItemRecord.ResumeLayout(false);
            this.tabItemRecord.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenceType)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer RightOptions;
        private System.Windows.Forms.Timer Options;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.TabControl masterTb;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TabPage tabPage4;
      
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button updateCakeRate;
        private System.Windows.Forms.Button categorySave;
        private System.Windows.Forms.Button companyUpdate;
        private System.Windows.Forms.Button companySave;
        public System.Windows.Forms.TextBox txtCakeRate;
        public System.Windows.Forms.TextBox companytxt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Button companyNew;
        private System.Windows.Forms.TabPage tabItemRecord;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOilGetData;
        public System.Windows.Forms.TextBox txtOilRate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDirtyOilGetData;
        public System.Windows.Forms.TextBox txtDirtyOil;
        private System.Windows.Forms.TextBox txtCakeId;
        private System.Windows.Forms.Button btnOilUpdate;
        private System.Windows.Forms.Button btnOilSave;
        private System.Windows.Forms.TextBox txtOilId;
        private System.Windows.Forms.Button btnDirtyOilUpdate;
        private System.Windows.Forms.Button btnDirtyOilSave;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnLaborUpdate;
        private System.Windows.Forms.Button btnLaborSave;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnLaborGetdata;
        public System.Windows.Forms.TextBox txtLabor;
        private System.Windows.Forms.TextBox txtDirtyId;
        private System.Windows.Forms.TextBox txtLaborId;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnNew;
        public System.Windows.Forms.TextBox txtExpenceType;
        private System.Windows.Forms.DataGridView dataGridViewExpenceType;
        private System.Windows.Forms.Button btnExpenceGetData;
        private System.Windows.Forms.Button btnExpenceUpdate;
        private System.Windows.Forms.Button btnExpenceDelete;
        private System.Windows.Forms.Button btnExpenceSave;
        private System.Windows.Forms.TextBox txtExpenceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        internal System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Label Label1;
    }
}