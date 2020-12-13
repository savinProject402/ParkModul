using System;
using ParkModul.Enums;

namespace ParkModul.Model.TreesOf
{
    public class EvergreenCypress : TreesOf
    {
        public EvergreenCypress(int age, int height)
            : base(age, height)
        { }
        public override ViewTree TypeViewTree => ViewTree.Evergreen;
        public override int Count => 3;
        public override string Name => "Cypress";
    }
}
