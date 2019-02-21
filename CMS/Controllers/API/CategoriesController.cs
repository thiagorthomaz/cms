using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CMS.Controllers.API
{
    public class CategoriesController : ApiController
    {

        public ApplicationDbContext _context;

        public CategoriesController() {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetCategories(int id)
        {

            var category = _context.Categories.SingleOrDefault(c => c.Id == id);
            if (category == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                return Ok(category);
            }

            
        }

        public IHttpActionResult GetCategories() {
            return Ok(_context.Categories.Where(c => c.DeletedAt == null).ToList());
        }


        [HttpPost]
        public IHttpActionResult CreateCategory(Category category) {

            category.CreatedAt = DateTime.Now;
            category.DeletedAt = null;
            category.UpdatedAt = null;

            /*
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }*/

            _context.Categories.Add(category);
            _context.SaveChanges();


            return Created(new Uri(Request.RequestUri + "/" + category.Id), category);

        }

        [HttpPut]
        public IHttpActionResult UpdateCategory(int id, Category category) {
            /*
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }*/

            Category categoryInDb = _context.Categories.SingleOrDefault(c => c.Id == id);

            if (categoryInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            categoryInDb.Slug = category.Slug;
            categoryInDb.Description = category.Description;
            categoryInDb.Name = category.Name;
            categoryInDb.UpdatedAt = DateTime.Now;

            
            _context.Entry(categoryInDb).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + categoryInDb.Id), categoryInDb);

        }


        [HttpDelete]
        public IHttpActionResult DeleteCategory(int id) {

            Category categoryInDb = _context.Categories.SingleOrDefault(c => c.Id == id);

            if (categoryInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            categoryInDb.DeletedAt = DateTime.Now;
            _context.SaveChanges();

            return Ok("category marked as deleted");
        }

    }
}
