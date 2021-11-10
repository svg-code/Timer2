﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Timer2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var myPath = @"c:\New Folder\TimeLog2.txt";
                //File.Create(myPath);
                Stack<DateTime> LogTime = new Stack<DateTime>();

                for (int i = 0; i < 15; i++)
                {
                    LogTime.Push(DateTime.Now);
                    Thread.Sleep(10000);
                }

                foreach (var item in LogTime)
                {
                    File.AppendAllLines(myPath, new String[] { item.ToString() });
                }
            }
        }
    }
}
