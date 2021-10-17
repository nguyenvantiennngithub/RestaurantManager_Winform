go
use master
go
drop database RestaurantManager
go
create database RestaurantManager
go
use RestaurantManager
go
--UserCategory () cai nay de sau di
--User (username, password, displayName, status, cmnd, phoneNumber)
--Area (id, displayName)
--Table (id, displayName, idArea, status)
--FoodCategory (id, displayName)
--Food (id, displayName, price, status, idFoodCategory)
--Bill (id, dateCheckin, dateCheckout, status, idTable, sender)
--BillDetail(idBill, idFood, countFood)


create table [User](
	username nvarchar(50) primary key,
	password nvarchar(50) not null,
	displayName nvarchar(50) not null,
	status nvarchar(50) not null default N'Hoạt Động', --Hoạt Động: sài được, Không Hoạt Đông: không sài đc
	phoneNumber varchar(50) not null,
	position nvarchar(50) default N'Quản lý' not null,
);
go
create table [Area](
	displayName nvarchar(50) primary key,
)
go
create table [Table](
	id int identity primary key,
	displayName nvarchar(50) not null,
	displayNameArea nvarchar(50) not null,
	status nvarchar(50) not null default N'Bàn trống',
	FOREIGN KEY (displayNameArea) REFERENCES [Area](displayName)
)
go
create table [FoodCategory](
	displayName nvarchar(50) primary key,
)
go
create table [Food](
	displayName nvarchar(50) primary key,
	status nvarchar(50) not null default N'Hoạt động',--Hoạt đông: Đang bán, Không Hoạt Động: Đéo bán nữa
	priceVip int not null check (priceVip >= 0), 
	priceNormal int not null check (priceNormal >= 0), 
	displayNameFoodCategory nvarchar(50) not null,
	calcUnit nvarchar(50) not null,
	FOREIGN KEY (displayNameFoodCategory) REFERENCES [FoodCategory](displayName)
);

create table [Customer](
	id int identity primary key,
	displayName nvarchar(50) not null,
	phoneNumber nvarchar(50) not null,
	address nvarchar(50),
	gender nvarchar(50), --Nam, Nử
)
go

create table [BookingTable](
	id int identity primary key,
	count int not null,
	deposit int not null,
	description nvarchar(1000),
	time datetime,
)
go
create table [Bill](
	id int identity primary key,
	dateCheckin datetime default GETDATE(),--Giờ lập phiếu là lúc tạo phiếu ok?
	dateCheckout datetime,
	status nvarchar(50) not null default N'Chưa tính tiền',--Chưa Tính Tiền, Đã Tính Tiền, Đặt trước
	sender nvarchar(50) not null,
	moneyInput int default 0,
	discount int default 0,
	isDelete int default 0 not null,

	idTable int not null,
	idCustomer int,
	idBookingTable int,

	FOREIGN KEY (idCustomer) REFERENCES [Customer](id),
	FOREIGN KEY (idBookingTable) REFERENCES [BookingTable](id),
	FOREIGN KEY (idTable) REFERENCES [Table](id),
	FOREIGN KEY (sender) REFERENCES [User](username),

);

create table [BillDetail](
	id int identity primary key,
	idBill int,
	displayNameFood nvarchar(50),
	countFood int,
	FOREIGN KEY (idBill) REFERENCES [Bill](id),
	FOREIGN KEY (displayNameFood) REFERENCES [Food](displayName),
)




insert into [user] (username, password, displayName, phoneNumber) values ('vantiennn', 'vantiennn', 'vantiennn', '0909090909')

insert into [Area] (displayName) values(N'Khu thường')
insert into [Area] (displayName) values('Khu Vip')

insert into [Table] (displayName, displayNameArea) values('Bàn 1', N'Khu thường')
insert into [Table] (displayName, displayNameArea) values('Bàn 2', N'Khu thường')
insert into [Table] (displayName, displayNameArea) values('Bàn 3', N'Khu thường')
insert into [Table] (displayName, displayNameArea) values('Bàn 4', N'Khu thường')
insert into [Table] (displayName, displayNameArea) values('Bàn 5', N'Khu thường')
insert into [Table] (displayName, displayNameArea) values('Bàn 6', N'Khu thường')
insert into [Table] (displayName, displayNameArea) values('Bàn 7', N'Khu thường')
insert into [Table] (displayName, displayNameArea) values('Bàn 8', N'Khu thường')
insert into [Table] (displayName, displayNameArea) values('Bàn 9', N'Khu thường')
insert into [Table] (displayName, displayNameArea) values('Bàn 10', N'Khu thường')

