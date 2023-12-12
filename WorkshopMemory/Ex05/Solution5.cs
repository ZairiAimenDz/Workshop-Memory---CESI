using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopMemory.Ex05
{

    public class Solution5
    {    
        public delegate void Frequence(string musique);

        public static void Start()
        {
            Radio Nrj, Fun;
            posteRadio poste1, poste2, poste3;

            Nrj = new Radio("nrj", "musique nrj");
            Fun = new Radio("fun", "musique fun");

            poste1 = new posteRadio();
            poste2 = new posteRadio();
            poste3 = new posteRadio();

            poste1.reglerStation("nrj");
            poste2.reglerStation("nrj");
            poste3.reglerStation("fun");

            Nrj.diffuserMusique();
            Fun.diffuserMusique();


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------");
            Console.ForegroundColor = ConsoleColor.Gray;

            poste1.reglerStation("fun");
            poste2.reglerStation("nrj");
            poste3.reglerStation("fun");

            Nrj.diffuserMusique();
            Fun.diffuserMusique();
        }


        public static class Dispatching
        {
            public static Frequence _1066;
            public static Frequence _1031;
            private delegate Frequence inK(Frequence f);
            private static inK inkD;
            private static inK inkA;
            private static inK inkMCA;

            public static void abonnement(posteRadio poste, string station)
            {
                inkD = x => x -= poste.ecouterMusique;
                inkA = x => x = new Frequence(poste.ecouterMusique);
                inkMCA = x => x += poste.ecouterMusique;

                if (Dispatching._1066 != null)
                {
                    foreach (Frequence f in Dispatching._1066.GetInvocationList())
                    {
                        if (f == poste.ecouterMusique)
                        {
                            _1066 = inkD(_1066);
                        }
                    }
                }

                if (Dispatching._1031 != null)
                {
                    foreach (Frequence f in Dispatching._1031.GetInvocationList())
                    {
                        if (f == poste.ecouterMusique)
                        {
                            _1031 = inkD(_1031);
                        }
                    }
                }

                if (station == "nrj")
                {
                    if (Dispatching._1066 == null)
                    {
                        _1066 = inkA(_1066);
                    }
                    else
                    {
                        _1066 = inkMCA(_1066);
                    }
                }
                else if (station == "fun")
                {
                    if (Dispatching._1031 == null)
                    {
                        _1031 = inkA(_1031);
                    }
                    else
                    {
                        _1031 = inkMCA(_1031);
                    }
                }
            }
        }


        public class posteRadio
        {
            public void ecouterMusique(string musique)
            {
                Console.WriteLine("J'écoute de la musique {0}: ", musique);
            }

            public void reglerStation(string station)
            {
                Dispatching.abonnement(this, station);
            }
        }


        public class Radio
        {
            private string musique;
            private string radio;
            private delegate void inK(Frequence f);
            private inK ink;

            public Radio(string radio, string musique)
            {
                this.radio = radio;
                this.musique = musique;
                this.ink = x => x.Invoke(this.musique);
            }

            public void diffuserMusique()
            {
                Console.WriteLine("{0} diffuse de la musique ", this.radio);
                if (this.radio == "nrj")
                {
                    if (Dispatching._1066 != null)
                        ink(Dispatching._1066);
                }
                else if (this.radio == "fun")
                {
                    if (Dispatching._1031 != null)
                        ink(Dispatching._1031);
                }
            }
        }
    }
}
