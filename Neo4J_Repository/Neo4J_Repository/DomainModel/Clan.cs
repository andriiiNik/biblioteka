using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4J_Repository.DomainModel
{
    public class Clan
    {
        public String id { get; set; }
        public String imeClana { get; set; }
        public String prezimeClana { get; set; }
        public int godineClana { get; set; }
        public String datumUclanjenja { get; set; }
        public String clanarina { get; set; }
        public String rezervisiKnjigu { get; set; }

        public DateTime getdatumUclanjenja()
        {
            if (this.datumUclanjenja == null) return new DateTime();

            long timestamp = Int64.Parse(this.datumUclanjenja);
            DateTime startDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return startDateTime.AddMilliseconds(timestamp).ToLocalTime();
        }
    }
}
