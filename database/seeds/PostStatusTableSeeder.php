<?php

use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;


class PostStatusTableSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
       $status = array();
       $status[] = array("description" => "Published");
       $status[] = array("description" => "Draft");
       $status[] = array("description" => "Auto-Draft");
       $status[] = array("description" => "Pending");
       $status[] = array("description" => "Trash");
       
       DB::table('post_status') ->insert($status);
    }
}
