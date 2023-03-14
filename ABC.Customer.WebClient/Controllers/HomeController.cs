using ABC.Customer.Domain.Configuration;
using ABC.Customer.Domain.DataConfig;
using ABC.EFCore.Repository.Edmx;
using ABC.Shared.DataConfig;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static ABC.Customer.Domain.DataConfig.RequestSender;

namespace ABC.Customer.WebClient.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<ItemCategory> ResItemCategroy = new List<ItemCategory>();
            List<ItemSubCategory> itemSubCategoriesList = new List<ItemSubCategory>();
            try
            {
                SResponse ress = RequestSender.Instance.CallAPI("api",
                  "Inventory/ItemGet", "GET");
                if (ress.Status && (ress.Resp != null) && (ress.Resp != ""))
                {
                    ResponseBack<List<Product>> response =
                                   JsonConvert.DeserializeObject<ResponseBack<List<Product>>>(ress.Resp);
                    if (response.Data.Count() > 0)
                    {
                        List<Product> responseObject = response.Data;

                        SResponse ItemCategoryGet = RequestSender.Instance.CallAPI("api",
              "Inventory/ItemCategoryGet", "GET");
                        if (ItemCategoryGet.Status && (ItemCategoryGet.Resp != null) && (ItemCategoryGet.Resp != ""))
                        {
                            ResponseBack<List<ItemCategory>> rescat =
                                JsonConvert.DeserializeObject<ResponseBack<List<ItemCategory>>>(ItemCategoryGet.Resp);
                            if (rescat.Data.Count() > 0)
                            {

                                ViewBag.ItemCategory = rescat.Data;
                            }
                            //ResponseBack<List<ItemCategory>> ResItemCategroy =
                            //             JsonConvert.DeserializeObject<ResponseBack<List<ItemCategory>>>(ItemCategoryGet.Resp);
                            //if (ResItemCategroy.Data.Count() > 0)
                            //{
                            //    ViewBag.ItemCategory = ResItemCategroy.Data;
                            //}
                        }
                        SResponse ItemSubCategoryGet = RequestSender.Instance.CallAPI("api",
              "Inventory/ItemSubCategoryGet", "GET");
                        if (ItemSubCategoryGet.Status && (ItemSubCategoryGet.Resp != null) && (ItemSubCategoryGet.Resp != ""))
                        {
                            ResponseBack<List<ItemSubCategory>> ResSubCategory =
                                             JsonConvert.DeserializeObject<ResponseBack<List<ItemSubCategory>>>(ItemSubCategoryGet.Resp);

                            if (ResSubCategory.Data.Count() > 0)
                            {
                                //List<ItemSubCategory> rep = ResSubCategory.Data;
                                //for (int i = 0; i < rep.Count(); i++)
                                //{
                                //    ItemSubCategory a = new ItemSubCategory();
                                //    a = rep.Where(x => x.CategoryId == ResItemCategroy[i].Id).FirstOrDefault();
                                //    itemSubCategoriesList.Add(a);
                                //}
                                //List<ItemSubCategory> ResSubCategoryObj = ResSubCategory;
                                ViewBag.ItemsubCategory = ResSubCategory.Data;
                            }
                        }
                        return View(responseObject);
                    }
                    else
                    {
                        TempData["response"] = "Server is down.";
                    }
                }
                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult PreviousOrder()
        {
            return View();
        }

        public IActionResult ProductDetail(int id)
        {
            try
            {
                SResponse ress = RequestSender.Instance.CallAPI("api",
             "Inventory/ItemGetByIDWithStock" + "/" + id, "GET");
                if (ress.Status && (ress.Resp != null) && (ress.Resp != ""))
                {
                    var response = JsonConvert.DeserializeObject<ResponseBack<Product>>(ress.Resp);
                    if (response.Data != null)
                    {
                        var responseObject = response.Data;
                        return View(responseObject);
                    }
                    else
                    {
                        TempData["response"] = "Server is down.";
                    }
                }
                return View();
            }
            catch(Exception)
            {
                throw;
            }
        }
        public JsonResult GetEmployerJson()
        {
            try
            {
                SResponse ress = RequestSender.Instance.CallAPI("api",
                 "Inventory/ItemGet", "GET");
                if (ress.Status && (ress.Resp != null) && (ress.Resp != ""))
                {
                    var response = JsonConvert.DeserializeObject<ResponseBack<List<Product>>>(ress.Resp);
                    if (response.Data != null)
                    {
                        var responseObject = response.Data;
                        return Json(responseObject);
                    }
                    else
                    {
                        TempData["response"] = "Unable to get details of Items.";
                        return Json(JsonConvert.DeserializeObject("false."));
                    }
                }
                return Json(JsonConvert.DeserializeObject("false."));
            }
            catch (Exception ex)
            {
                return Json(JsonConvert.DeserializeObject("false." + ex.Message));
            }
        }


    }
}
