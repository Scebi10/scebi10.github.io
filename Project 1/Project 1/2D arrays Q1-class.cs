 class AreaCode
    {
        string[] state;
        int[,] code;

        public AreaCode()
        {

        }
        public AreaCode(string[]s, int[,]c)
        {
            state = s;
            code = c;
        }

        public string[] State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        public int[,] Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        public override string ToString()
        {
            return "State: "+ state +
                "\nCodes: " + code.ToString();
        }

    }