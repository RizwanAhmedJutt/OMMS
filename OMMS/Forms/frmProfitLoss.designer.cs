namespace OMMS
{
    partial class frmProfitLoss
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBalnce = new System.Windows.Forms.TextBox();
            this.txtdebit = new System.Windows.Forms.TextBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column5,
            this.Column6,
            this.Column1});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle20;
            this.Grid.Location = new System.Drawing.Point(57, 115);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(1077, 352);
            this.Grid.TabIndex = 0;
            this.Grid.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.Grid_RowPostPaint);
            this.Grid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Particulars";
            this.Column7.Name = "Column7";
            this.Column7.Width = 500;
            // 
            // Column5
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column5.HeaderText = "Amount(Rs)";
            this.Column5.Name = "Column5";
            this.Column5.Width = 180;
            // 
            // Column6
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column6.HeaderText = "Amount(Rs)";
            this.Column6.Name = "Column6";
            this.Column6.Width = 180;
            // 
            // Column1
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle19;
            this.Column1.HeaderText = "Balance";
            this.Column1.Name = "Column1";
            this.Column1.Width = 180;
            // 
            // txtBalnce
            // 
            this.txtBalnce.BackColor = System.Drawing.Color.White;
            this.txtBalnce.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalnce.ForeColor = System.Drawing.Color.Black;
            this.txtBalnce.Location = new System.Drawing.Point(953, 473);
            this.txtBalnce.Name = "txtBalnce";
            this.txtBalnce.Size = new System.Drawing.Size(183, 29);
            this.txtBalnce.TabIndex = 173;
            this.txtBalnce.Text = "0";
            this.txtBalnce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdebit
            // 
            this.txtdebit.BackColor = System.Drawing.Color.White;
            this.txtdebit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdebit.ForeColor = System.Drawing.Color.Black;
            this.txtdebit.Location = new System.Drawing.Point(627, 473);
            this.txtdebit.Name = "txtdebit";
            this.txtdebit.Size = new System.Drawing.Size(171, 29);
            this.txtdebit.TabIndex = 174;
            this.txtdebit.Text = "0";
            this.txtdebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCredit
            // 
            this.txtCredit.BackColor = System.Drawing.Color.White;
            this.txtCredit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredit.ForeColor = System.Drawing.Color.Black;
            this.txtCredit.Location = new System.Drawing.Point(793, 473);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(165, 29);
            this.txtCredit.TabIndex = 175;
            this.txtCredit.Text = "0";
            this.txtCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.Label1);
            this.panel4.Location = new System.Drawing.Point(6, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1166, 41);
            this.panel4.TabIndex = 176;
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
            this.Label1.Text = "Profit && Loss Form";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 518);
            this.panel1.TabIndex = 177;
            // 
            // frmProfitLoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1191, 518);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtCredit);
            this.Controls.Add(this.txtdebit);
            this.Controls.Add(this.txtBalnce);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfitLoss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Lager";
            this.Load += new System.EventHandler(this.frmAccountLager_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        internal System.Windows.Forms.TextBox txtBalnce;
        internal System.Windows.Forms.TextBox txtdebit;
        internal System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel panel1;
    }
}