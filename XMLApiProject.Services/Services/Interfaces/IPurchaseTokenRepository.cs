using System;
using System.Threading.Tasks;

namespace XMLApiProject.Services.Services.Interfaces
{
    public interface IPurchaseTokenRepository
    {
        Task<string> AcquirePurchaseTokenAsync(string userName, string passWord, string certificationId, int transactionAmount, string purchaserInfo, string transactionInfo);
    }
}
