# TruckManagmentService
This is a small console application in c# .NetCore6, to handle some functionality related to 
truckPlan managment service.

## Domain Models 

 - `Driver` - The Driver class represents a driver who can drive a truck
 - `Truck` - The Truck class represents a vehicle used for transportation, equipped with a GPS device that provides its current position approximately every 5 minutes.
 - `GpsCoordinate` - The GpsCoordinate class represents a geographic coordinate with properties such as Latitude and Longitude.
 - `TruckPlan`  - The TruckPlan class represents a desciprion of plan for a driver, driving a truck for a continuous period.

## Functionalities

 - `DistanceCalculator.CalculateDistanceInKilometersForASingleTruckPlan` - To calculate the approximate distance driven for a single TruckPlan.
 - `GeoService.GetCountryNameAsync` - To get the countryName from a GPS coordinate. Currently use http://api.positionstack.com/v1 api, which can be replace with googlemapAPI
 - `TripService.GetTotalDistanceDrivenByDriversOver50InGermanyInFebruary2018Async` - To get total kilometers that drivers over the age of 50 drive in Germany in February 2018 drove


## TODO list
- Error handling : handle exceptions and return appropriate error messages to the client in case of failure.
- Test coverage : add more tests to cover more scenarios and to ensure that the methods are robust and scalable.write additional tests to cover various scenarios.
- Logging : to track the API's usage and to debug any issues
- Documentation : provide comprehensive documentation in code



