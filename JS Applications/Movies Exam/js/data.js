import { beginRequest, endRequest, showError } from './notification.js';
import API from './api.js';

const endpoints = {
    MOVIES: 'data/movies',
    MOVIE_BY_ID: 'data/movies/'
};

const api = new API(
    'DEE257E4-1411-83B9-FF6F-A2B15599C700',
    'C75F21B9-EC01-48D4-876E-611C577728D7',
    beginRequest,
    endRequest
);

export const login = api.login.bind(api);
export const register = api.register.bind(api);
export const logout = api.logout.bind(api);

//get all movies
export async function getAll() {
    return api.get(endpoints.MOVIES);
}

//create movie
export async function createMovie(movie) {
    return api.post(endpoints.MOVIES, movie);
}

//get movie by id
export async function getMovieById(id) {
    return api.get(endpoints.MOVIE_BY_ID + id);
}

//edit movie by id
export async function editMovie(id, movie) {
    return api.put(endpoints.MOVIE_BY_ID + id, movie);
}

//delete movie by id
export async function deleteMovie(id){
    return api.delete(endpoints.MOVIE_BY_ID + id);
}

//like movie by id
export async function likeMovie(id) {
    const movie = await getMovieById(id);

    return editMovie(id, { likes: movie.likes + 1 });
}

export function checkResult(result){
    if (result.hasOwnProperty('errorData')) {
        const error = new Error();
        Object.assign(error, result);
        throw error;
    }
}