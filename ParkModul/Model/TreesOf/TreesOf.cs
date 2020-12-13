namespace ParkModul.Model.TreesOf
{
    using ParkModul.Enums;
    using ParkModul.Model.Reserv;
    public abstract class TreesOf : Tress
    {
        protected TreesOf(int age,int height)
            :base(age, height)
        { }
        public abstract ViewTree TypeViewTree { get; }
    }
}
