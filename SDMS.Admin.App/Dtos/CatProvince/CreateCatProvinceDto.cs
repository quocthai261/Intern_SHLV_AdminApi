namespace SDMS.Admin.Api.Dtos.CatProvince
{
    public class CreateCatProvinceDto
    {
        public string ProvinceCode { get; set; }

        public string? ProvinceName { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
    }
}
