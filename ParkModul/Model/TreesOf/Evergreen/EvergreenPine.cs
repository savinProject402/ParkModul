namespace ParkModul.Model.TreesOf
{
    using System;
    using ParkModul.Enums;
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
