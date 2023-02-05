using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index(){
            //ViewBag
            //Model
            //ViewData

            var product = new Product(){Name="Iphone X",Price=6000,Description="güzel telefon"};

            // ViewData["Category"] = "Telefonlar";
            // ViewData["Product"] = product;


            ViewBag.Category = "Telefonlar";
            // ViewBag.Product = product;

            return View(product);
        }

         // localhost:5000/product/list
        public IActionResult list(){

            var products = new List<Product>(){
                new Product(){Name="Iphone 7",Price=3000,Description="iyi telefon",IsApproved=false},
                new Product(){Name="Iphone 8",Price=5000,Description="çok iyi telefon",IsApproved=true},
                new Product(){Name="Iphone X",Price=7000,Description="çok iyi telefon",IsApproved=true},
                new Product(){Name="Iphone 11",Price=8000,Description="çok iyi telefon",IsApproved=false},
            };
            
            var category = new Category(){Name="Telefonlar",Description="Telefon Kategorisi"};

            
            var productViewModel = new ProductViewModel(){Category=category,Products=products};

            return View(productViewModel);
        }

        // localhost:5000/product/details
        public IActionResult Details(int id){

            // ViewBag.Name = "Samsung S6";
            // ViewBag.Price = 3000;
            // ViewBag.Description = "iyi telefon";

            var p = new Product();
            p.Name="Samsung S6";
            p.Price = 3000;
            p.Description = "iyi telefon";


            return View(p);
        }
    }
}