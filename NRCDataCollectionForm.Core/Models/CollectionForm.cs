using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NRCDataCollectionForm.Models
{
    [Table("CollectionForm", Schema = "col")]
    public class CollectionForm : FullAuditedEntity
    {
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [MaxLength(256)]
        public string Email { get; set; }
        public int? Age { get; set; }
        [Required]
        [MaxLength(256)]
        public string ServicesOpinion { get; set; }

    }
}
