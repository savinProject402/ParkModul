using System;
using ParkModul.Abstractions;
using ParkModul.Services;
using ParkModul.Helpers.Comparers;
namespace ParkModul
{
   public class Starter
    {
        private readonly IParkService parkService;
        public Starter()
        {
            this.parkService = new ParkService();
        }
        public void Run()
        {
            var park = this.parkService.MaceParcer();
            Array.Sort(park.TreesOfs, new TreesComparer());
            for (int i = 0; i < park.TreesOfs.Length; i++)
            {
                Console.WriteLine($"Name: {park.TreesOfs[i].Name} Age: {park.TreesOfs[i].Age}"  +
                    $" Height: {park.TreesOfs[i].Height}M  Count: {park.TreesOfs[i].Count} Type: {park.TreesOfs[i].TypeViewTree}");
            }
            Console.WriteLine($"Count Trees of Park: {park.Count}");
            
        }
    }
}
