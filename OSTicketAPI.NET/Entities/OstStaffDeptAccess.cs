﻿namespace OSTicketAPI.NET.Entities
{
    public partial class OstStaffDeptAccess
    {
        public int StaffId { get; set; }
        public int DeptId { get; set; }
        public int RoleId { get; set; }
        public int Flags { get; set; }
    }
}
