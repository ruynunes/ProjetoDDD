using System.Collections.Generic;

namespace ProjetoDDD.Domain.Domain
{
    public partial class Customer
    {
        public Customer()
        {
            Endereco = new HashSet<Endereco>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string ZipCode { get; set; }
        public int Revenue { get; set; }

        public IEnumerable<Endereco> Endereco { get; set; }
    }
}
