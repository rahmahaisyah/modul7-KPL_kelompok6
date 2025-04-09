
namespace modul7_kelompok6
{

    class DataMahasiswa103022300153
    {
        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }

        }

        public class Courses
        {
            public string code { get; set; }
            public string name { get; set; }

        }
        public class Mahasiswa
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int  age { get; set; }
            public Address address { get; set; }
            public Courses courses { get; set; }

        }

        public static void ReadJSON()
        {
            string filePath = "jurnal7_1_103022300153.json";
            string jsonContent = File.ReadAllText(filePath);
            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonContent);
            Console.WriteLine("Nama depan: " + mhs.firstName + ", Nama belakang: " + mhs.lastName + ", Gender: " + mhs.gender + ", Age: " + mhs.age + ", Alamat: " + mhs.address + ", Course: " + mhs.courses);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
