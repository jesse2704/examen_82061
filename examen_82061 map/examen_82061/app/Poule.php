<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Poule extends Model
{
    protected $fillable = [
        'user_id',
        'name',
        'prediction_1_id',
        'prediction_2_id',
        'prediction_3_id',
        'prediction_4_id',
        'final_result',
    ];

    protected $hidden = [
        'created_at',
        'updated_at',
    ];
}
