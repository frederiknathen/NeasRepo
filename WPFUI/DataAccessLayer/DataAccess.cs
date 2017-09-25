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
        public List<PersonModel> GetSælgere(string Efternavn)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NeasDB")))
            {
                //return connection.Query<Sælger>($"SELECT * FROM Sælgere WHERE Efternavn = '{ Efternavn }'").ToList();
                return connection.Query<PersonModel>("dbo.VisSælgere @Efternavn", new { Efternavn = Efternavn }).ToList();
            }
        }

/*        public void InsertSælger(string fornavn, string efternavn)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NeasDB")))
            {
                //Sælger nySælger = new Sælger {Fornavn = fornavn, Efternavn = efternavn};
                List<PersonModel> sælgere = new List<PersonModel>();

                sælgere.Add(new PersonModel { Fornavn = fornavn, Efternavn = efternavn });

                connection.Execute("dbo.Insert_Ny_Sælger @Fornavn, @EFternavn", sælgere);
            }
        }*/

        public List<SælgerModel> SælgerData(string Distriktnavn)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NeasDB")))
            {
                return connection.Query<SælgerModel>("dbo.HentPersonerIDistrikt @Distriktnavn", new { Distriktnavn = Distriktnavn }).ToList();
            }
        }

        public List<DistrikterModel> DistriktData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NeasDB")))
            {
                List<DistrikterModel> test = new List<DistrikterModel>(); 
                test = connection.Query<DistrikterModel>("dbo.HentDistrikter").ToList();
                return test;
            }
        }

        public List<Butik> HentButikkerTilhørendeDistriktID(int DistriktID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NeasDB")))
            {
                return connection.Query<Butik>("dbo.FindButikkerIDistriktViaDID @Distrikt_DID", new { Distrikt_DID = DistriktID }).ToList();
            }
        }

        public void SetSælgerTilAnsvarlig()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NeasDB")))
            {

            }
        }

    }
}