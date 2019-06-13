using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQTools
{
    public partial class Form1 : Form
    {
        private static System.Diagnostics.Process process;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "/QQVIP/QQVipTool.exe";
            try
            {
                if (process == null)
                {
                    process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = path;
                    process.Start();
                }
                else
                {
                    if (process.HasExited) //是否正在运行
                    {
                        process.Start();
                    }
                }
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "/QQVIP/meihua.exe";
            try
            {
                if (process == null)
                {
                    process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = path;
                    process.Start();
                }
                else
                {
                    if (process.HasExited) //是否正在运行
                    {
                        process.Start();
                    }
                }
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
