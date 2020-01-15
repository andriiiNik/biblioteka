using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Neo4J_Repository.DomainModel;
using Neo4jClient;
using Neo4jClient.Cypher;

namespace Neo4J_Repository
{
    public partial class DodajClana : Form
    {
        public GraphClient client;
        public DodajClana()
        {
            InitializeComponent();
        }

        private void DodajClana_Load(object sender, EventArgs e)
        {
            
        }
        private Clan kreirajClana()
        {
            Clan c = new Clan();

            //TimeSpan unixtime =
            //    dateTimePicker1.Value.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            //c.datumUclanjenja = unixtime.TotalMilliseconds.ToString();
            c.imeClana = imeClanatb.Text;
            c.prezimeClana = prezimeClanatb.Text;
            c.godineClana = Int32.Parse(godineClanatb.Text);
            c.clanarina = clanarinatb.Text;
            c.rezervisiKnjigu = rezKnjigutb.Text;

            return c;
        }

        private String getMaxId()
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where exists(n.id) return max(n.id)",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            String maxId = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(query).ToList().FirstOrDefault();

            return maxId;
        }

        private void uclanibtn_Click(object sender, EventArgs e)
        {
            Clan clan = this.kreirajClana();
            string maxId = getMaxId();

            try
            {
                int mId = Int32.Parse(maxId);
                clan.id = (mId++).ToString();
            }
            catch (Exception exception)
            {
                clan.id = "";
            }


            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("imeClana", clan.imeClana);
            queryDict.Add("prezimeClana", clan.prezimeClana);
            queryDict.Add("godineClana", clan.godineClana);
            //queryDict.Add("datumUclanjenja", clan.datumUclanjenja);
            queryDict.Add("clanarina", clan.clanarina);
            queryDict.Add("rezervisiKnjigu", clan.rezervisiKnjigu);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Clan {id:'" + clan.id + "', imeClana:'" + clan.imeClana
                                                            + "', prezimeClana:'" + clan.prezimeClana + "', godineClana:'" + clan.godineClana
                                                            + "', clanarina:'" + clan.clanarina
                                                            + "'}) return n",
                                                            queryDict, CypherResultMode.Set);

            List<Clan> clanovi = ((IRawGraphClient)client).ExecuteGetCypherResults<Clan>(query).ToList();

            foreach (Clan c in clanovi)
            {
                MessageBox.Show(c.imeClana);
            }

            //ovde clan rezervise knjigu
            var queryVeza = new Neo4jClient.Cypher.CypherQuery("match (c:Clan) where c.imeClana='" + clan.imeClana+ "' "
                                                                + " match(k:Knjiga) where k.naslov='" + clan.rezervisiKnjigu + "' CREATE (c) -[r: REZERVISANO]->(k) return r",
                                                                queryDict, CypherResultMode.Set);

            List<Clan> clan1 = ((IRawGraphClient)client).ExecuteGetCypherResults<Clan>(queryVeza).ToList();
            //NodeReference<Actor> newActor = client.Create(actor);

            this.Close();

        }

        private void rezKnjigubtn_Click(object sender, EventArgs e)
        {

        }
        
    }
}
