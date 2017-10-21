using System;

class threeDigitLockExtended
{
    private static bool isValidDeptNumbers(int fireDept, int policeDept, int sanitationDept)
        {

        if ((policeDept % 2 == 0) && (fireDept + policeDept + sanitationDept == 12) &&
        (fireDept != policeDept) && (fireDept != sanitationDept) && (sanitationDept != policeDept))
            return true;

        else
            return false;
        }

static void Main()
    {
        for (int f = 1; f <= 7; f++)
        {

            for (int p = 1; p <= 7; p++)
            {
                for (int s = 1; s <= 7; s++)
                {
                    if (isValidDeptNumbers(f, p, s))
                    {
                        Console.WriteLine("{0}, {1}, {2}", f, p, s);
                    }
                    //taka stava s if-ove a ne s funkcia
                    //if (p % 2 == 0 )
                    //{
                    //    if (f + s + p == 12)
                    //    {
                    //        if (f != p && f!= s && s!= p)
                    //        {
                    //            Console.WriteLine("{0}, {1}, {2}", f, p, s);
                    //        }// end of numbers should be different requirement
                            
                    //    }//end of sum = 12 requirement

                    //}//end of police odd number requirement
                }// end of sanitation department
               
                
            }//end of police department
            
        }//end of fire department requirement
    }
}

