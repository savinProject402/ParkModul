namespace ParkModul.Services
{
    using ParkModul.Abstractions;
    using ParkModul.Entities;
    using ParkModul.Model.TreesOf.Deciduous;
    using ParkModul.Model.TreesOf;
    using ParkModul.Model.TreesOf.Broadleaf;
    using ParkModul.Model.TreesOf.Conifers;
    public class ParkService : IParkService
    {
        public ParkService()
        { }
        public Parker MaceParcer()
        {
            var treesOff = new TreesOf[]
            {
                new EvergreenCypress(50,3),
                new EvergreenCypress(20,2),
                new EvergreenPine(43,4),
                new EvergreenPine(70,6),
                new DeciduousBirch(12,2),
                new DeciduousBirch(22,3),
                new DeciduousChestnut(80,5),
                new DeciduousChestnut(20,2),
                new DeciduousPoplar(78,7),
                new DeciduousPoplar(40,4),
                new BroadLeafAsh(34,4),
                new BroadLeafAsh(5,1),
                new BroadLeafLinden(15,2),
                new BroadLeafLinden(90,5),
                new BroadLeafOak(10,1),
                new BroadLeafOak(500, 6),
                new ConifersCedar(14,6),
                new ConifersCedar(67,10),
                new ConifersSpruce(2,1),
                new ConifersSpruce(15,3),
                new ConifersThuja(10,6),
                new ConifersThuja(80,15),
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
