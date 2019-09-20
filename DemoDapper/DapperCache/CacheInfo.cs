using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DemoDapper.DapperCache
{

    public class CacheInfo
    {
       

        public DeserializerState Deserializer { get; set; }
        public Func<IDataReader, object>[] OtherDeserializers { get; set; }
        public Action<IDbCommand, object> ParamReader { get; set; }
        private int hitCount;
        public int GetHitCount() { return Interlocked.CompareExchange(ref hitCount, 0, 0); }
        public void RecordHit() { Interlocked.Increment(ref hitCount); }
    }
   
}
