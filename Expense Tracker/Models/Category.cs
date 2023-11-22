using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        [Required(ErrorMessage ="Title is required.")]
        public string CategoryTitle { get; set; }
        [Column(TypeName = "nvarchar(5)")]
        public string CategoryIcon { get; set; } = "";
        [Column(TypeName = "nvarchar(10)")]
        public string CategoryType { get; set; } = "Expense";
        [NotMapped]
        public string? TittleWithIcon
        {
            get
            {
                return this.CategoryIcon + " " + this.CategoryTitle;
            }
        }

    }
}
