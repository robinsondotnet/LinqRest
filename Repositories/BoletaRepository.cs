using System;
using LinqRest.Models;
using System.Collections;
using System.Collections.Generic;
using LinqRest.Repositories;
using System.Linq;

namespace LinqRest.Repositories
{
    public class BoletaRepository : RepositoryBase
    {
        public List<Boleta> getAll<T>()
        {
            List<Boleta> docList = new List<Boleta>(){
                new Boleta(){ Id = 1 , Description = "Kento's Invoice" },
                new Boleta(){ Id = 2 , Description = "2nd Test Invoice" , Notes = "Notes2" },
                new Boleta(){ Id = 3 , Description = "Third Test Invoice" , Notes = "Notes3" },
                new Boleta(){ Id = 3 , Description = "Fourth Test Invoice" , Notes = "Notes4" },
            };
            docList = docList.
            return docList;
        }
    }
}