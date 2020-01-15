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
    public partial class DodajKnjigu : Form
    {
        public GraphClient client;
        public DodajKnjigu()
        {
            InitializeComponent();
        }

        private void DodajKnjigu_Load(object sender, EventArgs e)
        {

        }

        private void dodajbtn_Click(object sender, EventArgs e)
        {
            Knjiga knjiga = this.napraviKnjigu();
            string maxId = getMaxId();

            try
            {
                int mId = Int32.Parse(maxId);
                knjiga.id = (mId++).ToString();
            }
            catch (Exception exception)
            {
                knjiga.id = "";
            }


            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("naslov", knjiga.naslov);
            queryDict.Add("zanr", knjiga.zanr);
            queryDict.Add("godinaIzdavanja", knjiga.godinaIzdavanja);
            queryDict.Add("glavnaUloga", knjiga.glavnaUloga);
            queryDict.Add("kratakSadrzaj", knjiga.kratakSadrzaj);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Knjiga {id:'" + knjiga.id+ "', naslov:'" + knjiga.naslov
                                                            + "', zanr:'" + knjiga.zanr + "', godinaIzdavanja:'" + knjiga.godinaIzdavanja
                                                            + "', glavnaUloga:'" + knjiga.glavnaUloga+ "',kratakSadrzaj:'"+knjiga.kratakSadrzaj
                                                            + "'}) return n",
                                                            queryDict, CypherResultMode.Set);

            List<Knjiga> knjige = ((IRawGraphClient)client).ExecuteGetCypherResults<Knjiga>(query).ToList();

            foreach (Knjiga k in knjige)
            {
                MessageBox.Show(k.naslov);
            }

            //NodeReference<Actor> newActor = client.Create(actor);

            this.Close();
        }
        private Knjiga napraviKnjigu()
        {
            Knjiga k = new Knjiga();

            k.naslov =naslovtb.Text;
            k.dela = new List<Pisac>();
            k.zanr = zanrtb.Text;
            k.godinaIzdavanja = Int32.Parse(godinatb.Text);
            k.glavnaUloga = glavnaUlogatb.Text;
            k.kratakSadrzaj = sadrzajtb.Text;

            return k;
        }
        private String getMaxId()
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where exists(n.id) return max(n.id)",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            String maxId = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(query).ToList().FirstOrDefault();

            return maxId;
        }

        private void odustanibtn_Click(object sender, EventArgs e)
        {
            Glavna glavnaForm = new Glavna();
            glavnaForm.client = client;
            glavnaForm.ShowDialog();
        }
    }
}
