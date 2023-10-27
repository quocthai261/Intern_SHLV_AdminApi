namespace SDMS.Admin.App.Dtos.CatWard
{
    public class UpdateCatWardDto
    {
        public long Id { get; set; }

        public long? DistrictCode { get; set; }

        public string? WardCode { get; set; }

        public string? WardName { get; set; }
        public DateTime? LastUpdatedDate { get; set; }

        public long? LastUpdatedBy { get; set; }
    }
}
