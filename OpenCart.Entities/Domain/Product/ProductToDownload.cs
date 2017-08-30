namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_product_to_download")]
    public class ProductToDownload
    {
        [Key]
        [Column("product_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        [Key]
        [Column("download_id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DownloadId { get; set; }
    }
}