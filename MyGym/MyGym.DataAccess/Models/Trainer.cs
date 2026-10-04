using MyGym.DataAccess.Enums;

namespace MyGym.DataAccess.Models;

public class Trainer : User
{
    public Specialty Specialty { get; set; }
    
    public DateTime HireDate { get; set; }

    public ICollection<Session> Sessions { get; set; } = [];
}