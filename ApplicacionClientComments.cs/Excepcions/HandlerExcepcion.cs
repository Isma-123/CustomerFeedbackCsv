
namespace ApplicacionClientComments.cs.Excepcions
{
    public class HandlerExcepcion : Exception
    {  
        public HandlerExcepcion(string message) : base(message) { 
        
           NotifyExceptions(message);
        
        } 


        public void NotifyExceptions(string menssage)
        {   

            // log excepsions

            Console.WriteLine("");

        }
    }
}
