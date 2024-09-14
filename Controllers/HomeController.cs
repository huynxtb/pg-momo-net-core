using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProGCoder_MomoAPI.Models;
using ProGCoder_MomoAPI.Models.Order;
using ProGCoder_MomoAPI.Services;

namespace ProGCoder_MomoAPI.Controllers;

public class HomeController : Controller
{
    private IMomoService _momoService;

    public HomeController(IMomoService momoService)
    {
        _momoService = momoService;
    }

    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> CreatePaymentUrl(OrderInfoModel model)
    {
        var response = await _momoService.CreatePaymentAsync(model);
        return Redirect(response.PayUrl);
    }

    [HttpGet]
    public IActionResult PaymentCallBack()
    {
        var response = _momoService.PaymentExecuteAsync(HttpContext.Request.Query);
        return View(response);
    }
}