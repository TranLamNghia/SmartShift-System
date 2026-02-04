namespace Domain.Entities.Core;

using Domain.Enums;

public class EndUser : BaseEntity
{
    public Guid BranchId { get; set; }
    public Branch Branch { get; set; }
    public string FullName { get; set; }
    public string PasswordHash { get; set; }
    public string PhoneNumber { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public SystemRole SystemRole { get; set; }
    public DateOnly HireAt { get; set; }
    public UserStatus Status { get; set; }
    public ICollection<EmployeePerformanceLog> EmployeePerformanceLogs { get; set; }
    public ICollection<ShiftChangeRequest> ShiftChangeRequests { get; set; }
    public ICollection<Schedule> Schedules { get; set; }
    public ICollection<EmployeeUnavailableSlot> EmployeeUnavailables { get; set; }
    public ICollection<RoleStaff> RoleStaffs { get; set; }
}