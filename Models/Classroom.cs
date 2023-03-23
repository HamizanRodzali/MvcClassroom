using System.ComponentModel.DataAnnotations;

namespace MvcClassroom.Models;

public class Classroom
{
    public int Id { get; set; }
    public int Rank { get; set; }
    public string? ClassName { get; set; }
    public string? Symbol { get; set; }
    public int TotalStudent { get; set; } 
    public decimal TotalStudentPercentage { get; set; }
}
