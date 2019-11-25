namespace FleaMarketApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class item_order
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal order_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal item_id { get; set; }

        public DateTime ordered_at { get; set; }

        public virtual item item { get; set; }

        public override string ToString()
        {
            return $"{order_id} | {item.item_name} | {ordered_at.ToString("yyyy MMM d, HH:mm")}";
        }
    }
}
