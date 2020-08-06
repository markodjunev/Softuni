import { beginRequest, endRequest, showError } from './notification.js';
import API from './api.js';

const endpoints = {
    RECIPES: 'data/recipes',
    RECIPE_BY_ID: 'data/recipes/'
};

const api = new API(
    '7E8DB985-6617-E7CE-FF68-AC43D120EF00',
    'F351EA89-2253-4F06-B5FB-90089764C6FA',
    beginRequest,
    endRequest
);

export const login = api.login.bind(api);
export const register = api.register.bind(api);
export const logout = api.logout.bind(api);

//get all recipes
export async function getAll() {
    return api.get(endpoints.RECIPES);
}

//create recipe
export async function createRecipe(recipe) {
    return api.post(endpoints.RECIPES, recipe);
}

//get recipe by id
export async function getRecipeById(id) {
    return api.get(endpoints.RECIPE_BY_ID + id);
}

//edit recipe by id
export async function editRecipe(id, recipe) {
    return api.put(endpoints.RECIPE_BY_ID + id, recipe);
}

//delete recipe by id
export async function deleteRecipe(id){
    return api.delete(endpoints.RECIPE_BY_ID + id);
}

//like recipe by id
export async function likeRecipe(id) {
    const recipe = await getRecipeById(id);

    return editRecipe(id, { likesCounter: recipe.likesCounter + 1 });
}

export function checkResult(result){
    if (result.hasOwnProperty('errorData')) {
        const error = new Error();
        Object.assign(error, result);
        throw error;
    }
}