using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok6
{

    class GlossaryItem103022300014
    {
        public class GlossDef
        {
            public string para { get; set; }
            public List<string> GlossSeeAlso { get; set;}
        }
        public class GlossEntry
        {
            public string ID { get; set; }
            public string SortAs { get; set; }
            public string GlossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev { get; set; }
            public GlossDef GlossDef { get; set; }
            public string GlossSee { get; set; }
        }
        public static void ReadJSON()
        {
            //path file json
            string filePath = "jurnal7_3_103022300014.json";

            //baca isi file
            string jsonString = File.ReadAllText(filePath);

            //deserialisasi ke object mahasiswa
            GlossEntry data = JsonSerializer.Deserialize<GlossEntry>(jsonString);

            //cetak format
            Console.WriteLine("Glossary Item GlossEntry:");
            Console.WriteLine($"ID: {data.ID} \nSortAs: {data.SortAs} \nGlossTerm: {data.GlossTerm}" +
                $"Acronym: {data.Acronym} \nAbbrev: {data.Abbrev} \nGlossDef: {data.GlossDef.para}, {data.GlossDef.GlossSeeAlso} \nGlossSee {data.GlossSee}");
        }
    }
}
