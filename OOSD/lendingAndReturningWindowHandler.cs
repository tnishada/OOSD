using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD
{
    class lendingAndReturningWindowHandler
    {
        Connection connection = new Connection();
        public String lendBook(string bookId, string userId)
        {
            return connection.lending(bookId, userId);
        }

        public string returBook(String bookId, string userId)
        {


            return connection.returning(bookId,userId);
        }
    }
}
