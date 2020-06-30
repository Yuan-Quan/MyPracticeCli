using System;
using System.IO;
using CommandDotNet;
using ConsoleTables;
using GoPractice.MyUtil;
using System.Collections.Generic;
using System.Net;

namespace GoPracticeCli
{
    class Program
    {
        static void Startup()
        {
           //debug code here
            
        }
        static int Main(string[] args)
        {
            //Startup();
            return new AppRunner<MainEntry>()
                .UseDefaultMiddleware()
                .Run(args);
            
            //return 0;
        }
    }
}
