using System;
using LinqRest.Models;
using System.Collections;
using System.Collections.Generic;
using LinqRest.Repositories;

namespace LinqRest.Repositories
{
    public class BoletaRepository : RepositoryBase
    {
        public override IEnumerable<Documento> getAll()
        {
            List<Documento> docList = new List<Documento>();
            return docList;
        }
    }
}