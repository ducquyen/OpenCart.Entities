namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_customer_group")]
    public class CustomerGroup
    {
        [Key]
        [Column("customer_group_id")]
        public int Id { get; protected set; }

        [Column("approval")]
        public int Approval { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}