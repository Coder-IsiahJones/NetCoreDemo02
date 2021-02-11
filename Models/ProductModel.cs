using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDemo02.Models
{
    public class ProductModel
    {

        [DisplayName("Id Number")]
        public int Id { get; set; }

        [DisplayName("Product")]
        public string Name { get; set; }

        [DisplayName("Price")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }
    }
}
