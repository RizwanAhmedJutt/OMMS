namespace OMMS
{
    partial class frmCottonOil
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.comboCusName = new System.Windows.Forms.ComboBox();
            this.txtOilTotalAmount = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbOilTot = new System.Windows.Forms.Label();
            this.lbComission = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvoiceId = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboProduct = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.txtOilPayment = new System.Windows.Forms.TextBox();
            this.txtDuepayment = new System.Windows.Forms.TextBox();
            this.dpInvoice = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(283, 589);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 32);
            this.btnUpdate.TabIndex = 191;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(79, 589);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(84, 32);
            this.btnNew.TabIndex = 190;
            this.btnNew.TabStop = false;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(180, 589);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 32);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 125);
            this.panel2.TabIndex = 188;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::OMMS.Properties.Resources.close_1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(413, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 31);
            this.button1.TabIndex = 143;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(78, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(293, 40);
            this.label12.TabIndex = 141;
            this.label12.Text = "Cotton Oil && Dirty Oil";
            this.label12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::OMMS.Properties.Resources.close_1;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(884, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 31);
            this.btnClose.TabIndex = 140;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // comboCusName
            // 
            this.comboCusName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboCusName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCusName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.comboCusName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCusName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCusName.FormattingEnabled = true;
            this.comboCusName.Location = new System.Drawing.Point(149, 256);
            this.comboCusName.Name = "comboCusName";
            this.comboCusName.Size = new System.Drawing.Size(272, 29);
            this.comboCusName.TabIndex = 0;
            this.comboCusName.SelectedIndexChanged += new System.EventHandler(this.comboCusName_SelectedIndexChanged);
            this.comboCusName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboCusName_KeyDown);
            // 
            // txtOilTotalAmount
            // 
            this.txtOilTotalAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOilTotalAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOilTotalAmount.Location = new System.Drawing.Point(149, 386);
            this.txtOilTotalAmount.Name = "txtOilTotalAmount";
            this.txtOilTotalAmount.ReadOnly = true;
            this.txtOilTotalAmount.Size = new System.Drawing.Size(272, 25);
            this.txtOilTotalAmount.TabIndex = 195;
            this.txtOilTotalAmount.TabStop = false;
            this.txtOilTotalAmount.Text = "0";
            this.txtOilTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(149, 470);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(272, 25);
            this.txtAmount.TabIndex = 204;
            this.txtAmount.TabStop = false;
            this.txtAmount.Text = "0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(149, 345);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(272, 25);
            this.txtWeight.TabIndex = 2;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            this.txtWeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWeight_KeyDown);
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.Color.White;
            this.txtRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(149, 302);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(272, 25);
            this.txtRate.TabIndex = 1;
            this.txtRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRate_KeyDown);
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // txtCommission
            // 
            this.txtCommission.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCommission.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommission.Location = new System.Drawing.Point(149, 428);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.ReadOnly = true;
            this.txtCommission.Size = new System.Drawing.Size(272, 25);
            this.txtCommission.TabIndex = 196;
            this.txtCommission.Text = "0";
            this.txtCommission.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 202;
            this.label4.Text = "Weight :";
            // 
            // lbOilTot
            // 
            this.lbOilTot.AutoSize = true;
            this.lbOilTot.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOilTot.Location = new System.Drawing.Point(-196, 276);
            this.lbOilTot.Name = "lbOilTot";
            this.lbOilTot.Size = new System.Drawing.Size(86, 17);
            this.lbOilTot.TabIndex = 197;
            this.lbOilTot.Text = "Total Amount";
            // 
            // lbComission
            // 
            this.lbComission.AutoSize = true;
            this.lbComission.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComission.Location = new System.Drawing.Point(-199, 222);
            this.lbComission.Name = "lbComission";
            this.lbComission.Size = new System.Drawing.Size(103, 17);
            this.lbComission.TabIndex = 198;
            this.lbComission.Text = "Oil Commission ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 203;
            this.label7.Text = "Total Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-154, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 200;
            this.label3.Text = "Rate :";
            // 
            // txtInvoiceId
            // 
            this.txtInvoiceId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtInvoiceId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceId.Location = new System.Drawing.Point(149, 129);
            this.txtInvoiceId.Name = "txtInvoiceId";
            this.txtInvoiceId.Size = new System.Drawing.Size(119, 25);
            this.txtInvoiceId.TabIndex = 206;
            this.txtInvoiceId.TabStop = false;
            this.txtInvoiceId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(25, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 17);
            this.label17.TabIndex = 207;
            this.label17.Text = "Bill Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 205;
            this.label2.Text = "Customer  Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 203;
            this.label1.Text = "Oil Commission";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 203;
            this.label5.Text = "Amount ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 203;
            this.label6.Text = "Rate";
            // 
            // comboProduct
            // 
            this.comboProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.comboProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProduct.FormattingEnabled = true;
            this.comboProduct.Items.AddRange(new object[] {
            "Cotton Oil",
            "Cotton Dirty"});
            this.comboProduct.Location = new System.Drawing.Point(149, 211);
            this.comboProduct.Name = "comboProduct";
            this.comboProduct.Size = new System.Drawing.Size(272, 29);
            this.comboProduct.TabIndex = 208;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 209;
            this.label8.Text = "Product Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.panel1.Location = new System.Drawing.Point(1, 632);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 52);
            this.panel1.TabIndex = 210;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 207;
            this.label9.Text = "Customer ID";
            // 
            // txtCusID
            // 
            this.txtCusID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCusID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusID.Location = new System.Drawing.Point(149, 169);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.ReadOnly = true;
            this.txtCusID.Size = new System.Drawing.Size(272, 25);
            this.txtCusID.TabIndex = 206;
            this.txtCusID.TabStop = false;
            this.txtCusID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOilPayment
            // 
            this.txtOilPayment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOilPayment.Location = new System.Drawing.Point(149, 510);
            this.txtOilPayment.Name = "txtOilPayment";
            this.txtOilPayment.Size = new System.Drawing.Size(136, 25);
            this.txtOilPayment.TabIndex = 3;
            this.txtOilPayment.TextChanged += new System.EventHandler(this.txtPayment_TextChanged);
            this.txtOilPayment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPayment_KeyDown);
            // 
            // txtDuepayment
            // 
            this.txtDuepayment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDuepayment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuepayment.Location = new System.Drawing.Point(285, 510);
            this.txtDuepayment.Name = "txtDuepayment";
            this.txtDuepayment.ReadOnly = true;
            this.txtDuepayment.Size = new System.Drawing.Size(136, 25);
            this.txtDuepayment.TabIndex = 211;
            // 
            // dpInvoice
            // 
            this.dpInvoice.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpInvoice.CustomFormat = "dd/MM/yyyy";
            this.dpInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpInvoice.Location = new System.Drawing.Point(274, 129);
            this.dpInvoice.Name = "dpInvoice";
            this.dpInvoice.Size = new System.Drawing.Size(147, 25);
            this.dpInvoice.TabIndex = 212;
            this.dpInvoice.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 518);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 213;
            this.label10.Text = "Payment Amount";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 214;
            // 
            // frmCottonOil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 687);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dpInvoice);
            this.Controls.Add(this.txtDuepayment);
            this.Controls.Add(this.txtOilPayment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboProduct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboCusName);
            this.Controls.Add(this.txtOilTotalAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtCommission);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbOilTot);
            this.Controls.Add(this.lbComission);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCusID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtInvoiceId);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCottonOil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCottonOil";
            this.Load += new System.EventHandler(this.frmCottonOil_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtAmount;
        public System.Windows.Forms.TextBox txtWeight;
        public System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbOilTot;
        private System.Windows.Forms.Label lbComission;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtOilPayment;
        public System.Windows.Forms.TextBox txtDuepayment;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnNew;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.ComboBox comboCusName;
        public System.Windows.Forms.TextBox txtOilTotalAmount;
        public System.Windows.Forms.TextBox txtCommission;
        public System.Windows.Forms.TextBox txtInvoiceId;
        public System.Windows.Forms.ComboBox comboProduct;
        public System.Windows.Forms.TextBox txtCusID;
        public System.Windows.Forms.DateTimePicker dpInvoice;
        public System.Windows.Forms.Button btnDelete;
    }
}