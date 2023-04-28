using Newtonsoft.Json;

namespace File
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
           

            
            var names = new List<string>();
            names.Add("Yasin");
            names.Add("Hakim");
            names.Add("Sahin");


            Add("Murad");
           
            

            
            Console.WriteLine(Search("Yasin")); 
            Console.WriteLine(Search("Hakim"));

            


        }
        static void Add(string name)
        {
            string str;
            using (StreamReader r = new StreamReader(@"C:\\Users\\Asus\\Documents\\C#AB103\\File\\File\\jsconfig1.json", true))
            {
                str = r.ReadToEnd();
                
            }
        }

        static bool Search(string name)
        {
            string json;
            using (StreamReader r = new StreamReader(@"C:\\Users\\Asus\\Documents\\C#AB103\\File\\File\\jsconfig1.json", true))
            {
                json = r.ReadToEnd();
                
            }
            List<string> str = JsonConvert.DeserializeObject<List<string>>(json);
             str.Find(x => x == name);
             return str != null;
        }

        static void Delete(int index)
        {
            string json;
            using (StreamWriter w = new StreamWriter(@"C:\\Users\\Asus\\Documents\\C#AB103\\File\\File\\jsconfig1.json", true))
            {
                json = JsonConvert.SerializeObject(index);
                w.Write(json);
            }
            List<string> strings = new List<string>();
            strings.Remove(strings.Find(x=>x==json));

        }

       
        
    }
}