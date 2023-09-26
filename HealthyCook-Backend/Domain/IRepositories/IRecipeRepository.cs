﻿using HealthyCook_Backend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyCook_Backend.Domain.IRepositories
{
    public interface IRecipeRepository
    {

        Task CreateRecipe(Recipe recipe);
        Task DeleteRecipe(Recipe recipe);
        Task<Recipe> GetRecipeByID(int recipeID);
        Task<Recipe> ChangePublicationStatus(int recipeID);
        Task<int> GetNumberOfRecipes();
        Task<List<Recipe>> GetListRecipes();
        Task<List<Recipe>> GetTodaysRecipes(string date);
        Task<List<Recipe>> GetLastFiveRecipes();
        Task<List<Recipe>> GetListRecipesPublishedByUser(int userID);
        Task<List<Recipe>> GetListRecipesNoPublishedByUser(int userID);
        Task<List<Recipe>> SearchRecipeByIngredient(string ingredient, string excludedIngredient);
        Task<List<Recipe>> SearchRecipeBetweenDates(string startDate, string endDate);
        Task<List<Recipe>> SearchRecipeByDifficulty(string difficulty);
        Task<List<Recipe>> SearchRecipeByName(string name);
        Task<List<Recipe>> SearchRecipeByCalories(int calories);
        Task<List<Recipe>> SearchRecipeByCategory(string category);


    }
}
