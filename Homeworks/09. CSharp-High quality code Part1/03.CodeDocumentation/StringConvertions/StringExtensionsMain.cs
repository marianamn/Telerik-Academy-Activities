// <copyright file="StringExtensionsMain.cs" company="company">
// Copyright (c) company. All rights reserved.
// </copyright>
using System;

namespace StringConvertions
{
    /// <summary>
    /// Startup point of the program.
    /// </summary>
    public class StringExtensionsMain
    {
        /// <summary>
        /// Main method executes all string extensions
        /// </summary>
        public static void Main()
        {
            string inputString = "minions2015филм.docx";
            Console.WriteLine(StringExtensions.CapitalizeFirstLetter(inputString));
            Console.WriteLine(StringExtensions.ConvertCyrillicToLatinLetters(inputString));
            Console.WriteLine(StringExtensions.GetFileExtension(inputString));
            Console.WriteLine(StringExtensions.GetFirstCharacters(inputString, 2));
            Console.WriteLine(StringExtensions.ToContentType(inputString));
        }
    }
}
