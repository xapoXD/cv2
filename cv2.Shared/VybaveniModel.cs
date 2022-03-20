using System.Runtime.InteropServices;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;







namespace cv2.Shared
{

    public class VybaveniModel
    {
        public string Jmeno { get; set; }
        public DateTime PosledniDatumRevize { get; set; }
        public DateTime DatumKoupeni { get; set; }

        public bool PotrebujeRevizi { get; set; }

        public bool EditMod { get; set; }



        public VybaveniModel(string jmeno, DateTime datumkoupeni, DateTime poslednidatumrevize, bool potrebujerevizi, bool editmod)
        {
            Jmeno = jmeno;
            DatumKoupeni = datumkoupeni;
            PosledniDatumRevize = poslednidatumrevize;
            PotrebujeRevizi = potrebujerevizi;
            EditMod = editmod;
        }

    }
}