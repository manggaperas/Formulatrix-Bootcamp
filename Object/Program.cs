using System;
using System.Collections;

object[] a1 = { "string", 123, true };
object[] a2 = { "string", 123, true };
Console.WriteLine(a1 == a2);
Console.WriteLine(a1.Equals(a2));
IStructuralEquatable se1 = (IStructuralEquatable)a1;
Console.WriteLine(se1.Equals(a2, StructuralComparisons.StructuralEqualityComparer));
