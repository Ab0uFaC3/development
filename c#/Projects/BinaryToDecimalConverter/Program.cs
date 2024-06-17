using BinaryToDecimal;


namespace Projects { 
    class PracticeProjects {

        private readonly IBinToDec _binToDec;

        public PracticeProjects (IBinToDec binToDec) {
            _binToDec = binToDec;
        }

        public void GetValueFromConsole () {
            var value = _binToDec.GetValue();
            if (value == -1) {
                Console.WriteLine("Error");
            } else {
                Console.WriteLine($"Value is = {value}");
            }
        }
        
    }

    class Program {
        public static void Main () {
            PracticeProjects projects = new (new BinToDec());
            projects.GetValueFromConsole();  
        }
    }
}
