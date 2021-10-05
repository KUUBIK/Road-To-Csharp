using System;
using System.Collections.Generic;



namespace Codewars 
{

	public class CodewarsArrayDiff
	{

		public int[] ArrayDiff(int[] arr1, int[] arr2)
			{
			//arr1 - Основные данные
			//arr2 - то что удаляем
				
				List<int> lst = new List<int>(arr1);
				foreach(int a in arr2)		
				
				{

					foreach (int b in arr1)
					{
						if(a == b)
							{
								lst.Remove(a);
							}
						continue;
					}
			
				}

            //foreach(int a in lst)
            //         {
            //             Console.WriteLine(a);
            //         }
            Console.WriteLine(lst.ToArray().GetType());
			return lst.ToArray();

			}



	}
}
