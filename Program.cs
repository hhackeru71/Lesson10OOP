﻿using System.Globalization;

namespace Lesson10OOP
{
    internal class Program
    {
     
        static void ChangeNum(int num)
        {
           num = 1;
        }
        static void ChangeClassAge(Test exa1)
        {
            exa1.Number1 = 3;
            exa1.Number2 = 4;

        }
        static void Main(string[] args)
        {
            //להגדיר class  בשם כלשהו
            //prop 
            //number1 
            //number2

            //ליצור בנאי בהתאם 

            //main
            //לאחר שיוצרים את האובייקט
            //להדפיס את number1 + number2
            //לקרוא פונקציה שמקבלת אובייקט
            // number1 = 30
            // number2 = 50

            //להדפיס לאחר מכן את number1 + number2
            Test exa1 = new Test(1,2);
            Console.WriteLine($"{exa1.Number1 + exa1.Number2}");
            ChangeClassAge(exa1);
            Console.WriteLine($"{exa1.Number1 + exa1.Number2}");




            ////refernce type  
            //Test exa1 = new Test();
            //exa1.Age = 20;
            //Console.WriteLine(exa1.Age);//before
            //ChangeClassAge(exa1);
            //Console.WriteLine(exa1.Age);//after

            ////value type
            //int num = 0;
            //Console.WriteLine(num);//before
            //ChangeNum(num);//after
            //Console.WriteLine(num);



            // int num1 = 0;
            // double num2 = 0;
            // //Console.WriteLine(num1);
            // Console.WriteLine(num2);
            //// ChangeNum(num1);
            // ChangeNumDouble(num2);
            // Console.WriteLine(num2);

            //ליצור מחלקה של סטודנטים 
            //T , V

            //prop
            // T X ;
            // V Y;

            //main
            // ליצור אובייקט שבהתחלה מוגדר כ string string
            // x = "ערך כלשהו"
            // y =ערך כלשהו
            //להדפיס את x y 

            //Students<string,string> students = new Students<string,string>();
            //students.X = "sdfdsf";
            //students.Y = "sdfsdfsdf";
            //Console.WriteLine($"{students.X} {students.Y} ");
            //Point<string> point = new Point<string>();
            ////Point<int> point1 = new Point<int>();
            //point.X = "sdfsdf";


            ////ליצור Dictionary 
            ////מפתח Int  וגם ה value  int
            ////להוסיף 5 ערכים 
            ////להדפיס בלולאה 

            //Dictionary<int,string> listD = new Dictionary<int, string>();
            //Dictionary<int, string> list1 = null;
            //list1 = listD;
            //listD.Add(1, "Moshe");
            //listD.Add(2, "sdfsdf");
            //Console.WriteLine(list1[1]);
            ////במידה ורוצים לשנות את הליסט נשנה לפי ה key
            //listD[1] = "yarin";
            ////Console.WriteLine(listD[1]);

            ////foreach (var item in listD)
            ////{
            ////    //Console.WriteLine(item);
            ////}


            ////ליצור רשימה מסוכ string 
            ////להוסיף לרשימה 3 ערכים 
            ////באינדקס האחרון של הרשימה  צריך למחוק אותו 
            ////לאחר מכן להדפיס את כל הרשימה

            //var a = 1;

            //int num = 0;
            //object obj1 = 0;//boxing unboxing שאלה מתוך ראיון עבודה
            //object obj2 = "sdf";
            //obj1 = obj2;

            //int num2 =(int)obj1;

            ////List<object> list1 = new List<object>();//הגדרת list list  של object
            //List<int> list = new List<int>();//הגדרת list
            //list.Add(1);//הוספת ערכים llist
            //list.Add(2);
            //list.Add(3);
            ////list[0] = 4;
            //list.Remove(3);
            ////list.RemoveAt(1);//מחיקה ע"י האינדקס
            //foreach (var item in list)
            //{
            //    //Console.Write(item + " ");

            //}

        }


    }
}