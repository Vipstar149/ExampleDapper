using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDapper.DapperCache
{
    public class DeserializerState
    {
        public readonly int Hash;
        public readonly Func<IDataReader, object> Func;

        public DeserializerState(int hash, Func<IDataReader, object> func)
        {
            Hash = hash;
            Func = func;
        }
    }
}
