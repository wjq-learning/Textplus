using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Textplus
{
	public partial class MainForm : Form
	{
		bool isNew = true;//是否为新建
		bool isSaved = true;//是否为已保存
		StreamReader lineReader;//打印数据流

		public MainForm()
		{
			InitializeComponent();
		}
        #region 事件代码 - 菜单栏
		//新建点击事件
		private void TsmiNew_Click(object sender, EventArgs e)
		{
			if (isSaved)
			{
				textBox.Clear();
			}
			else
			{
				switch (MessageBox.Show("是否保存？", "Textplus", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
				{
					case DialogResult.Yes:
						if (isNew)
						{
							if (sfd.ShowDialog() == DialogResult.OK)
							{
								SaveFile(sfd.FileName);
							}
							NewFile();
						}
						else
						{
							SaveFile(Text.Replace(" - Textplus", ""));
							NewFile();
						}
						break;
					case DialogResult.No:
						NewFile();
						break;
				}
			}
		}
		//打开点击事件
		private void TsmiOpen_Click(object sender, EventArgs e)
		{
			if(isSaved)
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					OpenFile(ofd.FileName);
				}
			}
			else
			{
				switch (MessageBox.Show("是否保存？", "Textplus", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
				{
					case DialogResult.Yes:
						if (isNew)
						{
							if (sfd.ShowDialog() == DialogResult.OK)
							{
								SaveFile(sfd.FileName);
							}
						}
						else
						{

							SaveFile(Text.Replace(" - Textplus", ""));
						}
						break;
					case DialogResult.No:
						if (ofd.ShowDialog() == DialogResult.OK)
						{
							OpenFile(ofd.FileName);
						}
						break;
				}
			}
		}
		//保存点击事件
		private void TsmiSave_Click(object sender, EventArgs e)
		{
			if (isNew)
			{
				if(sfd.ShowDialog()==DialogResult.OK)
				{
					SaveFile(sfd.FileName);
				}
			}
			else
			{
				SaveFile(Text.Replace(" - Textplus", ""));
			}
		}
		//另存为点击事件
		private void TsmiSaveAs_Click(object sender, EventArgs e)
		{
			if(sfd.ShowDialog()==DialogResult.OK)
			{
				SaveFile(sfd.FileName);
			}
		}
		//页面设置点击事件
		private void TsmiSetting_Click(object sender, EventArgs e)
		{
			psdlg.Document = printDocument;
			psdlg.AllowMargins = true;
			psdlg.AllowOrientation = true;
			psdlg.AllowPaper = true;
			psdlg.AllowPrinter = true;
			psdlg.ShowDialog();
		}
		//打印点击事件
		private void TsmiPrint_Click(object sender, EventArgs e)
		{
			ptdlg.Document = printDocument;
			ptdlg.PrinterSettings = psdlg.PrinterSettings;
			printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument_PrintPage);
			if (ptdlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					printDocument.Print();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "打印错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		//退出点击事件
		private void TsmiExit_Click(object sender, EventArgs e)
		{
			bool exitEnabled = true;//判断是否可以退出
			if (!isSaved)
			{
				switch (MessageBox.Show("是否保存？", "Textplus", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
				{
					case DialogResult.Yes:
						if (isNew)
						{
							if (sfd.ShowDialog() == DialogResult.OK)
							{
								SaveFile(sfd.FileName);
							}
							else
							{
								exitEnabled = false;//未保存，不可退出
							}
						}
						else
						{
							SaveFile(Text.Replace(" - Textplus", ""));
						}
						break;
					case DialogResult.No:
						break;
					case DialogResult.Cancel:
						exitEnabled = false;//取消退出操作，不可退出
						break;
				}
			}
			if (exitEnabled)
			{
				Application.ExitThread();
			}
		}
		//撤销点击事件
		private void TsmiUndo_Click(object sender, EventArgs e)
		{
			textBox.Undo();
		}
		//剪切点击事件
		private void TsmiCut_Click(object sender, EventArgs e)
		{
			textBox.Cut();
		}
		//复制点击事件
		private void TsmiCopy_Click(object sender, EventArgs e)
		{
			textBox.Copy();
		}
		//粘贴点击事件
		private void TsmiPaste_Click(object sender, EventArgs e)
		{
			textBox.Paste();
		}
		//删除点击事件
		private void TsmiDelete_Click(object sender, EventArgs e)
		{
			textBox.SelectedText = "";
		}
		//查找点击事件
		private void TsmiSearch_Click(object sender, EventArgs e)
		{
			SearchForm searchForm = new SearchForm();
			searchForm.Owner = this;
			searchForm.Show();
			searchForm.ShowInTaskbar = false;
			searchForm.TopMost = true;
		}
		//替换点击事件
		private void TsmiReplace_Click(object sender, EventArgs e)
		{
			ReplaceForm replaceForm = new ReplaceForm();
			replaceForm.Owner = this;
			replaceForm.Show();
			replaceForm.ShowInTaskbar = false;
			replaceForm.TopMost = true;
		}
		//全选点击事件
		private void TsmiSelectAll_Click(object sender, EventArgs e)
		{
			textBox.SelectAll();
		}
		//时间/日期点击事件
		private void TsmiTime_Click(object sender, EventArgs e)
		{
			textBox.AppendText(System.DateTime.Now.ToString());
		}
		//自动换行点击事件
		private void TsmiAuto_Click(object sender, EventArgs e)
		{
			if (TsmiAuto.Checked == false)
			{
				TsmiAuto.Checked = true;
				textBox.WordWrap = true;
			}
			else
			{
				TsmiAuto.Checked = false;
				textBox.WordWrap = false;
			}
		}
		//字体点击事件
		private void TsmiFont_Click(object sender, EventArgs e)
		{
			fdlg.ShowColor = true;
			if (fdlg.ShowDialog() == DialogResult.OK)
			{
				textBox.SelectionColor = fdlg.Color;
				textBox.SelectionFont = fdlg.Font;
			}
		}
		//工具栏点击事件
		private void TsmiTools_Click(object sender, EventArgs e)
		{
			if (TsmiTools.Checked == true)
			{
				TsmiTools.Checked = false;
				toolStrip.Visible = false;
			}
			else
			{
				TsmiTools.Checked = true;
				toolStrip.Visible = true;
			}
		}
		//状态栏点击事件
		private void TsmiStat_Click(object sender, EventArgs e)
		{
			if (TsmiStat.Checked == false)
			{
				TsmiStat.Checked = true;
				statusStrip.Visible = true;
			}
			else
			{
				TsmiStat.Checked = false;
				statusStrip.Visible = false;
			}
		}
		//词法分析点击事件
		private void TsmiAnalyzer_Click(object sender, EventArgs e)
		{
			LexicalAnalyzerForm lafm = new LexicalAnalyzerForm();
			LexicalAnalyzer la = new LexicalAnalyzer(this);
			foreach(var token in la.TokenHandle())
			{
				lafm.textBox.Text += token.ToString();
			}
			lafm.Show();
		}
		//查看帮助点击事件
		private void TsmiMenu_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"C:\Users\P C\Desktop\Textplus\Textplus\Resources\王跻权-Textplus.doc");
		}
		//关于Textplus点击事件
		private void TsmiAbout_Click(object sender, EventArgs e)
		{
			AboutForm aboutForm = new AboutForm();
			aboutForm.Show();
		}
		#endregion

		#region 事件代码 - 状态
		//打印前事件
		private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{
			byte[] array = Encoding.UTF8.GetBytes(textBox.Text);
			MemoryStream stream = new MemoryStream(array);
			lineReader = new StreamReader(stream);
		}
		//打印每一页前事件
		private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Graphics g = e.Graphics; //获得绘图对象
			float linesPerPage = 0; //页面的行数
			float yPosition = 0; //绘制字符串的纵向位置
			int count = 0; //行计数器
			string line = null; //行字符串
			Font printFont = textBox.Font; //当前的打印字体
			linesPerPage = e.MarginBounds.Height / printFont.GetHeight(g);//每页可打印的行数
																		  //逐行的循环打印一页
			while (count < linesPerPage && ((line = lineReader.ReadLine()) != null))
			{
				yPosition = count * printFont.GetHeight(g);
				g.DrawString(line, printFont, Brushes.Black, 0, yPosition);
				count++;
			}
			//如果本页打印完成而line不为空说明还有没完成的页面这将触发下一次的打印事件在下一次的打印中lineReader会
			//自动读取上次没有打印完的内容因为lineReader是这个打印方法外的类的成员它可以记录当前读取的位置
			if (line != null)
			{
				e.HasMorePages = true;
			}
			else
			{
				e.HasMorePages = false;
			}
		}
		//计时器事件
		private void timer_Tick(object sender, EventArgs e)
		{
			int line = 1 + textBox.GetLineFromCharIndex(textBox.SelectionStart);//计算光标所在行
			int col = 1 + textBox.SelectionStart - (textBox.GetFirstCharIndexFromLine(line - 1));//计算光标所在列
			tssl.Text = "第" + line.ToString() + "行，第" + col.ToString() + "列";//在状态栏显示光标位置
			//判断状态栏菜单按钮是否可用
			if(TsmiAuto.Checked == true)
			{
				TsmiStat.Enabled = false;
				TsmiStat.Checked = false;
			}
			else
			{
				TsmiStat.Enabled = true;
			}
			//判断状态栏是否显示
			if (TsmiStat.Checked == false)
			{
				statusStrip.Visible = false;
			}
			else
			{
				statusStrip.Visible = true;
			}
			//判断查找和替换菜单按钮是否可用
			if (textBox.Text == "")
			{
				TsmiSearch.Enabled = false;
				TsmiReplace.Enabled = false;
			}
			else
			{
				TsmiSearch.Enabled = true;
				TsmiReplace.Enabled = true;
			}
		}
		//更改选定事件
		private void textBox_SelectionChanged(object sender, EventArgs e)
		{
			if (textBox.SelectedText != "")//选定文本不为空
			{
				TsmiCut.Enabled = true;
				cutButton.Enabled = true;//允许剪切
				TsmiCopy.Enabled = true;
				copyButton.Enabled = true;//允许复制
				TsmiDelete.Enabled = true;
				deleteButton.Enabled = true;//允许删除
			}
			else
			{
				TsmiCut.Enabled = false;
				cutButton.Enabled = false;
				TsmiCopy.Enabled = false;
				copyButton.Enabled = false;
				TsmiDelete.Enabled = false;
				deleteButton.Enabled = false;
			}
		}
		//更改文本事件
		private void textBox_TextChanged(object sender, EventArgs e)
		{
			isSaved = false;//文本被修改后，表示文本并未保存
			TsmiUndo.Enabled = true;
			undoButton.Enabled = true;//文本被修改后,允许撤销
		}
		//关闭窗口事件
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!isSaved)
			{
				switch (MessageBox.Show("是否保存？", "Textplus", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
				{
					case DialogResult.Yes:
						if (isNew)
						{
							if (sfd.ShowDialog() == DialogResult.OK)
							{
								SaveFile(sfd.FileName);
							}
							else
							{
								e.Cancel = true;//未保存，不可退出
							}
						}
						else
						{
							SaveFile(Text.Replace(" - Textplus", ""));
						}
						break;
					case DialogResult.No:
						break;
					case DialogResult.Cancel:
						e.Cancel = true;//取消关闭操作，不可退出
						break;
				}
			}
		}
		#endregion

		#region 功能代码
		//新建文件时进行初始化
		private void NewFile()
		{
			textBox.Clear();
			isNew = true;
			isSaved = true;
			Text = "无标题 - Textplus";
		}
		//打开文件
		private void OpenFile(string fileName)
		{
            textBox.Clear();
			FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			StreamReader reader = new StreamReader(fs);
			bool first = true;
			for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
			{
				if (!first)
				{
					textBox.Text += "\n";
				}
				first = false;
				textBox.Text += line;
			}
			Text = ofd.FileName + " - Textplus";
			reader.Close();
			fs.Close();
			isNew = false;
			isSaved = true;
		}
		//保存文件
		private void SaveFile(string fileName)
		{
			try
			{
				FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
				StreamWriter writer = new StreamWriter(fs);
				writer.Write(textBox.Text.Replace("\n", "\r\n"));
				writer.Close();
				fs.Close();
				isSaved = true;
			}
			catch(UnauthorizedAccessException ex)
			{
				MessageBox.Show("该文件为只读文件，不可修改！", "Textplus", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
			}
		}
		#endregion

	}
}
