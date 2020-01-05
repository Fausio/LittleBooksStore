using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBooksStore.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "the book Required.")]
        [DataType(DataType.Text)]
        public int BookId { get; set; }

        [Required(ErrorMessage = "the Client Required.")]
        [DataType(DataType.Text)]
        public string ClientName { get; set; }

        [Required(ErrorMessage = "Street is Required.")]
        [DataType(DataType.Text)]
        public string Street { get; set; }

        [Required(ErrorMessage = "City is Required.")]
        [DataType(DataType.Text)]
        public string City { get; set; }
        public string State { get; set; }

        [Required(ErrorMessage ="Country is Required.")]
        [DataType(DataType.Text)]
        public string Country { get; set; }
    }
}
