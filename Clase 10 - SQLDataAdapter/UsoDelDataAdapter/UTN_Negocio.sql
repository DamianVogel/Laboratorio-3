/****** Script para el comando SelectTopNRows de SSMS  ******/
SELECT TOP 1000 [Id_Producto]
      ,[Nombre]
      ,[Tipo]
      ,[Proveedor]
  FROM [UTN_Negocio].[dbo].[Productos]