# SQL Practice – Vehicle Database (All Problems & Solutions)

## Problem 1: Create Master Vehicle Details View
CREATE VIEW MasterVehicalDetealis AS
SELECT 
    vd.ID, vd.MakeID, m.Make,
    vd.ModelID, mm.ModelName,
    vd.SubModelID, sm.SubModelName,
    vd.BodyID, b.BodyName,
    vd.Vehicle_Display_Name,
    vd.Year,
    vd.DriveTypeID, dt.DriveTypeName,
    vd.Engine, vd.Engine_CC,
    vd.Engine_Cylinders,
    vd.Engine_Liter_Display,
    vd.FuelTypeID, ft.FuelTypeName,
    vd.NumDoors
FROM VehicleDetails vd
INNER JOIN Makes m ON vd.MakeID = m.MakeID
INNER JOIN MakeModels mm ON m.MakeID = mm.MakeID
INNER JOIN SubModels sm ON mm.ModelID = sm.ModelID
INNER JOIN Bodies b ON vd.BodyID = b.BodyID
INNER JOIN DriveTypes dt ON vd.DriveTypeID = dt.DriveTypeID
INNER JOIN FuelTypes ft ON vd.FuelTypeID = ft.FuelTypeID;

## Problem 2: Vehicles between 1950 and 2000
SELECT * FROM VehicleDetails WHERE Year BETWEEN 1950 AND 2000;

## Problem 3: Count vehicles between 1950 and 2000
SELECT COUNT(*) FROM VehicleDetails WHERE Year BETWEEN 1950 AND 2000;

## Problem 4: Vehicles per make (1950–2000)
SELECT m.Make, COUNT(*) 
FROM VehicleDetails v
JOIN Makes m ON v.MakeID = m.MakeID
WHERE Year BETWEEN 1950 AND 2000
GROUP BY m.Make
ORDER BY COUNT(*) DESC;

## Problem 5: Makes > 12000 vehicles
SELECT m.Make, COUNT(*) 
FROM VehicleDetails v
JOIN Makes m ON v.MakeID = m.MakeID
WHERE Year BETWEEN 1950 AND 2000
GROUP BY m.Make
HAVING COUNT(*) > 12000;

## Problem 6: Vehicles + total
SELECT m.Make,
COUNT(*) AS NumberOfVehicles,
(SELECT COUNT(*) FROM VehicleDetails) AS TotalVehicles
FROM VehicleDetails v
JOIN Makes m ON v.MakeID=m.MakeID
WHERE Year BETWEEN 1950 AND 2000
GROUP BY m.Make;

## Problem 7: Percentage per make
SELECT *, 
CAST(NumberOfVehicle AS FLOAT)/CAST(TotalVehicle AS FLOAT) AS Percentage
FROM (
    SELECT m.Make, COUNT(*) NumberOfVehicle,
    (SELECT COUNT(*) FROM VehicleDetails) TotalVehicle
    FROM VehicleDetails v
    JOIN Makes m ON v.MakeID=m.MakeID
    WHERE Year BETWEEN 1950 AND 2000
    GROUP BY m.Make
) r;

## Problem 8: Fuel type per make
SELECT m.Make, f.FuelTypeName, COUNT(*)
FROM VehicleDetails v
JOIN Makes m ON v.MakeID=m.MakeID
JOIN FuelTypes f ON v.FuelTypeID=f.FuelTypeID
GROUP BY m.Make,f.FuelTypeName;

## Problem 9: GAS vehicles
SELECT v.*, f.FuelTypeName
FROM VehicleDetails v
JOIN FuelTypes f ON v.FuelTypeID=f.FuelTypeID
WHERE f.FuelTypeName='GAS';

## Problem 10: Makes with GAS
SELECT DISTINCT m.Make
FROM VehicleDetails v
JOIN Makes m ON v.MakeID=m.MakeID
JOIN FuelTypes f ON v.FuelTypeID=f.FuelTypeID
WHERE f.FuelTypeName='GAS';

## Problem 11: Total GAS makes
SELECT COUNT(DISTINCT m.Make)
FROM VehicleDetails v
JOIN Makes m ON v.MakeID=m.MakeID
JOIN FuelTypes f ON v.FuelTypeID=f.FuelTypeID
WHERE f.FuelTypeName='GAS';

## Problem 12: Vehicles per make
SELECT m.Make, COUNT(*)
FROM VehicleDetails v
JOIN Makes m ON v.MakeID=m.MakeID
GROUP BY m.Make;

