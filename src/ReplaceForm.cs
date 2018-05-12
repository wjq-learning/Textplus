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
	public partial class ReplaceForm : Form
	{
		public ReplaceForm()
		{
			InitializeComponent();
		}
		//查找下一个按钮点击事件
		private void button1_Click(object sender, EventArgs e)
		{
			FindStr();
		}
		//替换按钮点击事件
		private void button2_Click(object sender, EventArgs e)
		{
			MainForm mf = (MainForm)this.Owner;
			if (mf.textBox.SelectionLength == 0)
			{
				FindStr();
			}
			else
			{
				mf.textBox.SelectedText = textBox2.Text;
				FindStr();
			}
		}
		//全部替换按钮点击事件
		private void button3_Click(object sender, EventArgs e)
		{
			MainForm mf = (MainForm)this.Owner;
			mf.textBox.Text = mf.textBox.Text.Replace(textBox1.Text, textBox2.Text);
		}
		//取消按钮点击事件
		private void button4_Click(object sender, EventArgs e)
		{
			Close();
		}
		//文本更改事件
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
			{
				button1.Enabled = true;
				button2.Enabled = true;
				button3.Enabled = true;
			}
			else
			{
				button1.Enabled = false;
				button2.Enabled = false;
				button3.Enabled = false;
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
					if (mf.textBox.SelectionLength == 0)
					{
						index = mf.textBox.Find(findtext, mf.textBox.SelectionStart, mf.textBox.Text.Length, RichTextBoxFinds.MatchCase);
					}
					else
					{
						index = mf.textBox.Find(findtext, mf.textBox.SelectionStart + 1, mf.textBox.Text.Length, RichTextBoxFinds.MatchCase);
					}
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
