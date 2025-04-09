using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using static modul7_kelompok6.DataMahasiswa103022300153;

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

    class TeamMembers103022300153
    {
        internal class Members
        {
            public List<Members> Team { get; set; }
            public Members() { }
            public Members(List<Members> members)
            { 
                this.members = members;
            }

            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }
        }

        internal class Team
        {
            public List<Members> Team { get; set; }
        }

        internal static void ReadJSON()
        {
            string filePath = "tp7_2_103022300153.json";
            string jsonContent = File.ReadAllText(filePath);
            Team data = JsonSerializer.Deserialize<Team>(jsonContent);

            Console.WriteLine("Daftar member team:");
            for (int i = 0; i <= Team.Members.Count; i++)
            {
                Console.WriteLine("Member " + i + " : Nama depan: " + t.firstName + ", Nama belakang: " + t.lastName + ", Gender: " + t.gender + ", Age: " + t.age + ", NIM: " + t.nim);
                i++;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa103022300153.ReadJSON();
            Console.WriteLine();
            TeamMembers103022300153.ReadJSON();
        }
    }
}
