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
        public decimal order_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal item_id { get; set; }

        public DateTime ordered_at { get; set; }

        public virtual item item { get; set; }
    }
}
