using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dojoDachi.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace dojoDachi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if(HttpContext.Session.GetObjectFromJson<DojoDachi>("Dojodachi") == null){
                DojoDachi newDachi = new DojoDachi();
                HttpContext.Session.SetObjectAsJson("Dojodachi", newDachi);
            }
            
            DojoDachi d = HttpContext.Session.GetObjectFromJson<DojoDachi>("Dojodachi");            

            if(!d.Continue()){
                d.winOrLose();
            }

            return View("Index", d);
        }

        [Route("feed")]
        public IActionResult Feed(){
            DojoDachi d = HttpContext.Session.GetObjectFromJson<DojoDachi>("Dojodachi");
            d.Feed();
            HttpContext.Session.SetObjectAsJson("Dojodachi", d);
            
            return Redirect("/");
        }
        [Route("play")]
        public IActionResult Play(){
            DojoDachi d = HttpContext.Session.GetObjectFromJson<DojoDachi>("Dojodachi");
            d.Play();
            HttpContext.Session.SetObjectAsJson("Dojodachi", d);
            return Redirect("/");
        }
        [Route("work")]
        public IActionResult Work(){
            DojoDachi d = HttpContext.Session.GetObjectFromJson<DojoDachi>("Dojodachi");
            d.Work();
            HttpContext.Session.SetObjectAsJson("Dojodachi", d);
            return Redirect("/");
        }
        [Route("sleep")]
        public IActionResult Sleep(){
            DojoDachi d = HttpContext.Session.GetObjectFromJson<DojoDachi>("Dojodachi");
            d.Sleep();
            HttpContext.Session.SetObjectAsJson("Dojodachi", d);
            return Redirect("/");
        }

        [Route("restart")]
        public IActionResult Restart(){
            HttpContext.Session.Clear();
            return Redirect("/");
        }

        [Route("info")]
        public IActionResult Info(){
            // HttpContext.Session.Clear();
            return View("Info");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

// Somewhere in your namespace, outside other classes
    public static class SessionExtensions
    {
        // We can call ".SetObjectAsJson" just like our other session set methods, by passing a key and a value
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            // This helper function simply serializes theobject to JSON and stores it as a string in session
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        
        // generic type T is a stand-in indicating that we need to specify the type on retrieval
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            string value = session.GetString(key);
            // Upon retrieval the object is deserialized based on the type we specified
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }

}
