namespace Program
{
    internal class Obliczenia{
        public static void Main(string[] args){
            try{
                Wektor v1 = new Wektor(7, 3, 1);
                Wektor v2 = new Wektor(8, 4, 5);

                double iloczynSkalarny = Wektor.IloczynSkalarny(v1, v2);
                Console.WriteLine("Iloczyn skalarny: " + iloczynSkalarny);

                Wektor suma = Wektor.Suma(v1, v2);
                Console.WriteLine("Suma: " + suma);

                Wektor roznica = v1 - v2;
                Console.WriteLine("Różnica: " + roznica);

                Wektor iloczyn1 = v1 * 2.5;
                Console.WriteLine("Iloczyn 1: " + iloczyn1);

                Wektor iloraz = v1 / 2;
                Console.WriteLine("Iloraz: " + iloraz);
            }
            catch (Exception ex){
                Console.WriteLine("Wystąpił błąd: " + ex.Message);
            }
        }
    }
}