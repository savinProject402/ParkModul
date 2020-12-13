namespace ParkModul.Model.Reserv
{
    using ParkModul.Enums;
    public abstract class Park : Tress
    {
        protected Park (int age, int height)
            : base(age, height)
        { }
        public abstract bool IsProlific { get; } // приносит ли плоды
        public abstract TreeElements[] Elements { get; }
    }
}
