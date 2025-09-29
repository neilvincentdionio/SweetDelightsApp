USE SweetDelightsDB; 
GO

-- Insert sample Cakes
INSERT INTO Cake (CakeType, Price) VALUES
('Classic Chocolate Cake', 800.00),
('Vanilla Buttercream Cake', 750.00),
('Red Velvet Cake', 950.00),
('Black Forest Cake', 1000.00),
('Ube Halaya Cake', 600.00);

-- Insert sample Icings
INSERT INTO Icing (IcingType, Price) VALUES
('Chocolate Ganache', 120.00),
('Vanilla Buttercream', 100.00),
('Cream Cheese Frosting', 100.00),
('Whipped Cream', 90.00),
('Fondant Finish', 150.00);

-- Insert sample Toppings
INSERT INTO Topping (ToppingType, Price) VALUES
('Fresh Strawberries', 150.00),
('Chocolate Shavings', 80.00),
('Macarons (4 pcs)', 180.00),
('Oreo Crumbs', 70.00),
('Gold Sprinkles', 100.00);

-- Insert sample Customers
INSERT INTO Customer (FirstName, LastName, ContactNumber, Email, StreetAddress, Barangay, City) VALUES
('Carlos','Ramirez','09181231234','c.ramirez@example.com','10 Kalayaan Ave','Kamuning','Quezon City'),
('Sophia','Martinez','09182342345','sophia.martinez@example.com','55 Bayanihan St','Lahug','Cebu City'),
('David','Tan','09183453456','david.tan@example.com','123 Aurora Blvd','Cubao','Quezon City'),
('Isabella','Torres','09184564567','isabella.torres@example.com','77 San Juan St','Barangay 4','Makati'),
('Gabriel','Cruz','09185675678','gabriel.cruz@example.com','32 Mabuhay Ave','Barangay Malate','Manila');


-- Link Cakes to available Icings
INSERT INTO CakeIcing (CakeID, IcingID) VALUES 
(1,1),(1,2), -- Chocolate Cake can have Ganache or Buttercream
(2,2),(2,4), -- Vanilla Cake with Buttercream or Whipped Cream
(3,3),(3,5); -- Red Velvet with Cream Cheese or Fondant

-- Link Cakes to available Toppings
INSERT INTO CakeTopping (CakeID, ToppingID) VALUES 
(1,1),(1,2), -- Chocolate Cake: Strawberries, Shavings
(2,3),(2,4), -- Vanilla Cake: Macarons, Oreos
(3,5);       -- Red Velvet: Gold Sprinkles

-- Insert sample Order + OrderDetails
INSERT INTO Orders (CustomerID, OrderType, TotalAmount, Status) 
VALUES (1,'Delivery',0,'Pending'); -- OrderID = 1

-- Add OrderDetails (same cake twice but different icing/topping combos)
INSERT INTO OrderDetails (OrderID, CakeID, Quantity, Subtotal) 
VALUES (1,1,1,800.00),  -- OrderDetailID = 1 (Chocolate Cake)
       (1,1,1,820.00);  -- OrderDetailID = 2 (Chocolate Cake again, different setup)

-- Link icings/toppings to each order detail
INSERT INTO OrderDetailIcing (OrderDetailID, IcingID) VALUES 
(1,1), -- First Chocolate Cake ? Chocolate Ganache
(2,2); -- Second Chocolate Cake ? Vanilla Buttercream

INSERT INTO OrderDetailTopping (OrderDetailID, ToppingID) VALUES
(1,1), -- First ? Fresh Strawberries
(2,2); -- Second ? Chocolate Shavings