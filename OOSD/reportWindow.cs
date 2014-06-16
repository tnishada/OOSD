using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOSD
{
    public partial class reportWindow : Form
    {
        public reportWindow()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        reportWindowHandler handler = new reportWindowHandler();
        private void button1_Click(object sender, EventArgs e) // search button on user report tab
        {
            
            if (userNamechkbox.Checked == true) // all user details
            {


                UserInfo.DataSource = handler.getAllDetails();
                UserInfo.DataMember = "std";
                UserInfo.Refresh();
               
            }

            else // details of a specific user
            {
                UserInfo.DataSource = handler.getUserDetails(TextUserName.Text);
                UserInfo.DataMember = "std";
                UserInfo.Refresh();


                UserHistory.DataSource = handler.getUserHistory(TextUserName.Text);
                UserHistory.DataMember = "std";
                UserHistory.Refresh();
            }
        }

        private void userNamechkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (userNamechkbox.Checked == true)
            {
                TextUserName.Enabled = false;

                TextUserName.Enabled = false;

                UserHistory.Enabled = false;

            }

            else 
            {
                TextUserName.Enabled = true;
                UserHistory.Enabled = true;
                
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bookDetailsViewer.DataSource = handler.getBookDetails(textBookId.Text);
            bookDetailsViewer.DataMember = "std";
            bookDetailsViewer.Refresh();

        }

        
    }
}
