using System;
using System.Web.Mvc;

namespace Certification70_483._02_CreateAndUseTypes.CreateTypes
{
    /// <summary>
    /// The dynamic keyword in ASP.NET MVC
    /// </summary>
    public static class Example30
    {
        public static void Start()
        {
            var index = Index();
            Console.WriteLine(index.ViewBag.MyDynamicValue);//Print "This property is not statically typed"
        }
        public static ControllerType Index()
        {
            var controllerType = new ControllerType();

            controllerType.ViewBag.MyDynamicValue = "This property is not statically typed";

            return controllerType;
        }
    }

    //just to be able to use View bag in an console aplication
    public class ControllerType : ControllerBase
    {
        protected override void ExecuteCore()
        {
            throw new NotImplementedException();
        }
    }

    ///In an Asp.net mvc controller:
    //public ActionResult Index()
    //{
    //    ViewBag.MyDynamicValue = “This property is not statically typed”;
    //    return View();
    //}
}
