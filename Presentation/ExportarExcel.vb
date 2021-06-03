Module ExportarExcel

    Function llenarExcel(ByVal ElGrid As DataGridView) As Boolean

        'Creamos las variables

        Dim exApp As New Microsoft.Office.Interop.Excel.Application

        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook

        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try

            'Añadimos el Libro al programa, y la hoja al libro

            exLibro = exApp.Workbooks.Add

            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?

            Dim NCol As Integer = 8

            Dim NRow As Integer = ElGrid.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas

            'y vamos escribiendo.

            'For i As Integer = 1 To NCol

            '                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).HeaderText

            'Next

            exHoja.Cells.Item(1, 1) = "Codigo"
            exHoja.Cells.Item(1, 2) = "Descripcion"
            exHoja.Cells.Item(1, 3) = "DescripcionUnitaria"
            exHoja.Cells.Item(1, 4) = "CostoPonderado"
            exHoja.Cells.Item(1, 5) = "PrecioVenta1"
            exHoja.Cells.Item(1, 6) = "Casa Matriz"
            exHoja.Cells.Item(1, 7) = "Casa Matriz Costo"
            exHoja.Cells.Item(1, 8) = "Casa Matriz PV"


            For Fila As Integer = 0 To NRow - 1

                exHoja.Cells.Item(Fila + 2, 1) = ElGrid.Item(0, Fila).Value
                exHoja.Cells.Item(Fila + 2, 2) = "Hardware"
                exHoja.Cells.Item(Fila + 2, 3) = ElGrid.Item(1, Fila).Value
                exHoja.Cells.Item(Fila + 2, 4) = 0
                exHoja.Cells.Item(Fila + 2, 5) = ElGrid.Item(3, Fila).Value
                exHoja.Cells.Item(Fila + 2, 6) = ElGrid.Item(2, Fila).Value
                exHoja.Cells.Item(Fila + 2, 7) = 0
                exHoja.Cells.Item(Fila + 2, 8) = ElGrid.Item(3, Fila).Value * ElGrid.Item(2, Fila).Value

                '  For Col As Integer = 0 To NCol - 1

                '    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Item(Col, Fila).Value

                'Next

            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna

            'se ajuste al texto

            exHoja.Rows.Item(1).Font.Bold = 1

            exHoja.Rows.Item(1).HorizontalAlignment = 3

            exHoja.Columns.AutoFit()

            'Aplicación visible

            exApp.Application.Visible = True

            exHoja = Nothing

            exLibro = Nothing

            exApp = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

            Return False

        End Try

        Return True

    End Function
End Module
