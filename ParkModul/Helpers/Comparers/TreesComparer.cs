namespace ParkModul.Helpers.Comparers
{
    using ParkModul.Model.Reserv;
    using System.Collections;
    public class TreesComparer : IComparer
    {
        public int Compare(object first, object second)
        {
            var x = first as Tress;
            var y = second as Tress;
            if (x.Name.Length > y.Name.Length)
            {
                return 1;
            }
            else if (x.Name.Length < y.Name.Length)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
