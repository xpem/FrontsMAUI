using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIBank.Models
{
    public class TransactionGroup : List<Transaction>
    {
        public DateOnly Date { get; }

        public TransactionGroup(DateTime dateTime, List<Transaction> transactions) : base(transactions)
        {
            Date = new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);
        }
    }
}
