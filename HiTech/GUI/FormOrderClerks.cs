using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTech.BLL;
using HiTech.DAL;
using System.Configuration;
using System.Windows.Forms;
using HiTech.Models;
using HiTech.VALIDATION;

namespace HiTech.GUI
{
    public partial class FormOrderClerks : Form
    {
        
        HiTechDBEntities1 dbEntities = new HiTechDBEntities1();
        public FormOrderClerks()
        {
            InitializeComponent();
        }
       
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.ShowDialog();this.Hide();
        }

        private void buttonUpdateOrder_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(textBoxOrderId.Text.Trim());
            Order order = new Order();
            order = dbEntities.Orders.Find(orderId);
            if (order != null)
            {
                order.OrderId = Convert.ToInt32(textBoxOrderId.Text.Trim());
                order.OrderDate = Convert.ToDateTime(maskedTextBoxOrderDate.Text.Trim());
                order.CustomerId = Convert.ToInt32(textBoxCID.Text.Trim());
                order.EmployeeId = Convert.ToInt32(textBoxEID.Text.Trim());

                dbEntities.SaveChanges();
                MessageBox.Show("Order has been updated successfully", "Confirmation");
                textBoxOrderId.Clear();
                maskedTextBoxOrderDate.Clear();
                textBoxEID.Clear();
                textBoxCID.Clear();
            }
            else
            {
                MessageBox.Show("Order not found", "error");
                textBoxOrderId.Clear();
                maskedTextBoxOrderDate.Clear();
                textBoxEID.Clear();
                textBoxCID.Clear();
                return;
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(textBoxOrderId.Text.Trim());
            Order order = new Order();
            order = dbEntities.Orders.Find(orderId);
            if (order != null)
            {
                var result = MessageBox.Show("Are you sure to delete this order?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dbEntities.Orders.Remove(order);
                    dbEntities.SaveChanges();
                    MessageBox.Show("Orders deleted successfully", "successfully");
                }
                else
                {
                    return;
                }

            }
            textBoxOrderId.Clear();
            maskedTextBoxOrderDate.Clear();
            textBoxEID.Clear();
            textBoxCID.Clear();
        }
        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.OrderId = Convert.ToInt32(textBoxOrderId.Text.Trim());
            order.OrderDate = Convert.ToDateTime(maskedTextBoxOrderDate.Text);
            order.CustomerId = Convert.ToInt32(textBoxCID.Text.Trim());
            order.EmployeeId = Convert.ToInt32(textBoxEID.Text.Trim());
            dbEntities.Orders.Add(order);
            dbEntities.SaveChanges();
            MessageBox.Show("Orders saved successfully", "successfully");
            textBoxOrderId.Clear();
            maskedTextBoxOrderDate.Clear();
            textBoxEID.Clear();
            textBoxCID.Clear();
        }
        private void buttonSearchOrder_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(textBoxOrderId.Text.Trim());
            Order order = new Order();
            order = dbEntities.Orders.Find(orderId);
            if (order != null)
            {
                maskedTextBoxOrderDate.Text = order.OrderDate.ToString();
                textBoxCID.Text = order.CustomerId.ToString();
                textBoxEID.Text = order.EmployeeId.ToString();
            }
            else
            {
                MessageBox.Show("Can not find this order", "error");
            }
        }
        private void buttonListOrder_Click(object sender, EventArgs e)
        {
            var listOrder = (from order in dbEntities.Orders select order).ToList<Order>();
            dataGridViewOrder.DataSource = listOrder;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var listOrderline = (from order in dbEntities.OrderLines select order).ToList<OrderLine>();
            dataGridViewOrderLine.DataSource = listOrderline;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            OrderLine orderline = new OrderLine();
            orderline.OrderId = Convert.ToInt32(textBox1.Text.Trim());
            orderline.ISBN = Convert.ToInt32(textBoxOrderISBN.Text.Trim());
            orderline.QuantityOrdered = Convert.ToInt32(textBoxOrderQuantity.Text.Trim());
            dbEntities.OrderLines.Add(orderline);
            dbEntities.SaveChanges();
            MessageBox.Show("Orderlines saved successfully", "successfully");
            textBox1.Clear();
            textBoxOrderISBN.Clear();
            textBoxOrderQuantity.Clear();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int orderlineId = Convert.ToInt32(textBox1.Text.Trim());
            OrderLine searchorderLine = new OrderLine();
            searchorderLine = dbEntities.OrderLines.Find(orderlineId);
            if (orderlineId != 0)
            {
                textBoxOrderISBN.Text = searchorderLine.ISBN.ToString();
                textBoxOrderQuantity.Text = searchorderLine.QuantityOrdered.ToString();


            }
            else
            {
                MessageBox.Show("Can not find this order", "error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(textBox1.Text.Trim());
            OrderLine orderline = new OrderLine();
            orderline = dbEntities.OrderLines.Find(orderId);
            if (orderline != null)
            {
                orderline.OrderId = Convert.ToInt32(textBox1.Text.Trim());
                orderline.ISBN = Convert.ToInt32(textBoxOrderISBN.Text.Trim());
                orderline.QuantityOrdered = Convert.ToInt32(textBoxOrderQuantity.Text.Trim());

                dbEntities.SaveChanges();
                MessageBox.Show("OrderLine has been updated successfully", "Confirmation");
                textBox1.Clear();
                textBoxOrderISBN.Clear();
                textBoxOrderQuantity.Clear();
            }
            else
            {
                MessageBox.Show("Order not found", "error");
                textBoxOrderId.Clear();
                maskedTextBoxOrderDate.Clear();
                textBoxEID.Clear();
                textBoxCID.Clear();
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(textBox1.Text.Trim());
            OrderLine delorderline = new OrderLine();
            delorderline = dbEntities.OrderLines.Find(orderId);
            if (delorderline != null)
            {
                var result = MessageBox.Show("Are you sure to delete this orderLine?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dbEntities.OrderLines.Remove(delorderline);
                    dbEntities.SaveChanges();
                    MessageBox.Show("Orderlines deleted successfully", "successfully");
                    textBox1.Clear();
                    textBoxOrderISBN.Clear();
                    textBoxOrderQuantity.Clear();
                }
                else
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("Orders not found!", "Error");
                textBox1.Clear();
            }

        }
    }
}
