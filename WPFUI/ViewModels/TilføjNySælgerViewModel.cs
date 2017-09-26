using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFUI.DataAccessLayer;
using WPFUI.Models;

namespace WPFUI.ViewModels
{
    public class TilføjNySælgerViewModel : Screen
    {

        private string _fornavn;
        private string _efternavn; 

        public string Fornavn
        {
            get { return _fornavn; }
            set
            {
                _fornavn = value;
                NotifyOfPropertyChange(() => Fornavn);
            }
        }
     
        public string Efternavn
        {
            get { return _efternavn; }
            set
            {
                _efternavn = value;
                NotifyOfPropertyChange(() => Efternavn);
            }
        }

        private List<DistrikterModel> _distrikter;
        private DistrikterModel _selectedDistrikt;
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
                NotifyOfPropertyChange(() => SelectedDistrikt);
            }
        }
        public TilføjNySælgerViewModel()
        {
            DataAccess db = new DataAccess();
            Distrikt = db.DistriktData();
        }
        public void TilføjSælgerTilDB()
        {
            DataAccess db = new DataAccess();
            db.InsertSælger(Fornavn, Efternavn, SelectedDistrikt.DID);
            Fornavn = "";
            Efternavn = "";
        }

    }
}
