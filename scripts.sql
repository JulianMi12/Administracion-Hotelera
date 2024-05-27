-- TABLES
create table hotels (
	id INT AUTO_INCREMENT PRIMARY KEY,
    name varchar(30),
    city varchar(30),
    status bool
);

create table rooms (
	id INT AUTO_INCREMENT PRIMARY KEY,
    id_hotel int,
    status bool,
    value float,
    tax float,
    type varchar(30),
    capacity int,
    location varchar(30)
);
ALTER TABLE rooms
add constraint HOTEL_ROOM_FK FOREIGN KEY(id_hotel)
REFERENCES hotels(id);

create table passenger (
	id int PRIMARY KEY,
    first_name varchar(30),
    last_name varchar(30),
    date_birth datetime,
    gender varchar(30),
    type_doc varchar(30),
    email varchar(50),
    phone varchar(30),
    emergency_contact varchar(200)
);

create table bookings (
	id INT AUTO_INCREMENT PRIMARY KEY,
    id_hotel int,
    id_room int,
    id_passenger int,
    date_start datetime,
    date_end datetime
);
ALTER TABLE bookings
add constraint BOOKING_HOTEL_FK FOREIGN KEY(id_hotel)
REFERENCES hotels(id);
ALTER TABLE bookings
add constraint BOOKING_ROOM_FK FOREIGN KEY(id_room)
REFERENCES rooms(id);
ALTER TABLE bookings
add constraint HOTEL_PASSENGER_FK FOREIGN KEY(id_passenger)
REFERENCES passenger(id);

create table users (
	id INT AUTO_INCREMENT PRIMARY KEY,
    username varchar(100),
    password varchar(100)
);
