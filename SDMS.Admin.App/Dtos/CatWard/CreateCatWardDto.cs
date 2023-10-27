namespace SDMS.Admin.App.Dtos.CatWard
{
    public class CreateCatWardDto
    {
        public long? DistrictCode { get; set; }

        public string? WardCode { get; set; }

        public string? WardName { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
    }
}
