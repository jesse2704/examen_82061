<?php

use App\Poule;
use Illuminate\Database\Seeder;

class PouleSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        factory(Poule::class, 50)->create();
    }
}
