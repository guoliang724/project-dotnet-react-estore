using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        [HttpGet("not-found")]
        public ActionResult GetNotFound()
        {
            return NotFound();
        }

        [HttpGet("bad-request")]
        public ActionResult GetBadRequest()
        {
            var problemDetail = new ProblemDetails { Title = "This is a bed request" };
            return BadRequest(problemDetail);
        }


        [HttpGet("unauthorized")]
        public ActionResult GetUnauthorized()
        {
            var problemDetail = new ProblemDetails { Title = "you are unauthroized" };
            return Unauthorized(problemDetail);
        }


        [HttpGet("validation-error")]
        public ActionResult GetValidationError()
        {
            ModelState.AddModelError("Problem1", "this is a the first error");
            ModelState.AddModelError("Problem2", "this is a the seconde error");
            return ValidationProblem();
        }

        [HttpGet("server-error")]
        public ActionResult GetServerError()
        {
            throw new Exception("this is a server error");
        }

        [HttpGet("forbidden")]
        public ActionResult GetForbidden()
        {
            var problemDetail = new ProblemDetails { Title = "you are forbidden" };

            return Forbid("you are forbbiden");
        }
    }
}