namespace ParkModul.Model.Reserv
{
    using System;
    using ParkModul.Enums;
    public interface IProduct
    {
        string Name { get; }
        int Age { get; }
        //int View { get; } // Тип
        int Height { get; } // Высота
        //int Count { get; }
    }
}
