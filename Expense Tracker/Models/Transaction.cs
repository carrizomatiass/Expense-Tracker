using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }
        [Range (1,int.MaxValue,ErrorMessage ="Plase select a category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        [Range (1,int.MaxValue,ErrorMessage ="Amount should be greater than 0.")]
        public int TransactionAmount { get; set; }
        [Column (TypeName = "nvarchar(75)")]
        public string? TransactionNote { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Now;
        [NotMapped]
        public string ? CategoryTitleWithIcon
        {
            get
            {
                return Category == null ? "" : Category.CategoryIcon + " " + Category.CategoryTitle;
            }
        }
        [NotMapped]
        public string? FormattedAmount
        {
            get
            {
                return ((Category == null || Category.CategoryType == "Expense") ? "- " : "+ " + TransactionAmount.ToString("N2"));
            }
        }

        

    }
}
