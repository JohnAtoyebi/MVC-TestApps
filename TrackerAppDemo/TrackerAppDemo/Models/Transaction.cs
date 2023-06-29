using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace TrackerAppDemo.Models
{
    public class Transaction
    {
        CultureInfo ngCulture = CultureInfo.CreateSpecificCulture("en-NG");

        public string TransactionId { get; set; } = Guid.NewGuid().ToString();
        public int Amount { get; set; }
        public string? Note { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string CategoryId { get; set; }
        public Category? Category { get; set; }


        [NotMapped]
        public string CategoryTitleWithIcon 
        {
            get
            {
                return Category == null ? "" : Category.Icon + " " + Category.Title;
            } 
        }

        [NotMapped]
        public string AmountWithprefix 
        { 
            get
            {
                return ((Category == null || Category.Type == "Expense") ? "-" : "+ ") + string.Format(ngCulture, "{0:C0}", Amount);
            }
        }
    }
}
