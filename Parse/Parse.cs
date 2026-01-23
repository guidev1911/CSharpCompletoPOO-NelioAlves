using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // ---------- INT ----------
        int i = int.Parse("123");
        Console.WriteLine("int.Parse: " + i);

        // ---------- LONG ----------
        long l = long.Parse("123456789");
        Console.WriteLine("long.Parse: " + l);

        // ---------- SHORT ----------
        short s = short.Parse("321");
        Console.WriteLine("short.Parse: " + s);

        // ---------- BYTE ----------
        byte b = byte.Parse("200");
        Console.WriteLine("byte.Parse: " + b);

        // ---------- FLOAT ----------
        float f = float.Parse("10.5", CultureInfo.InvariantCulture);
        Console.WriteLine("float.Parse: " + f);

        // ---------- DOUBLE ----------
        double d = double.Parse("3.14159", CultureInfo.InvariantCulture);
        Console.WriteLine("double.Parse: " + d);

        // ---------- DECIMAL ----------
        decimal dec = decimal.Parse("99.95", CultureInfo.InvariantCulture);
        Console.WriteLine("decimal.Parse: " + dec);

        // ---------- BOOL ----------
        bool bo = bool.Parse("true");
        Console.WriteLine("bool.Parse: " + bo);

        // ---------- CHAR ----------
        char c = char.Parse("A");
        Console.WriteLine("char.Parse: " + c);

        // ---------- DATETIME ----------
        DateTime dt = DateTime.Parse("2025-01-30");
        Console.WriteLine("DateTime.Parse: " + dt.ToString("yyyy-MM-dd"));

        // ---------- DATETIME COM CULTURE ----------
        DateTime dtBr = DateTime.Parse("30/01/2025", new CultureInfo("pt-BR"));
        Console.WriteLine("DateTime.Parse pt-BR: " + dtBr.ToString("dd/MM/yyyy"));

        // ---------- GUID ----------
        Guid g = Guid.Parse("d2719b0d-52b1-4f79-9f50-f80635f0f9a8");
        Console.WriteLine("Guid.Parse: " + g);
    }
}
