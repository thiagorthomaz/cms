<?php

use Illuminate\Support\Facades\Schema;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class CreatePostsFk extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::table('posts', function (Blueprint $table) {
            $table->unsignedInteger('post_author')->change();
            $table->unsignedInteger('post_status')->change();
            $table->unsignedInteger('featured_image')->change();
            $table->foreign('post_author')->references('id')->on('users');
            $table->foreign('post_status')->references('id')->on('post_status');
            $table->foreign('featured_image')->references('id')->on('midia');
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        //
    }
}
