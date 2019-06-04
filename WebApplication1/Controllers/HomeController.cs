using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {



        public IActionResult Index()
        {
            IndexViewModel indexViewModel = new IndexViewModel();

            return View(indexViewModel);
        }

        public IActionResult Index2()
        {
            Index2ViewModel index2ViewModel = new Index2ViewModel();

            return View(index2ViewModel);
        }

        public IActionResult Error()
        {

            return View();
        }

        public IActionResult Result()
        {
            ResultViewModel resultViewModel = new ResultViewModel();

            resultViewModel.Error = "To add a new shape, please return to the 'Add' page.";



            return View(resultViewModel);
        }

        [HttpPost]
        public IActionResult Result(ResultViewModel resultViewModel)



        {


            if (ModelState.IsValid)
            {

                    Encrypt mess = new Encrypt(resultViewModel.messin);

                    string messone = mess.Messout(resultViewModel.messin);

                    resultViewModel.messout = mess.Messout(messone);

                    return View(resultViewModel);

                }
          

            return Redirect("/Home/Error");
        }

        public IActionResult Result2()
        {
            Result2ViewModel result2ViewModel = new Result2ViewModel();

            result2ViewModel.Error = "To add a new shape, please return to the 'Add' page.";



            return View(result2ViewModel);
        }

        [HttpPost]
        public IActionResult Result2(Result2ViewModel result2ViewModel)



        {


            if (ModelState.IsValid)
            {

                Encrypt mess = new Encrypt(result2ViewModel.decrypt);

                string messone = mess.Decrypt(result2ViewModel.decrypt);

                result2ViewModel.messout = mess.Decrypt(messone);

                return View(result2ViewModel);

            }


            return Redirect("/Home/Error");
        }


    }

}