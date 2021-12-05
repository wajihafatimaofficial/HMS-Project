CREATE TABLE [dbo].[Table]
(
	Guestid int IDENTITY(1,1) PRIMARY KEY,
    [Name] VARCHAR(50) NOT NULL,
	  [Email] VARCHAR(50) NOT NULL,
	   [NIC] VARCHAR(50) NOT NULL,
	    [Contact] VARCHAR(50) NOT NULL,
	    [Gender] VARCHAR(50) NOT NULL,
	    [Address] VARCHAR(50) NOT NULL, 
    [RoomType] VARCHAR(50) NOT NULL,
	 [TotalGuests] VARCHAR(50) NOT NULL,
	  [TotalAdults] VARCHAR(50) NOT NULL,
	   [TotalChildrens] VARCHAR(50) NOT NULL,
	    [CheckInDate] VARCHAR(50) NOT NULL,
		 [CheckInPeriod] VARCHAR(50) NOT NULL,
		  [PaymentMethod] VARCHAR(50) NOT NULL,
		  	  [PaymentAmount] VARCHAR(50) NOT NULL
)
