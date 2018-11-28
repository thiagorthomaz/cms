<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', function () {
    return view('welcome');
});


Route::get('postStatus', 'PostStatusController@show');


Route::get('user', 'AuthorController@insert');

Route::get('post', 'PostStatusController@show');
Route::get('postInsert', 'PostController@insert');
Route::put('postPut', 'PostController@update');
Route::delete('postDelete/{id}', 'PostController@delete');