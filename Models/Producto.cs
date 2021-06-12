  
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace branding.Models
{
    [Table("t_product")]
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID{get;set;}

        public String Name {get; set;}

        public double Price {get; set;}

        public String ImagenName { get; set;}

        public String Status {get; set;}

        public virtual ICollection<Proforma> Proforma { get; set; }


        
    }
}