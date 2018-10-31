using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderConsole;

namespace OrderForm
{
    public partial class Form1 : Form
    {
        OrderService server = new OrderService();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {                     
            
            //listBox1.DataSource.
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            Order ordertemp = new Order();
            OrderDetails detailstemp = new OrderDetails();
            ordertemp.Client = Clientbox.Text;
            detailstemp.name = Namebox.Text;
            try
            {
                detailstemp.price = int.Parse(Pricebox.Text);
            }
            catch { Pricebox.Text = "Invalid Input";return; }
            try
            {
                detailstemp.number = int.Parse(Numberbox.Text);
            }
            catch { Numberbox.Text = "Invalid Input";return; }
            ordertemp.AddDetail(detailstemp);
            server.AddOrder(ordertemp);

            //this.dataGridView1.Rows.Add(values);
            //refresh datagridview
            this.dataGridView1.Rows.Clear();
            int i = 0, count = server.myOrder.Count;
            while (i < count)
            {
                String[] values = { i.ToString(),
                            server.myOrder[i].Client,
                            server.myOrder[i].TotalPrice.ToString(),
                            server.myOrder[i].myOrderDetail[0].name,
                            server.myOrder[i].myOrderDetail[0].price.ToString(),
                            server.myOrder[i].myOrderDetail[0].number.ToString()};
                this.dataGridView1.Rows.Add(values);
                i++;
            }
            
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            int index;
            try
            {
                index = int.Parse(this.DelIndex.Text);
            }
            catch
            {
                index = -1;
            }
            server.DelOrder(index);
            //refresh datagridview
            this.dataGridView1.Rows.Clear();
            int i = 0, count = server.myOrder.Count;
            while (i < count)
            {
                String[] values = { i.ToString(),
                                server.myOrder[i].Client,
                                server.myOrder[i].TotalPrice.ToString(),
                                server.myOrder[i].myOrderDetail[0].name,
                                server.myOrder[i].myOrderDetail[0].price.ToString(),
                                server.myOrder[i].myOrderDetail[0].number.ToString()};
                this.dataGridView1.Rows.Add(values);
                i++;
            }
        }

        private void addNewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AddOrderForm = new Form();

        }

        private void Pricebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 57) && (e.KeyChar != 8) && (e.KeyChar != 46))
                e.Handled = true;
        }

        private void Numberbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 57) && (e.KeyChar != 8) && (e.KeyChar != 46))
                e.Handled = true;
        }
    }
}
