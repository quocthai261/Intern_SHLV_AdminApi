using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.SyncJob
{
    public class UpdateSyncJobDto
    {
        public long Id { get; set; }
        public long ScheduleTypeId { get; set; }
        public string? ScheduleDescription { get; set; }
        public string? Description { get; set; }
        public DateTime? LastRun { get; set; }
        public DateTime? NextRun { get; set; }
        public bool? Enable { get; set; }
        public bool? Valid { get; set; }
        public bool? JobIsRunning { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public decimal? LastUpdatedBy { get; set; }
        public int? ComplexPriority { get; set; }
        public bool? ForceRun { get; set; }
    }
}
