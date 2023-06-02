using domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussines
{
    public class gammaController
    {
        private int id;
        private string name;
        private string description;
        private connection con;
        public gammaController() { con = new connection(); }
        public List<gammaPhone> gammaList()
        {
            List<gammaPhone> gammaPhones = new List<gammaPhone>();
            try {
                con.setQuery("select g.gamma, g.description from gamma g");
                con.getConnectionAndExecuteReader();

                while (con.getReader().Read())
                {
                    SqlDataReader reader = con.getReader();
                    gammaPhone gamma = new gammaPhone((string)reader["gamma"]);
                    gamma.setDescription((string)reader["Description"]);
                    gammaPhones.Add(gamma);
                }
                return gammaPhones;
            }       
            catch(Exception e) {
                throw e; }
            finally { con.closeConnection(); }

        }


        public String getName () { return name; }
        public String getDescription () { return description; }
    }
}
