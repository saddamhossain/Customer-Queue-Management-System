using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerCareProblemQueueApp
{
    public partial class CustomerUI : Form
    {
        // at first for serial number we need a variable s. which is count is equalto 0
        private int count = 0;

        //we need a queue list for managing more than one customer in the list
        Queue<Customer> customerList = new Queue<Customer>(); 

        public CustomerUI()
        {
            InitializeComponent();
        }

        private void enqueueButton_Click(object sender, EventArgs e)
        {
            if (enqueueNameTextBox.Text != "" & enqueueNameTextBox.Text != "" & enqueueEmailTextBox.Text != "" &
                enqueuePhoneTextBox.Text != "" & enqueueComplainTextBox.Text != "")
            {
                //we need a create object of Customer class . that's why we need to access of that class and aCustomer is a variable 
                Customer aCustomer = new Customer();

                aCustomer.serialNo = Convert.ToString(++count); //for serial no count increment 
                aCustomer.name = enqueueNameTextBox.Text;   // the textbox'es text is allow only string tyepe value and which value is given textbox we keep it name variable which is stay customer class and that's why we needed a object of Customer class.
                aCustomer.email = enqueueEmailTextBox.Text;
                aCustomer.phone = enqueuePhoneTextBox.Text;
                aCustomer.complain = enqueueComplainTextBox.Text;

                customerList.Enqueue(aCustomer); // here list is enqueue and here the parameter is aCustomer.

                enqueueNameTextBox.Text = String.Empty; // all textbox are empty
                enqueueEmailTextBox.Text = String.Empty;
                enqueuePhoneTextBox.Text = String.Empty;
                enqueueComplainTextBox.Text = string.Empty;

                ListViewItem items = new ListViewItem(aCustomer.serialNo); //for use listviewitem we need to initialze or create object first and the first value iis item then use subitem
                items.SubItems.Add(aCustomer.name);
                items.SubItems.Add(aCustomer.phone);
                items.SubItems.Add(aCustomer.complain);

                waitingQueueListview.Items.Add(items); // now listview name is added all item here...


            }
            else
            {
                MessageBox.Show(@"Please enter all the information");
            }
            
            


        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            if (waitingQueueListview.Items.Count != 0)
            {
                Customer dequeueCustomer = new Customer();

                dequeueCustomer = customerList.Dequeue();

                dequeueSerialNoTextBox.Text = dequeueCustomer.serialNo;
                dequeueNameTextBox.Text = dequeueCustomer.name;
                dequeueEmailTextBox.Text = dequeueCustomer.email;
                dequeuePhoneTextBox.Text = dequeueCustomer.phone;
                dequeueComplainTextBox.Text = dequeueCustomer.complain;

                waitingQueueListview.Items.RemoveAt(0);   
            }
            else
            {
                MessageBox.Show(@"There are no customer waiting right now");
            }

            


        }
    }
}
