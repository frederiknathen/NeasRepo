using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFUI.Models;
using WPFUI.DataAccessLayer;

namespace WPFUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private string _overskrift = "Neas Project";
         
        public string Overskrift
        {
            get { return _overskrift; }
            set
            {
                _overskrift = value;
                NotifyOfPropertyChange(() => Overskrift);
            }
        }
       
        public void LoadDistrikter()
        {
            Overskrift = "Distrikter";
            ActivateItem(new DistrikterViewModel());
        }
        public void LoadTilføj()
        {
            Overskrift = "Tilføj/rediger sælger";
            ActivateItem(new TilføjNySælgerViewModel());

        }
    }
}
