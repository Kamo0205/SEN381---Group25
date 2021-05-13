USE SENGroup25DB

GO

EXEC spInsertEmployee @id = 'tianAdminID' , @name = 'Tian', @surname = 'Hanekom', @vatID = '101vatID', @email = 'hanekom.tian@gmail.com', @number = '+27738158483';

GO

EXEC spInsertEmployee @id = 'johanAdminID', @name = 'Johan', @surname = 'Schoeman', @vatID = '102vatID', @email = 'jschoeman@gmail.com', @number = '+27609931422';

GO

EXEC spInsertEmployee @id = 'arcoCallCentreID', @name = 'Arco', @surname = 'Unknown', @vatID = '103vatID', @email = 'arco@gmail.com', @number = '+27111111111';

GO

EXEC spInsertEmployee @id = 'kamoTechnicianID', @name = 'Kamo', @surname = 'Unknown', @vatID = '104vatID', @email = 'kamo@gmail.com', @number = '+27222222222';

GO

EXEC spInsertSkill @id = 'instalationSkillID', @description = 'Can install software and tech equipment', @type = 'installation';

GO

EXEC spInsertEmployeeSkill @empID = 'kamoTechnicianID', @skillID = 'instalationSkillID';

GO

EXEC spInsertContract @id = 'bronzeID', @serviceLevel = 'bronze', @experationDate = '2023-03-03' ;

GO

EXEC spInsertContract @id = 'silverID', @serviceLevel = 'silver', @experationDate = '2023-03-03';

GO

EXEC spInsertContract @id = 'premiumID', @serviceLevel = 'premium', @experationDate = '2023-03-03';

GO

EXEC spInsertClient @id = 'hanoClientID', @contractID = 'premiumID', @name = 'Hano', @surname = 'Jochemus', @address = 'Girlfriends house', @email = 'hano@gmail.com', @number = '+27715239487';

GO

EXEC spInsertJob @id = 'hanoJobID', @clientID = 'hanoClientID', @empID = null, @description = 'Buy and install new laptop', @type = 'Instalation', @status = 'unassigned';

GO

EXEC spInsertEquipment @id = 'pcEquipmentID', @description = 'PC instalation equipment';

GO 

EXEC spInsertJobEquipment @equipmentID = 'pcEquipmentID', @jobID = 'hanoJobID';