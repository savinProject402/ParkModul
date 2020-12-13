namespace ParkModul.Model.TreesOf.Broadleaf
{
    using ParkModul.Enums;
    public class BroadLeafOak : TreesOf
    {
        public BroadLeafOak(int age, int height)
        : base(age, height)
        { }
        public override ViewTree TypeViewTree => ViewTree.Broadleaf;
        public override int Count => 1;
        public override string Name => "Oak";
    }
}
