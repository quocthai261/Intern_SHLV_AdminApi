namespace SDMS.Admin.App.Dtos.CatWard
{
    public class QueryCatWardDto
    {
        public long Id { get; set; }

        public long? DistrictCode { get; set; }

        public string? WardCode { get; set; }

        public string? WardName { get; set; }

        public string? SalaryPeriodType { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreationDate { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public long? LastUpdatedBy { get; set; }
    }
}
