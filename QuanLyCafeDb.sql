CREATE TABLE [dbo].[tblCategory] (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	category_name NVARCHAR(50) NOT NULL
);

CREATE TABLE [dbo].[tblProduct] (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	category_id INT NOT NULL FOREIGN KEY REFERENCES tblCategory(id),
	title NVARCHAR(50) NOT NULL,
	price INT NOT NULL,
	thumbnail NVARCHAR(250) NOT NULL,
	descriptionP NVARCHAR(250) NOT NULL,
	deleted INT NOT NULL,
	discount INT
);

CREATE TABLE [dbo].[tblRole] (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	role_name NVARCHAR(50) NOT NULL
);

CREATE TABLE [dbo].[tblUser] (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	role_id INT NOT NULL FOREIGN KEY REFERENCES tblRole(id),
	deleted INT NOT NULL,
	passwordNV NVARCHAR(50) NOT NULL,
	fullname NVARCHAR(50) NOT NULL,
	sex INT NOT NULL,
	dob DATETIME NOT NULL,  
	addressU NVARCHAR(50) NOT NULL,
	phone NVARCHAR(50) NOT NULL
);

CREATE TABLE [dbo].[tblOrders] (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	id_nv INT NOT NULL FOREIGN KEY REFERENCES tblNhanvien(id),
	total_money INT NOT NULL,
	statusOrder INT NOT NULL,
	ngay_ban DATETIME NOT NULL,
);

CREATE TABLE [dbo].[tblOrderDetail] (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	order_id INT NOT NULL FOREIGN KEY REFERENCES tblOrders(id),
	product_id INT NOT NULL FOREIGN KEY REFERENCES tblProduct(id), 
	price INT NOT NULL,
	num INT NOT NULL,
	total_money INT NOT NULL
);

INSERT INTO tblRole(role_name)
VALUES('Staff')

INSERT INTO tblRole(role_name)
VALUES('Admin')

SET IDENTITY_INSERT [dbo].[Food] ON
INSERT [dbo].[Product] ([id], [title], [category_id], [price],[thumbnail],[descriptionP],[deleted],[discount]) VALUES (1, N'Mực một nắng nước sa tế', 1, 120000,1,1,1,1)
INSERT [dbo].[Product] ([id], [title], [category_id], [price],[thumbnail],[descriptionP],[deleted],[discount]) VALUES (2, N'Nghêu hấp xả', 1, 50000,1,1,1,1)
INSERT [dbo].[Product]  ([id], [title], [category_id], [price],[thumbnail],[descriptionP],[deleted],[discount]) VALUES (3, N'Dú dê nướng sữa', 2, 60000,1,1,1,1)
INSERT [dbo].[Product]  ([id], [title], [category_id], [price],[thumbnail],[descriptionP],[deleted],[discount]) VALUES (4, N'Heo rừng nướng muối ớt', 3, 75000,1,1,1,1)
INSERT [dbo].[Product]  ([id], [title], [category_id], [price],[thumbnail],[descriptionP],[deleted],[discount]) VALUES (5, N'Cơm chiên mushi', 4, 999999,1,1,1,1)
INSERT [dbo].[Product] ([id], [title], [category_id], [price],[thumbnail],[descriptionP],[deleted],[discount]) VALUES (6, N'7Up', 5, 15000,1,1,1,1)
INSERT [dbo].[Product]  ([id], [title], [category_id], [price],[thumbnail],[descriptionP],[deleted],[discount]) VALUES (7, N'Cafe', 5, 12000,1,1,1,1)
SET IDENTITY_INSERT [dbo].[Food] OFF
SELECT * FROM dbo.tblProduct
CREATE PROC [dbo].[USP_InsertBill]
AS
BEGIN
	INSERT dbo.tblOrders 
	        (  
	          ngay_ban,
	          total_money,
	          statusOrder
	        )
	VALUES  (  GETDATE() , -- DateCheckIn - date
	          0, -- TongTien - int
	          0  -- status - int
	        )
END
GO
CREATE PROC [dbo].[USP_InsertBillInfo]
@order_id INT, @id INT, @num INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	
	SELECT @isExitsBillInfo = id, @foodCount = b.num 
	FROM dbo.tblOrderDetail AS b 
	WHERE order_id = @order_id AND id = @id

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @num
		IF (@newCount > 0)
			UPDATE dbo.tblOrderDetail	SET num = @foodCount + @num WHERE id = @id
		ELSE
			DELETE dbo.tblOrderDetail WHERE order_id  = @order_id  AND id = @id
	END
	ELSE
	BEGIN
		INSERT	dbo.tblOrderDetail
        ( order_id, id, num )
		VALUES  ( @order_id, -- idBill - int
          @id, -- idFood - int
          @num  -- count - int
          )
	END
END
GO

