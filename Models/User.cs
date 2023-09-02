using System.ComponentModel.DataAnnotations;
namespace CentroM.Models;
public class User
{
[Key]
public Guid UserId {get;set;}

[Required]
public String Name {get;set;}

[Required]
public String Password {get;set;}

[Required]
public  UserTypes UserType {get;set;}

    public User(){
        UserType = UserTypes.Normal;
    }

}

public enum UserTypes {
    Normal,
    Admin
}