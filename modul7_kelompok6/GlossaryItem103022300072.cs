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
    class GlossaryItem103022300072
    {
        public class GlossaryWrapper
        {
            public Glossary glossary { get; set; }
        }

        public class Glossary
        {
            public string title { get; set; }
            public GlossDiv GlossDiv { get; set; }
        }
        public class GlossDiv
        {
            public string title { get; set; }
            public GlossList GlossList { get; set; }
        }

        public class GlossList
        {
            public GlossEntry GlossEntry { get; set; }
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

        public class GlossDef
        {
            public string para { get; set; }
            public List<string> GlossSeeAlso { get; set; }
        }

        public static void ReadJSON()
        {
            string filePath = "jurnal7_3_103022300072.json";
            string jsonString = File.ReadAllText(filePath);

            var data = JsonSerializer.Deserialize<GlossaryWrapper>(jsonString);
            var entry = data.glossary.GlossDiv.GlossList.GlossEntry;

            Console.WriteLine("Glosary Entry: ");
            Console.WriteLine("ID: " + entry.ID);
            Console.WriteLine("Sort As: " + entry.SortAs);
            Console.WriteLine("Term: " + entry.GlossTerm);
            Console.WriteLine("Acronym: " + entry.Acronym);
            Console.WriteLine("Abbrevation: " + entry.Abbrev);
            Console.WriteLine("Definition: " + entry.GlossDef.para);
            Console.WriteLine("See Also: " + string.Join(", ", entry.GlossDef.GlossSeeAlso));
            Console.WriteLine("See: " + entry.GlossSee);
        }
    }
}
