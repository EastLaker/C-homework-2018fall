/*
 第八次作业
1、为订单添加数据验证功能，要求
  （1）订单号不能为空、不能重复、并且是”年月日+三位流水号”的形式。
  （2）客户的电话号码是正确的格式。
2、将订单导出为HTML文件，在浏览器打开并显示。（备注：使用XSLT进行转换） 

截止时间下周四晚9:00
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
