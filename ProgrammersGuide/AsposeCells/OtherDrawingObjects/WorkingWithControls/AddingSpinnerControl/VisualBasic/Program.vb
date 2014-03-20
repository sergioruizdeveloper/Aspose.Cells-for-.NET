'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Cells. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells
Imports Aspose.Cells.Drawing
Imports System.Drawing

Namespace AddingSpinnerControl
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			'Instantiate a new Workbook.
			Dim excelbook As New Workbook()

			'Get the first worksheet.
			Dim worksheet As Worksheet = excelbook.Worksheets(0)

			'Get the worksheet cells.
			Dim cells As Cells = worksheet.Cells

			'Input a string value into A1 cell.
			cells("A1").PutValue("Select Value:")

			'Set the font color of the cell.
			cells("A1").GetStyle().Font.Color = Color.Red

			'Set the font text bold.
			cells("A1").GetStyle().Font.IsBold = True

			'Input value into A2 cell.
			cells("A2").PutValue(0)

			'Set the shading color to black with solid background.
			cells("A2").GetStyle().ForegroundColor = Color.Black
			cells("A2").GetStyle().Pattern = BackgroundType.Solid

			'Set the font color of the cell.
			cells("A2").GetStyle().Font.Color = Color.White

			'set the font text bold.
			cells("A2").GetStyle().Font.IsBold = True

			'Add a spinner control.
			Dim spinner As Aspose.Cells.Drawing.Spinner = excelbook.Worksheets(0).Shapes.AddSpinner(1, 0, 1, 0, 20, 18)

			'Set the placement type of the spinner.
			spinner.Placement = PlacementType.FreeFloating

			'Set the linked cell for the control.
			spinner.LinkedCell = "A2"

			'Set the maximum value.
			spinner.Max = 10

			'Set the minimum value.
			spinner.Min = 0

			'Set the incr. change for the control.
			spinner.IncrementalChange = 2

			'Set it 3-D shading.
			spinner.Shadow = True

			'Save the excel file.
			excelbook.Save(dataDir & "book1.xls")

		End Sub
	End Class
End Namespace