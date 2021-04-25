USE SENGroup25DB

GO

CREATE PROCEDURE spDeleteClient
(
@id VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			IF EXISTS(SELECT * FROM tblJob WHERE ClientID = @id)
			BEGIN
			DELETE FROM tblJob
			WHERE ClientID = @id 
			END

			DELETE FROM tblClient 
			WHERE ClientID=@id

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
@id VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			IF EXISTS(SELECT * FROM tblEmployeeSkills WHERE EmpID = @id)
			BEGIN
			DELETE FROM tblEmployeeSkills
			WHERE EmpID = @id
			END

			IF EXISTS(SELECT * FROM tblJob WHERE EmpID = @id)
			BEGIN
			UPDATE tblJob
			SET JobStatus = 'UNASSIGNED', EmpID = NULL
			WHERE EmpID = @id
			END

			DELETE FROM tblEmployee 
			WHERE EmpID=@id

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
@id VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			IF EXISTS(SELECT * FROM tblJobEquipment WHERE JobID = @id)
			BEGIN
			DELETE FROM tblJobEquipment
			WHERE JobID = @id
			END

			DELETE FROM tblJob
			WHERE JobID = @id

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
@id VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			IF EXISTS(SELECT * FROM tblEmployeeSkills WHERE SkillID = @id)
			BEGIN
			DELETE FROM tblEmployeeSkills
			WHERE SkillID = @id
			END

			DELETE FROM tblSkills 
			WHERE SkillID = @id

		COMMIT
		PRINT 'spDeleteSkill Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spDeleteSkill Transaction UNSUCCSESSFUL'
	END CATCH
END

GO

CREATE PROCEDURE spDeleteEquipment
(
@id VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			IF EXISTS(SELECT * FROM tblJobEquipment WHERE EquipmentID = @id)
			BEGIN
			DELETE FROM tblJobEquipment
			WHERE EquipmentID = @id
			END

			DELETE FROM tblEquipment 
			WHERE EquipmentID = @id

		COMMIT
		PRINT 'spDeleteEquipment Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spDeleteEquipment Transaction UNSUCCSESSFUL'
	END CATCH
END 