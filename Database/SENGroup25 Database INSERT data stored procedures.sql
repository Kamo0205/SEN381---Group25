USE SENGroup25DB

GO

CREATE PROCEDURE spInsertClient
(
@id VARCHAR(30),
@password VARCHAR(30),
@name VARCHAR(30),
@surname VARCHAR(30),
@address VARCHAR(100),
@email VARCHAR(50),
@number VARCHAR(12),
@type VARCHAR(15)
)
AS 
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			INSERT INTO tblAuthentication(AuthenticationID,UserName,UserPassword,UserType)
			VALUES(@id,@email,@password,@type)

			INSERT INTO tblClient(ClientID,ClientName,ClientSurname,ClientAddress,Email,ContactNumber)
			VALUES(@id,@name,@surname,@address,@email,@number)

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
@password VARCHAR(30),
@vatID VARCHAR(10),
@email VARCHAR(50),
@number VARCHAR(12),
@type VARCHAR(15)
)
AS 
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			INSERT INTO tblAuthentication(AuthenticationID,UserName,UserPassword,UserType)
			VALUES(@id,@email,@password,@type)

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
@contractID VARCHAR(30),
@empID VARCHAR(30),
@description VARCHAR(100),
@category VARCHAR(15),
@type VARCHAR(15),
@status VARCHAR(15)
)
AS 
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			INSERT INTO tblJob(JobID,ContractID,EmpID,JobDescription,JobCategory,JobType,JobStatus)
			VALUES(@id,@contractID,@empID,@description,@category,@type,@status)

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
@category VARCHAR(15),
@type VARCHAR(15)
)
AS 
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			INSERT INTO tblSkill(SkillID,SkillDescription,SkillCategory,SkillType)
			VALUES(@id,@description,@category,@type)

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
@empID VARCHAR(30),
@skillID VARCHAR(30)
)
AS 
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			INSERT INTO tblEmployeeSkill(EmpID,SkillID)
			VALUES(@empID,@skillID)

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
@clientID VARCHAR(30),
@serviceLevel VARCHAR(20),
@experationDate VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			
			INSERT INTO tblContract(ContractID,ClientID,ServiceLevel,ExperationDate)
			VALUES(@id,@clientID,@serviceLevel,@experationDate)

		COMMIT
		PRINT 'spInsertContract Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spInsertContract Transaction UNSUCCESSFUL'
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