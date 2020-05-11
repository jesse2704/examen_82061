<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Prediction extends Model
{
    protected $fillable = [
        'user_id',
        'country_1',
        'country_2',
        'country_3',
        'country_4',
        'score',
    ];

    protected $hidden = [
        'created_at',
        'updated_at',
    ];
}
