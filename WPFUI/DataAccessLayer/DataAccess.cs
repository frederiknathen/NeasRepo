using Caliburn.Micro;
using Dapper;
using FormUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFUI.Models;

namespace WPFUI.DataAccessLayer
{
    public class DataAccess
    {
        public void InsertSælger(string fornavn, string efternavn, int distrikt_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NeasDB")))
            {
                List<NySælgerModel> sælgere = new List<NySælgerModel>();

                sælgere.Add(new NySælgerModel { Fornavn = fornavn, Efternavn = efternavn, Distrikt_ID = distrikt_id });

                connection.Execute("dbo.InsertSælger @Fornavn, @Efternavn, @Distrikt_ID", sælgere);
            }
        }
        public void GørPersonAnsvarlig(int glAnsvarligSælgerID, int distriktID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NeasDB")))
            {
                List<SkiftAnsvarModel> AnsvarligSælger = new List<SkiftAnsvarModel>();

                AnsvarligSælger.Add(new SkiftAnsvarModel { Distrikter_DID = distriktID, Sælgere_SID = glAnsvarligSælgerID });

                connection.Execute("dbo.GørPersonAnsvarlig @Sælgere_SID, @Distrikter_DID", AnsvarligSælger);
            }
        }
        public void GørPersonSekundær(int glAnsvarligSælgerID, int distriktID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NeasDB")))
            {
                List<SkiftAnsvarModel> AnsvarligSælger = new List<SkiftAnsvarModel>();

                AnsvarligSælger.Add(new SkiftAnsvarModel { Distrikter_DID = distriktID, Sælgere_SID = glAnsvarligSælgerID });

                connection.Execute("dbo.GørPersonSekundær @Sælgere_SID, @Distrikter_DID", AnsvarligSælger);
            }
        }

        public void FjernSomSekundær(int glAnsvarligSælgerID, int distriktID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NeasDB")))
            {
                List<SkiftAnsvarModel> AnsvarligSælger = new List<SkiftAnsvarModel>();

                AnsvarligSælger.Add(new SkiftAnsvarModel { Distrikter_DID = distriktID, Sælgere_SID = glAnsvarligSælgerID });

                connection.Execute("dbo.FjernSomSekundær @Sælgere_SID, @Distrikter_DID", AnsvarligSælger);
            }
        }
        public void IndsætSomSekundærIAndetDistrikt(int glAnsvarligSælgerID, int distriktID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NeasDB")))
            {
                List<SkiftAnsvarModel> AnsvarligSælger = new List<SkiftAnsvarModel>();

                AnsvarligSælger.Add(new SkiftAnsvarModel { Distrikter_DID = distriktID, Sælgere_SID = glAnsvarligSælgerID });

                connection.Execute("dbo.IndsætSomSekundærIAndetDistrikt @Sælgere_SID, @Distrikter_DID", AnsvarligSælger);
            }
        }

        public List<DistrikterModel> DistriktData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NeasDB")))
            {
                List<DistrikterModel> test = new List<DistrikterModel>();
                return connection.Query<DistrikterModel>("dbo.HentDistrikter").ToList();
            }
        }

        public List<Butik> FindButikkerIDistriktViaDID(int DistriktID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NeasDB")))
            {
                return connection.Query<Butik>("dbo.FindButikkerIDistriktViaDID @Distrikt_DID", new { Distrikt_DID = DistriktID }).ToList();
            }
        }

        public List<SælgerModel> GetAnsvarligSælgerForDistrikt(int DistriktID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NeasDB")))
            {
                return connection.Query<SælgerModel>("dbo.GetAnsvarligSælgerForDistrikt @Distrikt_DID", new { Distrikt_DID = DistriktID }).ToList();
            }
        }
        public List<SælgerModel> GetSælgereForDistrikt(int DistriktID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NeasDB")))
            {
                return connection.Query<SælgerModel>("dbo.GetSælgereForDistrikt @Distrikt_DID", new { Distrikt_DID = DistriktID }).ToList();
            }
        }
    }
}