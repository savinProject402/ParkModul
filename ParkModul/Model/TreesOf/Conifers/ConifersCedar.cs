namespace ParkModul.Model.TreesOf.Conifers
{
    using ParkModul.Enums;
    public class ConifersCedar : TreesOf
    {
        public ConifersCedar(int age, int height)
        : base(age, height)
        { }
        public override ViewTree TypeViewTree => ViewTree.Conifers;
        public override int Count => 1;
        public override string Name => "Cedar";
    }
}
