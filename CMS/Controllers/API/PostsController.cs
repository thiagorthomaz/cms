using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CMS.Controllers.API
{
    public class PostsController : ApiController
    {

        public ApplicationDbContext _context;

        public PostsController() {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetPost(int id)
        {

            var post = _context.Post.SingleOrDefault(p => p.Id == id);
            if (post == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                return Ok(post);
            }

            
        }

        public IHttpActionResult GetPosts() {
            return Ok(_context.Post.ToList());
        }


        [HttpPost]
        public IHttpActionResult CreatePosts(Post post) {

            post.CreatedAt = DateTime.Now;
            post.DeletedAt = null;
            post.UpdatedAt = null;

            /*
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }*/

            _context.Post.Add(post);
            _context.SaveChanges();


            return Created(new Uri(Request.RequestUri + "/" + post.Id), post);

        }

        [HttpPut]
        public IHttpActionResult UpdatePost(int id, Post post) {
            /*
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }*/

            Post postInDb = _context.Post.SingleOrDefault(p => p.Id == id);

            if (postInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            postInDb.PostContent = post.PostContent;
            postInDb.PostSEO = post.PostSEO;
            postInDb.PostSummary = post.PostSummary;
            postInDb.PostTitle = post.PostTitle;
            postInDb.UpdatedAt = DateTime.Now;

            
            _context.Entry(postInDb).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + postInDb.Id), postInDb);

        }


        [HttpDelete]
        public IHttpActionResult DeletePost(int id) {

            Post postInDb = _context.Post.SingleOrDefault(p => p.Id == id);

            if (postInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            postInDb.DeletedAt = DateTime.Now;
            _context.SaveChanges();

            return Ok("Post marked as deleted");
        }

    }
}
