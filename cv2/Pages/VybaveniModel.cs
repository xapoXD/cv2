using System.Runtime.InteropServices;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


// In SDK-style projects such as this one, several assembly attributes that were historically
// defined in this file are now automatically added during build and populated with
// values defined in project properties. For details of which attributes are included
// and how to customise this process see: https://aka.ms/assembly-info-properties


// Setting ComVisible to false makes the types in this assembly not visible to COM
// components.  If you need to access a type in this assembly from COM, set the ComVisible
// attribute to true on that type.

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM.

[assembly: Guid("e502314a-8a81-4f8f-8f93-dd034b3c7600")]




namespace VybaveniModel
{

    public class VybaveniModel
    {
        public string Jmeno { get; set; }
        public DateTime PosledniDatumRevize { get; set; }
        public DateTime DatumKoupeni { get; set; }
        public bool PotrebujeRevizi;


        public VybaveniModel(string jmeno, DateTime datumkoupeni, DateTime poslednidatumrevize, bool potrebujerevizi)
        {
            Jmeno = jmeno;           
            DatumKoupeni = datumkoupeni;
            PosledniDatumRevize = poslednidatumrevize;
            PotrebujeRevizi = potrebujerevizi;

        }
    }
}