using System;
using ParkModul.Enums;

namespace ParkModul.Model.TreesOf.Broadleaf
{
    public class BroadLeafAsh : TreesOf
    {
        public BroadLeafAsh(int age, int height)
        : base(age, height)
        { }
        public override ViewTree TypeViewTree => ViewTree.Broadleaf;
        public override int Count => 1;
        public override string Name => "Ash";
    }
}
