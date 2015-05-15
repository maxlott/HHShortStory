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
           view.asciiTitle();
            //view.asciiTitle();
            view.askUserName();
<<<<<<< HEAD
            view.timer(15);
            
            StoryModel story=new StoryModel();
=======
            Controller story=new Controller();
>>>>>>> View
            story.Story();
        }

















    }
}
