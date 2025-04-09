using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace modul7_kelompok6
{
    class DataMahasiswa103022300065
    {
        public class Personal
        {
            public string firstname { get; set; } = string.Empty;
            public string lastname { get; set; } = string.Empty;
            public string gender { get; set; } = string.Empty;
            public int age { get; set; }
            public string address { get; set; } = string.Empty;
        }

        public class Course
        {
            public string Code { get; set; } = string.Empty;
            public string Name { get; set; } = string.Empty;
        }

        public class CourseList
        {
            public List<Course> Courses { get; set; } = new List<Course>();
        }

        public static void ReadJSON()
        {
            string filePath = "jurnal7_1_103022300065.json";

            try
            {
                string jsonContent = File.ReadAllText(filePath);

                // Deserialisasi data Personal
                Personal? prs = JsonSerializer.Deserialize<Personal>(jsonContent);

                if (prs != null)
                {
                    Console.WriteLine($"Nama: {prs.firstname} {prs.lastname}, Jenis Kelamin: {prs.gender}, Umur: {prs.age}, Alamat: {prs.address}");
                }

                // Deserialisasi daftar mata kuliah
                CourseList? courseList = JsonSerializer.Deserialize<CourseList>(jsonContent);

                if (courseList != null && courseList.Courses.Count > 0)
                {
                    Console.WriteLine("\nDaftar Mata Kuliah:");
                    foreach (var course in courseList.Courses)
                    {
                        Console.WriteLine($"Kode: {course.Code}, Nama: {course.Name}");
                    }
                }
                else
                {
                    Console.WriteLine("\nData mata kuliah kosong atau format JSON salah.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal membaca file JSON: " + e.Message);
            }
        }
    }
}
