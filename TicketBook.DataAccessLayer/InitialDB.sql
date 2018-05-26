

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


INSERT dbo.FLights(AirplaneId, ArivalTime, ArrivalCityId,AvaliableTicket,DepartureCityId, DepartureTime)
VALUES
(0,'05/26/2018 14:23:05',1,1,2,'05/26/2018 18:23:05')


INSERT dbo.FLights(AirplaneId, ArivalTime, ArrivalCityId,AvaliableTicket,DepartureCityId, DepartureTime)
VALUES
(0,'05/26/2018 14:23:05',1,1,2,'05/26/2018 18:23:05')