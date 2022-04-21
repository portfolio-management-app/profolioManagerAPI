using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.AssetAggregate.StockAggregate.DTOs;
using ApplicationCore.Entity.Asset;

namespace ApplicationCore.AssetAggregate.StockAggregate
{
    public interface IStockService: IBaseAssetService<Stock>
    {
        Stock CreateNewStockAsset(int portfolioId, StockDto dto);
    }
}