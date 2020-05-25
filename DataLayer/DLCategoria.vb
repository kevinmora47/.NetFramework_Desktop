Imports BusinessEntities
Imports System.Data.SqlClient
Public Class DLCategoria
    Inherits Conexion

    Public Function Listar() As DataTable

        Try

            Dim Dr As SqlDataReader
            Dim Tabla As New DataTable
            Dim Cmd As New SqlCommand("categoria_listar", MyBase.conexion)

            Cmd.CommandType = CommandType.StoredProcedure
            MyBase.conexion.Open()
            Dr = Cmd.ExecuteReader()
            Tabla.Load(Dr)
            Return Tabla




        Catch ex As Exception

        End Try

    End Function

    Public Function Buscar(valor As String) As DataTable

    End Function

    Public Sub Insertar(Obj As Categoria)

    End Sub

    Public Sub Actualizar(Obj As Categoria)

    End Sub

    Public Sub Eliminar(id As Integer)

    End Sub
    Public Sub Activar(id As Integer)

    End Sub

    Public Sub Descativar(id As Integer)

    End Sub



End Class
