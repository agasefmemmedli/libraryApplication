using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Managment.Models
{
    class RentedBook
    {
        public int Id { get; set; }

        [Required]
        public int AdministratorId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public DateTime TakingDate { get; set; }

        [Required]
        public DateTime ReturnDate { get; set; }


        public DateTime? InfactDate { get; set; }


        [Required, Column(TypeName = "money")]
        public decimal Price { get; set; }


        public Administrator Administrator { get; set; }

        public Customer Customer { get; set; }

        public Book Book { get; set; }


    }
}
