using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CompetitionsHelperCoolNamespace
{
    public static class CompetitionsHelper
    {
        #region Reader

        private static string Read()
        {
            return Console.ReadLine();
        }

        public static void Read(out int n1, out int n2)
        {
            string[] input = ReadArray();
            n1 = int.Parse(input[0]);
            n2 = int.Parse(input[1]);
        }

        public static void Read(out int n1, out int n2, out int n3)
        {
            string[] input = ReadArray();
            n1 = int.Parse(input[0]);
            n2 = int.Parse(input[1]);
            n3 = int.Parse(input[2]);
        }

        public static void Read(out int n1, out int n2, out int n3, out int n4)
        {
            string[] input = ReadArray();
            n1 = int.Parse(input[0]);
            n2 = int.Parse(input[1]);
            n3 = int.Parse(input[2]);
            n4 = int.Parse(input[3]);
        }

        public static void Read<T>(out T a1, out T a2)
        {
            string[] input = ReadArray();
            a1 = (T)Convert.ChangeType(input[0], typeof(T));
            a2 = (T)Convert.ChangeType(input[1], typeof(T));
        }

        public static void Read<T>(out T a1, out T a2, out T a3)
        {
            string[] input = ReadArray();
            a1 = (T)Convert.ChangeType(input[0], typeof(T));
            a2 = (T)Convert.ChangeType(input[1], typeof(T));
            a3 = (T)Convert.ChangeType(input[2], typeof(T));
        }

        public static void Read<T>(out T a1, out T a2, out T a3, out T a4)
        {
            string[] input = ReadArray();
            a1 = (T)Convert.ChangeType(input[0], typeof(T));
            a2 = (T)Convert.ChangeType(input[1], typeof(T));
            a3 = (T)Convert.ChangeType(input[2], typeof(T));
            a4 = (T)Convert.ChangeType(input[3], typeof(T));
        }

        public static int ReadInt()
        {
            return Int32.Parse(Read());
        }

        public static long ReadLong()
        {
            return long.Parse(Read());
        }

        public static double ReadDouble()
        {
            return double.Parse(Read(), CultureInfo.InvariantCulture);
        }

        public static T Read<T>()
        {
            return (T)Convert.ChangeType(Read(), typeof(T));
        }

        private static string[] ReadArray()
        {
            string readLine = Console.ReadLine();
            if (readLine != null)
                return readLine.Split(' ');

            throw new ArgumentException();
        }

        public static List<int> ReadIntArray()
        {
            return ReadArray().Select(Int32.Parse).ToList();
        }

        private static List<long> ReadLongArray()
        {
            return ReadArray().Select(long.Parse).ToList();
        }

        public static List<double> ReadDoubleArray()
        {
            return ReadArray().Select(d => double.Parse(d, CultureInfo.InvariantCulture)).ToList();
        }

        private static List<T> ReadArray<T>()
        {
            return ReadArray().Select(x => (T)Convert.ChangeType(x, typeof(T))).ToList();
        }

        public static void WriteLine(int value)
        {
            Console.WriteLine(value);
        }

        private static void WriteLine(double value)
        {
            Console.WriteLine(value.ToString(CultureInfo.InvariantCulture));
        }

        private static void WriteLine(long value)
        {
            Console.WriteLine(value);
        }

        public static void WriteLine(double value, string stringFormat)
        {
            Console.WriteLine(value.ToString(stringFormat, CultureInfo.InvariantCulture));
        }

        private static void WriteLine<T>(T value)
        {
            Console.WriteLine(value);
        }

        public static void Write(int value)
        {
            Console.Write(value);
        }

        public static void Write(double value)
        {
            Console.Write(value.ToString(CultureInfo.InvariantCulture));
        }

        public static void Write(long value)
        {
            Console.Write(value);
        }

        public static void Write(double value, string stringFormat)
        {
            Console.Write(value.ToString(stringFormat, CultureInfo.InvariantCulture));
        }

        private static void Write<T>(T value)
        {
            Console.Write(value);
        }

        public static void WriteLineArray<T>(IEnumerable<T> value)
        {
            foreach (T val in value)
            {
                WriteLine(val);
            }
        }

        public static void WriteArray<T>(IEnumerable<T> value)
        {
            foreach (T val in value)
            {
                Write(" ");
                Write(val);
            }
        }

        #endregion
    }
}
