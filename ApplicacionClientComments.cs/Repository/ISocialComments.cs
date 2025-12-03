using Damain.ClientComments.cs.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicacionClientComments.cs.Repository
{
    public interface ISocialComments
    {
        public Task<IEnumerable<SocialComments>> GetAllCommentsAsync();

    }
}
