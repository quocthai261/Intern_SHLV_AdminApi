using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.SysSetting
{
    public class UpdateSysSettingDto
    {
        public long Id { get; set; }
        public string? GroupSetting { get; set; }
        public string? SettingCode { get; set; }
        public string? SettingName { get; set; }
        public string? SettingValue { get; set; }
        public string? SettingDesciption { get; set; }
        public int IsActive { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
