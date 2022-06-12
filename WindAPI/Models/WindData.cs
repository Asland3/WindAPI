using System.ComponentModel.DataAnnotations.Schema;

namespace WindAPI.Models;

[Table("WindTable")]
public class WindData
{
    public int Id { get; set; }
    public int Vindhastighed { get; set; }
    public string Vindretning { get; set; }
}