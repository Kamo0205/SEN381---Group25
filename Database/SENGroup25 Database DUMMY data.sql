USE SENGroup25DB

GO

EXEC spInsertEmployee @id = 'tianAdminID' , @name = 'Tian', @surname = 'Hanekom', @password = 'Fumz',@vatID = '101vatID', @email = 'hanekom.tian@gmail.com', @number = '+27738158483', @type = 'Admin';

GO

EXEC spInsertEmployee @id = 'johanAdminID', @name = 'Johan', @surname = 'Schoeman', @password = 'Vatmz',@vatID = '102vatID', @email = 'jschoeman@gmail.com', @number = '+27609931422', @type = 'Admin';

GO

EXEC spInsertEmployee @id = 'arcoCallCentreID', @name = 'Arco', @surname = 'Unknown', @password = 'Mdoa', @vatID = '103vatID', @email = 'arco@gmail.com', @number = '+27111111111', @type = 'CallCentre';

GO

EXEC spInsertEmployee @id = 'kamoTechnicianID', @name = 'Kamo', @surname = 'Unknown', @password = 'Wmya', @vatID = '104vatID', @email = 'kamo@gmail.com', @number = '+27222222222', @type = 'Technician';

GO

EXEC spInsertSkill @id = 'installationSkillID', @description = 'Can install software and tech equipment', @category = 'Hardware', @type = 'Installation';

GO

EXEC spInsertEmployeeSkill @empID = 'kamoTechnicianID', @skillID = 'installationSkillID';

GO

EXEC spInsertClient @id = 'hanoClientID', @name = 'Hano', @surname = 'Jochemus', @password = 'Tmza',@address = 'Girlfriends house', @email = 'hano@gmail.com', @number = '+27715239487', @type = 'Client';

GO

EXEC spInsertContract @id = 'premiumID', @clientID = 'hanoClientID', @serviceLevel = 'premium', @experationDate = '2023-03-03';

GO

EXEC spInsertJob @id = 'hanoJobID', @contractID = 'premiumID', @empID = null, @description = 'Buy and install new laptop', @category = 'Hardware', @type = 'Installation', @status = 'unassigned';

GO

EXEC spInsertEquipment @id = 'pcEquipmentID', @description = 'PC installation equipment';

GO 

EXEC spInsertJobEquipment @equipmentID = 'pcEquipmentID', @jobID = 'hanoJobID';