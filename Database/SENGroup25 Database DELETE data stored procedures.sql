USE SENGroup25DB

GO

CREATE PROCEDURE spDeleteClient
(
@clientID INT
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			IF EXISTS(SELECT * FROM tblJob WHERE ClientID = @clientID)
			BEGIN
			DELETE FROM tblJob
			WHERE ClientID = @clientID 
			END

			DELETE FROM tblClient 
			WHERE ClientID=@clientID

		COMMIT
		PRINT 'spDeleteClient Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spDeleteClient Transaction UNSUCCSESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spDeleteEmployee
(
@empID INT 
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			IF EXISTS(SELECT * FROM tblEmployeeSkills WHERE EmpID = @empID)
			BEGIN
			DELETE FROM tblEmployeeSkills
			WHERE EmpID = @empID
			END

			IF EXISTS(SELECT * FROM tblJob WHERE EmpID = @empID)
			BEGIN
			UPDATE tblJob
			SET JobStatus = 'UNASSIGNED', EmpID = NULL
			WHERE EmpID = @empID
			END

			DELETE FROM tblEmployee 
			WHERE EmpID=@empID

		COMMIT
		PRINT 'spDeleteEmployee Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spDeleteEmployee Transaction UNSUCCSESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spDeleteJob
(
@jobID INT
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			DELETE FROM tblJob
			WHERE JobID = @jobID

		COMMIT
		PRINT 'spDeleteJob Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spDeleteJob Transaction UNSUCCSESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spDeleteSkill
(
@skillID INT
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			IF EXISTS(SELECT * FROM tblEmployeeSkills WHERE SkillID = @skillID)
			BEGIN
			DELETE FROM tblEmployeeSkills
			WHERE SkillID = @skillID
			END

			DELETE FROM tblSkills 
			WHERE SkillID = @skillID

		COMMIT
		PRINT 'spDeleteSkill Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spDeleteSkill Transaction UNSUCCSESSFUL'
	END CATCH
END 