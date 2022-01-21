// QMD5 v1.0 (c) 2022 Sensei (aka 'Q')
// Reads stdin and returns MD5 hash.
//
// Alternative to: certutil -hashfile <file> MD5
//
// Usage:
// QMD5 <text.txt
// QMD5 <index.html >md5.txt
//
// Compilation:
// %SYSTEMROOT%\Microsoft.NET\Framework\v3.5\csc QMD5.cs

using System;
using System.IO;
using System.Security.Cryptography;

public static class QMD5 {
  public static void Main( string [] args ) {
     Stream source = Console.OpenStandardInput();
     System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
     byte [] result = md5.ComputeHash( source );
     if( result != null ) {
       for( int i = 0; i < result.Length; i++ ) {
          Console.Write( "{0:X2}", result[i] );
       }
       Console.WriteLine();
     }
  }
}
