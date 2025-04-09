using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Net.Sockets;

namespace modul7_kelompok6
{
    class DataMahasiswa103022300072
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<Course> courses { get; set; }
        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }
        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public static void ReadJSON()
        {
            string filePath = "jurnal7_1_103022300072.json";
            string jsonString = File.ReadAllText(filePath);

            var data = JsonSerializer.Deserialize<DataMahasiswa103022300072>(jsonString);

            Console.WriteLine("========================= DATA MAHASISWA ========================= ");
            Console.WriteLine("Nama: " + data.firstName + " " + data.lastName);
            Console.WriteLine("Gender: " + data.gender);
            Console.WriteLine("Umur: " + data.age);
            Console.WriteLine("Alamat: " + data.address.streetAddress + ", " + data.address.city + ", " + data.address.state);
            Console.WriteLine("");

            Console.WriteLine("Daftar Mata Kuliah: ");
            foreach (var course in data.courses)
            {
                Console.WriteLine("Kode: " + course.code + ", Nama: " + course.name);
            }
        }
    }
}
