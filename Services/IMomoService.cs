using ProGCoder_MomoAPI.Models.Momo;
using ProGCoder_MomoAPI.Models.Order;

namespace ProGCoder_MomoAPI.Services;

public interface IMomoService
{
    Task<MomoCreatePaymentResponseModel> CreatePaymentAsync(OrderInfoModel model);
    MomoExecuteResponseModel PaymentExecuteAsync(IQueryCollection collection);
}