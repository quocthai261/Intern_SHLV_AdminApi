using System;
using System.Collections.Generic;

namespace SDMS.Admin.Domain.Entities;

public partial class CatHospital
{
    public long Id { get; set; }

    public string? HospitalCode { get; set; }

    public string? HospitalNameEng { get; set; }

    public string? HospitalNameVie { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? LastUpdatedDate { get; set; }

    public long? LastUpdatedBy { get; set; }

    public long? AddressId { get; set; }
}