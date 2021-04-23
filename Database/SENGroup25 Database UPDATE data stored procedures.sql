USE SENGroup25DB

GO

CREATE PROCEDURE spUpdateClient
(
@clientID INT,
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

			UPDATE tblClient 
			SET 
			ClientName = @name,
			ClientSurname = @surname,
			ClientAddress = @address,
			Email = @email,
			ContactNumber = @number
			WHERE ClientID = @clientID

		COMMIT
		PRINT 'spUpdateClient Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateClient Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateClientName
(
@clientID INT,
@name VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblClient 
			SET 
			ClientName = @name
			WHERE ClientID = @clientID

		COMMIT
		PRINT 'spUpdateClientName Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateClientName Transaction UNSUCCESSFUL'
	END CATCH
END

GO

GO

CREATE PROCEDURE spUpdateClientSurname
(
@clientID INT,
@surname VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblClient 
			SET 
			ClientSurname = @surname
			WHERE ClientID = @clientID

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
@clientID INT,
@address VARCHAR(100)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblClient 
			SET 
			ClientAddress = @address
			WHERE ClientID = @clientID

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
@clientID INT,
@email VARCHAR(50)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblClient 
			SET 
			Email = @email
			WHERE ClientID = @clientID

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
@clientID INT,
@number VARCHAR(12)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblClient 
			SET 
			ContactNumber = @number
			WHERE ClientID = @clientID

		COMMIT
		PRINT 'spUpdateClientNumber Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateClientNumber Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateEmployee
(
@empID INT,
@name VARCHAR(30),
@surname VARCHAR(30),
@vat VARCHAR(10),
@email VARCHAR(50),
@number VARCHAR(12)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblEmployee 
			SET 
			EmpName = @name,
			EmpSurname = @surname,
			VatIDNumber = @vat,
			Email = @email,
			ContactNumber = @number
			WHERE EmpID = @empID

		COMMIT
		PRINT 'spUpdateEmployee Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateEmployee Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateEmpName
(
@empID INT,
@name VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblEmployee 
			SET 
			EmpName = @name
			WHERE EmpID = @empID

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
@empID INT,
@surname VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblEmployee 
			SET 
			EmpSurname = @surname
			WHERE EmpID = @empID

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
@empID INT,
@vat VARCHAR(10)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblEmployee 
			SET 
			VatIDNumber = @vat
			WHERE EmpID = @empID

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
@empID INT,
@email VARCHAR(50)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblEmployee 
			SET 
			Email = @email
			WHERE EmpID = @empID

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
@empID INT,
@number VARCHAR(12)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblEmployee 
			SET 
			ContactNumber = @number
			WHERE EmpID = @empID

		COMMIT
		PRINT 'spUpdateEmpNumber Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateEmpNumber Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateJob
(
@jobID INT,
@clientID INT,
@description VARCHAR(100),
@type VARCHAR(10)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblJob 
			SET 
			ClientID = @clientID,
			JobDescription = @description,
			JobType = @type
			WHERE JobID = @jobID

		COMMIT
		PRINT 'spUpdateJob Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateJob Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateJobClient
(
@jobID INT,
@clientID INT
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblJob 
			SET 
			ClientID = @clientID
			WHERE JobID = @jobID

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
@jobID INT,
@description VARCHAR(100)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblJob 
			SET 
			JobDescription = @description
			WHERE JobID = @jobID

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
@jobID INT,
@type VARCHAR(10)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblJob 
			SET 
			JobType = @type
			WHERE JobID = @jobID

		COMMIT
		PRINT 'spUpdateJobType Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateJobType Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateSkill
(
@skillID INT,
@description VARCHAR(100),
@type VARCHAR(10)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblSkills 
			SET 
			SkillDescription = @description,
			SkillType = @type
			WHERE SkillID = @skillID

		COMMIT
		PRINT 'spUpdateSkill Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateSkill Transaction UNSUCCESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spUpdateSkillDescription
(
@skillID INT,
@description VARCHAR(100)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblSkills 
			SET 
			SkillDescription = @description
			WHERE SkillID = @skillID

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
@skillID INT,
@type VARCHAR(10)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblSkills 
			SET 
			SkillType = @type
			WHERE SkillID = @skillID

		COMMIT
		PRINT 'spUpdateSkillType Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateSkillType Transaction UNSUCCESSFUL'
	END CATCH
END
