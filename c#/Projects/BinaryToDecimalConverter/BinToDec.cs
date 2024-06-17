using System;

namespace BinaryToDecimal {

    interface IBinToDec {
        long GetValue();
        long ConvertFromBinToDecimal(string value);
    }


    public class BinToDec: IBinToDec {
        public long GetValue () {

            // Fetch the binary value
            Console.WriteLine("Enter a binary number");
            string? inputBinary = Console.ReadLine();
            
            // If value is other than 1 or 0, error
            if (inputBinary != null && !( inputBinary.Contains('1') || inputBinary.Contains('0'))) {
                Console.WriteLine("Invalid value. Binary should contain only 1's or 0's");
                return -1;
            } else {
                return ConvertFromBinToDecimal(inputBinary ?? String.Empty);
            }
        }

        public long ConvertFromBinToDecimal(string binary) {
            // Convert string to char array
            char[] binaryChar = binary.ToCharArray();
            long decimalValue = 0;

            for (int i = binaryChar.Length - 1; i >= 0; i--)
            {
                decimalValue += Convert.ToInt64( (int)Char.GetNumericValue(binaryChar[i]) * Math.Pow(2, binaryChar.Length - i));
            }

            return decimalValue;
        }
        
    }
}