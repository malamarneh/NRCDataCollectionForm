using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NRCDataCollectionForm.Models
{
    [Table("Admin", Schema = "Sec")]
    public class Admin : FullAuditedEntity
    {
        [Required]
        [MaxLength(256)]
        public string userName { get; set; }
        [MaxLength(256)]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
