using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatRelation
{
    public class QueryCatRelationDto
    {
        public long Id { get; set; }

        public string RelationCode { get; set; }

        public string RelationNameEng { get; set; }

        public string RelationNameVie { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreationDate { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public long? LastUpdatedBy { get; set; }

        public string RelationGroup { get; set; }
    }
}
