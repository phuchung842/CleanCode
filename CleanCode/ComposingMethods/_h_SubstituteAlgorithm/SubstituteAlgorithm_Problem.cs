using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.ComposingMethods._h_SubstituteAlgorithm
{
	//So you want to replace an existing algorithm with a new one?
	class SubstituteAlgorithm_Problem
    {
		string foundPerson(String[] people)
		{
			for (int i = 0; i < people.Length; i++)
			{
				if (people[i].Equals("Don"))
				{
					return "Don";
				}
				if (people[i].Equals("John"))
				{
					return "John";
				}
				if (people[i].Equals("Kent"))
				{
					return "Kent";
				}
			}
			return "";
		}
	}
}
