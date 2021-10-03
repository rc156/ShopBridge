CREATE DATABASE DB_ShopBridge
GO
CREATE SCHEMA INV
GO
CREATE TABLE INV.tbItems
(
    ItemId INT IDENTITY NOT NULL,
    ItemName NVARCHAR(100) NOT NULL,
    [Description] NVARCHAR(500),
    Price DECIMAL(10, 2),
	Quantity INT,
    PRIMARY KEY (ItemId)
);

GO
--===================================
--Created By : Rahul Kumar
--Created On : 02nd Oct 2021
--===================================
CREATE PROCEDURE INV.sp_Items_Save 
(
@ItemId      INT,
@ItemName    NVARCHAR(100),
@Description    NVARCHAR(500),
@Price          DECIMAL(10, 2),
@Quantity       INT
)
AS
  BEGIN
  IF(@ItemId=0)
  BEGIN
            INSERT INTO INV.tbItems(ItemName,[Description],Price,Quantity)
            VALUES     (@ItemName,@Description,@Price,@Quantity)
  END
  ELSE
  BEGIN
  UPDATE INV.tbItems  SET ItemName=@ItemName, [Description]=@Description, Price= @Price, Quantity= @Quantity
  WHERE ItemId=@ItemId
  END
  END
GO
--===================================
--Created By : Rahul Kumar
--Created On : 02nd Oct 2021
--===================================
CREATE PROCEDURE INV.sp_Items_Delete 
(
@ItemId      INT
)
AS
BEGIN
   DELETE FROM INV.tbItems WHERE ItemId=@ItemId
   END
GO
--===================================
--Created By : Rahul Kumar
--Created On : 02nd Oct 2021
--===================================
CREATE PROCEDURE INV.sp_Items_Bind 
AS
BEGIN
   SELECT * FROM INV.tbItems ORDER BY ItemName
END
GO