using System;
using ParkModul.Enums;

namespace ParkModul.Model.TreesOf.Conifers
{
    public class ConifersSpruce : TreesOf
    {
        public ConifersSpruce(int age, int height)
        : base(age, height)
        { }
        public override ViewTree TypeViewTree => ViewTree.Conifers;
        public override int Count => 1;
        public override string Name => "Spruce";
    }
}
