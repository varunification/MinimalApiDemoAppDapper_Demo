﻿CREATE PROCEDURE [dbo].[spUser_Get]
	@id int
AS
begin
	SELECT * from dbo.[User] where Id= @id;
end
