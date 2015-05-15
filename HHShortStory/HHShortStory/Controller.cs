using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHShortStory
{
    public class Controller
    {
        View view = new View();
       

        public Controller(string name)
        {
            // TODO: Complete member initialization
            view.Name = name;
        }
        
        public void Story()
        {

            string opotion1 = view.DisplayQuestion(1);
            for (int i = 1; i < 8; i++)
            {
                
                if (opotion1 == "a")
                {
                    int k = view.Dead(i);

                    opotion1 = view.DisplayQuestion(k);

                }
                else if (opotion1 == "b")
                {
                    opotion1 = view.DisplayQuestion(i + 1);
                }

            }
            


        }

        public int timer(int time)
        {
            //create int set at 30s
            Console.Write("Decide in the next:{0}    seconds, or die!!!!", time);
            for (int a = time; a >= 0; a--)
            {
                Console.CursorLeft = 22;
                Console.Write(a.ToString());
                System.Threading.Thread.Sleep(1000);
                time--;
            }
            return time;
        }
            //switch (opotion1)
            //{
            //    case "a":
            //        view.Dead();
            //        break;
            //    case "b":
            //        string option2 = view.displayQuestion(2);
            //        switch (option2)
            //        {
            //            case "a":
            //                view.Dead();
            //                break;
            //            case "b":
            //                string option3 = view.displayQuestion(3);
            //                switch (option3)
            //                {
            //                    case "a":
            //                        view.Dead();
            //                        break;
            //                    case "b":
            //                        string option4 = view.displayQuestion(4);
            //                        switch (option4)
            //                        {
            //                            case "a":
            //                                view.Dead();
            //                                break;
            //                            case "b":
            //                                string option5 = view.displayQuestion(5);
            //                                switch (option5)
            //                                {
            //                                    case "a":
            //                                        view.Dead();
            //                                        break;
            //                                    case "b":
            //                                        string option6 = view.displayQuestion(6);
            //                                        switch (option6)
            //                                        {
            //                                            case "a":
            //                                                view.Dead();
            //                                                break;
            //                                            case "b":
            //                                                string option7 = view.displayQuestion(7);
            //                                                switch (option7)
            //                                                {
            //                                                    case "a":
            //                                                        view.Dead();
            //                                                        break;
            //                                                    case "b":
            //                                                        view.displayQuestion(8);
            //                                                        break;
            //                                                    default:
            //                                                        view.defaultcase();
            //                                                        break;
            //                                                }
            //                                                break;
            //                                            default:
            //                                                view.defaultcase();
            //                                                break;
            //                                        }
            //                                        break;
            //                                    default:
            //                                        view.defaultcase();
            //                                        break;
            //                                }
            //                                break;
            //                            default:
            //                                view.defaultcase();
            //                                break;
            //                        }
            //                        break;
            //                    default:
            //                        view.defaultcase();
            //                        break;
            //                }
            //                break;
            //            default:
            //                view.defaultcase();
            //                break;
            //        }

            //        break;
            //    default:
            //        view.defaultcase();
            //        break;

            //}
        
    

    }
}
