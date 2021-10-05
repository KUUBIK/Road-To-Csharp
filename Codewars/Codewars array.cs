using System;
using System.Collections.Generic;



namespace Codewars 
{ 

	public class CodewarsArrayDiff
	{
		
			public void ArrayDiff(int[] arr1, int arr2)
			{
				List<int> lst = new List<int>(arr1);
				foreach(int a in arr2)
				{lst.RemoveAll(a);}

				foreach(int z in lst)
				{ Console.WriteLine(z); }
				

			}

		
	}
}
