using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textplus
{
	delegate Token TypeHandle(CharEnumerator pr);
	class LexicalAnalyzer
	{
		private List<Token> tokenList = new List<Token>();//要输出的Token表
		private string[] keyWord = {
			"int","float","bool","char","string","if","else","do","while","switch","case","break",
			"default","continue","for","try","catch","finally","return","void","class","public","private",
			"protect","true","false","double","namespace","using","struct"
		};
		public string source = null;//源代码
		private StringBuilder buffer = new StringBuilder();
		private MainForm mf;

		private TypeHandle[] typeHandleList;

		//初始化
		public LexicalAnalyzer(MainForm mf)
		{
			buffer = new StringBuilder();
			this.mf = mf;
			this.source = mf.textBox.Text;
			typeHandleList = new TypeHandle[]
			{
				KeyorIdHandle,
				NumberHandle,
				CharHandle,
				StringHandle,
				NotesHandle,
				SymbolHandle
			};
		}

		//关键字或标识符处理
		public Token KeyorIdHandle(CharEnumerator pr)
		{
			char c;
			Token token = new Token();
			c = pr.Current;
			if (c == '_' || (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
			{
				buffer.Append(c);
				pr.MoveNext();
				c = pr.Current;
				while (c == '_' || (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')||(c <= '9' && c >= '0'))
				{
					buffer.Append(c);
					pr.MoveNext();
					c = pr.Current;
					//buffer.Append(c);
					//if (pr.MoveNext())
					//{
					//	c = pr.Current;
					//}
				}
				foreach (var x in keyWord)
				{
					if (x == buffer.ToString())
					{
						if (x == "false" || x == "true")
						{
							token.type = "Bool";
							token.value = buffer.ToString();
							token.Length = buffer.Length;
							token.p = pr;
							buffer.Clear();
							return token;
						}
						else
						{
							token.type = "Keyword";
							token.value = buffer.ToString();
							token.Length = buffer.Length;
							token.p = pr;
							buffer.Clear();
							return token;
						}
					}
				}
				token.type = "ID";
				token.value = buffer.ToString();
				token.Length = buffer.Length;
				token.p = pr;
				buffer.Clear();
				return token;
			}
			token.Length = buffer.Length;
			token.p = pr;
			buffer.Clear();
			return token;
		}

		//数字处理
		public Token NumberHandle(CharEnumerator pr)
		{
			char c;
			Token token = new Token();
			c = pr.Current;
			string type = "Int";
			if (c <= '9' && c >= '0')//首字符是否为数字
			{
				buffer.Append(c);
				pr.MoveNext();
				c = pr.Current;
				while (c <= '9' && c >= '0')
				{
					buffer.Append(c);
					pr.MoveNext();
					c = pr.Current;
				}
				if (c == '.')
				{
					buffer.Append(c);
					pr.MoveNext();
					c = pr.Current;
					if (c <= '9' && c >= '0')//小数点后一位是否为数字
					{
						buffer.Append(c);
						pr.MoveNext();
						c = pr.Current;
						type = "Float";
						while (c <= '9' && c >= '0')
						{
							buffer.Append(c);
							pr.MoveNext();
							c = pr.Current;
						}
					}
					else
					{
						token.type = "Spelling error";
						token.value = buffer.ToString();
						token.Length = buffer.Length;
						token.p = pr;
						buffer.Clear();
						return token;
					}
				}
				if (c == 'e' || c == 'E')
				{
					buffer.Append(c);
					pr.MoveNext();
					c = pr.Current;
					if (c <= '9' && c >= '0')//e的后一位是否为数字
					{
						buffer.Append(c);
						pr.MoveNext();
						c = pr.Current;
						type = "Double";
						while (c <= '9' && c >= '0')
						{
							buffer.Append(c);
							pr.MoveNext();
							c = pr.Current;
						}
					}
					else
					{
						token.type = "Spelling error";
						token.value = buffer.ToString();
						token.Length = buffer.Length;
						token.p = pr;
						buffer.Clear();
						return token;
					}
				}
				token.type = type;
				token.value = buffer.ToString();
				token.Length = buffer.Length;
				token.p = pr;
				buffer.Clear();
				return token;
			}
			token.Length = buffer.Length;
			token.p = pr;
			buffer.Clear();
			return token;
		}

		//字符处理
		public Token CharHandle(CharEnumerator pr)
		{
			char c;
			Token token = new Token();
			c = pr.Current;
			if (c == '\'')
			{
				buffer.Append(c);
				pr.MoveNext();
				c = pr.Current;
				while (c != '\'')
				{
					buffer.Append(c);
					if (pr.MoveNext())
					{
						c = pr.Current;
					}
					else
					{
						token.isLast = true;
						token.type = "Spelling error";
						token.value = buffer.ToString().Substring(0, 2) + "...";
						token.Length = buffer.Length;
						token.p = pr;
						buffer.Clear();
						return token;
					}
				}
				buffer.Append(c);
				if (buffer.Length - 2 != 1)
				{
					pr.MoveNext();
					token.type = "Spelling error";
					token.value = buffer.ToString();
					token.Length = buffer.Length;
					token.p = pr;
					buffer.Clear();
					return token;
				}
				pr.MoveNext();
				token.type = "Char";
				token.value = buffer.ToString();
				token.Length = buffer.Length;
				token.p = pr;
				buffer.Clear();
				return token;
			}
			token.Length = buffer.Length;
			token.p = pr;
			buffer.Clear();
			return token;
		}

		//字符串处理
		public Token StringHandle(CharEnumerator pr)
		{
			char c;
			Token token = new Token();
			c = pr.Current;
			if (c == '"')
			{
				buffer.Append(c);
				pr.MoveNext();
				c = pr.Current;
				while (c != '"')
				{
					buffer.Append(c);
					if (pr.MoveNext())
					{
						c = pr.Current;
					}
					else
					{
						token.isLast = true;
						token.type = "Spelling error";
						token.value = buffer.ToString().Substring(0, 2) + "...";
						token.Length = buffer.Length;
						token.p = pr;
						buffer.Clear();
						return token;
					}
				}
				buffer.Append(c);
				pr.MoveNext();
				token.type = "String";
				token.value = buffer.ToString();
				token.Length = buffer.Length;
				token.p = pr;
				buffer.Clear();
				return token;
			}
			token.Length = buffer.Length;
			token.p = pr;
			buffer.Clear();
			return token;
		}

		//注释处理
		public Token NotesHandle(CharEnumerator pr)
		{
			char c;
			Token token = new Token();
			c = pr.Current;
			int state = 0;
			if (c == '/')
			{
				buffer.Append(c);
				pr.MoveNext();
				c = pr.Current;
				if (c == '/')
				{
					while (c != '\n')
					{
						buffer.Append(c);
						if (pr.MoveNext())
						{
							c = pr.Current;
						}
						else
						{
							token.isLast = true;
							break;
						}
					}
					token.type = "Notes://...";
					token.value = buffer.ToString();
					token.Length = buffer.Length;
					token.p = pr;
					buffer.Clear();
					return token;
				}
				else if (c == '*')
				{
					buffer.Append(c);
					while (state != 2)
					{
						if (pr.MoveNext())
						{
							c = pr.Current;
							buffer.Append(c);
							if (c == '*')
							{
								state = 1;
							}
							else if (c == '/' && state == 1)
							{
								state = 2;
								token.type = "Notes:/*...*/";
								token.value = buffer.ToString();
								token.Length = buffer.Length;
								pr.MoveNext();
								token.p = pr;
								buffer.Clear();
								return token;
							}
							else
							{
								state = 0;
							}
						}
						else
						{
							token.type = "Notes error";
							token.value = buffer.ToString();
							token.Length = buffer.Length;
							token.p = pr;
							token.isLast = true;
							buffer.Clear();
							return token;
						}
					}
				}
			}
			token.Length = buffer.Length;
			token.p = pr;
			buffer.Clear();
			return token;
		}
		//符号处理
		public Token SymbolHandle(CharEnumerator pr)
		{
			char c;
			Token token = new Token();
			c = pr.Current;
			switch (c)
			{
				case '#':
					buffer.Append(c);
					pr.MoveNext();
					token.type = "Sharp";
					break;
				case ',':
					buffer.Append(c);
					pr.MoveNext();
					token.type = "Comma";
					break;
				case ';':
					buffer.Append(c);
					pr.MoveNext();
					token.type = "Semicolon";
					break;
				case '.':
					buffer.Append(c);
					pr.MoveNext();
					token.type = "Decimal Point";
					break;
				case '+':
					buffer.Append(c);
					pr.MoveNext();
					c = pr.Current;
					switch (c)
					{
						case '+':
							buffer.Append(c);
							pr.MoveNext();
							token.type = "Self-Increasing Operator";
							break;
						case '=':
							buffer.Append(c);
							pr.MoveNext();
							token.type = "Assignment Operator";
							break;
						default:
							token.type = "Plus Operator";
							break;
					}
					break;
				case '-':
					buffer.Append(c);
					pr.MoveNext();
					c = pr.Current;
					switch (c)
					{
						case '-':
							buffer.Append(c);
							pr.MoveNext();
							token.type = "Self-Decreasing Operator";
							break;
						case '=':
							buffer.Append(c);
							pr.MoveNext();
							token.type = "Assignment Operator";
							break;
						default:
							token.type = "Minus Operator";
							break;
					}
					break;
				case '*':
					buffer.Append(c);
					pr.MoveNext();
					c = pr.Current;
					switch (c)
					{
						case '=':
							buffer.Append(c);
							pr.MoveNext();
							token.type = "Assignment Operator";
							break;
						default:
							token.type = "Multiply Operator";
							break;
					}
					break;
				case '/':
					buffer.Append(c);
					pr.MoveNext();
					c = pr.Current;
					switch (c)
					{
						case '=':
							buffer.Append(c);
							pr.MoveNext();
							token.type = "Assignment Operator";
							break;
						default:
							token.type = "Divide Operator";
							break;
					}
					break;
				case '%':
					buffer.Append(c);
					pr.MoveNext();
					c = pr.Current;
					switch (c)
					{
						case '=':
							buffer.Append(c);
							pr.MoveNext();
							token.type = "Assignment Operator";
							break;
						default:
							token.type = "Remainder Operator";
							break;
					}
					break;
				case '(':
					buffer.Append(c);
					pr.MoveNext();
					token.type = "Left Parenthesis";
					break;
				case ')':
					buffer.Append(c);
					pr.MoveNext();
					token.type = "Right Parenthesis";
					break;
				case '[':
					buffer.Append(c);
					pr.MoveNext();
					token.type = "Left Square Bracket";
					break;
				case ']':
					buffer.Append(c);
					pr.MoveNext();
					token.type = "Right Square Bracket";
					break;
				case '{':
					buffer.Append(c);
					pr.MoveNext();
					token.type = "Left Curly Bracket";
					break;
				case '}':
					buffer.Append(c);
					pr.MoveNext();
					token.type = "Right Curly Bracket";
					break;
				case '=':
					buffer.Append(c);
					pr.MoveNext();
					c = pr.Current;
					switch (c)
					{
						case '=':
							buffer.Append(c);
							pr.MoveNext();
							token.type = "Logical Operator";
							break;
						default:
							token.type = "Assignment Operator";
							break;
					}
					break;
				case '!':
					buffer.Append(c);
					pr.MoveNext();
					c = pr.Current;
					switch (c)
					{
						case '=':
							buffer.Append(c);
							pr.MoveNext();
							token.type = "Logical Operator";
							break;
						default:
							token.type = "Not Operator";
							break;
					}
					break;
				case '&':
					buffer.Append(c);
					pr.MoveNext();
					c = pr.Current;
					switch (c)
					{
						case '&':
							buffer.Append(c);
							pr.MoveNext();
							token.type = "Logical Operator";
							break;
						default:
							token.type = "Bitwise Operator";
							break;
					}
					break;
				case '|':
					buffer.Append(c);
					pr.MoveNext();
					c = pr.Current;
					switch (c)
					{
						case '|':
							buffer.Append(c);
							pr.MoveNext();
							token.type = "Logical Operator";
							break;
						default:
							token.type = "Bitwise Operator";
							break;
					}
					break;
				case '^':
					buffer.Append(c);
					pr.MoveNext();
					token.type = "Bitwise Operator";
					break;
				case '<':
					buffer.Append(c);
					pr.MoveNext();
					token.type = "Left Corner Bracket";
					break;
				case '>':
					buffer.Append(c);
					pr.MoveNext();
					token.type = "Right Corner Bracket";
					break;
			}
			if (token.type != null)
			{
				token.value = buffer.ToString();
				token.Length = buffer.Length;
				token.p = pr;
			}
			buffer.Clear();
			return token;
		}

		//生成Token表并返回
		public List<Token> TokenHandle()
		{
			source += '\n';
			CharEnumerator pr = source.GetEnumerator();
			char c;
			Token token;
			Token temp;
			pr.MoveNext();
			while (true)
			{
				c = pr.Current;
				while (c == ' ' || c == '\n' || c == '\t')
				{
					if (pr.MoveNext())
					{
						c = pr.Current;
					}
					else
					{
						return tokenList;
					}
				}
				token = new Token();
				foreach(var getToken in typeHandleList)
				{
					temp = getToken((CharEnumerator)pr.Clone());
					if (temp.Length > token.Length)
					{
						token = temp;
					}
				}
				if (token.Length > 0)
				{
					pr = token.p;
					if (token.isLast)
					{
						tokenList.Add(token);
						return tokenList;
					}
				}
				else
				{
					token.type = "Illegal Character";
					token.value = pr.Current.ToString();
					pr.MoveNext();
				}
				tokenList.Add(token);
			}
		}
	}
}
