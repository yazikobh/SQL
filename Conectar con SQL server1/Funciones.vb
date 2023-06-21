Imports System.Data.SqlClient


Public Class Funciones
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand

    Public Function Registrar_Producto(ByVal data As Propiedades) As Boolean
        Try
            cn.Open()
            cmd = New SqlCommand("SP_RegistrarProducto", cn)
            cmd.CommandType = (CommandType.StoredProcedure)

            With cmd.Parameters
                .AddWithValue("@CodProd", data.cod_prod)
                .AddWithValue("@Nombre", data.nombre)
                .AddWithValue("@Existencia", data.existencia)
                .AddWithValue("@Imagen", data.imagen)
            End With

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cn.Close()
        End Try



    End Function
    Public Function Modificar_Producto(ByVal data As Propiedades) As Boolean
        Try
            cn.Open()
            cmd = New SqlCommand("SP_ModificarProducto", cn)
            cmd.CommandType = (CommandType.StoredProcedure)

            With cmd.Parameters
                .AddWithValue("@CodProd", data.cod_prod)
                .AddWithValue("@Nombre", data.nombre)
                .AddWithValue("@Existencia", data.existencia)
                .AddWithValue("@Imagen", data.imagen)
            End With

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cn.Close()
        End Try



    End Function
    Public Function Eliminar_Producto(ByVal data As Propiedades) As Boolean
        Try
            cn.Open()
            cmd = New SqlCommand("SP_EliminarProducto", cn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodProd", data.cod_prod)

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cn.Close()
        End Try
    End Function

    Public Function Mostrar_Producto() As DataTable
        Try
            cn.Open()
            cmd = New SqlCommand("SP_MostrarProducto", cn)
            cmd.CommandType = CommandType.StoredProcedure

            If cmd.ExecuteNonQuery() Then
                Dim da As New SqlDataAdapter(cmd)
                Mostrar_Producto = New DataTable
                da.Fill(Mostrar_Producto)

                Return Mostrar_Producto
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            cn.Close()

        End Try
    End Function
End Class
