using System;
using ParkModul.Enums;

namespace ParkModul.Model.TreesOf.Deciduous
{
    public class DeciduousChestnut : TreesOf
    {
        public DeciduousChestnut(int age, int height)
        : base(age, height)
        { }
        public override ViewTree TypeViewTree => ViewTree.Deciduous;
        public override int Count => 3;
        public override string Name => "Chestnut";
    }
}