insert into [Table] (displayName, displayNameArea) values('Bàn 11', 'Khu vip')
insert into [Table] (displayName, displayNameArea) values('Bàn 12', 'Khu vip')
insert into [Table] (displayName, displayNameArea) values('Bàn 13', 'Khu vip')
insert into [Table] (displayName, displayNameArea) values('Bàn 14', 'Khu vip')
insert into [Table] (displayName, displayNameArea) values('Bàn 15', 'Khu vip')
insert into [Table] (displayName, displayNameArea) values('Bàn 16', 'Khu vip')
insert into [Table] (displayName, displayNameArea) values('Bàn 17', 'Khu vip')
insert into [Table] (displayName, displayNameArea) values('Bàn 18', 'Khu vip')
insert into [Table] (displayName, displayNameArea) values('Bàn 19', 'Khu vip')
insert into [Table] (displayName, displayNameArea) values('Bàn 20', 'Khu vip')

insert into [FoodCategory] (displayName) values(N'Súp');
insert into [FoodCategory] (displayName) values(N'Rau');
insert into [FoodCategory] (displayName) values(N'Nộm');
insert into [FoodCategory] (displayName) values(N'Món ăn kèm');
insert into [FoodCategory] (displayName) values(N'Gà');
insert into [FoodCategory] (displayName) values(N'Cá');
insert into [FoodCategory] (displayName) values(N'Trâu');
insert into [FoodCategory] (displayName) values(N'Bò');
insert into [FoodCategory] (displayName) values(N'Dê');
--insert into [FoodCategory] (displayName) values(N'Ếch');
--insert into [FoodCategory] (displayName) values(N'Ốc');
--insert into [FoodCategory] (displayName) values(N'Vịt');
--insert into [FoodCategory] (displayName) values(N'Lẫu');
--insert into [FoodCategory] (displayName) values(N'Xôi');
--insert into [FoodCategory] (displayName) values(N'Tráng miệng');
--insert into [FoodCategory] (displayName) values(N'Nước');

insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Súp cá hồi', N'Súp', 15000, 17000, N'Bát');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Súp cua', N'Súp', 15000, 17000, N'Bát');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Súp hải sản', N'Súp', 15000, 17000, N'Bát');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Súp gà', N'Súp', 15000, 17000, N'Bát');

insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Rau bò khai xào', N'Rau', 50000,  60000,N'Dĩa');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Rau rờn xào đu đủ', N'Rau', 15000, 17000, N'Dĩa');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Rau bí xào', N'Rau', 45000, 60000, N'Dĩa');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Rau muống xào', N'Rau', 30000, 45000, N'Dĩa');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Mồng tơi xào', N'Rau', 30000, 45000, N'Dĩa');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Rau lang xào', N'Rau', 50000, 60000, N'Dĩa');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Ngọn su su xào', N'Rau', 60000, 45000, N'Dĩa');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Rau bí xào nấm tươi', N'Rau', 30000, 50000, N'Dĩa');

insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Nộm sứ phồng tôm', N'Nộm', 40000, 45000, N'Dĩa');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Nộm bí xào nấm tươi', N'Nộm', 40000, 45000, N'Dĩa');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Nộm rau má', N'Nộm', 60000, 45000, N'Dĩa');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Nộm rau dớn', N'Nộm', 60000, 45000, N'Dĩa');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Nộm hoa chuối', N'Nộm', 60000, 45000, N'Dĩa');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Salat rau trộn cá ngừ', N'Nộm', 100000, 120000, N'Dĩa');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Salat rau mầm', N'Nộm', 60000, 100000, N'Dĩa');

insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Ngô chiên', N'Món ăn kèm', 40000, 60000, N'Phần');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Khoai chiên', N'Món ăn kèm', 40000, 60000, N'Phần');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Bánh mỳ chiên', N'Món ăn kèm', 30000, 60000, N'Phần');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Bánh bao chiên', N'Món ăn kèm', 30000, 60000, N'Phần');

insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Gà nướng ngũ vị', N'Gà', 180000, 200000, N'1/2 Con');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Lườn gà xào nấm hương', N'Gà', 120000, 15000, N'Dĩa');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Gà xào nấm tươi', N'Gà', 180000, 200000, N'Dĩa');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Gà hấp lá chanh', N'Gà', 180000, 200000, N'Dĩa');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Gà hầm thuốc bắc', N'Gà', 270000, 290000, N'Dĩa');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Gỏi gà lá chanh chua ngọt', N'Gà', 180000, 200000, N'Dĩa');
insert into [Food] (displayName, displayNameFoodCategory, priceNormal, priceVip, calcUnit) values(N'Gà nướng mật ong', N'Gà', 180000, 200000, N'Dĩa');

go

create trigger TG_StatusTableOrder on [Bill] for insert
as
begin
	declare @idTable int
	declare @status nvarchar(50)

	select @idTable = idTable, @status = [status] from inserted
	IF @status = N'Đặt trước'
		update [Table] set [status] = N'Bàn đặt trước' where [id] = @idTable
	ELSE 
		update [Table] set [status] = N'Bàn có khách' where [id] = @idTable
