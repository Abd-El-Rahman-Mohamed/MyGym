using MyGym.DataAccess.Models;
using MyGym.DataAccess.Enums;

namespace MyGym.DataAccess.Models;

public abstract class User : BaseEntity
{
    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;
    
    public DateOnly DateOfBirth { get; set; }
    
    public Gender Gender { get; set; }

    public Address Address { get; set; } = null!;
}