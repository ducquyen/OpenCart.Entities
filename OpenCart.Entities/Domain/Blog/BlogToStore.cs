namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_blog_to_store")]
    public class BlogToStore
    {
        [Key]
        [Column("blog_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BlogId { get; set; }

        [Key]
        [Column("store_id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreId { get; set; }
    }
}
