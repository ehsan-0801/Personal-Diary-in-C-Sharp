/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [UserId]
      ,[UserName]
      ,[Password]
  FROM [DiaryDatabase].[dbo].[Writers]