<?php

namespace App\Http\Controllers;

use App\PostStatus;
use App\Http\Controllers\Controller;

class PostStatusController extends Controller
{
    
    public function list() {
        
        $posts_status = PostStatus::all();

        return response()->json($posts_status);
        
    }


}