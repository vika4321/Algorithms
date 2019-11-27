using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHello
{
	class Algorithms
	{

		public List<int> spiralOrder(List<List<int>> A)
		{
			List<int> result = new List<int> { };

			int rows = 0;
			int cols = 0;
			foreach (var sublist in A)
			{
				cols = sublist.Count();
				rows++;
			}
			int top = 0;
			int bottom = rows-1;
			int left = 0;
			int right = cols-1;

			int dir = 0;
			while (top <= bottom && left <= right)
			{
				if (dir == 0)
				{
					for (int i = left; i <= right; i++)
					{
						result.Add(A[top][i]);
					} //for
					top++;
					dir = 1;
				}//if
				else if (dir == 1)
				{

					for (int i = top; i <= bottom; i++)
					{
						result.Add(A[i][right]);
					}
					right--;
					dir = 2;
				}//else if
				else if (dir == 2)
				{
					for (int i = right; i >= left; i--)
					{
						result.Add(A[bottom][i]);

					}
					bottom--;
					dir = 3;
				}
				else if (dir == 3)
				{
					for (int i = bottom; i >= top; i--)
					{
						result.Add(A[i][left]);
					}
					left++;
					dir = 0;
				}

			} //while
			return result;
		}
	}
}
