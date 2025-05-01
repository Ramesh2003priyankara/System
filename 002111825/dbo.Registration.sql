CREATE TABLE [dbo].[Registration] (
    [Reg_No]       INT          NOT NULL,
    [First_Name]   VARCHAR (50) NOT NULL,
    [Last_Name]    VARCHAR (50) NOT NULL,
    [dob]          DATETIME     NOT NULL,
    [Gender]       VARCHAR (50) NOT NULL,
    [Address]      VARCHAR (50) NOT NULL,
    [Email]        VARCHAR (50) NOT NULL,
    [Mobile_Phone] INT          NOT NULL,
    [Home_Phone]   INT          NOT NULL,
    [Parent_Name]  VARCHAR (50) NOT NULL,
    [NIC]          VARCHAR (50) NOT NULL,
    [Contact_No]   INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Reg_No] ASC)
);

