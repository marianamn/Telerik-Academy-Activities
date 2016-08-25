namespace _01.BooleanToStingConverter
{
    using System;

    public class BooleanToSting
    {
        public static void CreateConverter(bool input)
        {
            var converter = new Converter();
            converter.ConvertBooleanToString(input);
        }

        private class Converter
        {
            public void ConvertBooleanToString(bool inputedBoolVaraiable)
            {
                string booleanAsString = inputedBoolVaraiable.ToString();
                Console.WriteLine(booleanAsString);
            }
        }
    }
}
