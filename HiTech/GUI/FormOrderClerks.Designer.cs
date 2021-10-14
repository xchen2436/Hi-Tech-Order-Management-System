
namespace HiTech.GUI
{
    partial class FormOrderClerks
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxCID = new System.Windows.Forms.TextBox();
            this.textBoxEID = new System.Windows.Forms.TextBox();
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.maskedTextBoxOrderDate = new System.Windows.Forms.MaskedTextBox();
            this.buttonSearchOrder = new System.Windows.Forms.Button();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.buttonListOrder = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdateOrder = new System.Windows.Forms.Button();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewOrderLine = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxOrderQuantity = new System.Windows.Forms.TextBox();
            this.textBoxOrderISBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderLine)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1797, 1140);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonExit);
            this.tabPage1.Controls.Add(this.textBoxCID);
            this.tabPage1.Controls.Add(this.textBoxEID);
            this.tabPage1.Controls.Add(this.textBoxOrderId);
            this.tabPage1.Controls.Add(this.maskedTextBoxOrderDate);
            this.tabPage1.Controls.Add(this.buttonSearchOrder);
            this.tabPage1.Controls.Add(this.dataGridViewOrder);
            this.tabPage1.Controls.Add(this.buttonListOrder);
            this.tabPage1.Controls.Add(this.buttonDelete);
            this.tabPage1.Controls.Add(this.buttonUpdateOrder);
            this.tabPage1.Controls.Add(this.buttonAddOrder);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1781, 1093);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1327, 950);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(252, 56);
            this.buttonExit.TabIndex = 75;
            this.buttonExit.Text = "Back To LogIn";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxCID
            // 
            this.textBoxCID.Location = new System.Drawing.Point(1093, 108);
            this.textBoxCID.Name = "textBoxCID";
            this.textBoxCID.Size = new System.Drawing.Size(303, 31);
            this.textBoxCID.TabIndex = 74;
            // 
            // textBoxEID
            // 
            this.textBoxEID.Location = new System.Drawing.Point(1093, 191);
            this.textBoxEID.Name = "textBoxEID";
            this.textBoxEID.Size = new System.Drawing.Size(303, 31);
            this.textBoxEID.TabIndex = 73;
            // 
            // textBoxOrderId
            // 
            this.textBoxOrderId.Location = new System.Drawing.Point(457, 114);
            this.textBoxOrderId.Name = "textBoxOrderId";
            this.textBoxOrderId.Size = new System.Drawing.Size(303, 31);
            this.textBoxOrderId.TabIndex = 65;
            // 
            // maskedTextBoxOrderDate
            // 
            this.maskedTextBoxOrderDate.Location = new System.Drawing.Point(457, 187);
            this.maskedTextBoxOrderDate.Mask = "00/00/0000";
            this.maskedTextBoxOrderDate.Name = "maskedTextBoxOrderDate";
            this.maskedTextBoxOrderDate.Size = new System.Drawing.Size(303, 31);
            this.maskedTextBoxOrderDate.TabIndex = 72;
            this.maskedTextBoxOrderDate.ValidatingType = typeof(System.DateTime);
            // 
            // buttonSearchOrder
            // 
            this.buttonSearchOrder.Location = new System.Drawing.Point(1363, 321);
            this.buttonSearchOrder.Name = "buttonSearchOrder";
            this.buttonSearchOrder.Size = new System.Drawing.Size(216, 96);
            this.buttonSearchOrder.TabIndex = 71;
            this.buttonSearchOrder.Text = "Search By Order ID";
            this.buttonSearchOrder.UseVisualStyleBackColor = true;
            this.buttonSearchOrder.Click += new System.EventHandler(this.buttonSearchOrder_Click);
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(139, 456);
            this.dataGridViewOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.Height = 27;
            this.dataGridViewOrder.Size = new System.Drawing.Size(1440, 435);
            this.dataGridViewOrder.TabIndex = 70;
            // 
            // buttonListOrder
            // 
            this.buttonListOrder.Location = new System.Drawing.Point(1070, 321);
            this.buttonListOrder.Name = "buttonListOrder";
            this.buttonListOrder.Size = new System.Drawing.Size(216, 96);
            this.buttonListOrder.TabIndex = 69;
            this.buttonListOrder.Text = "List All Order";
            this.buttonListOrder.UseVisualStyleBackColor = true;
            this.buttonListOrder.Click += new System.EventHandler(this.buttonListOrder_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(763, 321);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(216, 96);
            this.buttonDelete.TabIndex = 68;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdateOrder
            // 
            this.buttonUpdateOrder.Location = new System.Drawing.Point(444, 321);
            this.buttonUpdateOrder.Name = "buttonUpdateOrder";
            this.buttonUpdateOrder.Size = new System.Drawing.Size(216, 96);
            this.buttonUpdateOrder.TabIndex = 67;
            this.buttonUpdateOrder.Text = "Update";
            this.buttonUpdateOrder.UseVisualStyleBackColor = true;
            this.buttonUpdateOrder.Click += new System.EventHandler(this.buttonUpdateOrder_Click);
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(139, 321);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(216, 96);
            this.buttonAddOrder.TabIndex = 66;
            this.buttonAddOrder.Text = "Add";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(909, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 25);
            this.label6.TabIndex = 64;
            this.label6.Text = "Customer ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(909, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 63;
            this.label5.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 62;
            this.label2.Text = "Order Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 61;
            this.label1.Text = "Order ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridViewOrderLine);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBoxOrderQuantity);
            this.tabPage2.Controls.Add(this.textBoxOrderISBN);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1781, 1093);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "OrderLine";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1363, 1010);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 56);
            this.button1.TabIndex = 91;
            this.button1.Text = "Back To LogIn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1399, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 96);
            this.button2.TabIndex = 90;
            this.button2.Text = "Search By Order ID";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewOrderLine
            // 
            this.dataGridViewOrderLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderLine.Location = new System.Drawing.Point(175, 516);
            this.dataGridViewOrderLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewOrderLine.Name = "dataGridViewOrderLine";
            this.dataGridViewOrderLine.RowHeadersWidth = 51;
            this.dataGridViewOrderLine.RowTemplate.Height = 27;
            this.dataGridViewOrderLine.Size = new System.Drawing.Size(1440, 435);
            this.dataGridViewOrderLine.TabIndex = 89;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1106, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 96);
            this.button3.TabIndex = 88;
            this.button3.Text = "List All OrderLine";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(799, 381);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 96);
            this.button4.TabIndex = 87;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(480, 381);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(216, 96);
            this.button5.TabIndex = 86;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(175, 381);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(216, 96);
            this.button6.TabIndex = 85;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(829, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 31);
            this.textBox1.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 83;
            this.label7.Text = "Order ID";
            // 
            // textBoxOrderQuantity
            // 
            this.textBoxOrderQuantity.Location = new System.Drawing.Point(829, 239);
            this.textBoxOrderQuantity.Name = "textBoxOrderQuantity";
            this.textBoxOrderQuantity.Size = new System.Drawing.Size(303, 31);
            this.textBoxOrderQuantity.TabIndex = 82;
            // 
            // textBoxOrderISBN
            // 
            this.textBoxOrderISBN.Location = new System.Drawing.Point(829, 184);
            this.textBoxOrderISBN.Name = "textBoxOrderISBN";
            this.textBoxOrderISBN.Size = new System.Drawing.Size(303, 31);
            this.textBoxOrderISBN.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 80;
            this.label4.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 79;
            this.label3.Text = "Quantity Ordered";
            // 
            // FormOrderClerks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1799, 1141);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormOrderClerks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOrderClerks";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxCID;
        private System.Windows.Forms.TextBox textBoxEID;
        private System.Windows.Forms.TextBox textBoxOrderId;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxOrderDate;
        private System.Windows.Forms.Button buttonSearchOrder;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Button buttonListOrder;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdateOrder;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxOrderQuantity;
        private System.Windows.Forms.TextBox textBoxOrderISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewOrderLine;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}