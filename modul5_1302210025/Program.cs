using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        SimpleDataBase<Double> data = new SimpleDataBase<Double>();
        data.addNewData(13);
        data.addNewData(02);
        data.addNewData(21);
        data.addNewData(00);
        data.printAllData();
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
        for(int i=0;i<storedData.Count;i++)
        {
            Console.WriteLine("Data " + (i + 1) + " berisi: " + storedData.ElementAt(i) + " yang disimpan pada waktu " + inputDates.ElementAt(i));
        } 
    }

}