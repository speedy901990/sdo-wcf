using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using sdo_wcf2.Models;
using sdo_wcf;

namespace sdo_wcf2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in both code and config file together.
    public class Service2 : ISecondServer, IRemotingDB
    {
        public VectorClock service1_2VC = new VectorClock("logService1_2VectorClock.log");

        public string MakeDatabasesSynced()
        {
            service1_2VC.incrementVersion("Sync started...");
            ServiceReference1.Service1Client clnt = new ServiceReference1.Service1Client("wsHttpEndpoint");
            Server2ModelMethods sdomm = new Server2ModelMethods();
            List<String> res0 = clnt.OutrageousDatabaseLeak().ToList<String>();
            string procenty = "%%%";
            if (res0.Count == 0)
            {
                service1_2VC.incrementVersion("ERR: Sync aborted. Empty database!");
                return "Pusta baza.";
            }
            else
            {
                foreach (String str in res0)
                {
                    string[] ciach = System.Text.RegularExpressions.Regex.Split(str, procenty);
                    var qry = new List<Patient>();
                    qry = sdomm.GetListOfPatients();
                    foreach (Patient pat in qry)
                    {
                        bool basaur;
                        if (ciach[5] == "true" || ciach[5] == "True")
                            basaur = true;
                        else
                            basaur = false;
                        if (pat.pssl == Convert.ToInt32(ciach[4]))
                        {
                            sdomm.updatePatient(pat.Id, ciach[1], ciach[2], basaur, ciach[3], Convert.ToInt32(pat.Height), Convert.ToInt32(pat.Weight));
                        }
                        else
                        {
                            sdomm.addPatient(ciach[1], ciach[2], basaur, ciach[3], Convert.ToInt32(pat.Height), Convert.ToInt32(pat.Weight));
                        }
                    }

                }
            }
            service1_2VC.incrementVersion("All data has been synced.");
            return "Update Completed.";
        }
        public string TerriblyRetrieveDatabase()
        {
            Server2ModelMethods sdomm = new Server2ModelMethods();
            List<Patient> pp = new List<Patient>();
            pp = sdomm.GetListOfPatients();
            string sp = pp.ToString(); // Istnieje specjalne miejsce w piekle dla ludzi, którzy robią coś takiego.
            return sp;
        }

    }
}
