﻿using CodePulse.API.Data;
using CodePulse.API.Models.Domain;
using CodePulse.API.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodePulse.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriesController : ControllerBase
	{
		private readonly ApplicationDbContext dbContext;

		public CategoriesController(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}
		[HttpPost]
		public async Task<IActionResult> CreateCategory(CreateCategoryRequestDTO request)
		{
			// map dto to domain model
			var category = new Category
			{
				Name = request.Name,
				UrlHandle = request.UrlHandle
			};

			

			//domain model to DTO

			var response = new CategoryDto
			{
				Id = category.Id,
				Name = category.Name,
				UrlHandle = category.UrlHandle
			};
			return Ok(response);



		}

	}
}
