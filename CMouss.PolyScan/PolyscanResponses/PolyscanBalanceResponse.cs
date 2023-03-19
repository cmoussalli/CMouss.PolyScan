using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMouss.Polyscan
{


    public class PolyscanBalanceResponse:PolyscanBaseResponse
    {
        public string result { get; set; }

    }





    public class PolyscanBalancesResponse_Balance
    {
        public string account { get; set; }
        public string balance { get; set; }
    }
    public class PolyscanBalancesResponse:PolyscanBaseResponse
    {
        public List<PolyscanBalancesResponse_Balance> result { get; set; }

    }



}
