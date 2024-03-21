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
        Button1 = New Button()
        Perimetro = New RadioButton()
        Area = New RadioButton()
        TextBox1 = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.Location = New Point(71, 149)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 37)
        Button1.TabIndex = 0
        Button1.Text = "Calcola"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Perimetro
        ' 
        Perimetro.AutoSize = True
        Perimetro.Location = New Point(74, 49)
        Perimetro.Name = "Perimetro"
        Perimetro.Size = New Size(77, 19)
        Perimetro.TabIndex = 1
        Perimetro.TabStop = True
        Perimetro.Text = "Perimetro"
        Perimetro.UseVisualStyleBackColor = True
        ' 
        ' Area
        ' 
        Area.AutoSize = True
        Area.Location = New Point(74, 74)
        Area.Name = "Area"
        Area.Size = New Size(49, 19)
        Area.TabIndex = 2
        Area.TabStop = True
        Area.Text = "Area"
        Area.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.AccessibleDescription = ""
        TextBox1.Location = New Point(71, 120)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 3
        TextBox1.Tag = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label1.Location = New Point(69, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 19)
        Label1.TabIndex = 4
        Label1.Text = "Lato?"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(254, 267)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Area)
        Controls.Add(Perimetro)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Tool per Matematica"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Perimetro As RadioButton
    Friend WithEvents Area As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label

End Class
