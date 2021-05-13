using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArzTiServer.Models
{
    public class ErezeptPruefResult
    {
        public String id;
        public String uid;
        public ICollection<ErSenderezepteErezeptStatusinfo> infos;
    }
}
