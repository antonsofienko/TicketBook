

INSERT dbo.Cities(id,Name)
    VALUES (NEWID ( ) ,'Hong Kong'),  
	       (NEWID ( ) ,'New York'),
		   (NEWID ( ) ,'Mumbai'),
		   (NEWID ( ) ,'Istanbul'),
		   (NEWID ( ) ,'Moscow'),
		   (NEWID ( ) ,'Tokyo'),
		   (NEWID ( ) ,'Kyiv'),
		   (NEWID ( ) ,'London')
GO 


insert dbo.Airplanes( Id, Name, SeatingPlace )
values
(NEWID ( ) ,'Airbus  A320', 320),
(NEWID ( ) ,'Airbus  A320', 320),
(NEWID ( ) ,'Boeing  747', 250),
(NEWID ( ) ,'Boeing  747', 250),
(NEWID ( ) ,'Boeing  747', 250),
(NEWID ( ) ,'Boeing  747', 250),
(NEWID ( ) ,'Airbus  B-767',150),
(NEWID ( ) ,'Airbus  B-767',150),
(NEWID ( ) ,'Airbus  B-767',150),
(NEWID ( ) ,'Airbus  B-767',150)

Go


INSERT dbo.FLights( ArivalTime, ArrivalCityId,DepartureCityId, DepartureTime, AvailableTicket1,TicketPrice1,AvailableTicket2,TicketPrice2,AvailableTicket3,TicketPrice3)
VALUES
('05/26/2018 14:23:05',1,2,'05/26/2018 18:23:05',20,100,30,80,40,60)


INSERT dbo.FLights(  Id, AirplaneId,ArivalTime, ArrivalCityId,DepartureCityId, DepartureTime, AvailableTicket1,TicketPrice1,AvailableTicket2,TicketPrice2,AvailableTicket3,TicketPrice3)
VALUES
(NEWID (),'69014bf4-d47c-4209-8613-00b8abbfaad9','05/26/2018 14:23:05','c15a3bf3-c4ba-491a-89bb-161da0fdd63b','4f9fd5c2-4ae9-438d-8f36-3d0117376f62','05/26/2018 18:23:05',20,100,30,80,40,60)