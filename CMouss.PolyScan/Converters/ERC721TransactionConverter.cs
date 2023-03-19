using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMouss.Polyscan
{
    public static class ERC721TransactionConverter
    {
        public static ERC721Transaction Convert(PolyscanERC721TransactionsResponse_Transaction sourceData)
        {
            ERC721Transaction result = new ERC721Transaction();
            result.BlockNumber = long.Parse( sourceData.blockNumber);
            result.TimeStamp = DateTimeOffset.FromUnixTimeSeconds(long.Parse(sourceData.timeStamp));
            result.Hash = sourceData.hash;
            result.Nonce = sourceData.nonce;
            result.BlockHash = sourceData.blockHash;
            result.From = sourceData.from;
            result.ContractAddress = sourceData.contractAddress;
            result.To = sourceData.to;
            result.TokenID = sourceData.tokenID;
            result.TokenName = sourceData.tokenName;
            result.TokenSymbol = sourceData.tokenSymbol;
            result.TokenDecimal = decimal.Parse( sourceData.tokenDecimal);
            result.TransactionIndex = sourceData.transactionIndex;
            result.Gas = long.Parse(sourceData.gas);
            result.GasPrice = long.Parse(sourceData.gasPrice);
            result.GasUsed = long.Parse(sourceData.gasUsed);
            result.CumulativeGasUsed = long.Parse(sourceData.cumulativeGasUsed);
            result.Input = sourceData.input;
            result.Confirmations = long.Parse(sourceData.confirmations);

            return result;
        }

        public static List<ERC721Transaction> Convert(List<PolyscanERC721TransactionsResponse_Transaction> sourceData)
        {
            List<ERC721Transaction> result = new();
            foreach (PolyscanERC721TransactionsResponse_Transaction item in sourceData)
            {
                //try
                //{
                    ERC721Transaction o = Convert(item);
                    
                    result.Add(o);
                //}
                //catch (Exception ex) { }
            }
            return result;
        }


    }
}
