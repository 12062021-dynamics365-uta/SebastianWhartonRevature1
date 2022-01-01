using System;

namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //
            //
            // Insert code here.
            //
            //

            byte byteName = 250;
            sbyte sbyteName = -128;
            int intName = -40000;
            uint uintName = 40;
            short shortName = -32000;
            ushort ushortName = 32000;
            long longName = -9000;
            ulong ulongName = 90;
            float floatName = -17; 
            double doubleName = 17.99;
            char charName = 'a';
            bool boolName = true;
            object objectName = table;
            string stringName = "cat";
            decimal decimalName = .99D;


            Program.PrintValues(byteName);
            Program.PrintValues(sbyteName);
            Program.PrintValues(intName);
            Program.PrintValues(uintName);
            Program.PrintValues(shortName);
            Program.PrintValues(ushortName);
            Program.PrintValues(longName);
            Program.PrintValues(ulongName);
            Program.PrintValues(floatName);
            Program.PrintValues(doubleName);
            Program.PrintValues(charName);
            Program.PrintValues(boolName);
            Program.PrintValues(objectName);
            Program.PrintValues(stringName);
            Program.PrintValues(decimalName);

            string controlText = "I control text";
            string wholeNum = "3";
            
            StringToInt(wholeNum);
            Console.WriteLine($"{controlText} {wholeNum}");

        }

        /// <summary>
        /// This method has an 'object' type parameter. 
        /// 1. Create a switch statement that evaluates for the data type of the parameter
        /// 2. You will need to get the data type of the parameter in the 'case' part of the switch statement
        /// 3. For each data type, return a string of exactly format, "Data type => <type>" 
        /// 4. For example, an 'int' data type will return ,"Data type => int",
        /// 5. A 'ulong' data type will return "Data type => ulong",
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string PrintValues(object obj)
        {
            //throw new NotImplementedException($"PrintValues() has not been implemented");



            switch (Type obj = obj.GetType();)
            {
                case obj.GetType == byte: 
                    byte.ToByte
                    return "Data type => byte";
                    break;
                case obj.GetType == sbyte:
                    return Console.WriteLine("Data type => sbyte");
                    break;
                case obj.GetType == int:
                    return Console.WriteLine("Data type => int");
                    break;
                case obj.GetType == uint:
                    return Console.WriteLine("Data type => uint");
                    break;
                case obj.GetType == short:
                    return Console.WriteLine("Data type => short");
                    break;
                case obj.GetType == ushort:
                    return Console.WriteLine("Data type => ushort");
                    break;
                case obj.GetType == long:
                    return Console.WriteLine("Data type => long");
                    break;
                case ulong:
                    return Console.WriteLine("Data type => ulong");
                    break;
                case float:
                    return Console.WriteLine("Data type => float");
                    break;
                case double:
                    return Console.WriteLine("Data type => double");
                    break;
                case char:
                    return Console.WriteLine("Data type => char");
                    break;
                case bool:
                    return Console.WriteLine("Data type => bool");
                    break;
                case object:
                    return Console.WriteLine("Data type => object");
                    break;
                case string:
                    return Console.WriteLine("Data type => string");
                    break; 
                case decimal:
                    
                    return Console.WriteLine("Data type => decimal");
                    break;

            }
            return obj.GetType();

        }

        /// <summary>
        /// This method has a string parameter.
        /// 1. Use the .TryParse() method of the Int32 class (Int32.TryParse()) to convert the string parameter to an integer. 
        /// 2. You'll need to investigate how .TryParse() and 'out' parameters work to implement the body of StringToInt().
        /// 3. If the string cannot be converted to a integer, return 'null'. 
        /// 4. Investigate how to use '?' to make non-nullable types nullable.
        /// </summary>
        /// <param name="numString"></param>
        /// <returns></returns>
        public static int? StringToInt(string numString)
        {
            // throw new NotImplementedException($"StringToInt() has not been implemented");
            
            
            public static string Int32.TryParse(int? numString, out string numString);
            return varName;




        }
    }// end of class
}// End of Namespace
