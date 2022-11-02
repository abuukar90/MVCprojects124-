using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCProjects.Data;
using MVCProjects.Models;
using MVCProjects.Services.Interfaces;

namespace MVCProjects.Controllers
{
    public class Class1sController : Controller
    {
        private IClass1sService? _service;

        private static readonly HttpClient client = new HttpClient();

        private string requestUri = "https://localhost:7221/api/Class1s/";

        public Class1sController(IClass1sService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));

            client.DefaultRequestHeaders.Accept.Clear();

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Add("User-Agent", "Jim's API");
        }

        public async Task<IActionResult> Index()
        {
            var response = await _service.FindAll();

            return View(response);
        }

        // GET: Class1s/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var Class1s = await _service.FindOne(id);
            if (Class1s == null)
            {
                return NotFound();
            }

            return View(Class1s);
        }

        // GET: Class1s/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Class1s/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id, player,  teams,  preferdfoot, height, weight, nationailty, position, salary, age")] Class1s class1s)
        {
            class1s.Id = 0;
            var resultPost = await client.PostAsync<Class1s>(requestUri, class1s, new JsonMediaTypeFormatter());

            return RedirectToAction(nameof(Index));
        }

        // GET: Class1s/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var Class1s = await _service.FindOne(id);
            if (Class1s == null)
            {
                return NotFound();
            }

            return View(Class1s);
        }

        // POST: Class1s/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id, player,  teams,  preferdfoot, height, weight, nationailty, position, salary, age")] Class1s class1s)
        {
            if (id != class1s.Id)
            {
                return NotFound();
            }

            var resultPut = await client.PutAsync<Class1s>(requestUri + class1s.Id.ToString(), class1s, new JsonMediaTypeFormatter());
            return RedirectToAction(nameof(Index));
        }

        // GET: Class1s/Delete/5
        public async Task<IActionResult> Delete(int id)

        {
            var Class1s = await _service.FindOne(id);
            if (Class1s == null)
            {
                return NotFound();
            }

            return View(Class1s);
        }

        // POST: Class1s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resultDelete = await client.DeleteAsync(requestUri + id.ToString());
            return RedirectToAction(nameof(Index));
        }
    }
}



























