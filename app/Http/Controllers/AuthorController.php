<?php


namespace App\Http\Controllers;

use App\User;
use App\Http\Controllers\Controller;



/**
 * Description of AuthorController
 *
 * @author thiago
 */
class AuthorController extends Controller{
  
  
  public function insert() {
    $user = new User();
    $user->name="Test test";
    $user->email="test@gmail.com";
    $user->email_verified_at=date("Y-m-d H:i:s");
    $user->created_at=date("Y-m-d H:i:s");
    $user->updated_at=date("Y-m-d H:i:s");
    $user->password= md5("teste");
    $user->save();
    
    
  }
  
  
}
