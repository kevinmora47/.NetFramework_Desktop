Imports System.Data.SqlClient
Public Class Conexion

    Public conexion As SqlConnection

    Public Sub New()
        Me.conexion = New SqlConnection("Data Source=DESKTOP-UVJK1GN\SQLEXPRESS;Initial Catalog=dbsistema;Integrated Security=True")
    End Sub


End Class
