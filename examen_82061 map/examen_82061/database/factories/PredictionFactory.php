<?php

/** @var \Illuminate\Database\Eloquent\Factory $factory */

use App\Prediction;
use App\Country;
use Faker\Generator as Faker;

$factory->define(Prediction::class, function (Faker $faker) {

    $countries = Country::pluck('id')->toArray();   

    return [
        'user_id'   => 1,
        'country_1' => $faker->randomElement($countries),
        'country_2' => $faker->randomElement($countries),
        'country_3' => $faker->randomElement($countries),
        'country_4' => $faker->randomElement($countries),
        'score'     => 0,
    ];
});
