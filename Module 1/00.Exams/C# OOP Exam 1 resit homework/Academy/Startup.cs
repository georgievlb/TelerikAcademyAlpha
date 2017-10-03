﻿using Academy.Core;
using Academy.Models.Academy.Course;
using Academy.Models.Academy.Participants;
using System;

namespace Academy
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            // Singleton design pattern
            // Ensures that there is only one instance of Engine in existance
            var engine = Engine.Instance;
            engine.Start();

        }
    }
}
