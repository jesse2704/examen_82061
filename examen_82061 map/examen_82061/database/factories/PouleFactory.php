<?php

/** @var \Illuminate\Database\Eloquent\Factory $factory */

use App\Poule;
use App\Prediction;
use App\User;
use Faker\Generator as Faker;

$factory->define(Poule::class, function (Faker $faker) {

    $users = User::pluck('id')->toArray();
    $predictions = Prediction::pluck('id')->toArray();   
    
    return [
        'user_id'         => $faker->randomElement($users),
        'name'            =>  User::find($users)->pluck('name'),
        'prediction_1_id' => $faker->randomElement($predictions),
        'prediction_2_id' => $faker->randomElement($predictions),
        'prediction_3_id' => $faker->randomElement($predictions),
        'prediction_4_id' => $faker->randomElement($predictions),
        'final_result'    => 0,
    ];
});
