namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Que numero se repite mas veces en este Array?
            //Imprimirlo por consola

           int[] array2 = {1,3,4,4,4,4,4,5,1,1,1};

           int bestStart = 0;
           int bestLen = 0;

           for(int i = 1; i < array2.Length; i++)
           {
             if(array2[i] != array2[i - 1])
             {
                return;
             }else{
                bestStart = array2[i];
                bestLen ++;
             }
           }

           for(int j = 0; j < bestLen; j++)
           {
            Console.Write(bestStart);
           }

           
           
           
            

            
        }
    }
}
