using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace WatchStore.Models
{
    public enum Material
    {
        Silicone,Nylon,Leather
    }
    public class Watch
    {
        [Key]
        public int ID { get; set; }
        //[Required]
        //public int CollectionID { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Watch Name")]
        public string Name { get; set; }

        [Display(Name = "Color")]
        public string Color { get; set; }

        //public List<SelectListItem> ColorItems { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public bool Gender { get; set; }

        [Display(Name = "Image")]
        public string Image { get; set; }//should be saved binary

        //[Display(Name = "Material")]
        //public Material? Material { get; set; }

        [Column("Year")]
        [Display(Name = "Publish Year")]
        public string PublishYear { get; set; }

        [Column("Price")]
        [Display(Name = "Price")]
        public decimal BasePrice { get; set; }

        //public virtual Collection Collection { get; set; }

        public Watch()
        {
            //ColorItems.AddRange(new List<SelectListItem>(){ new SelectListItem{Text = "Black", Value = "black", Selected = true},
            //                                                new SelectListItem { Text = "Black", Value = "black", Selected = true }});
        }
    }
}