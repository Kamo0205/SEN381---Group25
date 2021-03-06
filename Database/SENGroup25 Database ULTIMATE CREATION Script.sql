USE [master]
GO
/****** Object:  Database [SENGroup25DB]    Script Date: 19/05/2021 7:00:37 AM ******/
CREATE DATABASE [SENGroup25DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SENGroup25DBData', FILENAME = N'D:\Documents\Database\SEN\SENGroup25DB.mdf' , SIZE = 20480KB , MAXSIZE = 10485760KB , FILEGROWTH = 10%)
 LOG ON 
( NAME = N'SENGroup25DBLogs', FILENAME = N'D:\Documents\Database\SEN\SENGroup25DB.ldf' , SIZE = 20480KB , MAXSIZE = 10485760KB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SENGroup25DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SENGroup25DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SENGroup25DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SENGroup25DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SENGroup25DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SENGroup25DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SENGroup25DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SENGroup25DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SENGroup25DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SENGroup25DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SENGroup25DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SENGroup25DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SENGroup25DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SENGroup25DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SENGroup25DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SENGroup25DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SENGroup25DB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SENGroup25DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SENGroup25DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SENGroup25DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SENGroup25DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SENGroup25DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SENGroup25DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SENGroup25DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SENGroup25DB] SET RECOVERY FULL 
GO
ALTER DATABASE [SENGroup25DB] SET  MULTI_USER 
GO
ALTER DATABASE [SENGroup25DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SENGroup25DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SENGroup25DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SENGroup25DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SENGroup25DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SENGroup25DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SENGroup25DB', N'ON'
GO
ALTER DATABASE [SENGroup25DB] SET QUERY_STORE = OFF
GO
USE [SENGroup25DB]
GO
/****** Object:  Table [dbo].[tblAuthentication]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAuthentication](
	[AuthenticationID] [varchar](30) NOT NULL,
	[UserName] [varchar](30) NOT NULL,
	[UserPassword] [varchar](30) NOT NULL,
	[UserType] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AuthenticationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblClient]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblClient](
	[ClientID] [varchar](30) NOT NULL,
	[ClientName] [varchar](30) NOT NULL,
	[ClientSurname] [varchar](30) NOT NULL,
	[ClientAddress] [varchar](100) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[ContactNumber] [varchar](12) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblContract]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblContract](
	[ContractID] [varchar](30) NOT NULL,
	[ClientID] [varchar](30) NULL,
	[ServiceLevel] [varchar](20) NOT NULL,
	[ExperationDate] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ContractID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEmployee]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEmployee](
	[EmpID] [varchar](30) NOT NULL,
	[EmpName] [varchar](30) NOT NULL,
	[EmpSurname] [varchar](30) NOT NULL,
	[VatIDNumber] [varchar](10) NOT NULL,
	[ContactNumber] [varchar](12) NOT NULL,
	[Email] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEmployeeSkill]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEmployeeSkill](
	[EmpID] [varchar](30) NOT NULL,
	[SkillID] [varchar](30) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEquipment]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEquipment](
	[EquipmentID] [varchar](30) NOT NULL,
	[EquipmentDescription] [varchar](80) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EquipmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblJob]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblJob](
	[JobID] [varchar](30) NOT NULL,
	[ContractID] [varchar](30) NULL,
	[EmpID] [varchar](30) NULL,
	[ClientSatisfaction] [varchar](5) NULL,
	[JobDescription] [varchar](100) NOT NULL,
	[JobCategory] [varchar](15) NOT NULL,
	[JobType] [varchar](15) NOT NULL,
	[JobStatus] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[JobID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblJobEquipment]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblJobEquipment](
	[EquipmentID] [varchar](30) NOT NULL,
	[JobID] [varchar](30) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSkill]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSkill](
	[SkillID] [varchar](30) NOT NULL,
	[SkillDescription] [varchar](80) NOT NULL,
	[SkillCategory] [varchar](15) NOT NULL,
	[SkillType] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SkillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblContract]  WITH CHECK ADD FOREIGN KEY([ClientID])
REFERENCES [dbo].[tblClient] ([ClientID])
GO
ALTER TABLE [dbo].[tblEmployeeSkill]  WITH CHECK ADD FOREIGN KEY([EmpID])
REFERENCES [dbo].[tblEmployee] ([EmpID])
GO
ALTER TABLE [dbo].[tblEmployeeSkill]  WITH CHECK ADD FOREIGN KEY([SkillID])
REFERENCES [dbo].[tblSkill] ([SkillID])
GO
ALTER TABLE [dbo].[tblJob]  WITH CHECK ADD FOREIGN KEY([ContractID])
REFERENCES [dbo].[tblContract] ([ContractID])
GO
ALTER TABLE [dbo].[tblJob]  WITH CHECK ADD FOREIGN KEY([EmpID])
REFERENCES [dbo].[tblEmployee] ([EmpID])
GO
ALTER TABLE [dbo].[tblJobEquipment]  WITH CHECK ADD FOREIGN KEY([EquipmentID])
REFERENCES [dbo].[tblEquipment] ([EquipmentID])
GO
ALTER TABLE [dbo].[tblJobEquipment]  WITH CHECK ADD FOREIGN KEY([JobID])
REFERENCES [dbo].[tblJob] ([JobID])
GO
/****** Object:  StoredProcedure [dbo].[spAuthenticate]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spAuthenticate]
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
GO
/****** Object:  StoredProcedure [dbo].[spDeleteClient]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeleteClient]
(
@id VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			IF EXISTS(SELECT * FROM tblJob WHERE ContractID = @id)
			BEGIN
			DELETE FROM tblJobEquipment
			WHERE (SELECT JobID FROM tblJob WHERE ContractID = @id) = JobID
			DELETE FROM tblJob
			WHERE ContractID = @id 
			END

			IF EXISTS(SELECT * FROM tblContract WHERE ClientID = @id)
			BEGIN
			DELETE FROM tblContract
			WHERE ClientID = @id 
			END

			IF EXISTS(SELECT * FROM tblAuthentication WHERE AuthenticationID = @id)
			BEGIN
			DELETE FROM tblAuthentication
			WHERE AuthenticationID = @id
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
/****** Object:  StoredProcedure [dbo].[spDeleteContract]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeleteContract]
(
@id VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			IF EXISTS(SELECT * FROM tblJob WHERE ContractID = @id)
			BEGIN
			DELETE FROM tblJobEquipment
			WHERE (SELECT JobID FROM tblJob WHERE ContractID = @id) = JobID
			DELETE FROM tblJob
			WHERE ContractID = @id 
			END

			DELETE FROM tblContract 
			WHERE ContractID=@id

		COMMIT
		PRINT 'spDeleteContract Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spDeleteContract Transaction UNSUCCSESSFUL'
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteEmployee]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeleteEmployee]
(
@id VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			IF EXISTS(SELECT * FROM tblEmployeeSkill WHERE EmpID = @id)
			BEGIN
			DELETE FROM tblEmployeeSkill
			WHERE EmpID = @id
			END

			IF EXISTS(SELECT * FROM tblAuthentication WHERE AuthenticationID = @id)
			BEGIN
			DELETE FROM tblAuthentication
			WHERE AuthenticationID = @id
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
/****** Object:  StoredProcedure [dbo].[spDeleteEquipment]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeleteEquipment]
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

GO
/****** Object:  StoredProcedure [dbo].[spDeleteJob]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeleteJob]
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
/****** Object:  StoredProcedure [dbo].[spDeleteSkill]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeleteSkill]
(
@id VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			IF EXISTS(SELECT * FROM tblEmployeeSkill WHERE SkillID = @id)
			BEGIN
			DELETE FROM tblEmployeeSkill
			WHERE SkillID = @id
			END

			DELETE FROM tblSkill
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
/****** Object:  StoredProcedure [dbo].[spGetClientByAddress]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetClientByAddress]
@address VARCHAR(100)
AS
BEGIN
SELECT *
FROM tblClient
WHERE ClientAddress LIKE '%' + @address + '%' 
END

GO
/****** Object:  StoredProcedure [dbo].[spGetClientByContactNumber]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetClientByContactNumber]
@number VARCHAR(12)
AS
BEGIN
SELECT *
FROM tblClient
WHERE ContactNumber LIKE '%' + @number + '%' 
END

GO
/****** Object:  StoredProcedure [dbo].[spGetClientByEmail]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetClientByEmail]
@email VARCHAR(50)
AS
BEGIN
SELECT *
FROM tblClient
WHERE Email LIKE '%' + @email + '%'
END

GO
/****** Object:  StoredProcedure [dbo].[spGetClientByID]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* Client data retrieval stored procedures */

CREATE PROCEDURE [dbo].[spGetClientByID]
@id VARCHAR(30)
AS
BEGIN
SELECT *
FROM tblClient
WHERE ClientID = @id
END

GO
/****** Object:  StoredProcedure [dbo].[spGetContractByID]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* Contract */

CREATE PROCEDURE [dbo].[spGetContractByID]
@id VARCHAR(30)
AS
BEGIN
SELECT *
FROM tblContract
WHERE ContractID = @id
END

GO
/****** Object:  StoredProcedure [dbo].[spGetEmpByContactNumber]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetEmpByContactNumber]
@number VARCHAR(12)
AS
BEGIN
SELECT *
FROM tblEmployee
WHERE ContactNumber LIKE '%' + @number + '%' 
END

GO
/****** Object:  StoredProcedure [dbo].[spGetEmpByEmail]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetEmpByEmail]
@email VARCHAR(50)
AS
BEGIN
SELECT *
FROM tblEmployee
WHERE Email LIKE '%' + @email + '%' 
END

GO
/****** Object:  StoredProcedure [dbo].[spGetEmpByID]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* Employee data retrieval stored procedures */

CREATE PROCEDURE [dbo].[spGetEmpByID]
@id VARCHAR(30)
AS
BEGIN
SELECT *
FROM tblEmployee
WHERE EmpID = @id
END

GO
/****** Object:  StoredProcedure [dbo].[spGetEmpByVatID]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetEmpByVatID]
@vat VARCHAR(10)
AS
BEGIN
SELECT *
FROM tblEmployee
WHERE VatIDNumber LIKE '%' + @vat + '%' 
END

GO
/****** Object:  StoredProcedure [dbo].[spGetEquipmentByID]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* Equipment */

CREATE PROCEDURE [dbo].[spGetEquipmentByID]
@id VARCHAR(30)
AS 
BEGIN
SELECT *
FROM tblEquipment
WHERE EquipmentID = @id
END

GO
/****** Object:  StoredProcedure [dbo].[spGetJobByID]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* Job data retrieval stored procedures */

CREATE PROCEDURE [dbo].[spGetJobByID]
@id VARCHAR(30)
AS
BEGIN
SELECT *
FROM tblJob
WHERE JobID = @id
END

GO
/****** Object:  StoredProcedure [dbo].[spGetSkillByID]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* Skill data retrieval stored procedures */

CREATE PROCEDURE [dbo].[spGetSkillByID]
@id VARCHAR(30)
AS
BEGIN
SELECT *
FROM tblSkill
WHERE SkillID = @id
END

GO
/****** Object:  StoredProcedure [dbo].[spInsertClient]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spInsertClient]
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
/****** Object:  StoredProcedure [dbo].[spInsertContract]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spInsertContract]
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
/****** Object:  StoredProcedure [dbo].[spInsertEmployee]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spInsertEmployee]
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
/****** Object:  StoredProcedure [dbo].[spInsertEmployeeSkill]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spInsertEmployeeSkill]
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
/****** Object:  StoredProcedure [dbo].[spInsertEquipment]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spInsertEquipment]
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
GO
/****** Object:  StoredProcedure [dbo].[spInsertJob]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spInsertJob]
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
/****** Object:  StoredProcedure [dbo].[spInsertJobEquipment]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spInsertJobEquipment]
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
/****** Object:  StoredProcedure [dbo].[spInsertSkill]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spInsertSkill]
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
/****** Object:  StoredProcedure [dbo].[spListClientsByName]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spListClientsByName]
@name VARCHAR(30)
AS
BEGIN
SELECT ClientID
FROM tblClient
WHERE ClientName LIKE '%' + @name + '%'
END

GO
/****** Object:  StoredProcedure [dbo].[spListClientsBySurname]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spListClientsBySurname]
@surname VARCHAR(30)
AS
BEGIN
SELECT ClientID
FROM tblClient
WHERE ClientSurname LIKE '%' + @surname + '%' 
END

GO
/****** Object:  StoredProcedure [dbo].[spListContractsByClientID]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spListContractsByClientID]
@id VARCHAR(30)
AS
BEGIN
SELECT *
FROM tblContract
WHERE ClientID = @id
END

GO
/****** Object:  StoredProcedure [dbo].[spListContractsByServiceLevel]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spListContractsByServiceLevel]
@serviceLevel VARCHAR(20)
AS
BEGIN
SELECT *
FROM tblContract
WHERE ServiceLevel = @serviceLevel
END

GO
/****** Object:  StoredProcedure [dbo].[spListEmployeesByName]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spListEmployeesByName]
@name VARCHAR(30)
AS
BEGIN
SELECT EmpID
FROM tblEmployee
WHERE EmpName LIKE '%' + @name + '%' 
END

GO
/****** Object:  StoredProcedure [dbo].[spListEmployeesBySurname]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spListEmployeesBySurname]
@surname VARCHAR(30)
AS
BEGIN
SELECT EmpID
FROM tblEmployee
WHERE EmpSurname LIKE '%' + @surname + '%' 
END

GO
/****** Object:  StoredProcedure [dbo].[spListEmployeesForJob]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spListEmployeesForJob]
@category VARCHAR(15),
@type VARCHAR(15)
AS
BEGIN
SELECT *
FROM tblEmployee 
WHERE (SELECT EmpID FROM tblEmployeeSkill WHERE (SELECT SkillID FROM tblSkill WHERE SkillCategory = @category AND SkillType = @type)=SkillID) = EmpID
END 

/* Employee-ID data retrieval stored procedures */

GO
/****** Object:  StoredProcedure [dbo].[spListEquipmentByJob]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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

CREATE PROCEDURE [dbo].[spListEquipmentByJob]
@jobID VARCHAR(30)
AS
BEGIN
SELECT *
FROM tblEquipment
WHERE (SELECT EquipmentID FROM tblJobEquipment WHERE JobID = @jobID) = EquipmentID
END

GO
/****** Object:  StoredProcedure [dbo].[spListJobsByCategory]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spListJobsByCategory]
@category VARCHAR(15)
AS
BEGIN
SELECT *
FROM tblJob
WHERE JobCategory = @category
END

GO
/****** Object:  StoredProcedure [dbo].[spListJobsByContractID]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spListJobsByContractID]
@id VARCHAR(30)
AS
BEGIN
SELECT *
FROM tblJob
WHERE ContractID = @id
END

GO
/****** Object:  StoredProcedure [dbo].[spListJobsByEmpID]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spListJobsByEmpID]
@id VARCHAR(30)
AS
BEGIN
SELECT *
FROM tblJob
WHERE EmpID = @id
END

GO
/****** Object:  StoredProcedure [dbo].[spListJobsByStatus]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spListJobsByStatus]
@status VARCHAR(15)
AS
BEGIN
SELECT *
FROM tblJob
WHERE JobStatus = @status
END

GO
/****** Object:  StoredProcedure [dbo].[spListJobsByType]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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

CREATE PROCEDURE [dbo].[spListJobsByType]
@type VARCHAR(15)
AS
BEGIN
SELECT *
FROM tblJob
WHERE JobType = @type
END

GO
/****** Object:  StoredProcedure [dbo].[spListSkillsByCategory]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spListSkillsByCategory]
@category VARCHAR(15)
AS
BEGIN
SELECT *
FROM tblJob
WHERE JobCategory = @category
END

GO
/****** Object:  StoredProcedure [dbo].[spListSkillsByEmpID]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spListSkillsByEmpID]
@id VARCHAR(30)
AS
BEGIN
SELECT *
FROM tblSkill
WHERE (SELECT SkillID FROM tblEmployeeSkill WHERE EmpID = @id) = SkillID
END

GO
/****** Object:  StoredProcedure [dbo].[spListSkillsByType]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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

CREATE PROCEDURE [dbo].[spListSkillsByType]
@type VARCHAR(15)
AS
BEGIN
SELECT *
FROM tblSkill
WHERE SkillType = @type
END 

GO
/****** Object:  StoredProcedure [dbo].[spReassignJob]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spReassignJob]
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
			EmpID = @employeeID,
			JobStatus = 'Assigned'
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
/****** Object:  StoredProcedure [dbo].[spUpdateClient]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* Client */

CREATE PROCEDURE [dbo].[spUpdateClient]
(
@id VARCHAR(30),
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

			UPDATE tblAuthentication
			SET
			UserName = @email
			WHERE AuthenticationID = @id

			UPDATE tblClient 
			SET 
			ClientName = @name,
			ClientSurname = @surname,
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
/****** Object:  StoredProcedure [dbo].[spUpdateClientPassword]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpdateClientPassword]
(
@id VARCHAR(30),
@password VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblAuthentication
			SET
			UserPassword = @password
			WHERE AuthenticationID = @id

		COMMIT
		PRINT 'spUpdateClientPassword Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateClientPassword Transaction UNSUCCESSFUL'
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[spUpdateContract]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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

CREATE PROCEDURE [dbo].[spUpdateContract]
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
/****** Object:  StoredProcedure [dbo].[spUpdateEmployee]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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

CREATE PROCEDURE [dbo].[spUpdateEmployee]
(
@id VARCHAR(30),
@name VARCHAR(30),
@surname VARCHAR(30),
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
			UserType = @type
			WHERE AuthenticationID = @id

			UPDATE tblEmployee 
			SET 
			EmpName = @name,
			EmpSurname = @surname,
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
/****** Object:  StoredProcedure [dbo].[spUpdateEmployeePassword]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpdateEmployeePassword]
(
@id VARCHAR(30),
@password VARCHAR(30)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblAuthentication
			SET
			UserPassword = @password
			WHERE AuthenticationID = @id

		COMMIT
		PRINT 'spUpdateEmployeePassword Transaction Successful'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'spUpdateEmployeePassword Transaction UNSUCCESSFUL'
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[spUpdateEmployeeSkills]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpdateEmployeeSkills]
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
/****** Object:  StoredProcedure [dbo].[spUpdateEquipment]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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

CREATE PROCEDURE [dbo].[spUpdateEquipment]
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
/****** Object:  StoredProcedure [dbo].[spUpdateJob]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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

CREATE PROCEDURE [dbo].[spUpdateJob]
(
@id VARCHAR(30),
@contractID VARCHAR(30),
@empID VARCHAR(30),
@clientSatisfaction VARCHAR(5),
@description VARCHAR(100),
@category VARCHAR(15),
@type VARCHAR(15),
@status VARCHAR(15)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

			UPDATE tblJob 
			SET 
			ContractID = @contractID,
			EmpID = @empID,
			ClientSatisfaction = @clientSatisfaction,
			JobDescription = @description,
			JobCategory = @category,
			JobType = @type,
			JobStatus = @status
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
/****** Object:  StoredProcedure [dbo].[spUpdateJobEquipment]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpdateJobEquipment]
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
GO
/****** Object:  StoredProcedure [dbo].[spUpdateSkill]    Script Date: 19/05/2021 7:00:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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

CREATE PROCEDURE [dbo].[spUpdateSkill]
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

			UPDATE tblSkill
			SET 
			SkillDescription = @description,
			SkillCategory = @category,
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
USE [master]
GO
ALTER DATABASE [SENGroup25DB] SET  READ_WRITE 
GO
