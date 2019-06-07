using System;
using System.Collections.Generic;

namespace ProjetoDDD.Domain.Domain
{
    public partial class Endereco
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
