﻿using System;
using System.Collections.Generic;
using System.Text;

using IKVM.Sdk.Tests.Project.Lib;

namespace IKVM.Sdk.Tests.Project.Exe
{

    public static class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine(Helloworld.SayHello(args[0]));
        }

    }

}
