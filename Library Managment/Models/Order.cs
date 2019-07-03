using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Managment.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public DateTime TakedDate { get; set; }

        public Customer Customer { get; set; }

        public List<RentedBook> RentedBooks { get; set; }
    }
}
