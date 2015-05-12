<?php
/**
 * Created by PhpStorm.
 * User: Georgi
 * Date: 19.2.2015 г.
 * Time: 21:32
 */

namespace HotelReservationSystem;


class Guest {

    var $firstName;
    var $lastName;
    var $id;

    public function __construct($firstName, $lastName, $id){
        $this->firstName = $firstName;
        $this->lastName = $lastName;
        $this->id = $id;
    }

    public function __toString()
    {
        return $this->firstName . " " . $this->lastName;
    }
}