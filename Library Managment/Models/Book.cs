using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Managment.Models
{
   public class Book
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Author { get; set; }
        public int Count { get; set; }

        [StringLength(50)]
        public string Position { get; set; }


        [Required, Column(TypeName = "money")]
        public decimal Price { get; set; }


        public List<RentedBook> RentedBooks { get; set; }

    }
}
