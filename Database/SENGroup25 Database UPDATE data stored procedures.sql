USE SENGroup25DB

GO

/* Client */

CREATE PROCEDURE spUpdateClient
(
@id VARCHAR(30),
@name VARCHAR(30),
@surname VARCHAR(30),
@password VARCHAR(30),
@address VARCHAR(100),
@email VARCHAR(50),
@number VARCHAR(12)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblAuthentication
			SET
			UserName = @email,
			UserPassword = @password
			WHERE AuthenticationID = @id

			UPDATE tblClient 
			SET 
			ClientName = @name,
			ClientSurname = @surname,
			ClientPassword = @password,
			ClientAddress = @address,
			Email = @email,
			ContactNumber = @number
			WHERE ClientID = @id

		COMMIT
		PRINT 'spUpdateClient Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateClient Transaction UNSUCCESSFUL'
	END CATCH
END

GO

/*CREATE PROCEDURE spUpdateClientName
(
@id VARCHAR(30),
@name VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblClient 
			SET 
			ClientName = @name
			WHERE ClientID = @id

		COMMIT
		PRINT 'spUpdateClientName Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateClientName Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateClientSurname
(
@id VARCHAR(30),
@surname VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblClient 
			SET 
			ClientSurname = @surname
			WHERE ClientID = @id

		COMMIT
		PRINT 'spUpdateClientSurname Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateClientSurname Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateClientAddress
(
@id VARCHAR(30),
@address VARCHAR(100)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblClient 
			SET 
			ClientAddress = @address
			WHERE ClientID = @id

		COMMIT
		PRINT 'spUpdateClientAddress Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateClientAddress Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateClientEmail
(
@id VARCHAR(30),
@email VARCHAR(50)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblClient 
			SET 
			Email = @email
			WHERE ClientID = @id

		COMMIT
		PRINT 'spUpdateClientEmail Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateClientEmail Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateClientNumber
(
@id VARCHAR(30),
@number VARCHAR(12)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblClient 
			SET 
			ContactNumber = @number
			WHERE ClientID = @id

		COMMIT
		PRINT 'spUpdateClientNumber Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateClientNumber Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateClientContractID
(
@id VARCHAR(30),
@contractID VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblClient 
			SET 
			ContractID = @contractID
			WHERE ClientID = @id

			COMMIT
		PRINT 'spUpdateClientContractID Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateClientContractID Transaction UNSUCCESSFUL'
	END CATCH
END

GO */

/* Employee */

CREATE PROCEDURE spUpdateEmployee
(
@id VARCHAR(30),
@name VARCHAR(30),
@surname VARCHAR(30),
@password VARCHAR(30),
@vat VARCHAR(10),
@email VARCHAR(50),
@number VARCHAR(12),
@type VARCHAR(15)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblAuthentication
			SET
			UserName = @email,
			UserPassword = @password,
			UserType = @type
			WHERE AuthenticationID = @id

			UPDATE tblEmployee 
			SET 
			EmpName = @name,
			EmpSurname = @surname,
			EmpPassword = @password,
			VatIDNumber = @vat,
			Email = @email,
			ContactNumber = @number
			WHERE EmpID = @id

		COMMIT
		PRINT 'spUpdateEmployee Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateEmployee Transaction UNSUCCESSFUL'
	END CATCH
END

GO

/*CREATE PROCEDURE spUpdateEmpName
(
@id VARCHAR(30),
@name VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblEmployee 
			SET 
			EmpName = @name
			WHERE EmpID = @id

		COMMIT
		PRINT 'spUpdateEmpName Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateEmpName Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateEmpSurname
(
@id VARCHAR(30),
@surname VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblEmployee 
			SET 
			EmpSurname = @surname
			WHERE EmpID = @id

		COMMIT
		PRINT 'spUpdateEmpSurname Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateEmpSurname Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateEmpVatIDNumber
(
@id VARCHAR(30),
@vat VARCHAR(10)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblEmployee 
			SET 
			VatIDNumber = @vat
			WHERE EmpID = @id

		COMMIT
		PRINT 'spUpdateEmpVatIDNumber Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateEmpVatIDNumber Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateEmpEmail
(
@id VARCHAR(30),
@email VARCHAR(50)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblEmployee 
			SET 
			Email = @email
			WHERE EmpID = @id

		COMMIT
		PRINT 'spUpdateEmpEmail Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateEmpEmail Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateEmpNumber
(
@id VARCHAR(30),
@number VARCHAR(12)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblEmployee 
			SET 
			ContactNumber = @number
			WHERE EmpID = @id

		COMMIT
		PRINT 'spUpdateEmpNumber Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateEmpNumber Transaction UNSUCCESSFUL'
	END CATCH
END

GO*/

/* Job */

CREATE PROCEDURE spUpdateJob
(
@id VARCHAR(30),
@description VARCHAR(100),
@type VARCHAR(15)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblJob 
			SET 
			JobDescription = @description,
			JobType = @type
			WHERE JobID = @id

		COMMIT
		PRINT 'spUpdateJob Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateJob Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spReassignJob
(
@id VARCHAR(30),
@employeeID VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblJob 
			SET 
			EmpID = @employeeID
			WHERE JobID = @id

		COMMIT
		PRINT 'spReassignJob Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spReassignJob Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateJobStatus
(
@id VARCHAR(30),
@status VARCHAR(15)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblJob 
			SET 
			JobStatus = @status
			WHERE JobID = @id

		COMMIT
		PRINT 'spUpdateJobStatus Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateJobStatus Transaction UNSUCCESSFUL'
	END CATCH
END

GO

/*CREATE PROCEDURE spUpdateJobClient
(
@id VARCHAR(30),
@clientID INT
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblJob 
			SET 
			ClientID = @clientID
			WHERE JobID = @id

		COMMIT
		PRINT 'spUpdateJobClient Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateJobClient Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateJobDescription
(
@id VARCHAR(30),
@description VARCHAR(100)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblJob 
			SET 
			JobDescription = @description
			WHERE JobID = @id

		COMMIT
		PRINT 'spUpdateJobDescription Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateJobDescription Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateJobType
(
@id VARCHAR(30),
@type VARCHAR(10)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblJob 
			SET 
			JobType = @type
			WHERE JobID = @id

		COMMIT
		PRINT 'spUpdateJobType Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateJobType Transaction UNSUCCESSFUL'
	END CATCH
END

GO */

/* Skill */

CREATE PROCEDURE spUpdateSkill
(
@id VARCHAR(30),
@description VARCHAR(100),
@type VARCHAR(15)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblSkill
			SET 
			SkillDescription = @description,
			SkillType = @type
			WHERE SkillID = @id

		COMMIT
		PRINT 'spUpdateSkill Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateSkill Transaction UNSUCCESSFUL'
	END CATCH
END

GO

/*CREATE PROCEDURE spUpdateSkillDescription
(
@id VARCHAR(30),
@description VARCHAR(100)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblSkills 
			SET 
			SkillDescription = @description
			WHERE SkillID = @id

		COMMIT
		PRINT 'spUpdateSkillDescription Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateSkillDescription Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateSkillType
(
@id VARCHAR(30),
@type VARCHAR(10)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblSkills 
			SET 
			SkillType = @type
			WHERE SkillID = @id

		COMMIT
		PRINT 'spUpdateSkillType Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateSkillType Transaction UNSUCCESSFUL'
	END CATCH
END

GO*/

/* Contract */

CREATE PROCEDURE spUpdateContract
(
@id VARCHAR(30),
@serviceLevel VARCHAR(80),
@date VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblContract 
			SET 
			ServiceLevel = @serviceLevel,
			ExperationDate = @date
			WHERE ContractID = @id

		COMMIT
		PRINT 'spUpdateContract Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateContract Transaction UNSUCCESSFUL'
	END CATCH
END

GO

/*CREATE PROCEDURE spUpdateContractServiceLevel
(
@id VARCHAR(30),
@serviceLevel VARCHAR(80)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblContract 
			SET 
			ServiceLevel = @serviceLevel
			WHERE ContractID = @id

		COMMIT
		PRINT 'spUpdateContractServiceLevel Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateContractServiceLevel Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateContractExperationDate
(
@id VARCHAR(30),
@date DATE
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblContract 
			SET 
			ExperationDate = @date
			WHERE ContractID = @id

		COMMIT
		PRINT 'spUpdateContractExperationDate Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateContractExperationDate Transaction UNSUCCESSFUL'
	END CATCH
END


GO*/

/* Equipment */

CREATE PROCEDURE spUpdateEquipment
(
@id VARCHAR(30),
@description VARCHAR(80)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblEquipment 
			SET 
			EquipmentDescription = @description
			WHERE EquipmentID = @id

		COMMIT
		PRINT 'spUpdateEquipment Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateEquipment Transaction UNSUCCESSFUL'
	END CATCH
END

/* Composite keys */

GO

CREATE PROCEDURE spUpdateEmployeeSkills
(
@empID VARCHAR(30),
@skillID VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblEmployeeSkill
			SET 
			EmpID = @empID
			WHERE SkillID = @skillID

		COMMIT
		PRINT 'spUpdateEmployeeSkills Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateEmployeeSkills Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateJobEquipment
(
@equipmentID VARCHAR(30),
@jobID VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblJobEquipment 
			SET 
			EquipmentID = @equipmentID
			WHERE JobID = @jobID

		COMMIT
		PRINT 'spUpdateJobEquipment Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateJobEquipment Transaction UNSUCCESSFUL'
	END CATCH
END