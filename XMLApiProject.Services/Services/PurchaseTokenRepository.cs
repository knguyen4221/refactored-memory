using PurchaseTokenService;
using XMLApiProject.Services.Services.Interfaces;

namespace XMLApiProject.Services.Services
{
    public class PurchaseTokenRepository: ActionServiceClient, IPurchaseTokenRepository
    {
        public PurchaseTokenRepository(): base()
        {

        }
    }
}
