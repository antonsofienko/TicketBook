

INSERT dbo.Cities(Name)
    VALUES ('Hong Kong'),  
	       ('New York'),
		   ('Mumbai'),
		   ('Istanbul'),
		   ('Moscow'),
		   ('Tokyo'),
		   ('Kyiv'),
		   ('London')
GO 


insert dbo.Airplanes( Name, SeatingPlace )
values
('Airbus  A320', 320),
('Airbus  A320', 320),
('Boeing  747', 250),
('Boeing  747', 250),
('Boeing  747', 250),
('Boeing  747', 250),
('Airbus  B-767',150),
('Airbus  B-767',150),
('Airbus  B-767',150),
('Airbus  B-767',150)

Go


INSERT dbo.FLights(AirplaneId, ArivalTime, ArrivalCityId,DepartureCityId, DepartureTime, AvailableTicket1,TicketPrice1,AvailableTicket2,TicketPrice2,AvailableTicket3,TicketPrice3)
VALUES
(3,'05/26/2018 14:23:05',1,2,'05/26/2018 18:23:05',20,100,30,80,40,60)


INSERT dbo.FLights(AirplaneId, ArivalTime, ArrivalCityId,DepartureCityId, DepartureTime, AvailableTicket1,TicketPrice1,AvailableTicket2,TicketPrice2,AvailableTicket3,TicketPrice3)
VALUES
(1,'05/26/2018 14:23:05',1,1,'05/26/2018 18:23:05',20,100,30,80,40,60)