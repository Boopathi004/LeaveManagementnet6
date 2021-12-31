
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.web.Data
{
    public class LeaveAllocation : BaseEntity
    {
      
       public int NumberofDays { get; set; }

       [ForeignKey("LeaveTypeid")]
       public LeaveType LeaveType { get; set; }
       public int LeaveTypeId { get; set; } 
       public string EmployeeId { get; set; }
      

    }
}
