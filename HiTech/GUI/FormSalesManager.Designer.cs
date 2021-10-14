
namespace HiTech.GUI
{
    partial class FormSalesManager
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
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.textBoxPostcode = new System.Windows.Forms.TextBox();
            this.labelPostcode = new System.Windows.Forms.Label();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.buttonUpdateCustomer = new System.Windows.Forms.Button();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.labelCusId = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelCN = new System.Windows.Forms.Label();
            this.textBoxStreetName = new System.Windows.Forms.TextBox();
            this.labelStreetname = new System.Windows.Forms.Label();
            this.textBoxProvince = new System.Windows.Forms.TextBox();
            this.labelProvince = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCusId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxsearchpostalcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxsearchname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxsearchstreet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxsearchprovince = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxsearchcity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxsearchid = new System.Windows.Forms.TextBox();
            this.buttonSearchCus = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonListEmployee = new System.Windows.Forms.Button();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.buttonUpdateDatabase = new System.Windows.Forms.Button();
            this.groupBoxCustomer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.textBoxPostcode);
            this.groupBoxCustomer.Controls.Add(this.labelPostcode);
            this.groupBoxCustomer.Controls.Add(this.buttonDeleteCustomer);
            this.groupBoxCustomer.Controls.Add(this.buttonUpdateCustomer);
            this.groupBoxCustomer.Controls.Add(this.buttonAddCustomer);
            this.groupBoxCustomer.Controls.Add(this.labelCusId);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerName);
            this.groupBoxCustomer.Controls.Add(this.labelCN);
            this.groupBoxCustomer.Controls.Add(this.textBoxStreetName);
            this.groupBoxCustomer.Controls.Add(this.labelStreetname);
            this.groupBoxCustomer.Controls.Add(this.textBoxProvince);
            this.groupBoxCustomer.Controls.Add(this.labelProvince);
            this.groupBoxCustomer.Controls.Add(this.textBoxCity);
            this.groupBoxCustomer.Controls.Add(this.labelCity);
            this.groupBoxCustomer.Controls.Add(this.textBoxCusId);
            this.groupBoxCustomer.Location = new System.Drawing.Point(40, 44);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(529, 551);
            this.groupBoxCustomer.TabIndex = 11;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Customer";
            // 
            // textBoxPostcode
            // 
            this.textBoxPostcode.Location = new System.Drawing.Point(224, 345);
            this.textBoxPostcode.Name = "textBoxPostcode";
            this.textBoxPostcode.Size = new System.Drawing.Size(238, 31);
            this.textBoxPostcode.TabIndex = 14;
            // 
            // labelPostcode
            // 
            this.labelPostcode.AutoSize = true;
            this.labelPostcode.Location = new System.Drawing.Point(40, 345);
            this.labelPostcode.Name = "labelPostcode";
            this.labelPostcode.Size = new System.Drawing.Size(112, 25);
            this.labelPostcode.TabIndex = 13;
            this.labelPostcode.Text = "Post Code";
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(343, 438);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(109, 56);
            this.buttonDeleteCustomer.TabIndex = 12;
            this.buttonDeleteCustomer.Text = "Delete";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.buttonDeleteCustomer_Click);
            // 
            // buttonUpdateCustomer
            // 
            this.buttonUpdateCustomer.Location = new System.Drawing.Point(189, 438);
            this.buttonUpdateCustomer.Name = "buttonUpdateCustomer";
            this.buttonUpdateCustomer.Size = new System.Drawing.Size(109, 56);
            this.buttonUpdateCustomer.TabIndex = 11;
            this.buttonUpdateCustomer.Text = "Update";
            this.buttonUpdateCustomer.UseVisualStyleBackColor = true;
            this.buttonUpdateCustomer.Click += new System.EventHandler(this.buttonUpdateCustomer_Click);
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Location = new System.Drawing.Point(32, 438);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(109, 56);
            this.buttonAddCustomer.TabIndex = 10;
            this.buttonAddCustomer.Text = "Add";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // labelCusId
            // 
            this.labelCusId.AutoSize = true;
            this.labelCusId.Location = new System.Drawing.Point(40, 82);
            this.labelCusId.Name = "labelCusId";
            this.labelCusId.Size = new System.Drawing.Size(130, 25);
            this.labelCusId.TabIndex = 0;
            this.labelCusId.Text = "Customer ID";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(224, 131);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(238, 31);
            this.textBoxCustomerName.TabIndex = 9;
            // 
            // labelCN
            // 
            this.labelCN.AutoSize = true;
            this.labelCN.Location = new System.Drawing.Point(40, 134);
            this.labelCN.Name = "labelCN";
            this.labelCN.Size = new System.Drawing.Size(160, 25);
            this.labelCN.TabIndex = 1;
            this.labelCN.Text = "CustomerName";
            // 
            // textBoxStreetName
            // 
            this.textBoxStreetName.Location = new System.Drawing.Point(224, 183);
            this.textBoxStreetName.Name = "textBoxStreetName";
            this.textBoxStreetName.Size = new System.Drawing.Size(238, 31);
            this.textBoxStreetName.TabIndex = 8;
            // 
            // labelStreetname
            // 
            this.labelStreetname.AutoSize = true;
            this.labelStreetname.Location = new System.Drawing.Point(40, 186);
            this.labelStreetname.Name = "labelStreetname";
            this.labelStreetname.Size = new System.Drawing.Size(131, 25);
            this.labelStreetname.TabIndex = 2;
            this.labelStreetname.Text = "Street Name";
            // 
            // textBoxProvince
            // 
            this.textBoxProvince.Location = new System.Drawing.Point(224, 238);
            this.textBoxProvince.Name = "textBoxProvince";
            this.textBoxProvince.Size = new System.Drawing.Size(238, 31);
            this.textBoxProvince.TabIndex = 7;
            // 
            // labelProvince
            // 
            this.labelProvince.AutoSize = true;
            this.labelProvince.Location = new System.Drawing.Point(40, 238);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(96, 25);
            this.labelProvince.TabIndex = 3;
            this.labelProvince.Text = "Province";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(224, 287);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(238, 31);
            this.textBoxCity.TabIndex = 6;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(40, 290);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(49, 25);
            this.labelCity.TabIndex = 4;
            this.labelCity.Text = "City";
            // 
            // textBoxCusId
            // 
            this.textBoxCusId.Location = new System.Drawing.Point(224, 79);
            this.textBoxCusId.Name = "textBoxCusId";
            this.textBoxCusId.Size = new System.Drawing.Size(238, 31);
            this.textBoxCusId.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxsearchpostalcode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxsearchname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxsearchstreet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxsearchprovince);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxsearchcity);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxsearchid);
            this.groupBox1.Controls.Add(this.buttonSearchCus);
            this.groupBox1.Location = new System.Drawing.Point(657, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 535);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Customer";
            // 
            // textBoxsearchpostalcode
            // 
            this.textBoxsearchpostalcode.Location = new System.Drawing.Point(225, 329);
            this.textBoxsearchpostalcode.Name = "textBoxsearchpostalcode";
            this.textBoxsearchpostalcode.ReadOnly = true;
            this.textBoxsearchpostalcode.Size = new System.Drawing.Size(238, 31);
            this.textBoxsearchpostalcode.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Post Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Customer ID";
            // 
            // textBoxsearchname
            // 
            this.textBoxsearchname.Location = new System.Drawing.Point(225, 115);
            this.textBoxsearchname.Name = "textBoxsearchname";
            this.textBoxsearchname.ReadOnly = true;
            this.textBoxsearchname.Size = new System.Drawing.Size(238, 31);
            this.textBoxsearchname.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "CustomerName";
            // 
            // textBoxsearchstreet
            // 
            this.textBoxsearchstreet.Location = new System.Drawing.Point(225, 167);
            this.textBoxsearchstreet.Name = "textBoxsearchstreet";
            this.textBoxsearchstreet.ReadOnly = true;
            this.textBoxsearchstreet.Size = new System.Drawing.Size(238, 31);
            this.textBoxsearchstreet.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Street Name";
            // 
            // textBoxsearchprovince
            // 
            this.textBoxsearchprovince.Location = new System.Drawing.Point(225, 222);
            this.textBoxsearchprovince.Name = "textBoxsearchprovince";
            this.textBoxsearchprovince.ReadOnly = true;
            this.textBoxsearchprovince.Size = new System.Drawing.Size(238, 31);
            this.textBoxsearchprovince.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Province";
            // 
            // textBoxsearchcity
            // 
            this.textBoxsearchcity.Location = new System.Drawing.Point(225, 271);
            this.textBoxsearchcity.Name = "textBoxsearchcity";
            this.textBoxsearchcity.ReadOnly = true;
            this.textBoxsearchcity.Size = new System.Drawing.Size(238, 31);
            this.textBoxsearchcity.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "City";
            // 
            // textBoxsearchid
            // 
            this.textBoxsearchid.Location = new System.Drawing.Point(225, 63);
            this.textBoxsearchid.Name = "textBoxsearchid";
            this.textBoxsearchid.Size = new System.Drawing.Size(238, 31);
            this.textBoxsearchid.TabIndex = 20;
            // 
            // buttonSearchCus
            // 
            this.buttonSearchCus.Location = new System.Drawing.Point(149, 422);
            this.buttonSearchCus.Name = "buttonSearchCus";
            this.buttonSearchCus.Size = new System.Drawing.Size(202, 56);
            this.buttonSearchCus.TabIndex = 12;
            this.buttonSearchCus.Text = "Search Customer";
            this.buttonSearchCus.UseVisualStyleBackColor = true;
            this.buttonSearchCus.Click += new System.EventHandler(this.buttonSearchCus_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1168, 904);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(202, 56);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.Text = "Back To LogIn";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonListEmployee
            // 
            this.buttonListEmployee.Location = new System.Drawing.Point(1168, 672);
            this.buttonListEmployee.Name = "buttonListEmployee";
            this.buttonListEmployee.Size = new System.Drawing.Size(202, 56);
            this.buttonListEmployee.TabIndex = 20;
            this.buttonListEmployee.Text = "List All Customer";
            this.buttonListEmployee.UseVisualStyleBackColor = true;
            this.buttonListEmployee.Click += new System.EventHandler(this.buttonListEmployee_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(39, 672);
            this.dataGridViewCustomer.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowHeadersWidth = 82;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(1092, 288);
            this.dataGridViewCustomer.TabIndex = 23;
            // 
            // buttonUpdateDatabase
            // 
            this.buttonUpdateDatabase.Location = new System.Drawing.Point(1168, 784);
            this.buttonUpdateDatabase.Name = "buttonUpdateDatabase";
            this.buttonUpdateDatabase.Size = new System.Drawing.Size(202, 56);
            this.buttonUpdateDatabase.TabIndex = 24;
            this.buttonUpdateDatabase.Text = "Update Database";
            this.buttonUpdateDatabase.UseVisualStyleBackColor = true;
            this.buttonUpdateDatabase.Click += new System.EventHandler(this.buttonUpdateDatabase_Click);
            // 
            // FormSalesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 1055);
            this.Controls.Add(this.buttonUpdateDatabase);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.buttonListEmployee);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCustomer);
            this.Name = "FormSalesManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSalesManager";
            this.Load += new System.EventHandler(this.FormSalesManager_Load);
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.TextBox textBoxPostcode;
        private System.Windows.Forms.Label labelPostcode;
        private System.Windows.Forms.Button buttonDeleteCustomer;
        private System.Windows.Forms.Button buttonUpdateCustomer;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Label labelCusId;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label labelCN;
        private System.Windows.Forms.TextBox textBoxStreetName;
        private System.Windows.Forms.Label labelStreetname;
        private System.Windows.Forms.TextBox textBoxProvince;
        private System.Windows.Forms.Label labelProvince;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxCusId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearchCus;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonListEmployee;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.Button buttonUpdateDatabase;
        private System.Windows.Forms.TextBox textBoxsearchpostalcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxsearchname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxsearchstreet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxsearchprovince;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxsearchcity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxsearchid;
    }
}