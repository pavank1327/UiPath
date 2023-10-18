using System;
using System.Collections.Generic;
 
class Program 
{
 
  // Function to find the largest
  // number k such that both k and
  // -k are present in the array
  static int LargestNum(List<int> arr, int n)
  {
 
    // to store maximum k
    int maxK = -1;
 
    // loop through all elements and find it's negative
    // in array after it's index
    for (int i = 0; i < n; i++) {
      for (int j = i + 1; j < n; j++) {
        // if found and is greater than previous
        // maxK then update maxK with it
        if (arr[i] == -arr[j]
            && Math.Abs(arr[i]) > maxK)
          maxK = Math.Abs(arr[i]);
      }
    }
 
    return maxK;
  }
 
  static void Main(string[] args)
  {
     
    // Input array
    List<int> arr = new List<int>{ 3, 2, -2, 5, -3 };
    int n = arr.Count;
 
    // Function Call
    Console.WriteLine(LargestNum(arr, n));
  }
}