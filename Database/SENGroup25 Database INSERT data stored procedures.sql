USE SENGroup25DB

GO

CREATE PROCEDURE spInsertClient
(
@id VARCHAR(30),
@contractID VARCHAR(30),
@name VARCHAR(30),
@surname VARCHAR(30),
@address VARCHAR(100),
@email VARCHAR(50),
@number VARCHAR(12)
)
AS 
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			INSERT INTO tblClient(ClientID,ContractID,ClientName,ClientSurname,ClientAddress,Email,ContactNumber)
			VALUES(@id,@contractID,@name,@surname,@address,@email,@number)

		COMMIT
		PRINT 'spInsertClient Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spInsertClient Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spInsertEmployee
(
@id VARCHAR(30),
@name VARCHAR(30),
@surname VARCHAR(30),
@vatID VARCHAR(100),
@email VARCHAR(50),
@number VARCHAR(12)
)
AS 
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			INSERT INTO tblEmployee(EmpID,EmpName,EmpSurname,VatIDNumber,Email,ContactNumber)
			VALUES(@id,@name,@surname,@vatID,@email,@number)

		COMMIT
		PRINT 'spInsertEmployee Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spInsertEmployee Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spInsertJob
(
@id VARCHAR(30),
@clientID INT,
@empID INT,
@description VARCHAR(100),
@type VARCHAR(10),
@status VARCHAR(10)
)
AS 
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			INSERT INTO tblJob(JobID,ClientID,EmpID,JobDescription,JobType,JobStatus)
			VALUES(@id,@clientID,@empID,@description,@type,@status)

		COMMIT
		PRINT 'spInsertJob Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spInsertJob Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spInsertSkill
(
@id VARCHAR(30),
@description VARCHAR(100),
@type VARCHAR(10)
)
AS 
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			INSERT INTO tblSkills(SkillID,SkillDescription,SkillType)
			VALUES(@id,@description,@type)

		COMMIT
		PRINT 'spInsertSkill Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spInsertSkill Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spInsertEmployeeSkill
(
@id VARCHAR(30),
@empID INT,
@skillID INT
)
AS 
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			INSERT INTO tblEmployeeSkills(EmpID,EmpID,SkillID)
			VALUES(@empID,@empID,@skillID)

		COMMIT
		PRINT 'spInsertEmployeeSkill Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spInsertEmployeeSkill Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spInsertContract
(
@id VARCHAR(30),
@serviceLevel VARCHAR(20),
@experationDate DATE
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			
			INSERT INTO tblContract(ContractID,ServiceLevel,ExperationDate)
			VALUES(@id,@experationDate,@serviceLevel)

		COMMIT
		PRINT 'spInsertContract Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spInsertContract Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spInsertEmployeeSkills
(
@employeeID VARCHAR(30),
@skillID VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			
			INSERT INTO tblEmployeeSkills(EmpID,SkillID)
			VALUES(@employeeID,@skillID)

		COMMIT
		PRINT 'spInsertEmployeeSkills Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spInsertEmployeeSkills Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spInsertJobEquipment
(

@equipmentID VARCHAR(30),
@jobID VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			
			INSERT INTO tblJobEquipment(EquipmentID,JobID)
			VALUES(@equipmentID,@jobID)

		COMMIT
		PRINT 'spInsertJobEquipment Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spInsertJobEquipment Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spInsertEquipment
(

@id VARCHAR(30),
@description VARCHAR(80)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			
			INSERT INTO tblEquipment(EquipmentID,EquipmentDescription)
			VALUES(@id,@description)

		COMMIT
		PRINT 'spInsertEquipment Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spInsertEquipment Transaction UNSUCCESSFUL'
	END CATCH
END