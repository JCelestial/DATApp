using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestionsDataAccess;
using QuestionsDataAccess.Models;
using QuestionsDataAccess.Repository;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;


namespace QuestionsMVC.Controllers
{
    public class QuestionsController : Controller
    {
        private readonly IQuestionRepository _repo;
        public IConfiguration Configuration { get; set; }

        public QuestionsController(IQuestionRepository repo)
        {
            _repo = repo;
        }

        // GET: Questions
        public async Task<ActionResult> GetQuestions()
        {
            var lstModel = await _repo.GetAllQuestions();
            return View(lstModel);
        }

        // GET: Questions/Details/5
        [HttpGet]
        public async Task<ActionResult> GetQuestionById(int id)
        {
            var question = await _repo.GetQuestion(id);
            if (question == null)
            {
                return View("Error");
            }
            return View(question);
        }


        // public async Task GetNextQuestion(QuestionEntity currQuestion)
        // {
        //     int nextId = currQuestion.QuestionId++;
        //     await GetQuestionById(nextId);
        // }

        // // GET: Questions/Create
        // public ActionResult Create()
        // {
        //     return View();
        // }

        // // POST: Questions/Create
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public ActionResult Create(IFormCollection collection)
        // {
        //     try
        //     {
        //         // TODO: Add insert logic here

        //         return RedirectToAction(nameof(Index));
        //     }
        //     catch
        //     {
        //         return View();
        //     }
        // }

        // // GET: Questions/Edit/5
        // public ActionResult Edit(int id)
        // {
        //     return View();
        // }

        // // POST: Questions/Edit/5
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public ActionResult Edit(int id, IFormCollection collection)
        // {
        //     try
        //     {
        //         // TODO: Add update logic here

        //         return RedirectToAction(nameof(Index));
        //     }
        //     catch
        //     {
        //         return View();
        //     }
        // }

        // // GET: Questions/Delete/5
        // public ActionResult Delete(int id)
        // {
        //     return View();
        // }

        // // POST: Questions/Delete/5
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public ActionResult Delete(int id, IFormCollection collection)
        // {
        //     try
        //     {
        //         // TODO: Add delete logic here

        //         return RedirectToAction(nameof(Index));
        //     }
        //     catch
        //     {
        //         return View();
        //     }
        // }
    }
}