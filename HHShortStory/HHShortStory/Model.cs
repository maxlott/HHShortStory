using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHShortStory
{
    public class Model
    {
        List<string> story = new List<string>();

        public void QuQuestion()
        {
            //
            
        }

        public void UserStory()
        {
            using (StreamWriter writer = new StreamWriter("Story.txt"))
            {
                foreach (var line in story)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
