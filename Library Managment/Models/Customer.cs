using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Managment.Models
{
    public class Customer
    {

        public int Id { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        public DateTime CreateDate { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        public List<Order> Orders { get; set; }

    }
}
