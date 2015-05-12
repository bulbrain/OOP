<?php
/**
 * Created by PhpStorm.
 * User: Georgi
 * Date: 19.2.2015 г.
 * Time: 21:33
 */

namespace HotelReservationSystem;


class Reservation {

    var $startDate;
    var $endDate;
    var $guest;
    var $isFree = true;

    public function __construct($startDate, $endDate, $guest) {
        $this->startDate = $startDate;
        $this->endDate = $endDate;
        $this->guest = $guest;
        $isFree = false;
    }
}