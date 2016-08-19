using System;
using LinqRest.Models;
using System.Collections;
using System.Collections.Generic;

namespace LinqRest.Repositories
{
    public abstract class RepositoryBase
    {
        public abstract IEnumerable<Documento> getAll();
    }
}