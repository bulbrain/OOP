<?php

namespace HotelReservationSystem;
include ("iReservable.php");

class Room {// implements iReservable {

    public $roomInfo;
    public $reservations;

}

abstract class RoomType {

    const Standard = "Standard";
    const Gold = "Gold";
    const Diamond = "Diamond";
}