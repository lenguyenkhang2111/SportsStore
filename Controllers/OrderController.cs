using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SportsStore.Controllers;

public class OrderController : Controller
{
    public ViewResult Checkout() => View(new Order());
}
