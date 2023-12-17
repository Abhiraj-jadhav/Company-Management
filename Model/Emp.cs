using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DempApp2.Model;

[Table("Employee_03")]
public class Emp
{
    [Required]
    [Column("eno")]
    public string Id { get; set; }

   // [MinLength(length:3)]
    [MinLength(3, ErrorMessage = "Name too small")]
    public string ename { get; set; }

     public decimal esal { get; set; }

    [Column("deptno")]
    public string deptId { get; set; }

    public string Password { get; set; }


    // public List<Order> Orders { get; set; }
}
