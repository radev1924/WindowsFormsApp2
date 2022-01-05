alter proc AddUser
@Username varchar(50),
@Password varchar(50)
as
Insert into [C:\USERS\RADEV1924\SOURCE\REPOS\WINDOWSFORMSAPP2\WINDOWSFORMSAPP2\LoginData.MDF]( Username, Password)
Values (@Username,@Password)