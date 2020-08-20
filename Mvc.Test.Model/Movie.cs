using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MVC.Test.Model
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "标题")]
        public string Title { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "上映时间")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "类型")]
        public string Genre { get; set; }


        [Display(Name = "价格")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
