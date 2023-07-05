using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliBaba_ModifiedWithSolutionPath
{
    // *****************************************
    // DON'T CHANGE CLASS OR FUNCTION NAME
    // YOU CAN ADD FUNCTIONS IF YOU NEED TO
    // *****************************************
    class FindMaxGainedValue
    {
        //========================================================================================================
        //Your Code is Here:
        //===================
        /// <summary>
        /// This function finds the maximum amount of money that Ali baba can get, given the number of houses (N) and a list of the net gained value for each consecutive house (V)
        /// </summary>
        /// <param name="values">Array of the values of each given house (ordered by their consecutive placement in the city)</param>
        /// <param name="N">The number of the houses</param>
        /// <returns>Array of the indices of the robbed houses (1-based and ordered from left to right) as a return param and the maximum amount of money the Ali Baba can get as a reference param</returns>
        public static long[] GetMaxGainedValue(long[] values, long N, ref long res)
        {
            long[] SaveVal = new long[N];
            long[] SaveVal2 = new long[N];
            long Var1 ;
            if (N <= 2)
            {
                if (N == 0)
                    SaveVal[0] = 0;
                if (N == 1)
                    SaveVal[0] = values[0];
                else if (N == 2)
                    SaveVal[1] = Math.Max(values[0], values[1]);
            }
            else
            {
                if (N > 2)
                {
                    SaveVal[0] = values[0];
                    SaveVal[1] = Math.Max(values[0], values[1]);
                }
                long cont = 0;
                do
                {
                    if (cont < 2)
                        SaveVal[cont] = values[cont];
                    else if (cont == 2)
                        SaveVal[cont] = SaveVal[cont - 2] + values[cont];
                    else
                    {
                        Var1 = Math.Max(SaveVal[cont - 2], SaveVal[cont - 3]);
                        SaveVal[cont] = Var1 + values[cont];
                    }


                    cont++;
                } while (cont < N);

                if (SaveVal[cont - 1] > SaveVal[cont - 2])
                    res = SaveVal[cont - 1];
                else
                    res = SaveVal[cont - 2];
                
            }
                       
            long var2 = res;
            for (long i = N - 1; i > -1; i--)
            {
                if (var2 == SaveVal[i])
                {
                    SaveVal2[i] = i + 1;
                    var2 = (SaveVal[i] - values[i]);
                }
            }
            return SaveVal2;


        

    





            //Your code is here...
            //  [1] Calculate the max gain that Ali Baba can get and return it as a reference param (i.e. set the "res" to it)
            //  [2] Find the indices of the robbed houses (1-based and ordered from left to right) and return them as a return param (if there're multiple combinations that have the same max total gain, return ANY of them)

            //====================================
            //REMOVE THIS LINE BEFORE START CODING
            //throw new NotImplementedException();
            //====================================
        }
    }
}
