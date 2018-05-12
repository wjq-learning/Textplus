using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textplus
{
	class Token
	{
		public string type = null;//词法单元的类型
		public string value = null;//词法单元的值

		public int Length = 0;

		public bool isLast = false;
		public CharEnumerator p;
		public override string ToString()
		{
			value = value.Replace("\n", " ");
			if (type == "Keyword")
			{
				return string.Format("{0}		< {1} , _ >\n", value, value.ToUpper());
			}
			return string.Format("{0}		< {1} , {2} >\n", value, type, value);
		}
	}
}
