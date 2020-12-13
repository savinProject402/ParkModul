using System;
using ParkModul.Enums;

namespace ParkModul.Model.TreesOf
{
    public class EvergreenPine : TreesOf
    {
        public EvergreenPine(int age, int height)
        : base(age, height)
        { }
        public override ViewTree TypeViewTree => ViewTree.Evergreen;
        public override int Count => 2;
        public override string Name => "Pine";
    }
}
