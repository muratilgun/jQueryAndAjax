using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI
{
  [Table("ProductModel", Schema ="SalesLT")]
  public partial class ProductModel
  {
    /// <summary>
    /// Get/Set ProductModelID
    /// </summary>
    [Required]
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductModelID { get; set; }

    /// <summary>
    /// Get/Set Name
    /// </summary>
    [Required(ErrorMessage = "The Model Name is required")]    
    public string Name { get; set; }
  }
}
