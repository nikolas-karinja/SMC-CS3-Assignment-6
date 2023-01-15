<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConversion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGal = New System.Windows.Forms.TextBox()
        Me.txtFar = New System.Windows.Forms.TextBox()
        Me.txtFeet = New System.Windows.Forms.TextBox()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.lblLiters = New System.Windows.Forms.Label()
        Me.lblCel = New System.Windows.Forms.Label()
        Me.lblMeters = New System.Windows.Forms.Label()
        Me.lblKilo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gallons to Liters:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Farenheit to Celsius:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Feet to Meters:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Miles to Kilometers:"
        '
        'txtGal
        '
        Me.txtGal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGal.Location = New System.Drawing.Point(168, 37)
        Me.txtGal.Name = "txtGal"
        Me.txtGal.Size = New System.Drawing.Size(80, 27)
        Me.txtGal.TabIndex = 4
        Me.txtGal.Text = "0"
        Me.txtGal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFar
        '
        Me.txtFar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFar.Location = New System.Drawing.Point(168, 71)
        Me.txtFar.Name = "txtFar"
        Me.txtFar.Size = New System.Drawing.Size(80, 27)
        Me.txtFar.TabIndex = 5
        Me.txtFar.Text = "0"
        Me.txtFar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFeet
        '
        Me.txtFeet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFeet.Location = New System.Drawing.Point(168, 104)
        Me.txtFeet.Name = "txtFeet"
        Me.txtFeet.Size = New System.Drawing.Size(80, 27)
        Me.txtFeet.TabIndex = 6
        Me.txtFeet.Text = "0"
        Me.txtFeet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMiles
        '
        Me.txtMiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiles.Location = New System.Drawing.Point(168, 136)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(80, 27)
        Me.txtMiles.TabIndex = 7
        Me.txtMiles.Text = "0"
        Me.txtMiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblLiters
        '
        Me.lblLiters.BackColor = System.Drawing.Color.Khaki
        Me.lblLiters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLiters.Location = New System.Drawing.Point(265, 37)
        Me.lblLiters.Name = "lblLiters"
        Me.lblLiters.Size = New System.Drawing.Size(75, 27)
        Me.lblLiters.TabIndex = 8
        Me.lblLiters.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCel
        '
        Me.lblCel.BackColor = System.Drawing.Color.Khaki
        Me.lblCel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCel.Location = New System.Drawing.Point(265, 71)
        Me.lblCel.Name = "lblCel"
        Me.lblCel.Size = New System.Drawing.Size(75, 27)
        Me.lblCel.TabIndex = 9
        Me.lblCel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMeters
        '
        Me.lblMeters.BackColor = System.Drawing.Color.Khaki
        Me.lblMeters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMeters.Location = New System.Drawing.Point(265, 103)
        Me.lblMeters.Name = "lblMeters"
        Me.lblMeters.Size = New System.Drawing.Size(75, 27)
        Me.lblMeters.TabIndex = 10
        Me.lblMeters.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblKilo
        '
        Me.lblKilo.BackColor = System.Drawing.Color.Khaki
        Me.lblKilo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKilo.Location = New System.Drawing.Point(265, 136)
        Me.lblKilo.Name = "lblKilo"
        Me.lblKilo.Size = New System.Drawing.Size(75, 27)
        Me.lblKilo.TabIndex = 11
        Me.lblKilo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(168, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Imperial"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(265, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Metric"
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(44, 178)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 32)
        Me.btnConvert.TabIndex = 14
        Me.btnConvert.Text = "&Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(142, 178)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 32)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(241, 178)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 32)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmConversion
        '
        Me.AcceptButton = Me.btnConvert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(364, 225)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblKilo)
        Me.Controls.Add(Me.lblMeters)
        Me.Controls.Add(Me.lblCel)
        Me.Controls.Add(Me.lblLiters)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.txtFeet)
        Me.Controls.Add(Me.txtFar)
        Me.Controls.Add(Me.txtGal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmConversion"
        Me.Text = "Measure Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGal As TextBox
    Friend WithEvents txtFar As TextBox
    Friend WithEvents txtFeet As TextBox
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents lblLiters As Label
    Friend WithEvents lblCel As Label
    Friend WithEvents lblMeters As Label
    Friend WithEvents lblKilo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
