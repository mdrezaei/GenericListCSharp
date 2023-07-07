using System;
using System.Collections.Generic;

namespace ConsoleApp8_GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //در ارایه وقتی ایجاد میکنیم ان را باید حداقل تعداد ایندکس های ان را مشخص کنیم و یا حتی مقدار دهیم که در ساخته برنامه هایی که از قبل مقادیر مشخص نیس مشکل میسازد
            // همچنین در استفاده از ارایه چون از قبل تعیین میشود از فضای حافظه بهینه استفاده نمیکنه
            int[] Numbers = { 1, 2, 3 };
            int[] NumbersII = new int[3];

            List<int> NumbersIII = new List<int>();
            // جنریک لیست ایجاد میشود مشابه دستور بالا(List)با استفاده از کلمه  
            //و درون <> باید نوع دیتای ورودی لیست رو بنویسیم میتونه دیتا تایپ باشه یا حتی پراپرتی
            NumbersIII.Add(1);
            NumbersIII.Add(2);
            NumbersIII.Add(3);
            NumbersIII.Add(4);//اجازه اضافه کردن میدهد و موردی را که میخواهیم اضافه کنیم درون پرانتز ان مینویسیم .Add()دستور
            NumbersIII.Add(3);
            NumbersIII.Add(5);
            NumbersIII.Add(6);
            NumbersIII.Add(7);
            NumbersIII.Add(8);
            NumbersIII.Remove(3);// .اجازه میدهد موردی را که میخواهیم پاک شود . پاک کنیم.Remove()دستور                   
            // و از بالا فقط اولین موردی را که ما میخواستیم را پاک میکند 
            NumbersIII.Remove(3);
            NumbersIII.RemoveAt(2);// این دستور موردی را پاک میکند که شماره ایندکسش را داده باشیم.ایندکس از صفر شروع میشود


            foreach (int NumbersIV in NumbersIII)
            {
                Console.WriteLine(NumbersIV);
            }

            //for (int i = 0; i < length; i++)
            //{
            //    Console.WriteLine(NumbersIII);
            //}
            //از فور نمیتونیم استفاده کنیم چون نمیدونیم چقدر طول دارد



        }
    }
}
