﻿using System;
 
string[] array =
{
    "a",
    "bb",
    "ccc",
    "dddd",
    "eeeee",
    "z"
};
 
var result = new string[array.Length];
var realSize = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
 
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
