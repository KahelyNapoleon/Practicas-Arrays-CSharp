namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5,6,7,8,9,10};
            
            int n = 0;
            int m = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i]%2 == 0)
                {
                    n++;
                }else{
                    m++;
                }
            }

             int[] arrPar = new int[n]; 
             int[] arrImpar = new int[m]; 

             int contPar = 0;
             int contImpar = 0;

             for(int i = 0; i < array.Length; i++ )
             {
                if(array[i]%2 == 0)
                {   
                    arrPar[contPar] = array[i];
                    contPar++;
                }else if(array[i] % 2 != 0)
                {
                   arrImpar[contImpar] = array[i];
                   contImpar++;
                }
             }


             for(int j = 0; j < arrPar.Length; j++)
             {
               if(j == 0)
               {
                Console.Write("[{0}", arrPar[j]);
               }else if(j > 0 && j < arrPar.Length - 1){
                Console.Write(",{0}", arrPar[j]);
               }else if(j == arrPar.Length -1){
                Console.Write(",{0}]", arrPar[j]);
               }
             }

             Console.WriteLine();

             for(int j = 0; j < arrImpar.Length; j++)
             {
               if(j == 0)
               {
                Console.Write("[{0}", arrImpar[j]);
               }else if(j > 0 && j < arrImpar.Length - 1){
                Console.Write(",{0}", arrImpar[j]);
               }else if(j == arrImpar.Length -1){
                Console.Write(",{0}]", arrImpar[j]);
               }
             }
           
           
           
            

            
        }
    }
}
