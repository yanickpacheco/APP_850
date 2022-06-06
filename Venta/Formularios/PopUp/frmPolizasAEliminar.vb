Imports BI
Public Class frmPolizasAEliminar
    Dim clsPoliza As New clsPolizabBI
    Private Sub frmPolizasAEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtgPolizasAEliminar.DataSource = clsPoliza.ListaPolizas(CLIENTE.C_Id)
        dtgPolizasAEliminar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim seleccionado As Boolean = False
        Dim idPolizaTabla As Integer
        For i As Integer = 0 To dtgPolizasAEliminar.Rows.Count - 1

            If dtgPolizasAEliminar.Rows(i).Cells("chkSeleccione").Value = True Then
                seleccionado = True
                idPolizaTabla = i
            End If
        Next

        If seleccionado = False Then
            MsgBox("Debe seleccionar poliza a Eliminar", vbInformation, "CORDIALPHONE")
            Exit Sub
        End If

        If MsgBox("Esta seguro de eliminar la siguiente Poliza: " & vbNewLine & vbNewLine & "Rut: " & dtgPolizasAEliminar.Rows(idPolizaTabla).Cells("RUT").Value & dtgPolizasAEliminar.Rows(idPolizaTabla).Cells("DV").Value & vbNewLine & "Nombre: " & dtgPolizasAEliminar.Rows(idPolizaTabla).Cells("NOMBRE").Value & " " & dtgPolizasAEliminar.Rows(idPolizaTabla).Cells("PATERNO").Value & " " & dtgPolizasAEliminar.Rows(idPolizaTabla).Cells("MATERNO").Value & vbNewLine & "Nota: Esto eliminara la poliza junto con sus adicionales ", vbExclamation + vbYesNo, csNombreAplicacion) = vbNo Then Exit Sub


        Dim clsPoliza As New clsPolizabBI
        Dim correcto As Boolean
        correcto = clsPoliza.eliminaPoliza(dtgPolizasAEliminar.Rows(idPolizaTabla).Cells("IDPOLIZA").Value)
        If correcto = True Then
            MsgBox("Poliza fue eliminada", vbInformation, "CORDIALPHONE")
        End If

        Dim dt As New DataTable
        dt = clsPoliza.ListaPolizas(CLIENTE.C_Id)

        If dt.Rows.Count = 0 Then
            dtgPolizasAEliminar.DataSource = Nothing
            MsgBox("Cliente ya no cuenta con polizas asociadas, se pasara al proceso de venta", vbInformation, "CORDIALPHONE")

            sinPolizasAsociadas = True

        Else
            sinPolizasAsociadas = False
            dtgPolizasAEliminar.DataSource = dt
            dtgPolizasAEliminar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End If


    End Sub

    Private Sub dtgPolizasAEliminar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgPolizasAEliminar.CellContentClick
        If e.ColumnIndex <> 0 Then Exit Sub
        Dim row As DataGridViewRow = dtgPolizasAEliminar.Rows(e.RowIndex)



        If dtgPolizasAEliminar.Rows(e.RowIndex).Cells("chkSeleccione").Value = True Then
            dtgPolizasAEliminar.Rows(e.RowIndex).Cells("chkSeleccione").Value = False
        Else
            dtgPolizasAEliminar.Rows(e.RowIndex).Cells("chkSeleccione").Value = True


            For i As Integer = 0 To dtgPolizasAEliminar.Rows.Count - 1
                If i <> e.RowIndex Then
                    dtgPolizasAEliminar.Rows(i).Cells("chkSeleccione").Value = False
                End If
            Next

        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub
End Class