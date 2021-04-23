USE SENGroup25DB

GO

CREATE PROCEDURE spInsertClient
(
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

			INSERT INTO tblClient(ClientName,ClientSurname,ClientAddress,Email,ContactNumber)
			VALUES(@name,@surname,@address,@email,@number)

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

			INSERT INTO tblEmployee(EmpName,EmpSurname,VatIDNumber,Email,ContactNumber)
			VALUES(@name,@surname,@vatID,@email,@number)

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

			INSERT INTO tblJob(ClientID,EmpID,JobDescription,JobType,JobStatus)
			VALUES(@clientID,@empID,@description,@type,@status)

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
@description VARCHAR(100),
@type VARCHAR(10)
)
AS 
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			INSERT INTO tblSkills(SkillDescription,SkillType)
			VALUES(@description,@type)

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
@empID INT,
@skillID INT
)
AS 
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			INSERT INTO tblEmployeeSkills(EmpID,SkillID)
			VALUES(@empID,@skillID)

		COMMIT
		PRINT 'spInsertEmployeeSkill Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spInsertEmployeeSkill Transaction UNSUCCESSFUL'
	END CATCH
END