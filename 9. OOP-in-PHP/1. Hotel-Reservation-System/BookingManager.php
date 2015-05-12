<?php

namespace HotelReservationSystem;
include("Room.php");
include("SingleRoom.php");
include("Apartment.php");
include("Bedroom.php");
include("Guest.php");
include("Reservation.php");

class BookingManager {

    public static function bookRoom($room, $reservation)
    {
        if($reservation-> isFree)
        {
            echo "Room <strong>" . $room->roomNumber . "</strong> successfully booked for <strong>" . $reservation->guest
            . "</strong> from <time>" .  date('d.m.Y', $reservation->startDate) . "</time> to <time>" . date('d.m.Y', $reservation->endDate) . "</time>!";
        }
        else
        {
            echo "Cant book room <strong>" . $room->roomNumber . "</strong> it is reserved by <strong>" . $reservation->guest
                . "</strong> from <time>" .  date('d.m.Y', $reservation->startDate) . "</time> to <time>" . date('d.m.Y', $reservation->endDate) . "</time>!";
        }
    }
}

$room = new SingleRoom(1408, 99);
$guest = new Guest("Svetlin", "Nakov", 8003224277);
$startDate = strtotime("24.10.2014");
$endDate = strtotime("26.10.2014");
$reservation = new Reservation($startDate, $endDate, $guest);
BookingManager::bookRoom($room, $reservation);