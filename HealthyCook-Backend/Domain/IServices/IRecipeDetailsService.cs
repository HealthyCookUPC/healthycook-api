﻿using HealthyCook_Backend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyCook_Backend.Domain.IServices
{
    public interface IRecipeDetailsService
    {
        Task SaveRecipeDetails(RecipeDetails recipeDetails);
        Task<RecipeDetails> GetRecipeDetails(int recipeID);

        Task<RecipeDetails> SearchRecipeDetails(int recipeID);
    }
}
