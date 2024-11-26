using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1024
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string source = "CSharpStringMethods";//宣告字串
            //char[] destination = new char[7]; //宣告大小為7的陣列
            //source.CopyTo(6, destination, 0, 7);
            ////從字串source的索引6開始複製7個字元到陣列destination中，從該陣列的索引 0 開始放入
            //Console.WriteLine(destination);


            /*
            string str = "---Hello---";//宣告字串
            string result = str.Trim('-');//將字串前後的的指定字符移除
            Console.WriteLine(result);
            */

            /*
            string str = "Hello, World!"; //宣告字串
            string result = str.Substring(7);//從字串中提取字元，從索引0開始後5個字元
            Console.WriteLine(result);
             */

            ////隨機驗證碼生成
            //string str = "ABCDEFG123456"; 
            //char[] Key=str.ToCharArray();
            //Random random = new Random();
            ////建了一個Random物件生成隨機數
            //Key = Key.OrderBy(x => random.Next()).ToArray();
            ////透過 random.Next() 為 Key 的每個資料生成一個隨機數字作為排序的依據
            ////再透過 OrderBy 根據這些依據進行排序，並轉換回陣列
            //string output = new string(Key);
            ////將陣列key轉換成字串output
            //Console.WriteLine($"原始字串: {str}");
            //Console.WriteLine($"打亂後的字串: {output}");


            //foreach (char Word in str)
            ////透過ToCharArray()將str轉換成字串陣列(包括空格)
            ////再透過foreach迴圈將陣列中的資料依序放到Word中
            //{
            //    Console.WriteLine(Word); //每讀一個資料就印出Word直到讀完
            //}

            ////登入日誌紀錄
            //Console.WriteLine("請輸入使用者名稱：");
            //string UserName=Console.ReadLine();
            //Console.WriteLine("請輸入密碼：");
            //string Password = Console.ReadLine();
            //DateTime Time = DateTime.Now;
            ////取得系統當前日期與時間存入Time
            //Console.WriteLine($"登入日誌：{string.Join(" | ",UserName,Time)} Login");
            ////將使用者資料與登入時間透過Join達到格式化輸出

            //string str1 = "apple";
            //string str2 = "banana";
            //int result = string.Compare(str1, str2);
            //string output = result < 0 ? "apple 在字母順序上較前面" : "banana 在字母順序上較前面";
            //Console.WriteLine(output);
            //Console.WriteLine("\n"+result);

            //string str = "hello world";//宣告一個字串，值是"Hello World"
            //int lastIndex = str.LastIndexOf('o');
            ////LastIndexOf是一個方法，用來尋找字串中指定字母最後一個出現的位置
            ////括弧中指定宣告的字母是"o"，代表要尋找的是它
            ////宣告一個定義為整數的int變數lastIndex，把找到的值傳到lastIndex
            //Console.WriteLine(lastIndex);
            ////輸出結果且換行，輸出結果為7

            ////隱藏敏感資訊
            //string  CreditCard = "1234567812345678";
            //string mask = CreditCard.Substring(0, 4) + "****" + CreditCard.Substring(12);
            ////將需顯示的資訊顯示出來
            //Console.WriteLine($"信用卡號: {mask}");

            ////修正輸入格式
            //string phoneNumber = "   +886 912 345 678 | ";
            //string cleanPhoneNumber = phoneNumber.Trim(' ', '|').Replace(" ", "");
            ////保留需要的資料，其他多餘的符號空白去除
            //Console.WriteLine($"清理後的電話號碼: {cleanPhoneNumber}");

            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[] mergedArray = new int[array1.Length + array2.Length];

            array1.CopyTo(mergedArray, 0); // 將 array1 的內容從索引 0 開始複製到 mergedArray
            array2.CopyTo(mergedArray, array1.Length); // 將 array2 的內容從索引 3 開始複製到 mergedArray

            Console.WriteLine(string.Join(", ", mergedArray)); // 輸出: 1, 2, 3, 4, 5, 6

        }
    }
}
