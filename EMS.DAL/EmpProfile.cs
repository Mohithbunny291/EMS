using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS.DAL
{
    [Table(name: "EmpProfile")]
    public class EmpProfile
    {
        [Key]
        public int EmpCode { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string? EmpName { get; set; }
        [Required]
        public string? Email { get; set; }
        [ForeignKey("DeptCode")]
        public int DeptCode { get; set; }
        public virtual DeptMaster? DeptMaster { get; set; }
    }
}
