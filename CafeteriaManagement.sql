create database Cafe

create table Role (
 roleid int identity(1,1) primary key , 
 roleName varchar(30) not null 
)



insert into role (roleName) values 
	('cashier'),
	('manager'),
	('owner')

create table users (
	username varchar(20) primary key , 
	password varchar(30) not null , 
	roleID int not null ,
	name nvarchar(30) , 
	phone varchar(11) ,
	foreign key (roleID) references Role(roleID)
	)

--drop table users

insert into users (username, password, roleID) values 
	('owner','owner',3),
	('manager','manager',2),
	('cashier','cashier',1)

--select * from users
-- Return role 
--select roleName from Role where roleID in (select roleID from users where username like 'cashier')



--UPDATE users
--SET phone = '0393514980'
--WHERE username = 'cashier';



--delete from role where roleName like 'hello'





create table tableCards (
	id varchar(5) primary key,
	tableName nvarchar(20) not null , 
	status nvarchar(10) not null, 
)

	


go
CREATE PROCEDURE AddNewTableCards
AS
BEGIN
    DECLARE @Counter INT = 1;

    WHILE @Counter <= 18
    BEGIN
        DECLARE @TableID NVARCHAR(50) = CONCAT('T00', @Counter);
        DECLARE @TableName NVARCHAR(100) = CONCAT('Table ', @Counter);
        DECLARE @Status NVARCHAR(50) = 'Empty'; -- You can set the default status here

        INSERT INTO TableCards (ID, TableName, Status)
        VALUES (@TableID, @TableName, @Status);

        SET @Counter = @Counter + 1;
    END
END
go
--Table : 0 - Empty
--Table : 1 - Processing
--drop proc AddNewTableCards
exec AddNewTableCards

create table categories (
	cateID varchar(5) primary key , 
	cateName nvarchar(30) not null 
)

INSERT INTO categories (cateID, cateName) VALUES
    ('C001', 'Uncategorized'),
    ('C002', 'Milk Tea'),
    ('C003', 'Food'),
    ('C004', 'Juice'),
    ('C005', 'Coffee'),
    ('C006', 'Smoothies'),
    ('C007', 'Tea'),
    ('C008', 'Drinks');




create table products (
	pid varchar(5) primary key, 
	pname nvarchar(30) not null , 
	price decimal not null,
	status int not null, 
	cateID varchar(5) not null , 
	foreign key (cateID) references categories(cateID) 
)


-- Insert additional products for each category
INSERT INTO products (pid, pname, price, status, cateID) VALUES
    -- Uncategorized (drinks)
    ('P006', 'Sparkling Water', 1.50, 1, 'C001'),
    ('P007', 'Pepsi', 2.00, 1, 'C001'),
    ('P008', 'Sting', 2.20, 1, 'C001'),

    -- Milk Tea
    ('P009', 'Brown Sugar Boba Milk Tea', 4.50, 1, 'C002'),
    ('P010', 'Taro Milk Tea', 4.00, 1, 'C002'),
    ('P011', 'Thai Milk Tea', 3.75, 1, 'C002'),

    -- Food
    ('P012', 'Chicken Caesar Salad', 7.50, 1, 'C003'),
    ('P013', 'Margherita Pizza', 12.00, 1, 'C003'),
    ('P014', 'Beef Burger', 9.00, 1, 'C003'),

    -- Juice
    ('P015', 'Apple Juice', 2.00, 1, 'C004'),
    ('P016', 'Grapefruit Juice', 2.20, 1, 'C004'),
    ('P017', 'Pineapple Juice', 2.10, 1, 'C004'),

    -- Coffee
    ('P018', 'Espresso', 2.50, 1, 'C005'),
    ('P019', 'Cappuccino', 3.00, 1, 'C005'),
    ('P020', 'Latte', 3.25, 1, 'C005'),

    -- Smoothies
    ('P021', 'Strawberry Banana Smoothie', 4.75, 1, 'C006'),
    ('P022', 'Mango Pineapple Smoothie', 4.80, 1, 'C006'),
    ('P023', 'Blueberry Kale Smoothie', 5.00, 1, 'C006'),

    -- Tea
    ('P024', 'Green Tea', 2.00, 1, 'C007'),
    ('P025', 'Earl Grey Tea', 2.25, 1, 'C007'),
    ('P026', 'Chamomile Tea', 2.20, 1, 'C007'),

    -- Drinks
    ('P027', 'Lemonade', 2.50, 1, 'C008'),
    ('P028', 'Iced Tea', 2.25, 1, 'C008'),
    ('P029', 'Soda', 1.75, 1, 'C008');



--select * from products
--select * from categories

--select * from products where cateID in (select cateID from categories where cateName like 'Milk Tea')
--select * from products where cateID = 'C001'



create table shift (
	shiftID varchar(20) primary key ,
	shiftStart datetime , 
	username varchar(20) not null ,
	shiftEnd datetime,
	foreign key (username) references users(username)
)

--drop table shift
--Select date from shift
--select * from shift

