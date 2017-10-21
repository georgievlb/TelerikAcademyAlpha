using System;

    class digitLock
    {
        static void Main()
        {
            for (int leftDigit = 1; leftDigit < 10; leftDigit++)
            {
                for (int middleDigit = 1; middleDigit < 10; middleDigit++)
                {
                    for (int rightDigit = 1; rightDigit < 10; rightDigit++)
                    {
                        Console.WriteLine("{0} {1} {2}", leftDigit, middleDigit, rightDigit);
                    }// end of right digit
                    
                }// end of middle digit
                
  
            }//end of first digit
            
                    
  


        }//end of main
    }
