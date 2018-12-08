using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagement;

namespace OrderForm
{
    public partial class Edit : Form
    {
        OrderService orderService = new OrderService();
        bool addMode = false;
        public Order CurrentOrder { get; set; }

        public Edit()
        {
            InitializeComponent();
        }

        public Edit(Order order) : this()
        {
            if (order == null)
            {
                addMode = true;
                CurrentOrder = new Order();
            }
            else
            {
                CurrentOrder = order;
            }
            orderBindingSource.DataSource = CurrentOrder;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (addMode)
            {
                orderService.Add(CurrentOrder);
            }
            else
            {
                orderService.Update(CurrentOrder);
            }
            this.Close();
        }
    }
}
