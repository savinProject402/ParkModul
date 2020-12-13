using System;
using ParkModul.Enums;
using ParkModul.Model.Reserv;

namespace ParkModul.Model.TreesOf
{
    public abstract class TreesOf : Tress
    {
        protected TreesOf(int age,int height)
            :base(age, height)
        { }
        public abstract ViewTree TypeViewTree { get; }
    }
}
