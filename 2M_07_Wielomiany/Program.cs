namespace _2M_07_Wielomiany
{
    class Wielomian
    {
        private int n;
        private double[] wspolczynniki;
        //private double[] w1 = new double[16];
        //private double[] w2 = { 1, 3, 55, -11, 3.14 };
        private bool czyWielomian = true;
        public Wielomian(int poziom = 1)
        {
            this.n = poziom;
            if (n > 0)
            {
                wspolczynniki = new double[n+1];
                wczytajWspolczynniki();
            }
                
            else
            {
                czyWielomian = false;
            }
        }
        private void wczytajWspolczynniki()
        {
            for(int i = n; i >=0 ; i--)
            {
                Console.Write($"współczynnik {i}: ");
                wspolczynniki[i] = double.Parse( Console.ReadLine() );
            }
        }
        private string wypiszWielomian()
        {
            string s = "";
            for (int i = n; i >= 0; i--)
                s += wspolczynniki[i].ToString() + "; ";
            return s;
        }
        public override string ToString()
        {
            if (czyWielomian)
                return $"wielomian stopnia {n}; "+ wypiszWielomian();
            else
                return "nie jest ok";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Wielomian w1 = new Wielomian(4);
            Console.WriteLine(w1);
        }
    }
}