go
CREATE PROCEDURE generate_shiftID
AS
BEGIN
    DECLARE @new_shiftID VARCHAR(20);
    DECLARE @today_date VARCHAR(6);
    DECLARE @last_shiftID VARCHAR(20);

    -- Get today's date in 'ddmmyy' format
    SET @today_date = FORMAT(GETDATE(), 'ddMMyy');

    -- Get the last shiftID
    SELECT TOP 1 @last_shiftID = shiftID
    FROM shift
    WHERE shiftID LIKE CONCAT('S', @today_date, '%')
    ORDER BY shiftID DESC;

    -- If last_shiftID is null, set the new_shiftID to the first of the day
    IF @last_shiftID IS NULL
    BEGIN
        SET @new_shiftID = CONCAT('S', @today_date, '001');
    END
    ELSE
    BEGIN
        -- Extract the numeric part and increment by 1
        DECLARE @numeric_part INT;
        SET @numeric_part = CAST(SUBSTRING(@last_shiftID, 8, 3) AS INT) + 1;

        -- Combine the components to form the new shiftID
        SET @new_shiftID = CONCAT('S', @today_date, FORMAT(@numeric_part, '000'));
    END

    -- Return the generated shiftID
    SELECT @new_shiftID AS new_shiftID;
END;
go

--exec generate_shiftID
create table Ranks (
	rankID varchar(5) primary key ,
	rankName nvarchar(30) not null , 
	goalPoints int , 
	discount int , 
)

insert into ranks (rankID, rankName, goalPoints, discount) values 
	('1', 'Bronze',1,0),
	('2', 'Silver',100,5),
	('3', 'Gold',200,10)

CREATE TABLE Customers (
    id VARCHAR(5) PRIMARY KEY,
    name NVARCHAR(40),
    phoneNum VARCHAR(12),
    gender NVARCHAR(6) CHECK (gender IN ('male', 'female')),
	rankID varchar(5) not null , 
	points int ,
	foreign key (rankID) references Ranks(rankID)
);

insert into Customers (id, name, phoneNum, gender, rankID, points) values 
	('0','None','0000000000','male',1,0),
	('1', 'Trung Chanh','0393514981','male', 1, 1),
	('2', 'Trung Chanh1','0393514982','male', 2, 101),
	('3', 'Trung Chanh2','0393514983','male', 3, 220)


--select * from Customers

--select * from ranks




	

create table Orders (
	orderID varchar(20) primary key , 
	orderDate datetime not null , 
	total decimal  ,
	username varchar(20) not null, 
	tableID varchar(5) not null , 
	orderType varchar(20) not null ,
	customerId varchar(5) not null , 
	shiftID varchar(20) not null , 
	paymentMethod varchar(20) , 
	foreign key (username) references users(username),
	foreign key (tableID) references tableCards(id),
	foreign key (customerID) references Customers(id),
	foreign key (shiftID) references Shift(shiftID) 
)

--drop table Orders
select * from orders
--delete from orders where orderID like 'O120524001'


CREATE TABLE OrderDetails (
    orderDetailID int identity(1,1) PRIMARY KEY,
    orderID VARCHAR(20) NOT NULL,
    productID VARCHAR(5) NOT NULL,
	productName varchar(100) ,
    quantity INT,
    price DECIMAL NOT NULL,
	 
    FOREIGN KEY (orderID) REFERENCES Orders(orderID),
    FOREIGN KEY (productID) REFERENCES Products(pid)
);
--drop table OrderDetails --select * from OrderDetails
	

--generate Order ID 

go
CREATE PROCEDURE generate_orderID
AS
BEGIN
    DECLARE @new_orderID VARCHAR(20);
    DECLARE @today_date VARCHAR(6);
    DECLARE @last_orderID VARCHAR(20);

    -- Get today's date in 'ddmmyy' format
    SET @today_date = FORMAT(GETDATE(), 'ddMMyy');

    -- Get the last orderID
    SELECT TOP 1 @last_orderID = orderID
    FROM Orders
    WHERE orderID LIKE CONCAT('O', @today_date, '%')
    ORDER BY orderID DESC;

    -- If last_orderID is null, set the new_orderID to the first of the day
    IF @last_orderID IS NULL
    BEGIN
        SET @new_orderID = CONCAT('O', @today_date, '001');
    END
    ELSE
    BEGIN
        -- Extract the numeric part and increment by 1
        DECLARE @numeric_part INT;
        SET @numeric_part = CAST(SUBSTRING(@last_orderID, 8, 3) AS INT) + 1;

        -- Combine the components to form the new orderID
        SET @new_orderID = CONCAT('O', @today_date, FORMAT(@numeric_part, '000'));
    END

    -- Return the generated orderID
    SELECT @new_orderID AS new_orderID;
END;
go
--exec generate_orderID










--SELECT ORDERID, TOTAL, USERNAME, ORDERTYPE,CUSTOMERID 
--FROM orders 
--WHERE shiftID IN (
    --SELECT shiftID 
    --FROM shift 
    --WHERE CONVERT(DATE, shiftEnd) = '2024-05-10');


