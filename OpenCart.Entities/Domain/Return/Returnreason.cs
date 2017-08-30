namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_return_reason")]
    public class ReturnReason : Localizable, IEntityWithName
    {
        [Key]
        [Column("return_reason_id", Order = 0)]
        public int Id { get; protected set; }

        [Required]
        [StringLength(128)]
        [Column("name")]
        public string Name { get; set; }
    }
}