﻿namespace HOMEWORK;
/// <summary>
/// Data Types are the types of data that are stored in RAM memory
/// Basic Data types are 
/// 1. integer (signed & unsigned)
/// 2. real/floating (signed & unsigned)
/// 3. character
/// 4. boolean
/// </summary>


public class CH2_DATEATYPE
{
    public static void Test()
    {
        IntegerDataType();
    }

    private static void IntegerDataType()
    {
        throw new NotImplementedException();
    }

    public static void NumberSystem()
    {
        ///There are basically four number system
        ///1. Decimal
        ///2. Binary
        ///3. Octal
        ///4. Hexadecimal
        ///In decimal numbers available are 0,1,2,3,4,5,6,7,8,9
        ///In binary numbers available are 0,1
        ///Binary(2 bits i.e. 0 & 1)
        ///000  0
        ///001  1
        ///010  2
        ///011  3
        ///100  4
        ///101  5
        ///110  6
        ///111  7
        ///If i want to have both signs (+ & -) then divide the capacity into two
        ///for three bits the capacity is 8. for two signs it should be divided by two
        ///for - : 8/2 = 4 (i.e. -4,-3,-2,-1)
        ///for + : 8/2 = 4 (i.e. 3,2,1,0)
        ///therefore capacity will be expressed as (-4 to 3)
        ///This type is called SIGNED because it has both signs (+ & -)
        ///and the type which has only one sign (i.e. +) is called UNSIGNED
        ///Decimal = 2^(binary bits)
        ///2^3 = 8
        ///2^4 = 16
        ///Unsigned byte/Byte Type : 2^8 = 256 (8bit)
        ///Signed byte Type        : 2^8 = 256/2 = 128 (-128 to 127)
        ///Unsigned short/Int16 Type : 2^16 = 65536
        ///Signed Short Type         : 2^16 = 65536/2 = (-32768 to 32767)
        ///Unsigned int/Int32 Type : 2^32 = 4294967296
        ///Signed int Type         : 2^32 = 4294967296/2 = (-2147483648 to 2147483647)
        ///Unsigned long/Int64 Type : 2^64 = 18446744073709551616
        ///Signed long              : 2^64 = 18446744073709551616/2 = (-9223372036854775808 to 9223372036854775807)
        ///Unsigned Int128 2^128 = 340282366920938463463374607431768211456
        ///Signed Int128 2^128/2 = (-170141183460469231731687303715884105728 to 170141183460469231731687303715884105727)
        public static void IntegerDataType()
        {
            Byte ub = 255;
            SByte b = -128; b = 127;
            UInt16 ui = 65535;
            Int16 i = -32768; i = 32767;

            ///HOMEWORK DONE
            UInt32 ua = 4294967296;
            Int32 a = -2147483648; a = 2147483647;
            UInt64 b = 18446744073709551616;
            Int64 b = -9223372036854775808; b = 9223372036854775807
            UInt128 c = 340282366920938463463374607431768211456
            Int128 c = -170141183460469231731687303715884105728; c = 170141183460469231731687303715884105727
            //Homework: write variables with max capacity for following types: int32, int 64, int128

        }

    }
}