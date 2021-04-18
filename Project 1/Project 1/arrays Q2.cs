static void Main(string[] args)
        {
            
            

            int[] numbers = new int[5];


            GetValues(numbers);
            Console.WriteLine("\nArray elements");
            DispalyIntergers(numbers);
            Console.WriteLine("\nArray in reverse");
            DispalyInReverse(numbers);
            Console.WriteLine("\nTotal");
            DispalySum(numbers);
            Console.WriteLine("\nElements larger then average");
            DispalyGrterAve(numbers);

            Console.ReadKey();
        }

        public static void GetValues(int[] num)
        {
            int i;
            for (i = 0; i < num.Length; i++)
            {
                Console.WriteLine("enter value {0}: ", i + 1);
                string inV = Console.ReadLine();
                if (int.TryParse(inV, out num[i]) == false)
                {
                    Console.WriteLine("invalid, 0 stored");
                }

            }

        }
        public static void DispalyIntergers(int[] num)
        {
            int i;
            for(i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

        }

        public static void DispalyInReverse(int[] num)
        {
       
            
                Array.Reverse(num);
            foreach(int i in num)
            {
                Console.WriteLine(i);
            }
      
        }

        public static void DispalySum(int[] num)
        {
            int i;
            int total = 0;
            for (i = 0; i < num.Length; i++)
            {
                total += num[i];
                
            }
           // return total;
            Console.WriteLine(total);
            
        }    
        public static void DispalyGrterAve(int[] num)
        {
            int i;
            double average;
            int total = 0;
            
            
            for (i = 0; i < num.Length; i++)
            {

                total += num[i];
                average = (double) total / num.Length;
                int value =0; ;

                if (num[i] > average)
                {
                    value = num[i];
                    
                }
                Console.WriteLine(value);
            }

        }




    