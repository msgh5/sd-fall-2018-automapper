using AutoMapper;
using AutoMapper.QueryableExtensions;
using MappingProperties.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MappingProperties.Controllers
{
    public class PeopleController : Controller
    {
        private readonly ApplicationDbContext Context;

        public PeopleController()
        {
            Context = new ApplicationDbContext();
        }

        // GET: People
        public ActionResult Index()
        {
            var model = Context
                            .People
                            .ProjectTo<PersonIndexViewModel>()
                            .ToList();

            //var querySyntax = (from people in Context.People
              //            select people).ProjectTo<PersonIndexViewModel>();

            //var model = Mapper.Map<List<PersonIndexViewModel>>(people);

            //var model = Context
            //    .People
            //    .Select(p => new PersonIndexViewModel
            //    {
            //        Id = p.Id,
            //        Created = p.DateCreated,
            //        FirstName = p.FirstName,
            //        LastName = p.LastName
            //    }).ToList();

            return View(model);
        }
    }
}