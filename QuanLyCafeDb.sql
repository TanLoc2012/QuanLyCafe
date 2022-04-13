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
