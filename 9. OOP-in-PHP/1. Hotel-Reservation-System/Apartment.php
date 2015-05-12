<?php
/**
 * Created by PhpStorm.
 * User: Georgi
 * Date: 19.2.2015 г.
 * Time: 21:01
 */

namespace HotelReservationSystem;


class Apartment extends Room {

    var $roomType = RoomType::Diamond;
    var $restRoom = true;
    var $balcony = true;
    var $bedCount = 4;
    var $roomNumber;
    var $price;
    var $extras = "TV, air-conditioner, refrigerator, kitchen box, mini-bar, bathtub, free Wi-fi";

    public function __construct($roomNumber, $price){
        $this->roomNumber = $roomNumber;
        $this->price = $price;
    }
}