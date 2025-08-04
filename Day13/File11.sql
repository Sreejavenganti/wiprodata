Create Table Stock
(
    StockId int identity (1,1) constraint pk_stock_stockId primary key,
	StockName varchar(30),
	Quantity int,
	Price Numeric(9,2)
)
Go

Insert into Stock
Values('Books',55,233.44)

Insert into Stock
values('Pens',43,43.34)

Insert into Stock
values('Bottles',23,23.33)

Insert into Stock
values('Mobiles',45,5344.44)

Insert into Stock
values('Chairs',42,434.44)

Select *from Stock
Go

Create Table Orders
(
   OrderId int Identity(1,1) Constraint pk_orders_orderid primary key,
   StockId int constraint fk_stock_stockid references Stock(StockId),
   StockName varchar(30),
   QtyOrd Int,
   Price numeric(9,2)
)
Go

Create Table Amount
(
    Gamt numeric(9,2)
)

Insert into Amount Values(0)
Go

Create Trigger trgInsOrder On Orders for Insert
AS
     Declare
	    @stockid int,
		@qtyord int,
		@qtyavail int,
		@dif int,
		@price float,
		@stockname varchar(30),
		@tot float,
		@flag int

	set @flag =1
	select @stockid =StockId, @qtyord = QtyOrd 
	from inserted
	Select @qtyavail =Quantity, @stockname = StockName, @price = Price
	from Stock where StockId = @StockId
	set @dif = @qtyavail - @qtyord
	if @dif<0
	BEGIN
	     Print 'Sorry Quantity is not available'
		 set @flag =0
		 rollback Tran 
		 return
	END
		if @flag =1
		BEGIN
		Update Stock set Quantity = @dif where StockId = @stockid
		set @tot = @qtyord*@price
		Update Orders set StockName = @StockName, QtyOrd = @QtyOrd, Price =@Price
		where StockId = @StockId
		Update Amount set  Gamt = Gamt+@tot
		END
		GO

		Insert into Orders(StockId, QtyOrd) Values (3, 100)
		Go

		Select *from Orders
		go

		Select *from Amount
		Go
