﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHShortStory
{
    class Program
    {
        private static void Main(string[] args)
        {
           View view = new View();
           //view.asciiCharmander();
            //view.asciiTitle();
            view.askUserName();
            view.timer(15);
            
            StoryModel story=new StoryModel();
            story.Story();
        }

















    }
}
