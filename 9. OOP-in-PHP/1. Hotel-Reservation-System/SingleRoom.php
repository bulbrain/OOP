<?php
/**
 * Created by PhpStorm.
 * User: Georgi
 * Date: 19.2.2015 г.
 * Time: 20:59
 */

namespace HotelReservationSystem;


class SingleRoom extends  Room {

    var $roomType = RoomType::Standard;
    var $restRoom = true;
    var $balcony = false;
    var $bedCount = 1;
    var $roomNumber;
    var $price;
    var $extras = "TV, air-conditioner";

    public function __construct($roomNumber, $price){
        $this->roomNumber = $roomNumber;
        $this->price = $price;
    }
}