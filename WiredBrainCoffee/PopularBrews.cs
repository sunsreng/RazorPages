using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiredBrainCoffee.Services;

namespace WiredBrainCoffee
{
    public class PopularBrews : ViewComponent
    {
        private readonly IMenuService menuService;

        public PopularBrews(IMenuService menuService)
        {
            this.menuService = menuService;
        }

        public IViewComponentResult Invoke(int count)
        {
            return View(menuService.GetPopularItems().Take(count));
        }
    }
}
