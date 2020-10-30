CREATE TABLE tbl_Lease(
	LeaseId INT PRIMARY KEY IDENTITY(1,1),
	StreetAddress VARCHAR(50),
	Appartement VARCHAR(50),
	City VARCHAR(20),
	StateId INT,
	ZipCode VARCHAR(10),
	TermId INT
)