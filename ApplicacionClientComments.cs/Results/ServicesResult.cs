

namespace ApplicacionClientComments.cs.Results
{
    public class ServicesResult
    { 
        public string Message { get; set; } = string.Empty; 
        public bool IsSuccess { get; set; }
        public ServicesResult()
        {
            IsSuccess = true;
        }

    }
}
