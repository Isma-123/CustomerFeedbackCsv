

using Damain.ClientComments.cs.Api;
using Damain.ClientComments.cs.Csv;

namespace ApplicacionClientComments.cs.Dto
{
    public class DimDto
    { 
        public string? Filepath { get; set; }   
        public List<ClientDto>? Clients { get; set; }   
        public List<Social_Comments>? SocialComments { get; set; }   

    }
}
