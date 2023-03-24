
﻿internal class Program
{
    private static void Main(string[] args)
    {
        Penjumlahan<Double> penjumlahan = new Penjumlahan<double>();
        penjumlahan.jumlahTigaAngka(13, 02, 21);
        SimpleDataBase<Double> data = new SimpleDataBase<Double>();
        data.addNewData(13);
        data.addNewData(02);
        data.addNewData(21);
        data.addNewData(00);
        data.printAllData();
    }
}

class Penjumlahan<T>
{

    public void jumlahTigaAngka(T a, T b, T c)
    {
        dynamic aa = a;
        dynamic bb = b;
        dynamic cc = c;
        Console.WriteLine(aa + bb + cc);
    }
}
class SimpleDataBase<T>
{
    List<T> storedData { get; set; }
    List<DateTime> inputDates { get; set; }
    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }
    public void addNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }
    public void printAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i + 1) + " berisi: " + storedData.ElementAt(i) + " yang disimpan pada waktu " + inputDates.ElementAt(i));
        }
    }
}