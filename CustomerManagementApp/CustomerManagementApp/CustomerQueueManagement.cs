using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerManagementApp
{
    public partial class CustomerQueueManagement : Form
    {
        private int count = 0;

        private Queue<Customer> customerQueue = new Queue<Customer>();
       
        public CustomerQueueManagement()
        {
            InitializeComponent();
        }



        private void enqueueButton_Click(object sender, EventArgs e)
        {
            if (enqueueNameTextBox.Text != "" && enqueueComplainTextBox.Text != "")
            {
                Customer aCustomer = new Customer();
                aCustomer.serialNo = Convert.ToString(++count);
                aCustomer.name = enqueueNameTextBox.Text;
                aCustomer.complain = enqueueComplainTextBox.Text;

                customerQueue.Enqueue(aCustomer);

                //waitingQueueListview.Items.Clear();
                ListViewItem item = new ListViewItem(aCustomer.serialNo);
                item.SubItems.Add(aCustomer.name);
                item.SubItems.Add(aCustomer.complain);
                waitingQueueListview.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Please Enter All Data");
            }
            enqueueNameTextBox.Text = string.Empty;
            enqueueComplainTextBox.Text = string.Empty;

        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            if (waitingQueueListview.Items.Count !=0)
            {
                Customer dequeueCustomer = new Customer();
                dequeueCustomer = customerQueue.Dequeue();
                dequeueSerialNoTextBox.Text = dequeueCustomer.serialNo;
                dequeueNameTextBox.Text = dequeueCustomer.name;
                dequeueComplainTextBox.Text = dequeueCustomer.complain;
                waitingQueueListview.Items.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("Don't Waiting Any Customer");
            }


        }
    }
}
