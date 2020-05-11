<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateWinningResultTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('winning_result', function (Blueprint $table) {
            $table->id();
            $table->unsignedBigInteger('first_place');
            $table->unsignedBigInteger('second_place');
            $table->unsignedBigInteger('third_place');
            $table->unsignedBigInteger('fourth_place');
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('winning_result');
    }
}
