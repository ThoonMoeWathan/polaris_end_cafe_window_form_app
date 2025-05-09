//SQL QUERY
//db name="service_db"

Create Table CustomerInfo
(
       CustomerID varchar(10) not null primary key,
   CustomerName varchar(30),
   UserName varchar(30),
   Password varchar(30),
   EmailAddress varchar(30),
   PhoneNumber varchar(30),
   Address varchar(50),
);
Create Table AdminInfo
(
       AdminID varchar(10) not null primary key,
   AdminName varchar(30),
   UserName varchar(30),
   Password varchar(30),
   EmailAdds varchar(30),
   PhoneNum varchar(30),
   Address varchar(50),
);
Create Table Service
(
       serviceID varchar(10) not null primary key,
   serviceName varchar(30),
   serviceTypeID varchar(10),
   price int,
   ServiceImage text,
   Description varchar(100),
   Foreign Key (ServiceTypeID) References ServiceType (ServiceTypeID),
)
Create Table ServiceType
(
       serviceTypeID varchar(10) not null primary key,
   servicetypename varchar(30),
)
Create Table Booking
(
       BookingID varchar(20)not null primary key,
   BookingDate varchar(30),
   ServiceBookingDate date,
   CustomerID varchar(10),
   TotalService int,
   TotalPrice int,
   TotalQuantity int,
   BookingStatus varchar(20),
   Foreign Key (CustomerID) References CustomerInfo (CustomerID),
)
Create Table BookingDetail
(
       BookingID varchar(20),
   ServiceID varchar(10),
   UnitService int,
   UnitPrice int,
   Foreign Key (BookingID) References Booking(BookingID),
   Foreign Key (ServiceID) References Service(ServiceID),
)
Create Table Review
(
       ReviewID varchar(10) not null primary key,
   Review varchar(100),
   CustomerID varchar(10),
   Foreign Key (CustomerID) References CustomerInfo(CustomerID),
)
select * from CustomerInfo
select * from AdminInfo
select * from ServiceType
select * from Service
select * from ViewService
select * from BookingDetail
select * from Review

delete from CustomerInfo
delete from AdminInfo
delete from ServiceType
delete from BookingDetail
delete from Review

drop table CustomerInfo
drop table ServiceType
drop table Service
drop table Booking
drop table BookingDetail
drop table Review

insert into AdminInfo values('A_001','Thoon Moe Wathan','TMW','tmw','tmw@gmail.com','08-36254265','Yangon')
