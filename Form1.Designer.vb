<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        birthDatePicker = New DateTimePicker()
        currentDatePicker = New DateTimePicker()
        btnCalculateAge = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(29, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 32)
        Label1.TabIndex = 0
        Label1.Text = "BDay"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(29, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 32)
        Label2.TabIndex = 1
        Label2.Text = "PDay"' 
        ' birthDatePicker
        ' 
        birthDatePicker.Location = New Point(123, 56)
        birthDatePicker.Name = "birthDatePicker"
        birthDatePicker.Size = New Size(200, 23)
        birthDatePicker.TabIndex = 2
        ' 
        ' currentDatePicker
        ' 
        currentDatePicker.Location = New Point(123, 124)
        currentDatePicker.Name = "currentDatePicker"
        currentDatePicker.Size = New Size(200, 23)
        currentDatePicker.TabIndex = 3
        ' 
        ' btnCalculateAge
        ' 
        btnCalculateAge.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnCalculateAge.Location = New Point(152, 307)
        btnCalculateAge.Name = "btnCalculateAge"
        btnCalculateAge.Size = New Size(101, 37)
        btnCalculateAge.TabIndex = 4
        btnCalculateAge.Text = "Calc"
        btnCalculateAge.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(416, 450)
        Controls.Add(btnCalculateAge)
        Controls.Add(currentDatePicker)
        Controls.Add(birthDatePicker)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents birthDatePicker As DateTimePicker
    Friend WithEvents currentDatePicker As DateTimePicker
    Friend WithEvents btnCalculateAge As Button
End Class
