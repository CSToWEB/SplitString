using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace StringOperate
{
	public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		/// <summary>
		/// 去掉字符串中的空格、回车和换行，然后按指定长度进行分割
		/// </summary>
		/// <param name="str">待处理的字符串</param>
		/// <returns></returns>
		static string[] strProcess(string str)
		{			
			string strProcessed;
			string pass = @"[\t\r\n\s]";
			strProcessed = Regex.Replace(str, pass, "");  //去掉、回车、换行、空格
			int strLength = strProcessed.Length;          //统计经处理后的字符长度
            //判断待处理的字符串长度是否符合要求，并给出提示
            if (strLength % 4 != 0)
			{
				int absenceNum = 4-strLength % 4;
				string notification = $"注意：请检查数据是否完整！\r\n[提示：数据似乎缺少{absenceNum}位数字数符]";
				MessageBox.Show(notification, "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
            int byteLength = strProcessed.Length / 4;       //统计分割后字符数组长度，数组中每个元素长度为四个字节
            string[] strArrayH = new string[byteLength];    //存放十六进制字符串
            int[] dateDecimal = new int[byteLength];        //存放转换后的十进制数据
            //将字符串分割为长度为4的字符数组
            for (int i=0;i<(byteLength);i=i+1)
			{
				try
				{
					strArrayH[i]= strProcessed.Substring(4*i,4);//i-起始位置，4-子串长度
				}
				catch (Exception e)
				{
					MessageBox.Show(e.ToString(),"异常提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					continue;
				}				
			}
			return strArrayH;
		}

		private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
			string mydate;
			OpenFileDialog Ofdlg = new OpenFileDialog();
            openFileDialog1.Filter = "Word工作簿97-2003（*.doc)|*.doc|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FileName = "default";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.Title = "请选择待处理的数据文本"; //对话框的标题

			if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
				FileStream myfile = new FileStream(openFileDialog1.FileName,FileMode.Open,FileAccess.Read);
				//使用System.Text.Encoding.Defaul告诉StreamReader采用目前操作系统的编码,避免出现乱码
				StreamReader SR = new StreamReader(myfile,Encoding.Default);
				mydate = SR.ReadToEnd();
				try
				{					
					textBox1.Text = mydate;
					SR.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("打开文件出错：" + ex.Message);
				}
			}
        }

		//将文本按指定长度分割
		private void 分割字符串ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox2.Text = "";
			string myContentBefore;
			string[] myContentAfter;            
			myContentBefore = textBox1.Text.Trim();
			myContentAfter = strProcess(myContentBefore);
            int[] dateDecimal = new int[myContentAfter.Length];
            for (int i = 0; i < myContentAfter.Length; i++)
            {
                try
                {
                    dateDecimal[i] = Convert.ToInt32(myContentAfter[i], 16);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(),"提示");
                    continue;
                }
                finally
                {
					/*
					 * textBox2.Text = (textBox2.Text + " " + dateDecimal[i].ToString()).Trim();
					 * textBox2.Text += dateDecimal[i].ToString() + " ";
					 * 当数据较多时，上面两种给textBox的赋值方式响应较慢，程序可能出现假死
					 * 需要频繁更新TextBox（追加文本）时，AppendText能够稳定的即时更新，而且高效
					 */
					textBox2.AppendText(dateDecimal[i].ToString()+" ");
                }              
            }
			textBox2.Text = textBox2.Text.TrimEnd();

		}

		//清空textbox1的内容
		private void 清除text1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
		}

		//清空textbox2的内容
		private void 清除text2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox2.Text = "";
		}

		private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter mySteam;
            SaveFileDialog Sfdlg = new SaveFileDialog();
            saveFileDialog1.Filter= " Word文档97-2003（*.doc)|*.doc|txt files(*.txt)|*.txt|Excel工作簿97-2003（*.xls)|*.xls|All files(*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;					//设置默认文件类型
            saveFileDialog1.FileName = "default1";				//设置文件的默认名称
            saveFileDialog1.RestoreDirectory = true;			//记忆上次打开位置
            if (saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                mySteam = new StreamWriter(saveFileDialog1.FileName);
                mySteam.Write(textBox2.Text.Trim());
				//使用Flush()方法将所有信息从基础缓冲区移动到其目标或清除缓冲区，或者同时执行这两种操作
				mySteam.Flush();
                mySteam.Close();       
            }
        }
	}
}
