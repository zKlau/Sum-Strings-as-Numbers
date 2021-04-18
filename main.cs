using System;
using System.Numerics;
public static class Kata
{
    public static string sumStrings(string a, string b)
    {
      if(a == string.Empty) {a = "0";}
      if(b == string.Empty) {b = "0";}
      BigInteger res = BigInteger.Parse(a) + BigInteger.Parse(b);
      return res.ToString();
    }
}
