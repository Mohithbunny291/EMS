using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS.DAL
{
    [Table(name: "DeptMaster")]
    public class DeptMaster
    {
        [Key]
        public int DeptCode { get; set; }
        [Required]
        public string? DeptName { get; set; }

        public virtual ICollection<EmpProfile>? EmpProfiles { get; set; }
    }
}
