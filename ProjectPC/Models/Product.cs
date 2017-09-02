using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPC.Models
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int          ProductID           { get; set; }

        [Required, Display(Name = "Name")]
            public string       ProductName         { get; set; }

        [Required, Display(Name = "Description"), DataType(DataType.MultilineText)]
            public string       ProductDescription  { get; set; }

        [Display(Name = "Size 1")]
            public bool         Size1               { get; set; }

        [Display(Name = "Size 2")]
            public bool         Size2               { get; set; }

        [Display(Name = "Size 3")]
            public bool         Size3               { get; set; }

        [Required, Display(Name = "Price"), DataType(DataType.Currency)]
            public double       Price1              { get; set; }

        [Display(Name = "Price"), DataType(DataType.Currency)]
            public double?       Price2              { get; set; }

        [Display(Name = "Price"), DataType(DataType.Currency)]
            public double?       Price3              { get; set; }

        [Display(Name = "Product Image")]
            public byte[]       Image               { get; set; }

        [Display(Name = "Image Path")]
            public string       ImageType           { get; set; }
        
        [Display(Name = "Category")]
            public int          CategoryID          { get; set; }

        [ForeignKey("CategoryID")]
            public Category     Category            { get; set; }

    }
}