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
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
            this.Height = 400;
            this.Width = 400;
            this.BackColor = Color.FromArgb(255, 211, 211, 211);
            label1.Text = "OS：Microsoft Windows \n版本 001 \n根据GPL许可条款发布 允许所有皮皮使用本产品\n研发团队：王跻权 郭亨宇 郑梦野";
		}
    }

}
