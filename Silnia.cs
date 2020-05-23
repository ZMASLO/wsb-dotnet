using System;

namespace FunctionExampleApp
{
    class Silnia
    {
        public int calculate(int number)
        {
            if(a < 0){
                throw new ArgumentOutOfRangeException("a");
            }

            int result = 1;

            for(int i = 1; i <= a; i++){
                result = result * i;
            }
            
            return result;
        }
    }
}
