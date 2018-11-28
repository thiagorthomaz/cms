<?php

namespace App\Http\Controllers;

use App\Post;
use App\Http\Controllers\Controller;

class PostController extends Controller
{
        
    public function show() {
        $posts = Post::all();
        return response()->json($posts);
    }

    public function insert() {
      
      $post = new Post();
      $post->post_author = 1;
      $post->post_status = 1;
      $post->created_at = date("Y-m-d H:i:s");
      $post->updated_at = date("Y-m-d H:i:s");
      $post->post_title = md5(date("Y-m-d H:i:s"));
      $post->post_content = md5(date("Y-m-d H:i:s")) . md5(date("Y-m-d H:i:s")) . md5(date("Y-m-d H:i:s")) . md5(date("Y-m-d H:i:s"));
      $post->post_sumary = md5(date("Y-m-d H:i:s"));
      $post->post_seo = md5(date("Y-m-d H:i:s"));
      $post->save();
      
    }
    
    public function delete($id) {
        
        $destroyed = PostStatus::destroy($id);
        var_dump($destroyed);

    }
    
}