namespace OpenCart.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_manufacturer")]
    public class Manufacturer : IEntityWithName
    {
        [Key, Column("manufacturer_id")]
        public int Id { get; protected set; }

        [Required, StringLength(64), Column("name")]
        public string Name { get; set; }

        [StringLength(255), Column("image")]
        public string Image { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }

        public virtual ICollection<Product> Products { get; protected set; }

        public virtual ICollection<ManufacturerDescription> Descriptions { get; protected set; }

        public virtual ICollection<Store> Stores { get; set; }
    }
}
