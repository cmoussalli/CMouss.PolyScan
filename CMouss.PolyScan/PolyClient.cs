using System.Text.Json;

namespace CMouss.Polyscan
{





    public class PolyClient
    {
        #region Properties
        string apiKey = "";
        string baseURL = "https://api.Polygonscan.com/";

        #endregion



        #region Constructor
        public PolyClient(string PolyscanApiKey)
        {
            apiKey = PolyscanApiKey;

        }
        #endregion


        #region Behaviour

        #region Get Balance

        public async Task<decimal> GetBalanceAsync(string address)
        {
            decimal result = 0;
            try
            {
                HttpClient client = new HttpClient();
                string ps = "";
                ps = ps + "&module=account";
                ps = ps + "&action=balance";
                ps = ps + "&tag=latest";
                ps = ps + "&address=" + address;
                string resStr = await client.GetStringAsync(baseURL + "api?apikey=" + apiKey + ps);
                PolyscanBalanceResponse response = JsonSerializer.Deserialize<PolyscanBalanceResponse>(resStr);
                result = UnitsConverter.WeiToEth(Decimal.Parse(response.result));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public decimal GetBalance(string address)
        {
            var eth = Task.Run(async () => GetBalanceAsync(address));
            eth.Wait();
            return eth.Result.Result;
        }
        #endregion

        #region Get Balances
        public async Task<List<AccountBalance>> GetBalancesAsync(List<string> addresses)
        {
            List<AccountBalance> result = new();
            try
            {
                HttpClient client = new HttpClient();
                string ps = "";
                ps = ps + "&module=account";
                ps = ps + "&action=balancemulti";
                ps = ps + "&tag=latest";
                ps = ps + "&address=" + string.Join(",", addresses);
                string resStr = await client.GetStringAsync(baseURL + "api?apikey=" + apiKey + ps);
                PolyscanBalancesResponse response = JsonSerializer.Deserialize<PolyscanBalancesResponse>(resStr);
                result = AccountBalanceConverter.Convert(response.result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public List<AccountBalance> GetBalances(List<string> addresses)
        {
            var eth = Task.Run(async () => GetBalancesAsync(addresses));
            eth.Wait();
            return eth.Result.Result;
        }
        #endregion



        #region Get Normal Transactions
        public async Task<List<NormalTransaction>> GetNormalTransactionsAsync(string address, long startBlock = 0, long endBlock = 99999999, long page = 1, long pagesize = 25, SortingMode sortingMode = SortingMode.Ascending)
        {
            List<NormalTransaction> result = new();
            try
            {
                HttpClient client = new HttpClient();
                string ps = "";
                ps = ps + "&module=account";
                ps = ps + "&action=txlist";
                ps = ps + "&startblock=" + startBlock.ToString();
                ps = ps + "&endblock=" + endBlock.ToString();
                ps = ps + "&page=" + page.ToString();
                ps = ps + "&offset=" + pagesize.ToString();
                if (sortingMode == SortingMode.Ascending)
                {
                    ps = ps + "&sort=" + "asc";
                }
                else
                {
                    ps = ps + "&sort=" + "desc";
                }

                ps = ps + "&address=" + address;
                string resStr = await client.GetStringAsync(baseURL + "api?apikey=" + apiKey + ps);
                PolyscanNormalTransactionsResponse response = JsonSerializer.Deserialize<PolyscanNormalTransactionsResponse>(resStr);
                result = NormalTransactionConverter.Convert(response.result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        #endregion

        #region Get Internal Transactions
        public async Task<List<InternalTransaction>> GetInternalTransactionsAsync(string address, long startBlock = 0, long endBlock = 99999999, long page = 1, long pagesize = 25, SortingMode sortingMode = SortingMode.Ascending)
        {
            List<InternalTransaction> result = new();
            try
            {
                HttpClient client = new HttpClient();
                string ps = "";
                ps = ps + "&module=account";
                ps = ps + "&action=txlist";
                ps = ps + "&startblock=" + startBlock.ToString();
                ps = ps + "&endblock=" + endBlock.ToString();
                ps = ps + "&page=" + page.ToString();
                ps = ps + "&offset=" + pagesize.ToString();
                if (sortingMode == SortingMode.Ascending)
                {
                    ps = ps + "&sort=" + "asc";
                }
                else
                {
                    ps = ps + "&sort=" + "desc";
                }

                ps = ps + "&address=" + address;
                string resStr = await client.GetStringAsync(baseURL + "api?apikey=" + apiKey + ps);
                PolyscanInternalTransactionsResponse response = JsonSerializer.Deserialize<PolyscanInternalTransactionsResponse>(resStr);
                result = InternalTransactionConverter.Convert(response.result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        #endregion

        #region Get Internal Transactions by Transactions Hash
        public async Task<List<InternalTransaction>> GetInternalTransactionsAsync(string txhash)
        {
            List<InternalTransaction> result = new();
            try
            {
                HttpClient client = new HttpClient();
                string ps = "";
                ps = ps + "&module=account";
                ps = ps + "&action=txlistinternal";
                ps = ps + "&txhash=" + txhash;
                string resStr = await client.GetStringAsync(baseURL + "api?apikey=" + apiKey + ps);
                PolyscanInternalTransactionsResponse response = JsonSerializer.Deserialize<PolyscanInternalTransactionsResponse>(resStr);
                result = InternalTransactionConverter.Convert(response.result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        #endregion

        #region Get ERC721 token transfers
        public async Task<List<ERC721Transaction>> GetERC721TokenTransactionsAsync(string address, string? contractAddress = null, long startBlock = 0, long endBlock = 99999999, long page = 1, long pagesize = 25, SortingMode sortingMode = SortingMode.Ascending)
        {
            List<ERC721Transaction> result = new();
            try
            {
                HttpClient client = new HttpClient();
                string ps = "";
                ps = ps + "&module=account";
                ps = ps + "&action=tokennfttx";
                ps = ps + "&startblock=" + startBlock.ToString();
                ps = ps + "&endblock=" + endBlock.ToString();
                ps = ps + "&page=" + page.ToString();
                ps = ps + "&offset=" + pagesize.ToString();
                ps = ps + "&address=" + address;
                if (sortingMode == SortingMode.Ascending)
                {
                    ps = ps + "&sort=" + "asc";
                }
                else
                {
                    ps = ps + "&sort=" + "desc";
                }

                if (contractAddress != null)
                {
                    ps = ps + "&contractaddress=" + contractAddress;
                }
                string resStr = await client.GetStringAsync(baseURL + "api?apikey=" + apiKey + ps);
                PolyscanERC721TransactionsResponse response = JsonSerializer.Deserialize<PolyscanERC721TransactionsResponse>(resStr);
                result = ERC721TransactionConverter.Convert(response.result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        #endregion

        #endregion

    }
}