using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiTech.DAL;

namespace HiTech.GUI
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text.Trim();
            if (textBoxUserId.Text == "1111" && password == "henrybrown")
            {
                FormMISManager formMISManager = new FormMISManager();
                this.Hide();
                formMISManager.ShowDialog();
            }
            else if (textBoxUserId.Text == "2222" && password == "thomasmoore")
            {
                FormSalesManager formSalesManager = new FormSalesManager();
                this.Hide();
                formSalesManager.ShowDialog();
            }
            else if (textBoxUserId.Text == "3333" && password == "peterwang")
            {
                FormInventoryController formInventoryController = new FormInventoryController();
            this.Hide();
            formInventoryController.ShowDialog();
            }
                else if (textBoxUserId.Text == "4444" && password == "marybrown")
                {
                    FormOrderClerks formOrderClerks = new FormOrderClerks();
                    this.Hide();
                    formOrderClerks.ShowDialog();
                }
                else if (textBoxUserId.Text == "5555" && password == "jenniferbouchard")
                {
                    FormOrderClerks formOrderClerks = new FormOrderClerks();
                    this.Hide();
                    formOrderClerks.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please enter the correct User!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
    }
}
