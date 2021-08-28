using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.ComposingMethods._h_SubstituteAlgorithm
{
    //Replace the body of the method that implements the algorithm with a new algorithm.
    class SubstituteAlgorithm_Solution
    {
		string foundPerson(string[] people)
		{
			List<string> candidates = new List<string>{ "Don", "John", "Kent" };
			for (int i = 0; i < people.Length; i++)
			{
				if (candidates.Contains(people[i]))
				{
					return people[i];
				}
			}
			return "";
		}
	}
}
