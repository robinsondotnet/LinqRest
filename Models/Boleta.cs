using System;

namespace LinqRest.Models
{   
    public class Boleta : Documento
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string Notes { get; set; } 

    }

}