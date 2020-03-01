using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LadaWeb.Models;
using LadaWeb.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using System.Threading;
using System.Net.Mail;
using System.Net;
using Microsoft.Extensions.Localization;
using LadaWeb.Resources;
using Microsoft.Extensions.Configuration;
using LadaWeb.Interfaces;

namespace LadaWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _config;

        public HomeController(LauraWebContext context, IConfiguration config)
        {
            _unitOfWork = new UnitOfWork(context);
            _config = config;
        }

        public IActionResult Index()
        {
            var uiCultureInfo = Thread.CurrentThread.CurrentUICulture;

            if (HttpContext.Session.GetInt32("Language") == null)
            {
                if (uiCultureInfo.Name == "es-ES")
                {
                    HttpContext.Session.SetInt32("Language", 1);
                }
                else
                {
                    HttpContext.Session.SetInt32("Language", 2);
                }
            }

            var idLanguage = (Int32)HttpContext.Session.GetInt32("Language");

            var model = new HomeModel
            {
                Categories = _unitOfWork.Categories.GetCategoriesByLanguage(idLanguage).ToList(),
                Home = _unitOfWork.Home.GetHomeByLanguage(idLanguage),
                About = _unitOfWork.About.GetAboutByLanguage(idLanguage),
                Experiences = _unitOfWork.Experiences.GetExperiencesByLanguage(idLanguage).ToList(),
                SocialNetworks = _unitOfWork.SocialNetworks.GetAll().ToList()
            };

            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public ActionResult Spanish()
        {
            HttpContext.Session.SetInt32("Language", 1);
            HttpContext.Session.SetString("CultureWeb", "es-ES");

            //HttpContext.Response.Cookies.Append(
            // CookieRequestCultureProvider.DefaultCookieName,
            // CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(new CultureInfo("es-ES"))),
            // new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });

            return Redirect("/es-ES");
        }

        [HttpPost]
        public ActionResult English()
        {
            HttpContext.Session.SetInt32("Language", 2);
            HttpContext.Session.SetString("CultureWeb", "en-US");

            //HttpContext.Response.Cookies.Append(
            //CookieRequestCultureProvider.DefaultCookieName,
            //CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(new CultureInfo("en-US"))),
            //new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });

            return Redirect("/en-US");
        }

        [HttpPost]
        public ActionResult French()
        {
            HttpContext.Session.SetInt32("Language", 3);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult ContactMe(ContactModel model)
        {
            var configSection = _config.GetSection("SMTP");
            SmtpClient client = new SmtpClient(configSection.GetSection("Server").Value)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(configSection.GetSection("Email").Value, configSection.GetSection("Password").Value)
            };

            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress(model.Email)
            };
            mailMessage.To.Add(configSection.GetSection("DestinationEmail").Value);
            mailMessage.Body = model.Message;
            mailMessage.Subject = $"Nueva solicitud de contacto de {model.Name}, Telefono {model.Phone}";

            client.Send(mailMessage);

            return RedirectToAction("Index");
        }
    }
}
