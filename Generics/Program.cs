
// Bazen tasarlanılan metot class parametreleri(değişkenler) belirli bir tip olarak değil de bir şablon yapısı dahilinde çalışmayı sağlayan bir yapı
internal class Program
{
    private static void Main(string[] args)
    {
        // Generic yöntemini kullanarak..

        // Generic olarak tanımladığım class ı int olarak nesnelendiriyorum.
        Example<int> example = new Example<int>(); // Generic yapıda tanımlanmış bir classın integer olarak kullanılabilmesi...
        example.example = 20;
        example.example_2(200);

        // string olarak tanımlıyorum
        Example<string> example_2 = new Example<string>();

        example_2.example = "Nesibe K";
        example_2.example_2("C#");

        // Burada da double olarak ayarlıyorum
        Example<double> example_3 = new Example<double>();

        example_3.example = 100.5;
        example_3.example_2(151.25);

        Console.ReadKey();
        

    }
    //Normal olarak...
    public class Example
    {
        public int example;
        public void example_2(int parameter)
        {
            
        }
    }

    // Generic denilen yapıyı kullandığımızda değişkenler,parametreler ve metodların geri dönüş tipleri gibi durumları o sınıftan bir nesne oluştururken belirlenebilmesi

    public class Example<T> // T: Type
    { 
        public T example; // Sadece bir değişken
        public void example_2(T parameter) // Bir şeyler yapan bir metod
        {
            Console.WriteLine("Parametre değeri: " + parameter + "\n");
        }
    } 
}