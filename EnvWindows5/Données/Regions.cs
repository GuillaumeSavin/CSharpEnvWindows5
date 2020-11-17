using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvWindows5.Données
{
    class Regions : ObservableCollection<Region>
    {

        public void chargermentRegions()
        {
            List<Departement> listDepartARA = new List<Departement>() { new Departement("ARA1"), new Departement("ARA2"), new Departement("ARA3") };
            List<Departement> listDepartBFC = new List<Departement>() { new Departement("BFC1"), new Departement("BFC2") };
            List<Departement> listDepartB = new List<Departement>() { new Departement("B1") };
            List<Departement> listDepartCVL = new List<Departement>() { new Departement("CVL1") };
            List<Departement> listDepartC = new List<Departement>() { new Departement("C1"), new Departement("C2") };
            this.Add(new Region("ARA", listDepartARA));
            this.Add(new Region("BFC", listDepartBFC));
            this.Add(new Region("B", listDepartB));
            this.Add(new Region("CVL", listDepartCVL));
            this.Add(new Region("C", listDepartC));
        }

        public List<Departement> this[String regionGiven]
        {
            get
            {
                Regions reg = this;
                foreach(Region r in reg)
                {
                    if(r.Nom == regionGiven)
                    {
                        return r.ListDepart;
                    }
                }

                return new List<Departement>();
            }
        }
    }
}
