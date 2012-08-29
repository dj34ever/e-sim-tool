<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.BtnLoad = New System.Windows.Forms.Button()
        Me.CBServer = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBItem = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBQuality = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBCountry = New System.Windows.Forms.ComboBox()
        Me.TBQuantity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBMoney = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 372)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        Me.WebBrowser1.Visible = False
        '
        'BtnLoad
        '
        Me.BtnLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLoad.Location = New System.Drawing.Point(380, 369)
        Me.BtnLoad.Name = "BtnLoad"
        Me.BtnLoad.Size = New System.Drawing.Size(75, 23)
        Me.BtnLoad.TabIndex = 1
        Me.BtnLoad.Text = "Load"
        Me.BtnLoad.UseVisualStyleBackColor = True
        '
        'CBServer
        '
        Me.CBServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBServer.FormattingEnabled = True
        Me.CBServer.Items.AddRange(New Object() {"Primera", "Secura"})
        Me.CBServer.Location = New System.Drawing.Point(56, 12)
        Me.CBServer.Name = "CBServer"
        Me.CBServer.Size = New System.Drawing.Size(121, 21)
        Me.CBServer.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Server:"
        '
        'CBItem
        '
        Me.CBItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBItem.FormattingEnabled = True
        Me.CBItem.Items.AddRange(New Object() {"Iron", "Grain", "Oil", "Stone", "Wood", "Diamond", "Weapon", "House", "Gift", "Food", "Ticket", "DS", "Hospital", "Estate"})
        Me.CBItem.Location = New System.Drawing.Point(56, 67)
        Me.CBItem.Name = "CBItem"
        Me.CBItem.Size = New System.Drawing.Size(121, 21)
        Me.CBItem.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Item:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Quality:"
        '
        'CBQuality
        '
        Me.CBQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBQuality.FormattingEnabled = True
        Me.CBQuality.Items.AddRange(New Object() {"Q1", "Q2", "Q3", "Q4", "Q5"})
        Me.CBQuality.Location = New System.Drawing.Point(56, 94)
        Me.CBQuality.Name = "CBQuality"
        Me.CBQuality.Size = New System.Drawing.Size(121, 21)
        Me.CBQuality.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Country:"
        '
        'CBCountry
        '
        Me.CBCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCountry.FormattingEnabled = True
        Me.CBCountry.Items.AddRange(New Object() {"Argentina", "Australia", "Belgium", "Bosnia and Herzegovina", "Brazil", "Bulgaria", "Canada", "Chile", "China", "Colombia", "Croatia", "Finland", "France", "Germany", "Greece", "Hungary", "India", "Indonesia", "Iran", "Ireland", "Israel", "Italy", "Latvia", "Lithuania", "Malasya", "Mexico", "Netherlands", "Norway", "Pakistan", "Peru", "Poland", "Portugal", "Republic of Macedonia", "Romania", "Russia", "Serbia", "Slovenia", "South Korea", "Spain", "Sweden", "Switzerland", "Taiwan", "Turkey", "USA", "Ukraine", "United Kingdom"})
        Me.CBCountry.Location = New System.Drawing.Point(56, 40)
        Me.CBCountry.Name = "CBCountry"
        Me.CBCountry.Size = New System.Drawing.Size(121, 21)
        Me.CBCountry.TabIndex = 10
        '
        'TBQuantity
        '
        Me.TBQuantity.Location = New System.Drawing.Point(308, 12)
        Me.TBQuantity.Name = "TBQuantity"
        Me.TBQuantity.Size = New System.Drawing.Size(35, 20)
        Me.TBQuantity.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(240, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Quantidade:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(240, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Money:"
        '
        'TBMoney
        '
        Me.TBMoney.Location = New System.Drawing.Point(308, 40)
        Me.TBMoney.Name = "TBMoney"
        Me.TBMoney.Size = New System.Drawing.Size(35, 20)
        Me.TBMoney.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(349, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 404)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TBMoney)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBQuantity)
        Me.Controls.Add(Me.CBCountry)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBQuality)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBItem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBServer)
        Me.Controls.Add(Me.BtnLoad)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents BtnLoad As System.Windows.Forms.Button
    Friend WithEvents CBServer As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBQuality As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CBCountry As System.Windows.Forms.ComboBox
    Friend WithEvents TBQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBMoney As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