end

go
create trigger TG_StatusTablePay on [Bill] for update
as
begin
	declare @idTable int
	declare @status nvarchar(50)
	declare @countBillBooking int
	declare @isDelete int

	select @idTable = idTable, @status = status, @isDelete = [isDelete] from inserted
	select @countBillBooking = count(*) from [Table] as t, [Bill] as b where t.id = @idTable AND t.id = b.idTable AND b.status = N'Đặt trước' AND b.isDelete = 0
	if @status = N'Chưa tính tiền' --nhập tiệc
		update [Table] set [status] = N'Bàn có khách' where [id] = @idTable
	else if @isDelete = 1 -- su ly khi huy dat ban
		if @countBillBooking > 0
			update [Table] set [status] = N'Bàn đặt trước' where [id] = @idTable
		else
			update [Table] set [status] = N'Bàn trống' where [id] = @idTable
	else		--su ly khi tinh tien
		if @countBillBooking > 0
			update [Table] set [status] = N'Bàn đặt trước' where [id] = @idTable AND @status = N'Đã tính tiền'
		else
			update [Table] set [status] = N'Bàn trống' where [id] = @idTable AND @status = N'Đã tính tiền'
		
end
go

create trigger TG_StatusTableMove on [Bill] for delete
as
begin
	declare @idTable int
	declare @status nvarchar(50)
	declare @countBillNoPay int
	declare @countBillBooking int

	select @idTable = idTable, @status = [status] from deleted

	select @countBillNoPay = count(*) from [Table] as t, [Bill] as b where t.id = @idTable AND t.id = b.idTable AND b.status = N'Chưa tính tiền' AND b.isDelete = 0
	select @countBillBooking = count(*) from [Table] as t, [Bill] as b where t.id = @idTable AND t.id = b.idTable AND b.status = N'Đặt trước' AND b.isDelete = 0

	if @status = N'Chưa tính tiền'--su ly khi chuyen ban co khach trong moveTable
		begin
			if @countBillBooking > 0
				update [Table] set [status] = N'Bàn đặt trước' where [id] = @idTable
			else
				update [Table] set [status] = N'Bàn trống' where [id] = @idTable
		end
	else if @status = N'Đặt trước' --su ly khi chuyen ban da dat truoc trong fEditBookingTalbe
		begin
			if @countBillNoPay > 0 -- phòng hờ vì để lọt vào đây thì nó lọt cái if chưa tính tiền mẹ r
				update [Table] set [status] = N'Bàn có khách' where [id] = @idTable
			else if @countBillBooking > 0 --đổi bàn roioff nhưng mà bàn đó còn được người khác đặt nữa
				update [Table] set [status] = N'Bàn đặt trước' where [id] = @idTable
			else
				update [Table] set [status] = N'Bàn trống' where [id] = @idTable
		end
end

go
select count(*) from [Table] as t, [Bill] as b where t.id = 5 AND t.id = b.idTable AND b.status = N'Chưa tính tiền'  
select count(*) from [Table] as t, [Bill] as b where t.id = 1 AND t.id = b.idTable AND b.status = N'Đặt trước'  


use RestaurantManager

select * from BillDetail
select * from Food
select * from [Table]
select * from FoodCategory
select * from [User]
select * from bill where status = N'Chưa tính tiền' AND isDelete = 0 AND idTable = 16
select * from [customer]
select * from [BookingTable]
--7 63 / 37 39
--6 39 / 44

--move 6 -> 7

select * from bill where idTable = 7 
insert into [Customer] (displayName, address, phoneNumber, gender) values (N'Nguyễn Văn Tiến', N'Trái đất', '0808080808', N'Nam');
insert into [Customer] (displayName, address, phoneNumber, gender) values (N'Nguyễn Văn Tí', N'Việt Nam', '0808080808', N'Nữ');
insert into [BookingTable] (count, deposit, description) values (5, 20000, N'Luột gà không dùng nước'); 
insert into [Bill] (idTable, sender) values(3, N'vantiennn');

insert into [BillDetail] (idBill, displayNameFood, countFood) values (1, N'Súp cá hồi', 3);
insert into [BillDetail] (idBill, displayNameFood, countFood) values (1, N'Gà nướng mật ong', 1);
insert into [BillDetail] (idBill, displayNameFood, countFood) values (1, N'Bánh bao chiên', 5);
insert into [BillDetail] (idBill, displayNameFood, countFood) values (1, N'Salat rau mầm', 2);
insert into [BillDetail] (idBill, displayNameFood, countFood) values (1, N'Ngọn su su xào', 1);
