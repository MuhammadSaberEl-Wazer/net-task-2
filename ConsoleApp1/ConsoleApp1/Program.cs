namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //string? degreeText = "";
            //double? degree = default;
            //Console.WriteLine("Hello sir, please enter your exam's degree (0:100)");
            //degreeText = Console.ReadLine();
            //bool checkDegreeText = false;
            //do
            //{
            //    Console.WriteLine("degreeText " + degreeText);
            //    if (double.TryParse(degreeText, out _))
            //    {
            //        degree = double.Parse(degreeText);
            //        if (degree > 0 && degree < 100)
            //        {
            //            if (degree > 0 && degree < 50)
            //            {
            //                Console.WriteLine("Sorry, Failed!");

            //            }
            //            else if (degree >= 50 && degree < 65) {
            //                Console.WriteLine("fair");
            //            }
            //            else if (degree >= 65 && degree < 75) {
            //                Console.WriteLine("good");
            //            }
            //            else if (degree >= 75 && degree < 85) {
            //                Console.WriteLine("v.g");
            //            } 
            //            else if (degree >= 85 && degree < 100) {

            //            Console.WriteLine("excellent");}

            //            checkDegreeText = true;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Please write number within range (0:100)");
            //            degreeText = Console.ReadLine();
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Please write valid number");
            //        degreeText = Console.ReadLine();
            //    }
            //}
            //while (!checkDegreeText);


            #endregion

            #region

            bool continueProgram = true;
            string? choiceText;
            int choice;
            string? yesOrNoOption;

            do
            {
                Console.WriteLine("1) Good Morning\n2) Good Evening\n3) Good Afternoon\n4) Good Night\nPlease enter your option (1-4):");
                choiceText = Console.ReadLine();

                if (int.TryParse(choiceText, out choice) && choice >= 1 && choice <= 4)
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Good Morning");
                            break;
                        case 2:
                            Console.WriteLine("Good Evening");
                            break;
                        case 3:
                            Console.WriteLine("Good Afternoon");
                            break;
                        case 4:
                            Console.WriteLine("Good Night");
                            break;
                    }

                    bool validResponse = false;
                    do
                    {
                        Console.WriteLine("Do you want to continue? (y/n)");
                        yesOrNoOption = Console.ReadLine()?.Trim().ToUpper();

                        if (yesOrNoOption == "N")
                        {
                            continueProgram = false;
                            validResponse = true;
                        }
                        else if (yesOrNoOption == "Y")
                        {
                            validResponse = true;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid option (y/n).");
                        }
                    } while (!validResponse);
                }
                else
                {
                    Console.WriteLine("Please enter a valid number within the range 1-4.");
                }

            } while (continueProgram);

            #endregion


        }
    }
}
