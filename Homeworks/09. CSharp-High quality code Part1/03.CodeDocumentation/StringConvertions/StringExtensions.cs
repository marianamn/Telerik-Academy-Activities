// <copyright file="StringExtensions.cs" company="company">
// Copyright (c) company. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace StringConvertions
{
    /// <summary>
    /// Execute series of methods, working with string input.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Converts input string to bytes array, compute the hash and each byte of the hashed data 
        /// is presented as hexadecimal string.
        /// </summary>
        /// <param name="input">Takes string parameter.</param>
        /// <returns>Returns a hexadecimal string.</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            return builder.ToString();
        }

        /// <summary>
        /// Check if a string contains true-like statements value: "true", "ok", "yes", "1", "да"
        /// </summary>
        /// <param name="input">Takes String parameter.</param>
        /// <returns>Returns True/False if input collection contains true-like statements.</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Converts input string to 16-bit sight integer number.
        /// </summary>
        /// <param name="input">Takes String parameter.</param>
        /// <returns>If the input string can be converted to shortValue, returns integer, otherwise returns null.</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Converts input string to integer number.
        /// </summary>
        /// <param name="input">Takes String parameter.</param>
        /// <returns>If the input string can be converted to integer, returns integer, otherwise returns null.</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Converts input string to long integer number.
        /// </summary>
        /// <param name="input">Takes String parameter.</param>
        /// <returns>Returns long value</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        ///  Converts input string to DateTime.
        /// </summary>
        /// <param name="input">Takes String parameter.</param>
        /// <returns>Returns DateTime</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// The CapitalizeFirstLetter() method takes non empty input string sequence 
        /// and capitalize first letter of the string
        /// </summary>
        /// <param name="input">Takes String parameter.</param>
        /// <returns>Returns input string with first letter capitalized if the string is not null or empty, otherwise returns the input itself.</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// The GetStringBetween() method takes input string and returns string between 
        /// parsed start and end strings.
        /// </summary>
        /// <param name="input">Takes String parameter.</param>
        /// <param name="startString">Start string takes String parameter.</param>
        /// <param name="endString">End string takes String parameter.</param>
        /// <param name="startFrom">Takes Integer parameter for starting substring position.</param>
        /// <returns>Returns substring from input string between parsed start and end strings.</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// The ConvertCyrillicToLatinLetters() method takes cyrillic string sequence and transliterate it to latin one.
        /// </summary>
        /// <param name="input">Takes String parameter.</param>
        /// <returns>Returns transliterated cyrillic string to the latin one.</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// The ConvertLatinToCyrillicKeyboard() method takes latin string sequence and transliterate it to cyrillic one.
        /// </summary>
        /// <param name="input">Takes String parameter.</param>
        /// <returns>Returns converted  latin string to cyrillic one.</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// The ToValidUsername() method takes string, converts it to latin (if it is in cyrillic) 
        /// and then check whether given user name consists of letters and numbers.
        /// </summary>
        /// <param name="input">Takes String parameter.</param>
        /// <returns>Returns the string if it is valid user name.</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// The ToValidLatinFileName() method takes string, converts it to latin (if it is in cyrillic) 
        /// and then check whether given file name consists of letters and numbers.
        /// </summary>
        /// <param name="input">Takes String parameter.</param>
        /// <returns>Returns the string if it is valid file name.</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// The GetFirstCharacters() method takes string sequence and returns string substring
        /// starting from the beginning of the sequence with length - parsed integer number.
        /// </summary>
        /// <param name="input">Takes String parameter.</param>
        /// <param name="charsCount">Integer number showing how many characters from the beginning to be shown</param>
        /// <returns>Returns string with length "charsCount" starting from the beginning of the input string.</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// The GetFileExtension() method reads file name and returns the extension of the file.
        /// </summary>
        /// <param name="fileName">Takes String parameter.</param>
        /// <returns>Returns string showing file extension e.g. '.docx'</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// The ToContentType() method reads file name, gets the extension of the file
        /// and according to it returns file content type.
        /// </summary>
        /// <param name="fileExtension">Takes String parameter.</param>
        /// <returns>Returns string showing content type.</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Converts a string into an array of bytes
        /// </summary>
        /// <param name="input">Takes String parameter.</param>
        /// <returns>Returns converted string to its byte representation.</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}