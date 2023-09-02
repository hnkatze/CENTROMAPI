using System.ComponentModel.DataAnnotations;
namespace CentroM.Models;
public class Product
{
[Key]
public Guid ProductId {get;set;}

[Required]
[MaxLength(150)]
public String Name {get;set;}

[Required]
[MaxLength(500)]
public String Description {get;set;}

[Required]
[MaxLength(50)]
public int amount {get;set;}

[Required]
[MaxLength(50)]
public String codigo {get;set;}

[Required]
public DateTime DateEnd {get;set;}


}

