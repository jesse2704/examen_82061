<?php

use App\Country;
use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreatePredictionTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('predictions', function (Blueprint $table) {
            $table->id();
            $table->unsignedBigInteger('user_id');
            $table->unsignedBigInteger('country_1');
            $table->unsignedBigInteger('country_2');
            $table->unsignedBigInteger('country_3');
            $table->unsignedBigInteger('country_4');
            $table->string('score');
            $table->timestamps();

            $table->foreign('user_id')->references('id')->on('users');
            $table->foreign('country_1')->references('id')->on('countries')->onDelete('cascade');
            $table->foreign('country_2')->references('id')->on('countries')->onDelete('cascade');
            $table->foreign('country_3')->references('id')->on('countries')->onDelete('cascade');
            $table->foreign('country_4')->references('id')->on('countries')->onDelete('cascade');
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('predictions');
    }
}
