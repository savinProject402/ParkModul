namespace ParkModul.Helpers.Extentions
{
    using ParkModul.Model.TreesOf;
    using ParkModul.Enums;
    public static class Extentions
    {
        public static TreesOf Find(this TreesOf[] arrey, ViewTree view)
        {
            TreesOf toReturn = null;
            foreach (TreesOf item in arrey)
            {
                if (item.TypeViewTree == view)
                {
                    toReturn = item;
                    break;
                }
            }
            return toReturn;
        }
        public static TreesOf Find(this TreesOf[] arrey, ViewTree view, string name)
        {
            TreesOf toReturn = null;
            foreach (TreesOf item in arrey)
            {
                if (item.TypeViewTree == view && item.Name == name)
                {
                    toReturn = item;
                    break;
                }
            }
            return toReturn;
        }
    }
}
