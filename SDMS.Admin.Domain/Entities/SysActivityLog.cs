using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.Domain.Entities
{
    public class SysActivityLog
    {
        public long Id { get; set; }
        public string? UserName { get; set; }
        public string Service { get; set; } = null!;
        public string? IpAddress { get; set; }
        public string? Client { get; set; }
        public string? Host { get; set; }
        public DateTime Time { get; set; }
        public string? CustomData { get; set; }
        public bool? State { get; set; }
        public string? Action { get; set; }
        public long? Duration { get; set; }
        public string? Source { get; set; }
        public string? Device { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
        public string? Os { get; set; }
        public string? Provider { get; set; }
        public string? Parameters { get; set; }
    }
}
