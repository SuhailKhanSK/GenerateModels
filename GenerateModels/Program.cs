using GenerateModels.Models;
using Newtonsoft.Json;

namespace GenerateModels
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var data = JsonConvert.DeserializeObject<Well>(File.ReadAllText("C:\\Users\\Suhail.Khan\\OneDrive - V Software Consulting inc\\Desktop\\Files\\Wells\\Well2.json"));

            //try
            //{

            //    using (Mx4220Context context = new Mx4220Context())
            //    {
            //        //Well well = context.Wells.Where(id => id.Id == data.Id).FirstOrDefault();
            //        //if(well != null)
            //        //{
            //        //    context.Remove(well);
            //        //    int rowsaff = context.SaveChanges();
            //        //}
            //        context.Add(data);
            //        int rows = context.SaveChanges();
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            //List<string> guids =  JsonConvert.DeserializeObject<List<string>>(File.ReadAllText(@"C:\Users\Suhail.Khan\Downloads\OldGetWellIds.json"));

            //for (int i = 0; i < guids.Count; i++)
            //{
            //    for (int j = 0; j < guids.Count; j++)
            //    {
            //        if (guids[i].Equals(guids[j+1]))
            //        {
            //            Console.WriteLine($"Found equal guid : {guids[i]}");
            //        }
            //    }
            //}
            var well = new Solution();
            var props = well.GetType().GetProperties();

            foreach (var prop in props)
            {
                Console.WriteLine($".SetProperty(x => x.{prop.Name}, x => existingValue.{prop.Name})");
            }


            Console.WriteLine("Hello, World!");

        }
    }
}