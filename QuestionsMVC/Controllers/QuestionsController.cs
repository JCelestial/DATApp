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
using QuestionsMVC.Models;


namespace QuestionsMVC.Controllers
{
    public class QuestionsController : Controller
    {
        #region Constructor
        private readonly IQuestionRepository _repo;
        public IConfiguration Configuration { get; set; }

        public QuestionsController(IQuestionRepository repo)
        {
            _repo = repo;
        }
        #endregion

        // GET: Questions
        public async Task<ActionResult> GetQuestions()
        {
            try
            {
                var lstModel = await _repo.GetAllQuestions();
                if (lstModel == null)
                {
                    return View("Error");
                }
                return View(lstModel);
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Questions/Details/5
        // [HttpGet]
        // public async Task<ActionResult> GetQuestionById(int currId)
        // {
        //     try
        //     {
        //         var question = await _repo.GetQuestion(currId);
        //             if (question != null)
        //             {
        //                 return View(question);
        //             }
        //             return View("Error");
        //     }
        //     catch
        //     {
        //         return View("Error");
        //     }
        // }

        [HttpGet]
        public async Task<ActionResult> GetQuestionById(Traversal trav)
        {
            try
            {
                var question = await _repo.GetQuestion(trav);
                if (question != null)
                {
                    return View(question);
                }
                return View("Error");
            }
            catch
            {
                return View("Error");
            }
        }


    }
}