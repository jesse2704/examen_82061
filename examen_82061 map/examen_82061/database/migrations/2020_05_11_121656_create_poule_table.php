<?php
 
use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreatePouleTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('poules', function (Blueprint $table) {
            $table->id();
            $table->integer('user_id');
            $table->string('name');
            $table->unsignedBigInteger('prediction_1_id');
            $table->unsignedBigInteger('prediction_2_id');
            $table->unsignedBigInteger('prediction_3_id');
            $table->unsignedBigInteger('prediction_4_id');
            $table->integer('final_result');
            $table->timestamps();

            $table->foreign('prediction_1_id')->references('id')->on('predictions')->onDelete('cascade');
            $table->foreign('prediction_2_id')->references('id')->on('predictions')->onDelete('cascade');
            $table->foreign('prediction_3_id')->references('id')->on('predictions')->onDelete('cascade');
            $table->foreign('prediction_4_id')->references('id')->on('predictions')->onDelete('cascade');
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('poule');
    }
}
