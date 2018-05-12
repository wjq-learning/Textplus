using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textplus
{
	public partial class SearchForm : Form
	{
		public SearchForm()
		{
			InitializeComponent();
		}
		//查找下一个按钮点击事件
		private void button1_Click(object sender, EventArgs e)
		{
			FindStr();
		}
		//取消按钮点击事件
		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}
		//更改文本事件
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
			{
				button1.Enabled = true;
			}
			else
			{
				button1.Enabled = false;
			}
		}
		//查找功能
		private void FindStr()
		{
			MainForm mf = (MainForm)this.Owner;
			string findtext = textBox1.Text;//要查找的字符串
			int index;//查找结果的索引
			try
			{
				if (checkBox1.Checked)
				{
					if (radioButton1.Checked)
					{
						index = mf.textBox.Find(findtext, 0, mf.textBox.SelectionStart, RichTextBoxFinds.MatchCase | RichTextBoxFinds.Reverse);
					}
					else
					{
						if (mf.textBox.SelectionLength == 0)
						{
							index = mf.textBox.Find(findtext, mf.textBox.SelectionStart, mf.textBox.Text.Length, RichTextBoxFinds.MatchCase);
						}
						else
						{
							index = mf.textBox.Find(findtext, mf.textBox.SelectionStart + 1, mf.textBox.Text.Length, RichTextBoxFinds.MatchCase);
						}
					}
				}
				else
				{
					if (radioButton1.Checked)
					{
						index = mf.textBox.Find(findtext, 0, mf.textBox.SelectionStart, RichTextBoxFinds.Reverse);
					}
					else
					{
						if (mf.textBox.SelectionLength == 0)
						{
							index = mf.textBox.Find(findtext, mf.textBox.SelectionStart, mf.textBox.Text.Length, RichTextBoxFinds.None);
						}
						else
						{
							index = mf.textBox.Find(findtext, mf.textBox.SelectionStart + 1, mf.textBox.Text.Length, RichTextBoxFinds.None);
						}
					}
				}
				mf.textBox.SelectionStart = index;
				mf.textBox.SelectionLength = findtext.Length;
				mf.textBox.Focus();
			}
			catch
			{
				MessageBox.Show("找不到\"" + findtext + "\"", "Textplus", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
			}
		}
	}
}
