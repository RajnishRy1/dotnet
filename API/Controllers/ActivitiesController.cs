﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Controllers;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API;

public class ActivitiesController(DataContext context) : BaseApiController
{
    private readonly DataContext _context = context;
    [HttpGet]
    public async Task<ActionResult<List<Activity>>> GetActivities()
    {
        return await _context.Activities.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Activity>> GetActivity(Guid id){

        return await _context.Activities.FindAsync(id);
    }
}
