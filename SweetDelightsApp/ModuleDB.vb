﻿Imports System.Data.SqlClient

Module ModuleDB
    ' Change the Data Source to match your SQL Server instance
    Public connectionString As String =
    "Data Source=NEIL\SQLEXPRESS;Initial Catalog=SweetDelightsDB;Integrated Security=True"


    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
End Module