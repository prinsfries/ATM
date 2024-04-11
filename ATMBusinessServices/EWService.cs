using ATMDataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMBusinessServices
{
    public class EWService
    {
        public bool VerifyPin(string EWPin)
        {
            EWDataService eWDataService = new EWDataService();
            var result = eWDataService.GetEWallet(EWPin);
            return result.EWPin != null ? true : false;
        }
    }
}
