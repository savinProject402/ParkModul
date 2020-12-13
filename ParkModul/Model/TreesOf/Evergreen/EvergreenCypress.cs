namespace ParkModul.Model.TreesOf
{
    using ParkModul.Enums;
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
