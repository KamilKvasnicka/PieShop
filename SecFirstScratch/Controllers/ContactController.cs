﻿using Microsoft.AspNetCore.Mvc;

namespace SecFirstScratch.Controllers
{
    public class ContactController:Controller   
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
