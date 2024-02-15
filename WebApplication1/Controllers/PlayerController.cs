using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PlayerController : Controller
    {
        private PlayerList _pml;

        public PlayerController(PlayerList pml)
        {
            _pml = pml;
        }

        [Route("list")]
        public IActionResult List()
        {
            return View("List", _pml.list);
        }

        [Route("list2")]
        public IActionResult List2(PlayerList pl)
        {
            return View("List2", pl.OrderListBy(pl));
        }

        [Route("create")]
        public IActionResult Create()
        {
            return View("Create");
        }

        public IActionResult Add(PlayerModel pm)
        {
            _pml.AddToList(pm);
            return RedirectToAction("list");
        }

        public IActionResult Delete(PlayerModel pm)
        {
            _pml.RemoveFromList(pm);
            return RedirectToAction("list");
        }
    }
}
