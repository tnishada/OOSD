using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MySql.Data.Types;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace OOSD
{
    class reportWindowHandler
    {
        Connection con = new Connection();
        DataSet ds = null;
        public DataSet getAllDetails()
        {
           
            ds = con.getAllDetails();

            return ds;

            
        }

        public DataSet getUserDetails(String usernamed)
        {

            ds = con.getUserdetails(usernamed);

            return ds;
        }

        public DataSet getUserHistory(String usernameH)
        {
            ds = con.getUserHistory(usernameH);

            return ds;
        }

        public DataSet getBookDetails(string bookId)
        {
            ds = con.getBookDetails(bookId);
            return ds;
        }
    }
}
