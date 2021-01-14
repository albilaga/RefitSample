using System;
using System.Threading.Tasks;
using Refit;

namespace RefitSample.Services
{
    public interface ICatApi
    {
       Task<Cat>
    }
}
