CREATE PROCEDURE [dbo].[spUser_Update]
  @id int,
  @firstname nvarchar(50),
  @lastname nvarchar(50)

  AS
  begin
  update dbo.[User] set LastName=@lastname, FirstName= @firstname 
   where Id= @id;
   end