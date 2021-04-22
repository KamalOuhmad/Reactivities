
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using Persistence;
using domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext __context;
        public ActivitiesController(DataContext context)
        {
            __context = context;
           
        }

        [HttpGet]

        public async Task<ActionResult<List<Activity>>>GetActivities()
        {
          return await __context.Activities.ToListAsync();
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<Activity>>GetActivity(Guid id)
        {
          return await __context.Activities.FindAsync(id);
        }
    }
}