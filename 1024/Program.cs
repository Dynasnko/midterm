using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*0101  Compare() 方法
            string str1 = "apple";
            string str2 = "banana";
            //使用 Compare 方法來比較 str1 和str2
            int result = string.Compare(str1, str2);
            //根據 Compare 的結果輸出不同的訊息
            if (result < 0)
            {
                Console.WriteLine($"字串 '{str1}' 小於字串 '{str2}'");
                //如果result是負數,執行這一段程式碼,輸出'apple'小於'banana'
            }
            else if (result > 0)
            {
                Console.WriteLine($"字串 '{str1}' 大於字串 '{str2}'");
                //如果result是正數,會執行這段程式碼,輸出'apple'大於'banana'
            }
            else
            {
                Console.WriteLine($"字字串  '{str1}' 等於字串 '{str2}'");
                //如果result等於0,會執行這段程式碼·輸出'apple'等於'banana'
            }
            */

            /*0201 CompareTo()方法
            string str1 = "apple";
            string str2 = "banana";
            // 使用 CompareTo 方法來比較 str1 和 str2
            int result = str1.CompareTo(str2);
            // 根據 CompareTo 的結果輸出不同的訊息
            if (result < 0)
            {
                Console.WriteLine($"字串 '{str1}' 小於字串 '{str2}'");
                // 如果返回的是負數, 表示 str1 小於 str2, 並輸出 'apple 小於 banana'
            }
            else if (result > 0)
            {
                Console.WriteLine($"字串 '{str1}' 大於字串 '{str2}'");
                // 如果返回的是正數, 表示 str1 大於 str2, 並輸出 'apple 大於 banana'
            }
            else
            {
                Console.WriteLine($"字串 '{str1}' 等於字串 '{str2}'");
                // 如果 result 等於 0, 表示兩個字串完全相等, 輸出 'apple 等於 banana'
            }
            */

            /*0301 ToUpper()方法
            string originalStr = "hello, world!";
            //使用 ToUpper 方法將字串轉換為大寫
            string upperStr = originalStr.ToUpper();
            // 輸出轉換後的字串
            Console.WriteLine("原字串:" + originalStr);
            Console.WriteLine("轉換後的字串:" + upperStr);
            */

            /* 0402 Copy()方法
            string original = "banana"; // 建立了一個名為 original 的字串變數，並將它的初始值設為 "banana"。
            // original 現在存儲的值是 "banana"
            string copy = string.Copy(original); // 建立了一個名為 copy 的字串變數，並通過 string.Copy 方法將 original 的值複製給它。
              // 現在 copy 儲存的值也是 "banana"
            original = "orange"; // 這行將字串變數 original 的值改為 "orange"。
            Console.WriteLine(original); // 印出 original 的值。
            Console.WriteLine(copy);     // 印出 copy 的值。
            Console.ReadLine(); 
            */

            /*0501 StartWith()方法
            string str = "Programming"; // 建立了一個名為 str 的字串變數，並將它的初始值設為 "Programming"。
            // 使用 StartsWith 方法來檢查 str 是否以 "Pro" 開頭。
            bool result = str.StartsWith("Pro");
            // StartsWith 方法會返回一個布林值 (bool)，如果 str 以 "Pro" 開頭，result 將為 true；否則，result 為 false。
            string output = result ? "字串以 'Pro' 開頭" : "字串不以 'Pro' 開頭";
            // 使用條件運算符 (?) 根據 result 的值決定 output 的內容。
            // 如果 result 為 true，output 被賦值為 "字串以 'Pro' 開頭"；
            // 如果 result 為 false，output 被賦值為 "字串不以 'Pro' 開頭"。
            Console.WriteLine(output); // 將 output 的值輸出到控制台。
            Console.ReadLine();        // 暫停程式，等待使用者輸入，以便窗口不會立即關閉。
            */

            /*0601 EndsWith()方法
            string str = "HelloWorld"; // 建立了一個名為 str 的字串變數，並將它的初始值設為 "HelloWorld"。
            // 使用 EndsWith 方法來檢查 str 是否以 "World" 結尾。
            bool result = str.EndsWith("World");
            // EndsWith 方法會返回一個布林值 (bool)，如果 str 以 "World" 結尾，result 將為 true；否則，result 為 false。
            */

            /*0703 Concat()方法
            int[] numbers = {1, 2, 3, 4, 5};//定義整數數組
            string result = string.Concat(numbers);//合併數組為字串
            Console.WriteLine(result);//輸出結果"12345"
            */

            /*0803 Rquals()方法
            string str1 = "12345";//定義第一個字串
            string str2 = "12345";//定義第二個字串
            bool result = str1.Equals(str2);//判斷兩個字串是否相等
            //輸出結果
            Console.WriteLine("字串相等: "+result);// 會顯示 True
            */

            /*0902 Insert()方法
            string original = "今天天氣很好";//原始字串
            string result = original.Insert(0, "早安·");//在開頭插入字串
            Console.WriteLine(result);//會顯示"早安·今天天氣很好"
            */

            /*1001 PadLeft()方法
            string str = "apple";//宣告一個字串,值是"apple"
            string result = str.PadLeft(10, '-');
            //PadLeft是一個方法,可以將字串長度填充到指定的值,並且是從字串左邊開始填充
            //括弧中指定宣告的第一個值10,代表要把字串填充到10個字
            //括弧中宣告的第二個值'-',是指用來填充的符號
            //需告一個變數result,把新字串的值傳到result
            Console.WriteLine(result);
            //輸出新字串,且換行
            //輸出結果為"-----apple"
            */

            /* 1001  舉例：書籍清單
            string[] books = { "C# Programming", "Data Structures", "AI Fundamentals", "Math for Engineers" };
            //book{0}是"C# Programming"
            //用for迴圈將每本書填充至20個字元
            for (int i = 0; i < books.Length; i++)//使用Length為了能够詢動態確認陣列大小
            {
                string book = books[i];//將書名傳至book變數中
                Console.WriteLine(book.PadLeft(20)); //填充滿20個字元後輸出且换行
            }
            */

            /*1103 PadRight()方法
            string name = "shan";//宣告一個字串,值是"shan"
            string result = name.PadRight(15,'-');
            //PadRight是一個方法,可以將字串長度填充到指定的值,並且是從字串右邊開始填充
            //括弧中指定宣告的值是15,代表要將字串從右邊開始填充到15
            //因為括弧中沒有宣告第二個值,所以預設使用空白來填充
            //宣告一個變數result,把新字串的值傳到result
            Console.WriteLine(result);
            //輸出新字串,且換行
            //輸出結果為"shan
            */

            /*1103 舉例：名單整理
            // 學生姓名和成績
            string[] english_name = { "Cai Xukun", "Wu Yifan", "Zhou Bing Lun", "Li Zong Heng" };
            string[] chinese_name = { "蔡徐坤", "吴亦凡", "周倫", "李宗恒" };

            // 將名字對齊至15個字元
            Console.WriteLine("學生名單:");
            Console.WriteLine("中文姓名             英文姓名");
            Console.WriteLine("--------------------------");
            for (int i = 0; i < english_name.Length; i++)// 用.Length 動態確認陣列大小
            {
                // 名字靠左對齊，補空白到 15 個字元
                Console.WriteLine(chinese_name[i].PadRight(15) + english_name[i]);
                //將英文名字填充至15個字元後加中文名字
                //english_name[0]是"Cai Xukun"
            }
            */

            /*1202 LastIndexOf()方法
            string str = "hello world"; //宣告一個字串,值是"Hello World"
            int lastIndex = str.LastIndexOf('o');
            //LastIndex0f是一個方法,用來尋找字串中指定字母最後一個出現的位置
            //括弧中指定宣告的字母是"o”,代表要尋找的是它
            //宣告一個定義為整數的int變數lastIndex,把找到的值傳到lastIndex
            Console.WriteLine(lastIndex);
            //輸出結果且換行,輸出結果為7
            */

            /* 1202 舉例：查詢購物清單
            // 假設我們有多次購物清單記錄
            string shopLists = @"
2024-11-01:牛奶,麵包,蘋果,雞蛋
2024-11-05:麥片,牛奶,香蕉,咖啡
2024-11-15:麵包,牛奶,蘋果,花生醬
2024-11-20:牛肉,魚,蘋果,茶葉";
            // 輸入想查找的物品名稱
            Console.Write("請輸入要查找的物品: ");
            string item = Console.ReadLine();
            // 使用 LastIndexOf 找出最後一次購買該物品的位置，並將值賦給 lastIndex
            int lastIndex = shopLists.LastIndexOf(item);
            if (lastIndex != -1) // 如果找不到，LastIndexOf 會返回 -1
            {
                // 找到該行的開始和結束位置
                int startOfLine = shopLists.LastIndexOf('\n', lastIndex) + 1;
                // 從 lastIndex 開始，往前尋找最近的一個換行符號 '\n'
                // +1 是為了跳到下一行的第一個字元
                int endOfLine = shopLists.IndexOf('\n', lastIndex);
                // 從 lastIndex 開始，往後尋找最近的一個換行符號 '\n'
                if (endOfLine == -1) endOfLine = shopLists.Length;
               // 提取完整行
                string lastShopEntry = shopLists.Substring(startOfLine, endOfLine - startOfLine);
                Console.WriteLine($"\n最後一次購買 \"{item}\" 的記錄是:\n{lastShopEntry}");
            }
            else
            {
                Console.WriteLine($"\n購物清單中沒有找到 \"{item}\"。");
            }
            */

            /*1301 ToCharArray()方法
            string str = "Hello World";//宣告字串
            foreach (char Word in str.ToCharArray())
             //透過ToCharArray()將str轉換成字串陣列(包括空格)
             //再透過foreach迴圈將陣列中的資料依序放到Word中
             Console.WriteLine(Word);//每讀一個資料就印出Word直到讀完
            */

            /*1301 舉例：隨機驗證碼生成
            string str = "ABCDEFG123456";
            char[] Key = str.ToCharArray();
            Random random = new Random();
            //建了一個Random物件生成隨機數
            Key = Key.OrderBy(x => random.Next()).ToArray();
            //透過 random.Next() 為 Key 的每個資料生成一個隨機數字作為排序的依據
            //再透過 OrderBy 根據這些依據進行排序，並轉換回陣列
            string output = new string(Key);
            //將陣列key轉換成字串output
            Console.WriteLine($"原始字串: {str}");
            Console.WriteLine($"打亂後的字串: {output}");
            */

            /*1402 Join()方法
            int[] numbers = { 1, 2, 3, 4, 5 };//宣告整数陣列:1,2,3,4,5
            string result = string.Join("-", numbers);//將陣列中的整數合併為字串,以"-"分隔
            Console.WriteLine(result);
            */

            /*1402 舉例：登入日誌紀錄
            Console.WriteLine("請輸入使用者名稱：");
            string UserName = Console.ReadLine();
            Console.WriteLine("請輸入密碼：");
            string Password = Console.ReadLine();
            DateTime Time = DateTime.Now;
            //取得系統當前日期與時間存入Time
            Console.WriteLine($"登入日誌：{string.Join(" | ", UserName, Time)} Login");
            //將使用者資料與登入時間透過Join達到格式化輸出
            */

            /*1501 Remove()用法
            string  str = "Hello, World!";
            //定義了一個字串變數 str,其内容為"Hello,World!"。
            //這個字串包含了 13 個字元(包括空格和標點符號)
            string result = str.Remove(5);
            //當索引是 5時,對應的字元是」,!,這意味著從這個字元開始,
            //後面的所有字元(包括空格和字母)都將將被移除。
            Console.WriteLine(result);//輸出:Hello
            */

            /*1501 舉例1
            string sentence = "Hello World";
            string newSentence = sentence.Remove(5, 7);
            //刪除從索引5開始7個字元
            Console.WriteLine(newSentence);
            */

            /*1501 舉例2
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
            bool result = fruits.Remove("Grape");   // 嘗試移除不存在的元素 "Grape"
            Console.WriteLine(result); // 輸出 "False"
            Console.WriteLine(string.Join(", ", fruits)); // 輸出 "Apple, Banana, Cherry"
            */

            /*1602 Split()用法
            // 定義所有水果名稱的字串
            string fruits = "apple,banana,cherry,grape";
            // 使用 Split 方法分割字串（在這裡是逗號 ','）
            string[] fruitList = fruits.Split(',');
            // 使用 foreach 迴圈遍歷每個水果名稱
            foreach (string fruit in fruitList)
            {
                // 計算並顯示每個水果名稱的長度
                int length = fruit.Length;
                Console.WriteLine($"The length of '{fruit}' is {length}.");
            }
            */

            /*1602 舉例
            string text = "apple;banana|cherry,orange";
            string[] fruits = text.Split(';' , 'I', ',');
            //使用了多個分隔符(;,|,,)來分割字符串
            //Split(';', |',',)會將字符串按照這些字符進行分割,
            //並且返回每個分隔的子字符串
            foreach (string fruit in fruits)
            { 
                Console.WriteLine(fruit);
             }
            */

            /* 1701 Replace()用法
            string str = "Hello World";
            string result = str.Replace("World", "C#");
            //第一個參數 "World"是要被替換的字串,第二個參數“C#”是用來替换的字串。
            //Replace() 方法搜索所有出現的 "World”轉成“C#”。
            //因為 "World"只在字串中出現一次,所以只需要换一次
            Console.WriteLine(result);//輸出:HelloC#
            */

            /* 1701 舉例
            string sentence = "I like apples and apples are sweet.";
            string result = sentence.Replace("apples", "oranges");
            //將所有的"apples" 替換成"oranges"
            Console.WriteLine(result); //輸出 "I like oranges and oranges are sweet."
            */

            /* 1802 Substring()用法
            string str = "Hello, World!"; //宣告字串
            string result = str.Substring(7);//從字串中提取字元，從索引0開始後5個字元
            Console.WriteLine(result);
             */

            /*1802 舉例：隱藏敏感資訊
            string CreditCard = "1234567812345678";
            string mask = CreditCard.Substring(0, 4) + "****" + CreditCard.Substring(12);
            //將需顯示的資訊顯示出來
            Console.WriteLine($"信用卡號: {mask}");
            */

            /*1902 Trim()用法
            string str = "---Hello---";  //宣告字串
            string result = str.Trim('-'); //將字串前後的的指定字符移除
            Console.WriteLine(result);
            */

            /*1902 舉例：修正輸入格式
            string phoneNumber = "   +886 912 345 678 | ";
            string cleanPhoneNumber = phoneNumber.Trim(' ', '|').Replace(" ", "");
            //保留需要的資料，其他多餘的符號空白去除
            Console.WriteLine($"清理後的電話號碼: {cleanPhoneNumber}");
            */

            /*2003 CopyTo()用法
            string source = "CSharpStringMethods";//宣告字串
            char[] destination = new char[7];//宣告大小為7的陣列
            source.CopyTo(6, destination, 0, 7);
            //從字串source的索引6開始複製7個字元到陣列destination中,從該陣列的索引(0開始放人
            Console.WriteLine(destination);
            */

            /*2003 舉例：整數陣列合併
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[] PlusArray = new int[array1.Length + array2.Length];
            //建立一個大小為1+2的整數陣列
            array1.CopyTo(PlusArray, 0); // 將 array1 的內容從索引 0 開始複製到 PlusArray
            //目前 PlusArray內容為{ 1, 2, 3, 0, 0, 0}
            array2.CopyTo(PlusArray, array1.Length); // 將 array2 的內容從索引 3 開始複製到 PlusArray
            Console.WriteLine(string.Join(", ", PlusArray)); // 輸出: 1, 2, 3, 4, 5, 6
            */
        }
    }
}