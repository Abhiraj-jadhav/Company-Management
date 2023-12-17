using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace DempApp2.Model;

[Table("Department_03")]
public class Dept


{
    [Column("deptId")]
    public string Id { get; set; }

    public string dname { get; set; }

     public string dloc { get; set; }

     public List<Emp>Employee_03 = new();

}
