using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4J_Repository.DomainModel
{
    public class Knjiga
    {
        public String id { get; set; }
        public String naslov { get; set; }
        public String zanr { get; set; }
        public int godinaIzdavanja { get; set; }
        public String glavnaUloga { get; set; }
        public String kratakSadrzaj { get; set; }

        public List<Pisac> dela { get; set; }
    }
}
