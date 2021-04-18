class Program
    {
        static void Main()
        {
            int i,
                counter= 0;
            string outputMsg = "";

            Console.WriteLine("How many people you want to add? ");
            string inV = Console.ReadLine();
            if( int.TryParse(inV, out int n) == false)
            {
                Console.WriteLine("invalid, 0 stored");
            }
            string[] Fnames = new string[n];
            string[] lname = new string[n];

            Console.WriteLine("add name and last: ");
            for(i = 0; i< Fnames.Length; i++)
            {
                Console.WriteLine("enter person {0}", counter +1);
                Fnames[i] = Console.ReadLine();
                lname[i] = Console.ReadLine();
                counter++;
            }
            Array.Sort(Fnames);
            outputMsg = "Names in accending order\n\n";
            foreach (string name in Fnames)
            {
                 outputMsg += name + "\n";
            }
            MessageBox.Show(outputMsg);

           // Console.ReadKey();
        }
    }