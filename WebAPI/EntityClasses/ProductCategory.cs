using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI
{
  [Table("ProductCategory", Schema ="SalesLT")]
  public partial class ProductCategory
  {
    /// <summary>
    /// Get/Set ProductCategoryID
    /// </summary>
    [Required]
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductCategoryID { get; set; }

    /// <summary>
    /// Get/Set Name
    /// </summary>
    [Required(ErrorMessage = "The Category Name is required")]    
    public string Name { get; set; }
  }
}
