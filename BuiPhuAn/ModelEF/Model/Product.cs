namespace ModelEF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int ID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the name")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the name")]
        public int? UnitCost { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the name")]
        public int? Quantity { get; set; }

        public string UrlImage { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the name")]
        [StringLength(10)]
        public string Status { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}
