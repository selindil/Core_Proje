﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projects.ViewComponents.About
{
    public class AboutList : ViewComponent
    {


        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = aboutManager.GetList();

            return View(values);
        }
    }
}

