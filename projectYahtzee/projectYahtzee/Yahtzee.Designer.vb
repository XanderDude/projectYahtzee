<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYahtzee
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
        Me.pnlStartLoad = New System.Windows.Forms.Panel()
        Me.pnlGame = New System.Windows.Forms.Panel()
        Me.picDice4 = New System.Windows.Forms.PictureBox()
        Me.picDice5 = New System.Windows.Forms.PictureBox()
        Me.picDice2 = New System.Windows.Forms.PictureBox()
        Me.picDice3 = New System.Windows.Forms.PictureBox()
        Me.picDice1 = New System.Windows.Forms.PictureBox()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.lblHighScore = New System.Windows.Forms.Label()
        Me.lblStartMenuTitle = New System.Windows.Forms.Label()
        Me.pnlChoosePlayers = New System.Windows.Forms.Panel()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.rad6P = New System.Windows.Forms.RadioButton()
        Me.rad5P = New System.Windows.Forms.RadioButton()
        Me.rad4P = New System.Windows.Forms.RadioButton()
        Me.rad3P = New System.Windows.Forms.RadioButton()
        Me.rad2P = New System.Windows.Forms.RadioButton()
        Me.rad1P = New System.Windows.Forms.RadioButton()
        Me.lblChoosePlayers = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lblCurrentPlayer = New System.Windows.Forms.Label()
        Me.pnlScoreboard = New System.Windows.Forms.Panel()
        Me.pnlScores = New System.Windows.Forms.Panel()
        Me.lblOnes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pnlStartLoad.SuspendLayout()
        Me.pnlGame.SuspendLayout()
        CType(Me.picDice4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDice5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDice3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDice1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlChoosePlayers.SuspendLayout()
        Me.pnlScoreboard.SuspendLayout()
        Me.pnlScores.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlStartLoad
        '
        Me.pnlStartLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStartLoad.Controls.Add(Me.pnlGame)
        Me.pnlStartLoad.Controls.Add(Me.lblHighScore)
        Me.pnlStartLoad.Controls.Add(Me.lblStartMenuTitle)
        Me.pnlStartLoad.Controls.Add(Me.pnlChoosePlayers)
        Me.pnlStartLoad.Controls.Add(Me.btnExit)
        Me.pnlStartLoad.Controls.Add(Me.btnNewGame)
        Me.pnlStartLoad.Controls.Add(Me.btnLoad)
        Me.pnlStartLoad.Location = New System.Drawing.Point(13, 13)
        Me.pnlStartLoad.Name = "pnlStartLoad"
        Me.pnlStartLoad.Size = New System.Drawing.Size(599, 417)
        Me.pnlStartLoad.TabIndex = 0
        Me.pnlStartLoad.Visible = False
        '
        'pnlGame
        '
        Me.pnlGame.BackColor = System.Drawing.Color.White
        Me.pnlGame.Controls.Add(Me.pnlScoreboard)
        Me.pnlGame.Controls.Add(Me.lblCurrentPlayer)
        Me.pnlGame.Controls.Add(Me.picDice4)
        Me.pnlGame.Controls.Add(Me.picDice5)
        Me.pnlGame.Controls.Add(Me.picDice2)
        Me.pnlGame.Controls.Add(Me.picDice3)
        Me.pnlGame.Controls.Add(Me.picDice1)
        Me.pnlGame.Controls.Add(Me.btnRoll)
        Me.pnlGame.Location = New System.Drawing.Point(-1, -1)
        Me.pnlGame.Name = "pnlGame"
        Me.pnlGame.Size = New System.Drawing.Size(599, 417)
        Me.pnlGame.TabIndex = 6
        Me.pnlGame.Visible = False
        '
        'picDice4
        '
        Me.picDice4.BackColor = System.Drawing.Color.Tomato
        Me.picDice4.InitialImage = Nothing
        Me.picDice4.Location = New System.Drawing.Point(54, 190)
        Me.picDice4.Name = "picDice4"
        Me.picDice4.Size = New System.Drawing.Size(50, 50)
        Me.picDice4.TabIndex = 6
        Me.picDice4.TabStop = False
        '
        'picDice5
        '
        Me.picDice5.BackColor = System.Drawing.Color.Tomato
        Me.picDice5.InitialImage = Nothing
        Me.picDice5.Location = New System.Drawing.Point(156, 190)
        Me.picDice5.Name = "picDice5"
        Me.picDice5.Size = New System.Drawing.Size(50, 50)
        Me.picDice5.TabIndex = 5
        Me.picDice5.TabStop = False
        '
        'picDice2
        '
        Me.picDice2.BackColor = System.Drawing.Color.Tomato
        Me.picDice2.InitialImage = Nothing
        Me.picDice2.Location = New System.Drawing.Point(156, 92)
        Me.picDice2.Name = "picDice2"
        Me.picDice2.Size = New System.Drawing.Size(50, 50)
        Me.picDice2.TabIndex = 4
        Me.picDice2.TabStop = False
        '
        'picDice3
        '
        Me.picDice3.BackColor = System.Drawing.Color.Tomato
        Me.picDice3.InitialImage = Nothing
        Me.picDice3.Location = New System.Drawing.Point(101, 136)
        Me.picDice3.Name = "picDice3"
        Me.picDice3.Size = New System.Drawing.Size(50, 50)
        Me.picDice3.TabIndex = 3
        Me.picDice3.TabStop = False
        '
        'picDice1
        '
        Me.picDice1.BackColor = System.Drawing.Color.Tomato
        Me.picDice1.InitialImage = Nothing
        Me.picDice1.Location = New System.Drawing.Point(54, 92)
        Me.picDice1.Name = "picDice1"
        Me.picDice1.Size = New System.Drawing.Size(50, 50)
        Me.picDice1.TabIndex = 2
        Me.picDice1.TabStop = False
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(76, 368)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 1
        Me.btnRoll.Text = "Roll"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'lblHighScore
        '
        Me.lblHighScore.Location = New System.Drawing.Point(211, 174)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(159, 23)
        Me.lblHighScore.TabIndex = 5
        Me.lblHighScore.Text = "Highscore: 0"
        '
        'lblStartMenuTitle
        '
        Me.lblStartMenuTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartMenuTitle.Location = New System.Drawing.Point(221, 10)
        Me.lblStartMenuTitle.Name = "lblStartMenuTitle"
        Me.lblStartMenuTitle.Size = New System.Drawing.Size(149, 40)
        Me.lblStartMenuTitle.TabIndex = 4
        Me.lblStartMenuTitle.Text = "Yahtzee"
        '
        'pnlChoosePlayers
        '
        Me.pnlChoosePlayers.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlChoosePlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlChoosePlayers.Controls.Add(Me.btnConfirm)
        Me.pnlChoosePlayers.Controls.Add(Me.rad6P)
        Me.pnlChoosePlayers.Controls.Add(Me.rad5P)
        Me.pnlChoosePlayers.Controls.Add(Me.rad4P)
        Me.pnlChoosePlayers.Controls.Add(Me.rad3P)
        Me.pnlChoosePlayers.Controls.Add(Me.rad2P)
        Me.pnlChoosePlayers.Controls.Add(Me.rad1P)
        Me.pnlChoosePlayers.Controls.Add(Me.lblChoosePlayers)
        Me.pnlChoosePlayers.Location = New System.Drawing.Point(156, 222)
        Me.pnlChoosePlayers.Name = "pnlChoosePlayers"
        Me.pnlChoosePlayers.Size = New System.Drawing.Size(280, 150)
        Me.pnlChoosePlayers.TabIndex = 3
        Me.pnlChoosePlayers.Visible = False
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(99, 111)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 8
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        Me.btnConfirm.Visible = False
        '
        'rad6P
        '
        Me.rad6P.Appearance = System.Windows.Forms.Appearance.Button
        Me.rad6P.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad6P.Location = New System.Drawing.Point(189, 75)
        Me.rad6P.Name = "rad6P"
        Me.rad6P.Size = New System.Drawing.Size(31, 17)
        Me.rad6P.TabIndex = 6
        Me.rad6P.TabStop = True
        Me.rad6P.Text = "6"
        Me.rad6P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rad6P.UseVisualStyleBackColor = True
        '
        'rad5P
        '
        Me.rad5P.Appearance = System.Windows.Forms.Appearance.Button
        Me.rad5P.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad5P.Location = New System.Drawing.Point(152, 75)
        Me.rad5P.Name = "rad5P"
        Me.rad5P.Size = New System.Drawing.Size(31, 17)
        Me.rad5P.TabIndex = 5
        Me.rad5P.TabStop = True
        Me.rad5P.Text = "5"
        Me.rad5P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rad5P.UseVisualStyleBackColor = True
        '
        'rad4P
        '
        Me.rad4P.Appearance = System.Windows.Forms.Appearance.Button
        Me.rad4P.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad4P.Location = New System.Drawing.Point(115, 75)
        Me.rad4P.Name = "rad4P"
        Me.rad4P.Size = New System.Drawing.Size(31, 17)
        Me.rad4P.TabIndex = 4
        Me.rad4P.TabStop = True
        Me.rad4P.Text = "4"
        Me.rad4P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rad4P.UseVisualStyleBackColor = True
        '
        'rad3P
        '
        Me.rad3P.Appearance = System.Windows.Forms.Appearance.Button
        Me.rad3P.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad3P.Location = New System.Drawing.Point(78, 71)
        Me.rad3P.Name = "rad3P"
        Me.rad3P.Size = New System.Drawing.Size(31, 24)
        Me.rad3P.TabIndex = 3
        Me.rad3P.TabStop = True
        Me.rad3P.Text = "3"
        Me.rad3P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rad3P.UseVisualStyleBackColor = True
        '
        'rad2P
        '
        Me.rad2P.Appearance = System.Windows.Forms.Appearance.Button
        Me.rad2P.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad2P.Location = New System.Drawing.Point(41, 71)
        Me.rad2P.Name = "rad2P"
        Me.rad2P.Size = New System.Drawing.Size(31, 24)
        Me.rad2P.TabIndex = 2
        Me.rad2P.TabStop = True
        Me.rad2P.Text = "2"
        Me.rad2P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rad2P.UseVisualStyleBackColor = True
        '
        'rad1P
        '
        Me.rad1P.Appearance = System.Windows.Forms.Appearance.Button
        Me.rad1P.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad1P.Location = New System.Drawing.Point(0, 68)
        Me.rad1P.Name = "rad1P"
        Me.rad1P.Size = New System.Drawing.Size(32, 24)
        Me.rad1P.TabIndex = 1
        Me.rad1P.TabStop = True
        Me.rad1P.Text = "1"
        Me.rad1P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rad1P.UseVisualStyleBackColor = True
        '
        'lblChoosePlayers
        '
        Me.lblChoosePlayers.AutoSize = True
        Me.lblChoosePlayers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoosePlayers.Location = New System.Drawing.Point(3, 9)
        Me.lblChoosePlayers.Name = "lblChoosePlayers"
        Me.lblChoosePlayers.Size = New System.Drawing.Size(200, 20)
        Me.lblChoosePlayers.TabIndex = 0
        Me.lblChoosePlayers.Text = "Choose Number Of Players"
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(255, 123)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Close Game"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnNewGame
        '
        Me.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewGame.Location = New System.Drawing.Point(295, 94)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(75, 23)
        Me.btnNewGame.TabIndex = 1
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Location = New System.Drawing.Point(214, 94)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Load Game"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'lblCurrentPlayer
        '
        Me.lblCurrentPlayer.BackColor = System.Drawing.Color.Silver
        Me.lblCurrentPlayer.Location = New System.Drawing.Point(72, 299)
        Me.lblCurrentPlayer.Name = "lblCurrentPlayer"
        Me.lblCurrentPlayer.Size = New System.Drawing.Size(100, 23)
        Me.lblCurrentPlayer.TabIndex = 7
        Me.lblCurrentPlayer.Text = "________'s Turn"
        Me.lblCurrentPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlScoreboard
        '
        Me.pnlScoreboard.BackColor = System.Drawing.Color.Silver
        Me.pnlScoreboard.Controls.Add(Me.pnlScores)
        Me.pnlScoreboard.Location = New System.Drawing.Point(249, 0)
        Me.pnlScoreboard.Name = "pnlScoreboard"
        Me.pnlScoreboard.Size = New System.Drawing.Size(350, 417)
        Me.pnlScoreboard.TabIndex = 8
        '
        'pnlScores
        '
        Me.pnlScores.BackColor = System.Drawing.Color.White
        Me.pnlScores.Controls.Add(Me.Label18)
        Me.pnlScores.Controls.Add(Me.Label16)
        Me.pnlScores.Controls.Add(Me.Label15)
        Me.pnlScores.Controls.Add(Me.Label14)
        Me.pnlScores.Controls.Add(Me.Label13)
        Me.pnlScores.Controls.Add(Me.Label12)
        Me.pnlScores.Controls.Add(Me.Label11)
        Me.pnlScores.Controls.Add(Me.Label10)
        Me.pnlScores.Controls.Add(Me.Label9)
        Me.pnlScores.Controls.Add(Me.Label8)
        Me.pnlScores.Controls.Add(Me.Label7)
        Me.pnlScores.Controls.Add(Me.Label6)
        Me.pnlScores.Controls.Add(Me.Label5)
        Me.pnlScores.Controls.Add(Me.Label4)
        Me.pnlScores.Controls.Add(Me.Label3)
        Me.pnlScores.Controls.Add(Me.Label2)
        Me.pnlScores.Controls.Add(Me.Label1)
        Me.pnlScores.Controls.Add(Me.lblOnes)
        Me.pnlScores.Location = New System.Drawing.Point(3, 1)
        Me.pnlScores.Name = "pnlScores"
        Me.pnlScores.Size = New System.Drawing.Size(98, 413)
        Me.pnlScores.TabIndex = 0
        '
        'lblOnes
        '
        Me.lblOnes.BackColor = System.Drawing.Color.Gainsboro
        Me.lblOnes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOnes.Location = New System.Drawing.Point(6, 3)
        Me.lblOnes.Name = "lblOnes"
        Me.lblOnes.Size = New System.Drawing.Size(85, 22)
        Me.lblOnes.TabIndex = 0
        Me.lblOnes.Text = "Ones"
        Me.lblOnes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(5, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Twos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(5, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Threes"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(3, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "3 of a Kind"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(3, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Gainsboro
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(5, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Full House"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Gainsboro
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(3, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 22)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Large Straight"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Gainsboro
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(3, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 22)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Total"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Gainsboro
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(3, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 22)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "4 of a Kind"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Gainsboro
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(5, 267)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 22)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Small Straight"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Gainsboro
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(3, 311)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 22)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "YAHTZEE"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Gainsboro
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(5, 333)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 22)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Chance"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Gainsboro
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(3, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 22)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Sixes"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Gainsboro
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(3, 91)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 22)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Fives"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Gainsboro
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Location = New System.Drawing.Point(3, 157)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 22)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Bonus"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Gainsboro
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Location = New System.Drawing.Point(5, 377)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 22)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "GRAND TOTAL"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Gainsboro
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(5, 355)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 22)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Total"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Gainsboro
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Location = New System.Drawing.Point(5, 69)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 22)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Fours"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmYahtzee
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.pnlStartLoad)
        Me.Name = "frmYahtzee"
        Me.Text = "Yahtzee Project"
        Me.pnlStartLoad.ResumeLayout(False)
        Me.pnlGame.ResumeLayout(False)
        CType(Me.picDice4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDice5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDice2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDice3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDice1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlChoosePlayers.ResumeLayout(False)
        Me.pnlChoosePlayers.PerformLayout()
        Me.pnlScoreboard.ResumeLayout(False)
        Me.pnlScores.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlStartLoad As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNewGame As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents pnlChoosePlayers As Panel
    Friend WithEvents lblStartMenuTitle As Label
    Friend WithEvents lblChoosePlayers As Label
    Friend WithEvents rad6P As RadioButton
    Friend WithEvents rad5P As RadioButton
    Friend WithEvents rad4P As RadioButton
    Friend WithEvents rad3P As RadioButton
    Friend WithEvents rad2P As RadioButton
    Friend WithEvents rad1P As RadioButton
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblHighScore As Label
    Friend WithEvents btnRoll As Button
    Friend WithEvents pnlGame As Panel
    Friend WithEvents picDice1 As PictureBox
    Friend WithEvents picDice4 As PictureBox
    Friend WithEvents picDice5 As PictureBox
    Friend WithEvents picDice2 As PictureBox
    Friend WithEvents picDice3 As PictureBox
    Friend WithEvents pnlScoreboard As Panel
    Friend WithEvents pnlScores As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblOnes As Label
    Friend WithEvents lblCurrentPlayer As Label
End Class
