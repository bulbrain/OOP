<?php
/**
 * Created by PhpStorm.
 * User: Georgi
 * Date: 19.2.2015 г.
 * Time: 21:01
 */

namespace HotelReservationSystem;


class Bedroom extends Room{

    var $roomType = RoomType::Gold;
    var $restRoom = true;
    var $balcony = true;
    var $bedCount = 2;
    var $roomNumber;
    var $price;
    var $extras = "TV, air-conditioner, refrigerator, mini-bar, bathtub";

    public function __construct($roomNumber, $price){
        $this->roomNumber = $roomNumber;
        $this->price = $price;
    }
}