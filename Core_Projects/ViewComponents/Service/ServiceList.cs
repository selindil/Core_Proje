using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projects.ViewComponents.ServiceList
{
    public class ServiceList : ViewComponent
    {


        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IViewComponentResult Invoke()
        {
            var values = serviceManager.GetList();

            return View(values);
        }
    }

}
