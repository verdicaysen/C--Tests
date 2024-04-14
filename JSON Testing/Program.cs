using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;
using CsvHelper;    
using Microsoft.VisualBasic;

//So this code creates and grabs JSON into memory, deserializes it, then interprets and puts it back into a CSV file in properly organized columns of data. 
namespace JSON_Testing;

    class Program
    {
        static void Main(string[] args)
        {
            string json = @"{
    ""Name"": ""Russ"",
    ""Channel"": ""Code Time"",
    ""Active"": true,
    ""Age"": 3,
    ""Members"": [
        ""Richard"",
        ""Tim"",
        ""Victor"",
        ""Chandra"",
        ""Andres"",
        ""Nicholas"",
        ""Jessica""
    ]
}";
               ClassData obj = JsonSerializer.Deserialize<ClassData>(json);

            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Channel);
            Console.WriteLine(obj.Active);
            Console.WriteLine(obj.Age);
            Console.WriteLine(string.Join(",", obj.Members));
     

            var csvPath =Path.Combine(Environment.CurrentDirectory, $"classes.csv");
            using (var streamWriter = new StreamWriter(csvPath))
            {
                //CSV Header.
                streamWriter.WriteLine("Name,Channel,Active,Age,Members");

                // Write the data.
                streamWriter.Write($"{obj.Name},{obj.Channel},{obj.Active},{obj.Age},");
                streamWriter.WriteLine(); // Move on to the next line.

                // Write Members under the "Members" column. This is going to skip a cell.
                foreach (var member in obj.Members)
                {
                    streamWriter.WriteLine($",,,,{member}");
                }
            }
        }
                  public class ClassData
            {
                public string? Name { get; set; }
                public string? Channel { get; set; }
                public bool? Active { get; set; }
                public int? Age { get; set; }

                [JsonPropertyName("Members")]
                public List<string>? Members { get; set; }
            }
            
         
    }
     
           
        
        
    




