using PurchaseTokenService;
using System;
using System.Collections.Generic;
using System.Text;
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
