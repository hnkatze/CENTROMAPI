using System.ComponentModel.DataAnnotations;
namespace CentroM.Models;
public class Consul
{
[Key]
public Guid ConsulId {get;set;}

[Required]
[MaxLength(50)]
public int Code {get;set;}

[Required]
[MaxLength(150)]
public String NameCustomer {get;set;}

[Required]
[MaxLength(500)]
public String Description {get;set;}

[Required]
[MaxLength(50)]
public int Age {get;set;}

[Required]
[MaxLength(50)]
public int CellPhone {get;set;}


[Required]
public DateTime DateCreated {get;set;}

[Required]
public  BloodTypes BloodType {get;set;}

    public Consul(){
        BloodType = BloodTypes.OP;
    }


}
public enum BloodTypes {
    OP,
    ON
}