## Problem 13: Makes > 20000 vehicles
SELECT m.Make, COUNT(*)
FROM VehicleDetails v
JOIN Makes m ON v.MakeID=m.MakeID
GROUP BY m.Make
HAVING COUNT(*) > 20000;

## Problem 14: Make starts with B
SELECT * FROM Makes WHERE Make LIKE 'B%';

## Problem 15: Make ends with W
SELECT * FROM Makes WHERE Make LIKE '%W';

## Problem 16: FWD makes
SELECT DISTINCT m.Make
FROM VehicleDetails v
JOIN Makes m ON v.MakeID=m.MakeID
JOIN DriveTypes d ON v.DriveTypeID=d.DriveTypeID
WHERE d.DriveTypeName='FWD';

## Problem 17: Count FWD makes
SELECT COUNT(DISTINCT v.MakeID)
FROM VehicleDetails v
JOIN DriveTypes d ON v.DriveTypeID=d.DriveTypeID
WHERE d.DriveTypeName='FWD';

## Problem 18: Drive type per make
SELECT m.Make, d.DriveTypeName, COUNT(*)
FROM VehicleDetails v
JOIN Makes m ON v.MakeID=m.MakeID
JOIN DriveTypes d ON v.DriveTypeID=d.DriveTypeID
GROUP BY m.Make,d.DriveTypeName;

## Problem 19: Drive type > 10000
SELECT m.Make, d.DriveTypeName, COUNT(*)
FROM VehicleDetails v
JOIN Makes m ON v.MakeID=m.MakeID
JOIN DriveTypes d ON v.DriveTypeID=d.DriveTypeID
GROUP BY m.Make,d.DriveTypeName
HAVING COUNT(*)>10000;

## Problem 20: Missing doors
SELECT * FROM VehicleDetails WHERE NumDoors IS NULL;

## Problem 21: Count missing doors
SELECT COUNT(*) FROM VehicleDetails WHERE NumDoors IS NULL;

## Problem 22: Percentage missing doors
SELECT CAST(NoDoors AS FLOAT)/CAST(Total AS FLOAT)
FROM (
 SELECT COUNT(*) NoDoors,(SELECT COUNT(*) FROM VehicleDetails) Total
 FROM VehicleDetails WHERE NumDoors IS NULL
) r;

## Problem 23: Elite submodel
SELECT DISTINCT m.MakeID,m.Make,s.SubModelName
FROM VehicleDetails v
JOIN Makes m ON v.MakeID=m.MakeID
JOIN SubModels s ON v.SubModelID=s.SubModelID
WHERE s.SubModelName='Elite';

## Problem 24: Engine > 3L
SELECT * FROM VehicleDetails WHERE Engine_Liter_Display>3 AND NumDoors=2;

## Problem 25: OHV & 4 cylinders
SELECT m.Make,v.Vehicle_Display_Name,v.Engine
FROM VehicleDetails v
JOIN Makes m ON v.MakeID=m.MakeID
WHERE Engine LIKE '%OHV%' AND Engine_Cylinders=4;

## Problem 26: Sport Utility > 2020
SELECT b.BodyName,v.*
FROM VehicleDetails v
JOIN Bodies b ON v.BodyID=b.BodyID
WHERE b.BodyName='Sport Utility' AND v.Year>2020;

## Problem 27: Coupe/Hatchback/Sedan
SELECT * FROM VehicleDetails v
JOIN Bodies b ON v.BodyID=b.BodyID
WHERE b.BodyName IN ('Coupe','Hatchback','Sedan');

## Problem 28: Body + year filter
SELECT * FROM VehicleDetails v
JOIN Bodies b ON v.BodyID=b.BodyID
WHERE b.BodyName IN ('Coupe','Hatchback','Sedan')
AND v.Year IN (2008,2020,2021);

## Problem 29: Exists 1950
SELECT 1 WHERE EXISTS(SELECT 1 FROM VehicleDetails WHERE Year=1950);

## Problem 30: Door words
SELECT Vehicle_Display_Name,NumDoors,
CASE
 WHEN NumDoors=1 THEN 'One'
 WHEN NumDoors=2 THEN 'Two'
 WHEN NumDoors IS NULL THEN 'Not Set'
 ELSE 'Other'
END
FROM VehicleDetails;

## Problem 31: Age
SELECT Vehicle_Display_Name,Year,
YEAR(GETDATE())-Year AS Age
FROM VehicleDetails;

## Problem 32: Age 15–25
SELECT * FROM (
 SELECT Vehicle_Display_Name,Year,YEAR(GETDATE())-Year Age
 FROM VehicleDetails
) r WHERE Age BETWEEN 15 AND 25;

