 class Program
    { //parallel arrays, length ==
        static void Main()
        {
            string[] names = new string[10];  // [A ||B ||C||]
            string [] bdays = new string[10];  //[1,2,3]
            
            //  Arrays data input
            int counter = 0;
            int i =0;
            string inputName,
                searchName;
            Console.WriteLine("Enter name {0}:(ZZZ to exit)", counter + 1);
              inputName = Console.ReadLine();
            while (inputName != "ZZZ")
            {
                names[counter] = inputName;
                Console.WriteLine("Enter birthyear fo name {0}: ", counter + 1);
                string BValue = Console.ReadLine();
                //string MValue = Console.ReadLine();
                bdays[counter] = BValue;
               ++counter;

                Console.WriteLine("Enter name {0}:(ZZZ to exit)", counter + 1);
                inputName = Console.ReadLine();
            }
            // print names
            for ( int j = 0; j < counter; j++)
            {
                Console.WriteLine(names[j] + " " + bdays[j]);
            }
            Console.ReadLine(); 
            //loop for search
            Console.WriteLine("Enter name to search (ZZZ to exit) ");
            searchName = Console.ReadLine();
            bool hasName = false;
            while (searchName != "ZZZ")
            {


                string bDay = "";

                for (i = 0; i < counter; i++)
                {

                    if (searchName == names[i])// a z e
                    {
                        hasName = true;
                        bDay = bdays[i];
                        break;
                    }

                }
                if (hasName == true)
                {
                    Console.WriteLine("the birth year of {0} is {1}", searchName, bDay);
                }
                else
                {
                    Console.WriteLine("name not found");
                }

                Console.WriteLine("Enter name to search ");  //t
                searchName = Console.ReadLine();
                hasName = false;
            }



        }
    }