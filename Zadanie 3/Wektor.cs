

public class Wektor{
    private double[] współrzędne;

    public Wektor(byte wymiar){
        współrzędne = new double[wymiar];
    }

    public Wektor(params double[] współrzędne){
        this.współrzędne = współrzędne;
    }

    public double this[byte indeks]{
        get { return współrzędne[indeks]; }
        set { współrzędne[indeks] = value; }
    }

    public double Długość{
        get { return Math.Sqrt(IloczynSkalarny(this, this)); }
    }

    public byte Wymiar{
        get { return (byte)współrzędne.Length; }
    }

    public static Wektor Suma(params Wektor[] wektory){
        if (wektory.Length == 0)
            throw new ArgumentException("Nie podano żadnego wektora.");

        byte wymiar = wektory[0].Wymiar;
        for (int i = 1; i < wektory.Length; i++){
            if (wektory[i].Wymiar != wymiar)
                throw new ArgumentException("Wektory muszą mieć ten sam wymiar.");
        }

        Wektor wynik = new Wektor(wymiar);
        for (byte i = 0; i < wymiar; i++){
            double suma = 0;
            for (int j = 0; j < wektory.Length; j++){
                suma += wektory[j][i];
            }
            wynik[i] = suma;
        }
        return wynik;
    }

    public static Wektor operator +(Wektor v1, Wektor v2){
        if (v1.Wymiar != v2.Wymiar)
            throw new ArgumentException("Wektory muszą mieć ten sam wymiar.");

        Wektor wynik = new Wektor(v1.Wymiar);
        for (byte i = 0; i < v1.Wymiar; i++){
            wynik[i] = v1[i] + v2[i];
        }
        return wynik;
    }

    public static Wektor operator -(Wektor v1, Wektor v2){
        if (v1.Wymiar != v2.Wymiar)
            throw new ArgumentException("Wektory muszą mieć ten sam wymiar.");

        Wektor wynik = new Wektor(v1.Wymiar);
        for (byte i = 0; i < v1.Wymiar; i++){
            wynik[i] = v1[i] - v2[i];
        }
        return wynik;
    }

    public static Wektor operator *(Wektor v, double skalar){
        Wektor wynik = new Wektor(v.Wymiar);
        for (byte i = 0; i < v.Wymiar; i++){
            wynik[i] = v[i] * skalar;
        }
        return wynik;
    }

    public static Wektor operator /(Wektor v, double skalar){
        if (skalar == 0)
            throw new ArgumentException("Dzielenie przez zero.");

        Wektor wynik = new Wektor(v.Wymiar);
        for (byte i = 0; i < v.Wymiar; i++){
            wynik[i] = v[i] / skalar;
        }
        return wynik;
    }

    public static double IloczynSkalarny(Wektor v1, Wektor v2){
        if (v1.Wymiar != v2.Wymiar)
            throw new ArgumentException("Wektory muszą mieć ten sam wymiar.");

        double suma = 0;
        for (byte i = 0; i < v1.Wymiar; i++){
            suma += v1[i] * v2[i];
        }
        return suma;
    }

    public override string ToString(){
        string separator = " | ";
        string result = string.Join(separator, współrzędne);
        return $"({result})";
    }

}