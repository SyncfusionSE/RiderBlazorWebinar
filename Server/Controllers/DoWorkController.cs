using Microsoft.AspNetCore.Mvc;
using RiderBlasorWebinar.Shared.Models;

namespace RiderBlasorWebinar.Server.Controllers;


[Route("[controller]")]
public class DoWorkController : Controller
{
    private readonly SampleDb _db;

    // GET
    [HttpGet, Route("")]
    public IActionResult Index()
    {
        return Ok(_db.WorkOrders.ToList());
    }

    public DoWorkController(SampleDb db)
    {
        _db = db;
    }
}