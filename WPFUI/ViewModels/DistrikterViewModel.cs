using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFUI.DataAccessLayer;
using WPFUI.Models;

namespace WPFUI.ViewModels
{
    public class DistrikterViewModel : Screen
    {
        // Variables
        private List<DistrikterModel> _distrikter;
        private DistrikterModel _selectedDistrikt;
        private List<Butik> _distriktsButikker;
        private List<SælgerModel> _ansvarligSælger;
        private List<SælgerModel> _sekundæreSælgere;
        private SælgerModel _selectedSælger;

        public List<DistrikterModel> IndsætDistrikt
        {
            get { return _distrikter; }
            set { _distrikter = value; }
        }
        public DistrikterModel SelectedIndsætDistrikt
        {
            get { return _selectedDistrikt; }
            set
            {
                _selectedDistrikt = value;

                NotifyOfPropertyChange(() => SelectedIndsætDistrikt);
            }
        }

        public List<DistrikterModel> Distrikt
        {
            get { return _distrikter; }
            set { _distrikter = value; }
        }
        public DistrikterModel SelectedDistrikt
        {
            get { return _selectedDistrikt; }
            set
            {
                _selectedDistrikt = value;
                NotifyOfPropertyChange(() => DistriktsButikker);
                NotifyOfPropertyChange(() => SelectedDistrikt);
                NotifyOfPropertyChange(() => AnsvarligSælger);
                NotifyOfPropertyChange(() => AnsvarligSælgerNavn);
                NotifyOfPropertyChange(() => SekundæreSælgere);
            }
        }
        public List<Butik> DistriktsButikker
        {
            get
            {
                return GetDistriktsButikker();
            }
            set
            {
                _distriktsButikker = value;
            }
        }
        public string AnsvarligSælgerNavn
        {
            get { return FullAnsvarligSælgerNavn(); }

            set
            {
                NotifyOfPropertyChange(() => AnsvarligSælgerNavn);
            }
        }
        public List<SælgerModel> AnsvarligSælger
        {
            get
            {
                return GetAnsvarligSælger();
            }
            set
            {
                _ansvarligSælger = value;
                NotifyOfPropertyChange(() => AnsvarligSælger);
            }
        }
        public List<SælgerModel> SekundæreSælgere
        {
            get
            {
                return GetSekundæreSælgere();
            }
            set
            {
                _sekundæreSælgere = value;
                NotifyOfPropertyChange(() => SekundæreSælgere);
            }
        }
        public SælgerModel SelectedSælger
        {
            get { return _selectedSælger; }
            set
            {
                _selectedSælger = value;
                NotifyOfPropertyChange(() => SelectedSælger);

            }
        }
        //Constructor
        public DistrikterViewModel()
        {
            DataAccess db = new DataAccess();
            Distrikt = db.DistriktData();
        }

        // Methods
        public List<Butik> GetDistriktsButikker()
        {
            try
            {
                DataAccess db = new DataAccess();
                return db.FindButikkerIDistriktViaDID(SelectedDistrikt.DID);
            }
            catch
            {
                return new List<Butik>();
            }
        }
        public string FullAnsvarligSælgerNavn()
        {
            try
            {
                return AnsvarligSælger[0].FuldeNavn;
            }
            catch
            {
                return "";
            }
        }
        public List<SælgerModel> GetAnsvarligSælger()
        {
            try
            {
                DataAccess db = new DataAccess();
                return db.GetAnsvarligSælgerForDistrikt(SelectedDistrikt.DID);
            }
            catch
            {
                return new List<SælgerModel>();
            }
        }
        public List<SælgerModel> GetSekundæreSælgere()
        {
            try
            {
                DataAccess db = new DataAccess();
                return db.GetSælgereForDistrikt(SelectedDistrikt.DID);
            }
            catch
            {
                return new List<SælgerModel>();
            }
        }

        public void GørMarkeretAnsvarlig()
        {
            try
            {
                if (SelectedSælger == null)
                {
                    throw new NullReferenceException("Vælg venligst en sælger");
                }
                if (AnsvarligSælger[0].SID == SelectedSælger.SID)
                {
                    throw new ArgumentException("Den valgte sælger er allerede ansvarlig sælger");
                }
                
                DataAccess db = new DataAccess();
                db.GørPersonSekundær(AnsvarligSælger[0].SID, SelectedDistrikt.DID);
                db.GørPersonAnsvarlig(SelectedSælger.SID, SelectedDistrikt.DID);
                AnsvarligSælgerNavn = FullAnsvarligSælgerNavn();
                SekundæreSælgere = GetSekundæreSælgere();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
