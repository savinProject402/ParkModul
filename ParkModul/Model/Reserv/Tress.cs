using System;
using ParkModul.Enums;

namespace ParkModul.Model.Reserv
{
    public abstract class Tress : IProduct
    {
        private readonly int age;
        private readonly int height;
        //private readonly int count;

        protected Tress (int age, int height) //, int count)
        {
            this.age = age;
            this.height = height;
            //this.count = count;
        }
        public abstract string Name { get; }
        public int Age => this.age;
        public int Height => this.height;
        //public int Count => this.count;
        public abstract int Count { get; }
//        public abstract int TypeOfTrees { get; }

    }
}
