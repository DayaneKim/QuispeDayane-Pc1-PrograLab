using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace progra.Models
{
    //CARRITO
    [Table("t_orden")]
    public class Pedido
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID {get; set;}

        public String UserID {get; set;}


        public Decimal Total { get; set; }
    }
}