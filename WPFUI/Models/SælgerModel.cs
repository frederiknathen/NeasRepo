using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public class SælgerModel
    {
        public int SID { get; set; }
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public string FuldeNavn
        {
            get { return $"{Fornavn} {Efternavn}"; }
        }
    }
}
