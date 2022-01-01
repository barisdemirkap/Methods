using System;

namespace methods
{

    class Program
    {   
         static void Main(string[] args)
        {
            //erisim_belirteci geri_donustipi method_adi(parametreListesi/arguman)
            //{
                    //komutlar;
                    //retrun ;   
            //}
            int a = 2;
            int b = 3 ;
            int result= _Sum(a,b) ;
            Console.WriteLine(result);
            methods exp = new methods() ;
            exp._writeonthescreen(Convert.ToString(result)) ;

            int result2 = exp.increaseandsum(ref a,ref b);
            exp._writeonthescreen(Convert.ToString(a+b)) ;
            exp._writeonthescreen(Convert.ToString(result2)) ;
            




        }
        static int _Sum(int value1, int value2)
        {
            return (value1 + value2) ;

        }

    }
    class methods
    {
        public void _writeonthescreen (string data)
        {
            Console.WriteLine(data);
        }
        public int increaseandsum(ref int value1 ,ref int value2)
        {
            value1 +=1 ;
            value2 += 1 ;
            return (value1 + value2) ; 
        }
    }
}