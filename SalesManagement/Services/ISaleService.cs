using SalesManagement.Models;
using static SalesManagement.Models.enums;

namespace SalesManagement.Services
{
    public interface ISaleService
    {
        void CreateSale(Sale sale);
        void CreateSaleFromExistingOrders(Sale sale, Guid customerId);
        void UpdateSalePayment(Guid saleid);
        void UpdateMerchandiseFromId(Guid saleId);
        List<Sale> GetAllSales();
        Sale GetSaleById(Guid saleid);
        List<Order> GetOrdersFromSaleId(Guid saleid);
        void DeleteSaleRecord(Guid saleid);
        void UpdateSaleStatus(Guid saleid, Status status);
    }
}
