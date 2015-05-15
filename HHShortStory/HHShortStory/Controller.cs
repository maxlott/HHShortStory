using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHShortStory
{
    public class StoryModel
    {
        View view = new View();
        public void Story()
        {
            string opotion1 = view.displayQuestion(1);
            switch (opotion1)
            {
                case "a":
                    view.Dead();
                    break;
                case "b":
                    string option2 = view.displayQuestion(2);
                    switch (option2)
                    {
                        case "a":
                            view.Dead();
                            break;
                        case "b":
                            string option3 = view.displayQuestion(3);
                            switch (option3)
                            {
                                case "a":
                                    view.Dead();
                                    break;
                                case "b":
                                    string option4 = view.displayQuestion(4);
                                    switch (option4)
                                    {
                                        case "a":
                                            view.Dead();
                                            break;
                                        case "b":
                                            string option5 = view.displayQuestion(5);
                                            switch (option5)
                                            {
                                                case "a":
                                                    view.Dead();
                                                    break;
                                                case "b":
                                                    string option6 = view.displayQuestion(6);
                                                    switch (option6)
                                                    {
                                                        case "a":
                                                            view.Dead();
                                                            break;
                                                        case "b":
                                                            string option7 = view.displayQuestion(7);
                                                            switch (option7)
                                                            {
                                                                case "a":
                                                                    view.Dead();
                                                                    break;
                                                                case "b":
                                                                    view.displayQuestion(7);
                                                                    break;
                                                                default:
                                                                    view.defaultcase();
                                                                    break;
                                                            }
                                                            break;
                                                        default:
                                                            view.defaultcase();
                                                            break;
                                                    }
                                                    break;
                                                default:
                                                    view.defaultcase();
                                                    break;
                                            }
                                            break;
                                        default:
                                            view.defaultcase();
                                            break;
                                    }
                                    break;
                                default:
                                    view.defaultcase();
                                    break;
                            }
                            break;
                        default:
                            view.defaultcase();
                            break;
                    }

                    break;
                default:
                    view.defaultcase();
                    break;

            }
        }
    

    }
}
