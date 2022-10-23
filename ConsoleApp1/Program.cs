using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool isMonth=false;
			int month;
			
			do
			{
				Console.Write("請輸入一個月份：");
				isMonth = int.TryParse(Console.ReadLine(), out month);
				if (isMonth == false) Console.WriteLine("請輸入整數且為1~12的數字");
				else if (month <=0 || month > 12) Console.WriteLine("月份為1~12的數字");
			}
			while (isMonth == false || month <= 0 || month > 12); //直接在do宣告的while無法使用 (month)兩個會是?群組先執行?

			int remainder = month % 12; //先%好再做下列比較方便 //0~12

			if (remainder >= 0 && remainder <= 2) //0=12月.1.2 記得if else if else 是逐行判斷的 不用重複判斷上面符合的
			{
				Console.WriteLine($"您輸入的月份是{month}，季節是冬天");
			}
			else if (remainder <= 5) //3.4.5
			{
				Console.WriteLine($"您輸入的月份是{month}，季節是春天");
			}
			else if (remainder <= 8) //6.7.8
			{
				Console.WriteLine($"您輸入的月份是{month}，季節是夏天");
			}
			else  //9.10.11
			{
				Console.WriteLine($"您輸入的月份是{month}，季節是秋天");
			}
		}
	}
}
