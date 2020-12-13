namespace ParkModul.Model.TreesOf.Deciduous
{
    using ParkModul.Enums;
    class DeciduousPoplar : TreesOf
    {
        public DeciduousPoplar(int age, int height)
        : base(age, height)
        { }
        public override ViewTree TypeViewTree => ViewTree.Deciduous;
        public override int Count => 3;
        public override string Name => "Poplar";
    }
}
