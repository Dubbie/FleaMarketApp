namespace FleaMarketApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Globalization;

    [Table("item")]
    public partial class item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public item()
        {
            item_order = new HashSet<item_order>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal item_id { get; set; }

        [Required]
        [StringLength(255)]
        public string item_name { get; set; }

        [StringLength(255)]
        public string item_description { get; set; }

        public decimal? item_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal status_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal category_id { get; set; }

        public DateTime created_at { get; set; }

        public DateTime? modified_at { get; set; }

        public virtual category category { get; set; }

        public virtual status status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<item_order> item_order { get; set; }

        public override string ToString()
        {
            string price_label = GetFormattedPrice();
            return $"{item_id} - {item_name} ({price_label})";
        }

        public string GetFormattedPrice()
        {
            var nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
            nfi.NumberGroupSeparator = " ";


            if (item_price != null)
            {
                decimal decimalPrice = (decimal)item_price;
                return decimalPrice.ToString("#,0", nfi) + " Ft"; // "1 234 897.11"
            }
            else
            {
                return "Ár nélkül";
            }
        }
    }
}
