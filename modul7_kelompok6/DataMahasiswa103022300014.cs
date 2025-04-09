using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok6
{
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }
    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
    public class Mahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public long age { get; set; }
        public Address address { get; set; }
        public List<Course> courses { get; set; }
    }
    class DataMahasiswa103022300014
    {
        public static void ReadJSON()
        {
            //path file json
            string filePath = "jurnal7_1_103022300014.json";

            //baca isi file
            string jsonString = File.ReadAllText(filePath);

            //deserialisasi ke object mahasiswa
            Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

            //cetak format
            Console.WriteLine($"Nama {data.firstName} {data.lastName} merupakan {data.gender}" +
                $" berumur {data.age} yang tinggal di {data.address.streetAddress}, {data.address.city}");
            Console.WriteLine("\nDaftar mata kuliah yang diambil:");
            foreach (var course in data.courses)
            {
                Console.WriteLine($"MK {course.code} - {course.name}");
            }
        }
    }
}
