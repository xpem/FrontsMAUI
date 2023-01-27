using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingDashboardMAUI.Models
{
    public class Information
    {
        private string _title = string.Empty;
        private string _description = string.Empty;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public Information(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
