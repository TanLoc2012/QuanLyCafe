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
	phone NVARCHAR(50) NOT NULL,
	username NVARCHAR(50) NOT NULL
);

CREATE TABLE [dbo].[tblOrders] (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	id_nv INT NOT NULL FOREIGN KEY REFERENCES tblUser(id),
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

INSERT INTO tblRole(role_name)
VALUES('Manager')


/* Thêm attribute username vào tblUser*/
ALTER TABLE tblUser
ADD username nvarchar(50) 

create proc authentication
@username nvarchar(50),
@passwordNV nvarchar(50)
as
begin
    if exists (select * from tblUser where username = @username and passwordNV = @passwordNV and role_id = 1)
        select 1 as code
    else if exists (select * from tblUser where username = @username and passwordNV = @passwordNV and role_id = 2)
        select 2 as code
    else select 3 as code
end


INSERT INTO [dbo].[tblCategory] VALUES ('Do uong');

INSERT INTO [dbo].[tblProduct] VALUES (1,'Cafe chon', 50000, 'cak', 'Not for children', 0,0);
INSERT INTO [dbo].[tblProduct] VALUES (1, 'Tra sua', 20000, 'hihi', 'only couple', 0, 0);
INSERT INTO [dbo].[tblProduct] VALUES (1, 'Nuoc ep', 15000, 'hoho', 'healthy person',0,0);
INSERT INTO [dbo].[tblProduct] VALUES (1, 'Cam vat', 14000, 'hehe', 'helthy boy', 0, 0);

INSERT INTO [dbo].[tblUser] VALUES (1,0,'admin','Vu Dang Khoa', 1,'1988-05-22','Tay Ninh','0937811504','vuatrochoiyugioh');
INSERT INTO [dbo].[tblUser] VALUES (2,0,'admin','Uzumaki Naruto',1,'2002-04-30','Tay Ninh', '0937811504','naruto');
INSERT INTO [dbo].[tblUser] VALUES (2,0,'admin', 'Uchiha Itachi',1,'2001-5-19','Tp. Ho Chi Minh', '213132121', 'thegioingam');
INSERT INTO [dbo].[tblUser] VALUES (1,0, 'admin', 'Hoa Diem Thien Vuong', 1, '2002-04-25', 'Tp.Ho Chi Minh', '012313123', 'codon');

INSERT INTO [dbo].[tblOrders] VALUES (4, 25000, 1, '2022/04/23');
INSERT INTO [dbo].[tblOrders] VALUES (4, 25000, 1, '2022/04/23');
INSERT INTO [dbo].[tblOrders] VALUES (1, 30000, 1, '2022/04/23');
INSERT INTO [dbo].[tblOrders] VALUES (2, 15000, 1, '2022/04/23');

INSERT INTO [dbo].[tblOrders] VALUES (2, 25000, 1, '2022/04/24');
INSERT INTO [dbo].[tblOrders] VALUES (3, 15000, 1, '2022/04/24');
INSERT INTO [dbo].[tblOrders] VALUES (1, 20000, 1, '2022/04/25');
INSERT INTO [dbo].[tblOrders] VALUES (3, 25000, 1, '2022/04/25');
INSERT INTO [dbo].[tblOrders] VALUES (2, 20000, 1, '2022/04/25');
INSERT INTO [dbo].[tblOrders] VALUES (4, 21000, 1, '2022/04/25');
INSERT INTO [dbo].[tblOrders] VALUES (4, 20000, 1, '2022/05/01');
INSERT INTO [dbo].[tblOrders] VALUES (2, 25000, 1, '2022/05/02');
DBCC CHECKIDENT ([tblOrders], RESEED, 0);

INSERT INTO [dbo].[tblOrderDetail] VALUES (4,2,15000, 1, 15000);
INSERT INTO [dbo].[tblOrderDetail] VALUES (4,3, 15000, 1, 15000);
INSERT INTO [dbo].[tblOrderDetail] VALUES (4,1, 50000,1, 50000);




DBCC CHECKIDENT ([tblCategory], RESEED, 0);
DBCC CHECKIDENT ([tblUser], RESEED, 0);
DBCC CHECKIDENT ([tblOrderDetail], RESEED,0);
DBCC CHECKIDENT ([tblOrders], RESSED,0);

SELECT [dbo].[tblOrders].id, [dbo].[tblOrders].id_nv, [dbo].[tblUser].fullname, [dbo].[tblOrders].total_money, [dbo].[tblOrders].statusOrder, [dbo].[tblOrders].ngay_ban
FROM [dbo].[tblOrders], [dbo].[tblUser]
WHERE [dbo].[tblOrders].id_nv = [dbo].[tblUser].id;

SELECT [dbo].[tblOrderDetail].product_id, [dbo].[tblProduct].title, [dbo].[tblOrderDetail].price, [dbo].[tblOrderDetail].num, [dbo].[tblOrderDetail].total_money
FROM [dbo].[tblOrderDetail], [dbo].[tblProduct]
WHERE [dbo].[tblOrderDetail].order_id = 5 AND [dbo].[tblOrderDetail].product_id = [dbo].[tblProduct].id

SELECT [dbo].[tblUser].id,[dbo].[tblRole].role_name, [dbo].[tblUser].deleted, [dbo].[tblUser].passwordNV, tblUser.fullname, [dbo].[tblUser].sex, [dbo].[tblUser].dob, [dbo].[tblUser].addressU, [dbo].[tblUser].phone
FROM [dbo].[tblUser], [dbo].[tblRole]
WHERE [dbo].[tblUser].role_id = [dbo].[tblRole].id

SELECT [dbo].[tblOrders].id, [dbo].[tblOrders].id_nv, [dbo].[tblUser].fullname, [dbo].[tblOrders].total_money, [dbo].[tblOrders].statusOrder, [dbo].[tblOrders].ngay_ban 
FROM [dbo].[tblOrders], [dbo].[tblUser] 
WHERE [dbo].[tblOrders].id_nv = [dbo].[tblUser].id AND [dbo].[tblOrders].ngay_ban >= '2022/04/24' AND [dbo].[tblOrders].ngay_ban <= '2022/04/25';

SELECT [dbo].[tblOrders].ngay_ban, COUNT([dbo].[tblOrders].ngay_ban) AS tong_don, SUM([dbo].[tblOrders].total_money) AS tong_tien
FROM [dbo].[tblOrders]
WHERE [dbo].[tblOrders].ngay_ban >= '2022/04/23' AND [dbo].[tblOrders].ngay_ban <= '2022/04/25'
GROUP BY [dbo].[tblOrders].ngay_ban

 SELECT MONTH([dbo].[tblOrders].ngay_ban) AS ngay_ban, COUNT([dbo].[tblOrders].ngay_ban) AS tong_don, SUM([dbo].[tblOrders].total_money) AS tong_tien
FROM[dbo].[tblOrders]
WHERE[dbo].[tblOrders].ngay_ban >= '2022/04/23'  AND [dbo].[tblOrders].ngay_ban <= '2022/05/25'
GROUP BY MONTH([dbo].[tblOrders].ngay_ban);


UPDATE [dbo].[tblUser] SET deleted = 0 WHERE id = 1;




SELECT DATENAME(month, [dbo].[tblOrders].ngay_ban) AS date, COUNT(*) AS tong_don, SUM([dbo].[tblOrders].total_money) AS tong_tien
FROM[dbo].[tblOrders]
WHERE[dbo].[tblOrders].ngay_ban >=  '2022/04/01' AND [dbo].[tblOrders].ngay_ban <= '2022/05/31'
GROUP BY DATENAME(month, [dbo].[tblOrders].ngay_ban);

SELECT CONVERT(varchar(1), DATEPART(QUARTER, [dbo].[tblOrders].ngay_ban)) AS date, COUNT(*) AS tong_don, SUM([dbo].[tblOrders].total_money) AS tong_tien
FROM[dbo].[tblOrders]
WHERE[dbo].[tblOrders].ngay_ban >=  '2022/01/01' AND [dbo].[tblOrders].ngay_ban <= '2022/12/31'
GROUP BY CONVERT(varchar(1), DATEPART(QUARTER, [dbo].[tblOrders].ngay_ban));


SELECT DATEPART(week, [dbo].[tblOrders].ngay_ban) AS date, COUNT(*) AS tong_don, SUM([dbo].[tblOrders].total_money) AS tong_tien
FROM[dbo].[tblOrders]
WHERE[dbo].[tblOrders].ngay_ban >=  '2022/04/01' AND [dbo].[tblOrders].ngay_ban <= '2022/05/01'
GROUP BY DATEPART(week, [dbo].[tblOrders].ngay_ban);
