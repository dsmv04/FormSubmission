﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers;


    public class HomeController : Controller

    {

        [HttpGet("")]

        public ViewResult Index()

        {

            return View();

        }

        [HttpPost("submit")]

        public IActionResult Submit(Submitter user)

        {

            if(ModelState.IsValid)

            {

                return RedirectToAction("Success");

            }

            return View("Index");

        }

        [HttpGet("success")]

        public ViewResult Success()

        {

            return View();

        }

    }

