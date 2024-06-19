using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习文件
{
    class 字符串
    {
        public static void String1()
        {
            //字符串及其方法
            string str1 = "小鸟";
            string str2 = str1 + "飞翔";    //字符串相加
            string str3 = str2.Substring(1, 3);   //截取字符串的一个部分
            str2 = str2.Replace("飞翔", "自由");   //将"飞翔"替换为"自由"
            str2 = str2.Insert(2, "-"); //在字符串索引位置插入 - 
            bool isequal = (str1 == str2);  //判断字符串是否相等
            bool isContain = str2.Contains("飞翔");     //判断是否"飞翔"在字符串str2中
            str2 = string.Format("小鸟飞了{0}公里", 9);  //格式化字符串

            Console.WriteLine(str2, str3, isequal, isContain, str2);
        }
    }
}
