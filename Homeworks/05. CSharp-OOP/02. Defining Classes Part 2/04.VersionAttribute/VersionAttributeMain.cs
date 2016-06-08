namespace _04.VersionAttribute
{
    using System;

    [Version("v. 2.11")]
    public class VersionAttributeMain
    {
        public static void Main()
        {
            Type type = typeof(VersionAttributeMain);

            object[] attributes = type.GetCustomAttributes(false);

            foreach (Version item in attributes)
            {
                Console.WriteLine(item.Vers);
            }
        }
    }
}
