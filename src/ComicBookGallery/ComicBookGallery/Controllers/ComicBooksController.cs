﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            var ComicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus'" +
                               " life and his one, last, great act of revenge! Even if Spider-Man survives... " +
                               "<strong>will Peter Parker?</strong></p>",

                Artists = new Artists[]
                {
                    new Artists() {Name ="Dan Slott" , Role ="Script"},
                     new Artists() {Name ="Humberto Ramos" , Role ="Pencils"},
                      new Artists() {Name ="Victor Olazaba" , Role ="Inks"},
                       new Artists() {Name ="Edgar Delgado" , Role ="Colors"},
                        new Artists() {Name ="Chris Eliopoulos" , Role ="Letters"},
                }
            };

            //ViewBag.SeriesTitle = "The Amazing Spider-man";
            //ViewBag.IssueNumber = 700;
            //ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus'" +
            //                   " life and his one, last, great act of revenge! Even if Spider-Man survives... " +
            //                   "<strong>will Peter Parker?</strong></p>";
            //ViewBag.Artists = new string[]
            //{
            //    "Script: Dan Slott",
            //    "Pencils: Humberto Ramos",
            //    "Inks: Victor Olazaba",
            //    "Colors: Edgar Delgado",
            //    "Letters: Chris Eliopoulos"
            //};
        
            return View(ComicBook);

        }
    }
}