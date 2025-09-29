-- Drop tables in correct dependency order
IF OBJECT_ID('OrderDetailTopping','U') IS NOT NULL DROP TABLE OrderDetailTopping;
IF OBJECT_ID('OrderDetailIcing','U') IS NOT NULL DROP TABLE OrderDetailIcing;
IF OBJECT_ID('OrderDetails','U') IS NOT NULL DROP TABLE OrderDetails;
IF OBJECT_ID('CakeTopping','U') IS NOT NULL DROP TABLE CakeTopping;
IF OBJECT_ID('CakeIcing','U') IS NOT NULL DROP TABLE CakeIcing;

-- Recreate OrderDetails (make each row unique by OrderDetailID)
CREATE TABLE OrderDetails (
    OrderDetailID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL,
    CakeID INT NOT NULL,
    Quantity INT DEFAULT 1,
    Subtotal DECIMAL(12,2) DEFAULT 0.00,
    CONSTRAINT FK_OrderDetails_Order FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    CONSTRAINT FK_OrderDetails_Cake FOREIGN KEY (CakeID) REFERENCES Cake(CakeID)
);

-- Allow multiple Icings per OrderDetail
CREATE TABLE OrderDetailIcing (
    OrderDetailID INT NOT NULL,
    IcingID INT NOT NULL,
    CONSTRAINT PK_OrderDetailIcing PRIMARY KEY (OrderDetailID, IcingID),
    CONSTRAINT FK_ODI_OrderDetail FOREIGN KEY (OrderDetailID) REFERENCES OrderDetails(OrderDetailID),
    CONSTRAINT FK_ODI_Icing FOREIGN KEY (IcingID) REFERENCES Icing(IcingID)
);

-- Allow multiple Toppings per OrderDetail
CREATE TABLE OrderDetailTopping (
    OrderDetailID INT NOT NULL,
    ToppingID INT NOT NULL,
    CONSTRAINT PK_OrderDetailTopping PRIMARY KEY (OrderDetailID, ToppingID),
    CONSTRAINT FK_ODT_OrderDetail FOREIGN KEY (OrderDetailID) REFERENCES OrderDetails(OrderDetailID),
    CONSTRAINT FK_ODT_Topping FOREIGN KEY (ToppingID) REFERENCES Topping(ToppingID)
);

-- Keep CakeIcing and CakeTopping for "available customization options"
CREATE TABLE CakeIcing (
    CakeID INT NOT NULL,
    IcingID INT NOT NULL,
    CONSTRAINT PK_CakeIcing PRIMARY KEY (CakeID, IcingID),
    CONSTRAINT FK_CakeIcing_Cake FOREIGN KEY (CakeID) REFERENCES Cake(CakeID),
    CONSTRAINT FK_CakeIcing_Icing FOREIGN KEY (IcingID) REFERENCES Icing(IcingID)
);

CREATE TABLE CakeTopping (
    CakeID INT NOT NULL,
    ToppingID INT NOT NULL,
    CONSTRAINT PK_CakeTopping PRIMARY KEY (CakeID, ToppingID),
    CONSTRAINT FK_CakeTopping_Cake FOREIGN KEY (CakeID) REFERENCES Cake(CakeID),
    CONSTRAINT FK_CakeTopping_Topping FOREIGN KEY (ToppingID) REFERENCES Topping(ToppingID)
);