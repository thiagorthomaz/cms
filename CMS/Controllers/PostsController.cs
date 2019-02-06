using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS.Controllers
{
    public class PostsController : Controller
    {

        public ApplicationDbContext _context;

        public PostsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Posts
        public ActionResult Index()
        {
            var posts = _context.Post.ToList();

            return View(posts);
        }


        // GET: Add View
        public ActionResult Add()
        {
            return View("FormPost", new Post());
        }


        // GET: Add View
        public ActionResult Edit(int id)
        {
            var post = _context.Post.SingleOrDefault(p => p.Id == id);
            return View("FormPost", post);
        }

    }
}