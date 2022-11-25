/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[UserName]
      ,[Password]
      ,[ImagineURL]
      ,[IsActive]
  FROM [SiparisDB].[dbo].[user]