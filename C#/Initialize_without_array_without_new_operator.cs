using System;
public class without_array
{
	static void Main()
	{
		int[] arr = { 12, 55, 77, 43, 99 };
		Console.WriteLine("Enter the number which you want to excess from array");
		int num = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("The number from array is ");
		int x = arr[num-1];
		Console.WriteLine(x);
	}
}