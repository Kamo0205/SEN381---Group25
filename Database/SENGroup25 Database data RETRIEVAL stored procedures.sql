USE SENGroup25DB

GO

/* Employee data retrieval stored procedures */

CREATE PROCEDURE spGetEmpByID
@empID INT
AS
BEGIN
SELECT *
FROM tblEmployee
WHERE EmpID = @empID
END

GO

CREATE PROCEDURE spGetEmpByEmail
@email VARCHAR(50)
AS
BEGIN
SELECT *
FROM tblEmployee
WHERE Email = @email
END

GO

CREATE PROCEDURE spGetEmpByVatID
@vat VARCHAR(10)
AS
BEGIN
SELECT *
FROM tblEmployee
WHERE VatIDNumber = @vat
END

GO

CREATE PROCEDURE spGetEmpByContactNumber
@number VARCHAR(12)
AS
BEGIN
SELECT *
FROM tblEmployee
WHERE ContactNumber = @number
END

GO

CREATE PROCEDURE spListEmployeesForJob
@jobType VARCHAR(10)
AS
BEGIN
SELECT *
FROM tblEmployee 
WHERE (SELECT EmpID FROM tblEmployeeSkills WHERE (SELECT SkillID FROM tblSkills WHERE SkillType = @jobType)=SkillID) = EmpID
END 

/* Employee-ID data retrieval stored procedures */

GO 

CREATE PROCEDURE spListEmployeesByName
@name VARCHAR(30)
AS
BEGIN
SELECT EmpID
FROM tblEmployee
WHERE EmpName = @name
END

GO 

CREATE PROCEDURE spListEmployeesBySurname
@surname VARCHAR(30)
AS
BEGIN
SELECT EmpID
FROM tblEmployee
WHERE EmpSurname = @surname
END

GO 

/* Client data retrieval stored procedures */

CREATE PROCEDURE spGetClientByID
@clientID INT
AS
BEGIN
SELECT *
FROM tblClient
WHERE ClientID = @clientID
END

GO

CREATE PROCEDURE spGetClientByEmail
@email VARCHAR(50)
AS
BEGIN
SELECT *
FROM tblClient
WHERE Email = @email
END

GO

CREATE PROCEDURE spGetClientByAddress
@address VARCHAR(100)
AS
BEGIN
SELECT *
FROM tblClient
WHERE ClientAddress = @address
END

GO

CREATE PROCEDURE spGetClientByContactNumber
@number VARCHAR(12)
AS
BEGIN
SELECT *
FROM tblClient
WHERE ContactNumber = @number
END


/* Client-ID data retrieval stored procedures */

GO 

CREATE PROCEDURE spListClientsByName
@name VARCHAR(30)
AS
BEGIN
SELECT ClientID
FROM tblClient
WHERE ClientName = @name
END

GO 

CREATE PROCEDURE spListClientsBySurname
@surname VARCHAR(30)
AS
BEGIN
SELECT ClientID
FROM tblClient
WHERE ClientSurname = @surname
END

GO 

/* Job data retrieval stored procedures */

CREATE PROCEDURE spGetJobByID
@jobID INT
AS
BEGIN
SELECT *
FROM tblJob
WHERE JobID = @jobID
END

GO

CREATE PROCEDURE spListJobsByClientID
@clientID int
AS
BEGIN
SELECT *
FROM tblJob
WHERE ClientID = @clientID
END

GO

CREATE PROCEDURE spListJobsByEmpID
@empID int
AS
BEGIN
SELECT *
FROM tblJob
WHERE EmpID = @empID
END

GO

CREATE PROCEDURE spListJobsByStatus
@status VARCHAR(10)
AS
BEGIN
SELECT *
FROM tblJob
WHERE JobStatus = @status
END

GO

CREATE PROCEDURE spListJobsByDescription
@description VARCHAR(100)
AS
BEGIN
SELECT *
FROM tblJob
WHERE JobDescription = @description
END

GO

CREATE PROCEDURE spListJobsByType
@type VARCHAR(10)
AS
BEGIN
SELECT *
FROM tblJob
WHERE JobType = @type
END

GO

/* Skill data retrieval stored procedures */

CREATE PROCEDURE spGetSkillByID
@skillID INT
AS
BEGIN
SELECT *
FROM tblSkills
WHERE SkillID = @skillID
END

GO

CREATE PROCEDURE spGetSkillByEmpID
@empID int
AS
BEGIN
SELECT *
FROM tblSkills
WHERE (SELECT SkillID FROM tblEmployeeSkills WHERE EmpID = @empID) = SkillID
END

GO

CREATE PROCEDURE spGetSkillByDescription
@description VARCHAR(80)
AS
BEGIN
SELECT *
FROM tblSkills
WHERE SkillDescription = @description
END

GO

CREATE PROCEDURE spGetSkillByType
@type VARCHAR(10)
AS
BEGIN
SELECT *
FROM tblSkills
WHERE SkillType = @type
END 