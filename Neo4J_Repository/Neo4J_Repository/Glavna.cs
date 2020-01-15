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
    public partial class Glavna : Form
    {
        public GraphClient client;
        public Glavna()
        {
            InitializeComponent();
        }

        private void dodajKnjigubtn_Click(object sender, EventArgs e)
        {
            DodajKnjigu dodajKnjiguForm = new DodajKnjigu();
            dodajKnjiguForm.client = client;
            dodajKnjiguForm.ShowDialog();
        }

        private void Glavna_Load(object sender, EventArgs e)
        {
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "komsika");
            try
            {
                client.Connect();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void pronadjiKnjigubtn_Click(object sender, EventArgs e)
        {
            string knjigaNaslov = ".*" + naslovKnjigetb.Text + ".*";

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("knjigaNaslov", knjigaNaslov);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Knjiga) and exists(n.naslov) and n.naslov =~ {knjigaNaslov} return n",
                                                            queryDict, CypherResultMode.Set);

            List<Knjiga> knjige = ((IRawGraphClient)client).ExecuteGetCypherResults<Knjiga>(query).ToList();

            foreach (Knjiga k in knjige)
            {
                MessageBox.Show(k.naslov+" "+k.zanr);
            }
        }

        private void delabtn_Click(object sender, EventArgs e)
        {
            string imePisca = ".*" + imePiscatb.Text + ".*";

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("imePisca", imePisca);
          
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:NAPISAO]->(a) where exists(n.ime) and n.ime =~ {imePisca} return a",
                                                            queryDict, CypherResultMode.Set);

            List<Knjiga> knjige = ((IRawGraphClient)client).ExecuteGetCypherResults<Knjiga>(query).ToList();

            foreach (Knjiga k in knjige)
            {
                MessageBox.Show(k.naslov);
            }
        }

        private void button1_Click(object sender, EventArgs e) //obrisi knjigu
        {
            string naslovKnjige = ".*Cekajuci.*"; //Cekajuci Godoa

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("naslovKnjige", naslovKnjige);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Knjiga) and exists(n.naslov) and n.naslov =~ {naslovKnjige} delete n",
                                                            queryDict, CypherResultMode.Projection);

            List<Knjiga> knjige = ((IRawGraphClient)client).ExecuteGetCypherResults<Knjiga>(query).ToList();

            foreach (Knjiga k in knjige)
            {
                MessageBox.Show(k.naslov);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)//uclani
        {
            DodajClana dodajClanaForm = new DodajClana();
            dodajClanaForm.client = client;
            dodajClanaForm.ShowDialog();
        }
    }
}
