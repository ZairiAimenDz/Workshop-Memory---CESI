
namespace WorkshopMemory.Ex05
{
    public class MySolution5
    {
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
            Console.WriteLine("Hello, World!");
        }
    }

    public delegate void Broadcast(string message);


    internal static class PointDeControle{
        public static Broadcast nrj;
        public static Broadcast fun;
    }

    internal class posteRadio
    {
        internal void reglerStation(string v)
        {

            if (PointDeControle.nrj != null)
            {
                PointDeControle.nrj -= this.Affiche;
            }
            if(PointDeControle.fun != null)
            {
                PointDeControle.fun -= this.Affiche;
            }

            if(v == "nrj")
            {
                PointDeControle.nrj += this.Affiche;
            }
            else
            {
                PointDeControle.fun += this.Affiche;
            }
        }

        void Affiche(string m)
        {
            Console.WriteLine(m);
        }
    }

    internal class Radio
    {
        public Radio(string v1, string v2)
        {
            V1 = v1;
            V2 = v2;
        }

        public string V1 { get; }
        public string V2 { get; }

        internal void diffuserMusique()
        {
            Console.WriteLine("Diffuse" + V1);
            if(V1 == "nrj")
            {
                PointDeControle.nrj(V2);
            }
            else {
                PointDeControle.fun(V2);
            }
        }
    }
}
