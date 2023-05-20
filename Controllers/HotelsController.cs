using Microsoft.AspNetCore.Mvc;
using lab6Dotnet.Models;
using lab6Dotnet.Repos;

namespace lab6Dotnet.Controllers
{
    public class HotelsController : Controller
    {
        private readonly IHotelRepo _hotelRepo;

        public HotelsController(IHotelRepo hotelRepo)
        {
            _hotelRepo = hotelRepo;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<HotelsModel> hotels;
            return View(await _hotelRepo.GetAllAsync());
        }

        //Create The Hotel
        public async Task<IActionResult> CreateHotels()
        {
            ViewBag.Title = "Add";
            ViewBag.Action = "Add New hotel";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateHotels(HotelsModel hotel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _hotelRepo.CreateHotelsAsync(hotel);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(hotel);
                }
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            return RedirectToAction(nameof(Index));
        }

        //Delete The Hotel
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _hotelRepo.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        //View Hotels Info
        public async Task<IActionResult> viewHotels(int id)
        {
            // try
            // {
                var hotel = await _hotelRepo.GetByIdAsync(id);
                return View("viewHotels", hotel);
            // }
            // catch (Exception ex)
            // {
            //     return View("Error");
            // }
        }
            }
}