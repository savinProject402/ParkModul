using System;
using ParkModul.Model.Reserv;
using ParkModul.Abstractions;
using ParkModul.Entities;
using ParkModul.Model.TreesOf.Deciduous;
using ParkModul.Model.TreesOf;


namespace ParkModul.Services
{
    public class ParkService : IParkService
    {
        public ParkService()
        { }
        public Parker MaceParcer()
        {
            var treesOff = new TreesOf[]
            {
                new EvergreenCypress(50,3),
                new EvergreenPine(43,4),
                new DeciduousBirch(12,2),
                new DeciduousChestnut(80,5),
            };
            var count = 0d;
            for (int i = 0; i < treesOff.Length; i++)
            {
                count += treesOff[i].Count;
            }
            return new Parker {TreesOfs = treesOff, Count = count};
        }
    }
}
