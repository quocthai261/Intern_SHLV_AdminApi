namespace SDMS.Admin.Api.Dtos.CatProvince
{
    public class QueryCatProvinceDto
    {
        public long Id { get; set; }

        public string ProvinceCode { get; set; }

        public string ProvinceName { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreationDate { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public long? LastUpdatedBy { get; set; }
    }
}
