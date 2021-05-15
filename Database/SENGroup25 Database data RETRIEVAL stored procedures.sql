USE SENGroup25DB

GO

/* Employee data retrieval stored procedures */

CREATE PROCEDURE spGetEmpByID
@id VARCHAR(30)
AS
BEGIN
SELECT *
FROM tblEmployee
WHERE EmpID = @id
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
@jobType VARCHAR(15)
AS
BEGIN
SELECT *
FROM tblEmployee 
WHERE (SELECT EmpID FROM tblEmployeeSkill WHERE (SELECT SkillID FROM tblSkill WHERE SkillType = @jobType)=SkillID) = EmpID
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

/*CREATE PROCEDURE spGetClientByID
@id VARCHAR(30)
AS
BEGIN
SELECT *
FROM tblClient
WHERE ClientID = @id
END

GO*/

CREATE PROCEDURE spGetClientByEmail
@email VARCHAR(50)
AS
BEGIN
SELECT *
FROM tblClient
WHERE Email = @email
END

GO

/*CREATE PROCEDURE spGetClientByAddress
@address VARCHAR(100)
AS
BEGIN
SELECT *
FROM tblClient
WHERE ClientAddress = @address
END

GO*/

CREATE PROCEDURE spGetClientByContactNumber
@number VARCHAR(12)
AS
BEGIN
SELECT *
FROM tblClient
WHERE ContactNumber = @number
END

GO

/*CREATE PROCEDURE spGetClientByContractID
@id VARCHAR(30)
AS
BEGIN
SELECT * 
FROM tblClient
WHERE ContractID = @id
END*/


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
@id VARCHAR(30)
AS
BEGIN
SELECT *
FROM tblJob
WHERE JobID = @id
END

GO

CREATE PROCEDURE spListJobsByContractID
@id VARCHAR(30)
AS
BEGIN
SELECT *
FROM tblJob
WHERE ContractID = @id
END

GO

CREATE PROCEDURE spListJobsByEmpID
@id VARCHAR(30)
AS
BEGIN
SELECT *
FROM tblJob
WHERE EmpID = @id
END

GO

CREATE PROCEDURE spListJobsByStatus
@status VARCHAR(15)
AS
BEGIN
SELECT *
FROM tblJob
WHERE JobStatus = @status
END

GO

/*CREATE PROCEDURE spListJobsByDescription
@description VARCHAR(100)
AS
BEGIN
SELECT *
FROM tblJob
WHERE JobDescription = @description
END

GO*/

CREATE PROCEDURE spListJobsByType
@type VARCHAR(15)
AS
BEGIN
SELECT *
FROM tblJob
WHERE JobType = @type
END

GO

CREATE PROCEDURE spListJobsByCategory
@category VARCHAR(15)
AS
BEGIN
SELECT *
FROM tblJob
WHERE JobCategory = @category
END

GO

/* Skill data retrieval stored procedures */

CREATE PROCEDURE spGetSkillByID
@id VARCHAR(30)
AS
BEGIN
SELECT *
FROM tblSkill
WHERE SkillID = @id
END

GO

CREATE PROCEDURE spListSkillsByEmpID
@id VARCHAR(30)
AS
BEGIN
SELECT *
FROM tblSkill
WHERE (SELECT SkillID FROM tblEmployeeSkill WHERE EmpID = @id) = SkillID
END

GO

/*CREATE PROCEDURE spGetSkillByDescription
@description VARCHAR(80)
AS
BEGIN
SELECT *
FROM tblSkills
WHERE SkillDescription = @description
END

GO*/

CREATE PROCEDURE spListSkillsByType
@type VARCHAR(15)
AS
BEGIN
SELECT *
FROM tblSkill
WHERE SkillType = @type
END 

GO

CREATE PROCEDURE spListSkillsByCategory
@category VARCHAR(15)
AS
BEGIN
SELECT *
FROM tblJob
WHERE JobCategory = @category
END

GO

/* Equipment */

CREATE PROCEDURE spGetEquipmentByID
@id VARCHAR(30)
AS 
BEGIN
SELECT *
FROM tblEquipment
WHERE EquipmentID = @id
END

GO

/*CREATE PROCEDURE spGetEquipmentByDescription
@description VARCHAR(80)
AS
BEGIN
SELECT *
FROM tblEquipment
WHERE EquipmentDescription = @description
END

GO*/

CREATE PROCEDURE spListEquipmentByJob
@jobID VARCHAR(30)
AS
BEGIN
SELECT *
FROM tblEquipment
WHERE (SELECT EquipmentID FROM tblJobEquipment WHERE JobID = @jobID) = EquipmentID
END

/*GO

/* Contract */

CREATE PROCEDURE spGetContractByID
@id VARCHAR(30)
AS
BEGIN
SELECT *
FROM tblContract
WHERE ContractID = @id
END*/

GO

CREATE PROCEDURE spListContractsByClientID
@id VARCHAR(30)
AS
BEGIN
SELECT *
FROM tblContract
WHERE ClientID = @id
END

GO

CREATE PROCEDURE spListContractsByServiceLevel
@serviceLevel VARCHAR(20)
AS
BEGIN
SELECT *
FROM tblContract
WHERE ServiceLevel = @serviceLevel
END

GO 

CREATE PROCEDURE spAuthenticate
@userName VARCHAR(30),
@password VARCHAR(30)
AS
BEGIN
SELECT * 
FROM tblAuthentication
WHERE UserName = @userName AND UserPassword = @password
END

/*CREATE PROCEDURE spGetContractByExperationDate
@date DATE
AS
BEGIN
SELECT *
FROM tblContract
WHERE ExperationDate = @date
END

GO*/

/*CREATE PROCEDURE spListClientContracts
@id VARCHAR(30)
AS
BEGIN
SELECT ContractID
FROM tblClient
WHERE ClientID = @id
END*/