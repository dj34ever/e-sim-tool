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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnLoad1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CBCountry2 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBServer2 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FicheiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quality = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Quantity2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Money = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gold2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBMoney1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CBCountry3 = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.WebBrowser1.Location = New System.Drawing.Point(556, 269)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(46, 30)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        Me.WebBrowser1.Visible = False
        '
        'BtnLoad
        '
        Me.BtnLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLoad.Location = New System.Drawing.Point(608, 276)
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
        Me.CBServer.Location = New System.Drawing.Point(73, 19)
        Me.CBServer.Name = "CBServer"
        Me.CBServer.Size = New System.Drawing.Size(121, 21)
        Me.CBServer.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
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
        Me.CBItem.Location = New System.Drawing.Point(73, 73)
        Me.CBItem.Name = "CBItem"
        Me.CBItem.Size = New System.Drawing.Size(121, 21)
        Me.CBItem.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Item:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 103)
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
        Me.CBQuality.Location = New System.Drawing.Point(73, 100)
        Me.CBQuality.Name = "CBQuality"
        Me.CBQuality.Size = New System.Drawing.Size(121, 21)
        Me.CBQuality.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 49)
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
        Me.CBCountry.Location = New System.Drawing.Point(73, 46)
        Me.CBCountry.Name = "CBCountry"
        Me.CBCountry.Size = New System.Drawing.Size(121, 21)
        Me.CBCountry.TabIndex = 10
        '
        'TBQuantity
        '
        Me.TBQuantity.Location = New System.Drawing.Point(83, 22)
        Me.TBQuantity.Name = "TBQuantity"
        Me.TBQuantity.Size = New System.Drawing.Size(46, 20)
        Me.TBQuantity.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Quantidade:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Money:"
        '
        'TBMoney
        '
        Me.TBMoney.Location = New System.Drawing.Point(83, 47)
        Me.TBMoney.Name = "TBMoney"
        Me.TBMoney.Size = New System.Drawing.Size(46, 20)
        Me.TBMoney.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(135, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Currency"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(697, 331)
        Me.TabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.BtnLoad)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.WebBrowser1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(689, 305)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.Quality, Me.Quantity, Me.Price, Me.Gold})
        Me.DataGridView1.Location = New System.Drawing.Point(212, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(471, 263)
        Me.DataGridView1.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnAdd)
        Me.GroupBox2.Controls.Add(Me.TBQuantity)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TBMoney)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 157)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(109, 127)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 16
        Me.BtnAdd.Text = "Add to List"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBServer)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CBCountry)
        Me.GroupBox1.Controls.Add(Me.CBItem)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CBQuality)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 130)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(Me.BtnLoad1)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(689, 305)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnLoad1
        '
        Me.BtnLoad1.Location = New System.Drawing.Point(608, 276)
        Me.BtnLoad1.Name = "BtnLoad1"
        Me.BtnLoad1.Size = New System.Drawing.Size(75, 23)
        Me.BtnLoad1.TabIndex = 2
        Me.BtnLoad1.Text = "Load"
        Me.BtnLoad1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CBCountry3)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TBMoney1)
        Me.GroupBox3.Controls.Add(Me.CBCountry2)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.CBServer2)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 206)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'CBCountry2
        '
        Me.CBCountry2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCountry2.FormattingEnabled = True
        Me.CBCountry2.Items.AddRange(New Object() {"Argentina", "Australia", "Belgium", "Bosnia and Herzegovina", "Brazil", "Bulgaria", "Canada", "Chile", "China", "Colombia", "Croatia", "Finland", "France", "Germany", "Greece", "Hungary", "India", "Indonesia", "Iran", "Ireland", "Israel", "Italy", "Latvia", "Lithuania", "Malasya", "Mexico", "Netherlands", "Norway", "Pakistan", "Peru", "Poland", "Portugal", "Republic of Macedonia", "Romania", "Russia", "Serbia", "Slovenia", "South Korea", "Spain", "Sweden", "Switzerland", "Taiwan", "Turkey", "USA", "Ukraine", "United Kingdom"})
        Me.CBCountry2.Location = New System.Drawing.Point(73, 46)
        Me.CBCountry2.Name = "CBCountry2"
        Me.CBCountry2.Size = New System.Drawing.Size(121, 21)
        Me.CBCountry2.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "From:"
        '
        'CBServer2
        '
        Me.CBServer2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBServer2.FormattingEnabled = True
        Me.CBServer2.Items.AddRange(New Object() {"Primera", "Secura"})
        Me.CBServer2.Location = New System.Drawing.Point(73, 19)
        Me.CBServer2.Name = "CBServer2"
        Me.CBServer2.Size = New System.Drawing.Size(121, 21)
        Me.CBServer2.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Server:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FicheiroToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(721, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FicheiroToolStripMenuItem
        '
        Me.FicheiroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem})
        Me.FicheiroToolStripMenuItem.Name = "FicheiroToolStripMenuItem"
        Me.FicheiroToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.FicheiroToolStripMenuItem.Text = "Ficheiro"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'Item
        '
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 60
        '
        'Quality
        '
        Me.Quality.HeaderText = "Quality"
        Me.Quality.Name = "Quality"
        Me.Quality.ReadOnly = True
        Me.Quality.Width = 50
        '
        'Quantity
        '
        Me.Quantity.FillWeight = 20.0!
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 50
        '
        'Price
        '
        Me.Price.FillWeight = 20.0!
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        '
        'Gold
        '
        Me.Gold.HeaderText = "Gold"
        Me.Gold.Name = "Gold"
        Me.Gold.ReadOnly = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Quantity2, Me.Money, Me.Gold2})
        Me.DataGridView2.Location = New System.Drawing.Point(212, 6)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(471, 150)
        Me.DataGridView2.TabIndex = 3
        '
        'Quantity2
        '
        Me.Quantity2.HeaderText = "Quantity"
        Me.Quantity2.Name = "Quantity2"
        Me.Quantity2.ReadOnly = True
        '
        'Money
        '
        Me.Money.HeaderText = "Money"
        Me.Money.Name = "Money"
        Me.Money.ReadOnly = True
        '
        'Gold2
        '
        Me.Gold2.HeaderText = "Gold"
        Me.Gold2.Name = "Gold2"
        Me.Gold2.ReadOnly = True
        '
        'TBMoney1
        '
        Me.TBMoney1.Location = New System.Drawing.Point(73, 130)
        Me.TBMoney1.Name = "TBMoney1"
        Me.TBMoney1.Size = New System.Drawing.Size(100, 20)
        Me.TBMoney1.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "To:"
        '
        'CBCountry3
        '
        Me.CBCountry3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCountry3.FormattingEnabled = True
        Me.CBCountry3.Items.AddRange(New Object() {"Argentina", "Australia", "Belgium", "Bosnia and Herzegovina", "Brazil", "Bulgaria", "Canada", "Chile", "China", "Colombia", "Croatia", "Finland", "France", "Germany", "Greece", "Hungary", "India", "Indonesia", "Iran", "Ireland", "Israel", "Italy", "Latvia", "Lithuania", "Malasya", "Mexico", "Netherlands", "Norway", "Pakistan", "Peru", "Poland", "Portugal", "Republic of Macedonia", "Romania", "Russia", "Serbia", "Slovenia", "South Korea", "Spain", "Sweden", "Switzerland", "Taiwan", "Turkey", "USA", "Ukraine", "United Kingdom"})
        Me.CBCountry3.Location = New System.Drawing.Point(73, 73)
        Me.CBCountry3.Name = "CBCountry3"
        Me.CBCountry3.Size = New System.Drawing.Size(121, 21)
        Me.CBCountry3.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 370)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "e-sim tool"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FicheiroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CBServer2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnLoad1 As System.Windows.Forms.Button
    Friend WithEvents CBCountry2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quality As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gold As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Quantity2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Money As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gold2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TBMoney1 As System.Windows.Forms.TextBox
    Friend WithEvents CBCountry3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
