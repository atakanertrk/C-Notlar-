﻿using System;
using System.Collections;     // KÜTÜPHANELERİ EKLEMEYİ UNUTMA 
namespace ArrayList_
{
    class Program
    {
        static void Main(string[] args)
        {
            Arraylist list = new Arraylist();
            list.ListeyeEkleInt(5);
            list.ListeyeEkleInt(10);

            list.ListeyeEkleStr("BLUE");
            list.ListeyeEkleStr("RED");

            list.ListeGoruntule();

            Console.ReadLine();
        }
    }

    class Arraylist
    {
        ArrayList values = new ArrayList();

        public void ListeyeEkleInt(int x)
        {
            values.Add(x);
        }
        public void ListeyeEkleStr(string y)
        {
            values.Add(y);
        }
        public void ListeGoruntule()
        {
            foreach(var values in values)
            {
                Console.WriteLine(values);
            }
        }
    }
}