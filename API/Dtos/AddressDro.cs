using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class AddressDto
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
    }
}