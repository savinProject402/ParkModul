using System;
using ParkModul.Enums;

namespace ParkModul.Model.TreesOf.Conifers
{
    public class ConifersThuja : TreesOf
    {
        public ConifersThuja(int age, int height)
        : base(age, height)
        { }
        public override ViewTree TypeViewTree => ViewTree.Conifers;
        public override int Count => 1;
        public override string Name => "Thuja";
    }
}
