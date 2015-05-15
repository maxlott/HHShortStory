using System;
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
            view.askUserName();
            StoryModel story=new StoryModel();
            story.Story();
        }

















    }
}