## Problem 33: Engine stats
SELECT MIN(Engine_CC),MAX(Engine_CC),AVG(Engine_CC)
FROM VehicleDetails;

## Problem 34: Min engine CC
SELECT * FROM VehicleDetails
WHERE Engine_CC=(SELECT MIN(Engine_CC) FROM VehicleDetails);

## Problem 35: Max engine CC
SELECT * FROM VehicleDetails
WHERE Engine_CC=(SELECT MAX(Engine_CC) FROM VehicleDetails);

## Problem 36: Below average
SELECT * FROM VehicleDetails
WHERE Engine_CC<(SELECT AVG(Engine_CC) FROM VehicleDetails);

## Problem 37: Above average count
SELECT COUNT(*) FROM VehicleDetails
WHERE Engine_CC>(SELECT AVG(Engine_CC) FROM VehicleDetails);

## Problem 38: Unique engine CC
SELECT DISTINCT Engine_CC FROM VehicleDetails;

## Problem 39: Top 3 engine CC
SELECT TOP 3 Engine_CC FROM VehicleDetails ORDER BY Engine_CC DESC;

## Problem 40: Vehicles top 3 engine CC
SELECT * FROM VehicleDetails
WHERE Engine_CC IN (SELECT TOP 3 Engine_CC FROM VehicleDetails ORDER BY Engine_CC DESC);

## Problem 41: Makes top engine CC
SELECT DISTINCT m.Make
FROM VehicleDetails v
JOIN Makes m ON v.MakeID=m.MakeID
WHERE Engine_CC IN (SELECT TOP 3 Engine_CC FROM VehicleDetails ORDER BY Engine_CC DESC);

## Problem 42: Engine tax
SELECT Engine_CC,
CASE
 WHEN Engine_CC<=1000 THEN 100
 WHEN Engine_CC<=2000 THEN 200
 ELSE 0
END Tax
FROM VehicleDetails;

## Problem 43: Doors per make
SELECT m.Make,SUM(v.NumDoors)
FROM VehicleDetails v
JOIN Makes m ON v.MakeID=m.MakeID
GROUP BY m.Make;

## Problem 44: Ford doors
SELECT SUM(v.NumDoors)
FROM VehicleDetails v
JOIN Makes m ON v.MakeID=m.MakeID
WHERE m.Make='Ford';

## Problem 45: Models per make
SELECT m.Make,COUNT(*)
FROM Makes m
JOIN MakeModels mm ON m.MakeID=mm.MakeID
GROUP BY m.Make;

## Problem 46: Top 3 models makers
SELECT TOP 3 m.Make,COUNT(*)
FROM Makes m
JOIN MakeModels mm ON m.MakeID=mm.MakeID
GROUP BY m.Make;

## Problem 47: Max models
SELECT TOP 1 m.Make,COUNT(*)
FROM Makes m
JOIN MakeModels mm ON m.MakeID=mm.MakeID
GROUP BY m.Make;

## Problem 48: Highest model makers
SELECT m.Make,COUNT(*)
FROM Makes m
JOIN MakeModels mm ON m.MakeID=mm.MakeID
GROUP BY m.Make
HAVING COUNT(*)=(SELECT MAX(cnt) FROM (SELECT COUNT(*) cnt FROM MakeModels GROUP BY MakeID) r);

## Problem 49: Lowest model makers
SELECT m.Make,COUNT(*)
FROM Makes m
JOIN MakeModels mm ON m.MakeID=mm.MakeID
GROUP BY m.Make
HAVING COUNT(*)=(SELECT MIN(cnt) FROM (SELECT COUNT(*) cnt FROM MakeModels GROUP BY MakeID) r);

## Problem 50: Random fuel types
SELECT * FROM FuelTypes ORDER BY NEWID();

## Problem 51: Employees with manager
SELECT e.EmployeeID,e.Name,m.Name
FROM Employees e
JOIN Employees m ON e.ManagerID=m.EmployeeID;

## Problem 52: Employees optional manager
SELECT e.EmployeeID,e.Name,m.Name
FROM Employees e
LEFT JOIN Employees m ON e.ManagerID=m.EmployeeID;

## Problem 53: Self manager fallback
SELECT e.EmployeeID,e.Name,
CASE WHEN m.Name IS NULL THEN e.Name ELSE m.Name END
FROM Employees e
LEFT JOIN Employees m ON e.ManagerID=m.EmployeeID;
