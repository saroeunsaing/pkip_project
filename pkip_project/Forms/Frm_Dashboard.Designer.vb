﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Dashboard
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
        Me.Panel_Title = New System.Windows.Forms.Panel()
        Me.Panel_Menu = New System.Windows.Forms.Panel()
        Me.Panel_Content = New System.Windows.Forms.Panel()
        Me.btn_close = New FontAwesome.Sharp.IconButton()
        Me.tbn_restore = New FontAwesome.Sharp.IconButton()
        Me.bnt_minimize = New FontAwesome.Sharp.IconButton()
        Me.btn_maximize = New FontAwesome.Sharp.IconButton()
        Me.facebook = New FontAwesome.Sharp.IconButton()
        Me.messager = New FontAwesome.Sharp.IconButton()
        Me.youtube = New FontAwesome.Sharp.IconButton()
        Me.telegrame = New FontAwesome.Sharp.IconButton()
        Me.instagram = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.whatapp = New FontAwesome.Sharp.IconButton()
        Me.bnt_home = New FontAwesome.Sharp.IconButton()
        Me.btn_menu = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.btn_logout = New FontAwesome.Sharp.IconButton()
        Me.logo = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel_Title.SuspendLayout()
        Me.Panel_Menu.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.Color.LightGray
        Me.Panel_Title.Controls.Add(Me.btn_maximize)
        Me.Panel_Title.Controls.Add(Me.bnt_minimize)
        Me.Panel_Title.Controls.Add(Me.tbn_restore)
        Me.Panel_Title.Controls.Add(Me.btn_close)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(1400, 35)
        Me.Panel_Title.TabIndex = 0
        '
        'Panel_Menu
        '
        Me.Panel_Menu.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel_Menu.Controls.Add(Me.logo)
        Me.Panel_Menu.Controls.Add(Me.btn_logout)
        Me.Panel_Menu.Controls.Add(Me.IconButton2)
        Me.Panel_Menu.Controls.Add(Me.btn_menu)
        Me.Panel_Menu.Controls.Add(Me.bnt_home)
        Me.Panel_Menu.Controls.Add(Me.whatapp)
        Me.Panel_Menu.Controls.Add(Me.IconButton1)
        Me.Panel_Menu.Controls.Add(Me.instagram)
        Me.Panel_Menu.Controls.Add(Me.telegrame)
        Me.Panel_Menu.Controls.Add(Me.youtube)
        Me.Panel_Menu.Controls.Add(Me.messager)
        Me.Panel_Menu.Controls.Add(Me.facebook)
        Me.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Menu.Location = New System.Drawing.Point(0, 35)
        Me.Panel_Menu.Name = "Panel_Menu"
        Me.Panel_Menu.Size = New System.Drawing.Size(300, 665)
        Me.Panel_Menu.TabIndex = 1
        '
        'Panel_Content
        '
        Me.Panel_Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Content.Location = New System.Drawing.Point(300, 35)
        Me.Panel_Content.Name = "Panel_Content"
        Me.Panel_Content.Size = New System.Drawing.Size(1100, 665)
        Me.Panel_Content.TabIndex = 2
        '
        'btn_close
        '
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.btn_close.IconColor = System.Drawing.Color.Brown
        Me.btn_close.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_close.IconSize = 35
        Me.btn_close.Location = New System.Drawing.Point(1362, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(35, 35)
        Me.btn_close.TabIndex = 0
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'tbn_restore
        '
        Me.tbn_restore.FlatAppearance.BorderSize = 0
        Me.tbn_restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbn_restore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        Me.tbn_restore.IconColor = System.Drawing.Color.Brown
        Me.tbn_restore.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.tbn_restore.IconSize = 35
        Me.tbn_restore.Location = New System.Drawing.Point(1321, 0)
        Me.tbn_restore.Name = "tbn_restore"
        Me.tbn_restore.Size = New System.Drawing.Size(35, 35)
        Me.tbn_restore.TabIndex = 1
        Me.tbn_restore.UseVisualStyleBackColor = True
        '
        'bnt_minimize
        '
        Me.bnt_minimize.FlatAppearance.BorderSize = 0
        Me.bnt_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnt_minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.bnt_minimize.IconColor = System.Drawing.Color.Brown
        Me.bnt_minimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.bnt_minimize.IconSize = 35
        Me.bnt_minimize.Location = New System.Drawing.Point(1280, 0)
        Me.bnt_minimize.Name = "bnt_minimize"
        Me.bnt_minimize.Size = New System.Drawing.Size(35, 35)
        Me.bnt_minimize.TabIndex = 2
        Me.bnt_minimize.UseVisualStyleBackColor = True
        '
        'btn_maximize
        '
        Me.btn_maximize.FlatAppearance.BorderSize = 0
        Me.btn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.btn_maximize.IconColor = System.Drawing.Color.Brown
        Me.btn_maximize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_maximize.IconSize = 35
        Me.btn_maximize.Location = New System.Drawing.Point(1321, 0)
        Me.btn_maximize.Name = "btn_maximize"
        Me.btn_maximize.Size = New System.Drawing.Size(35, 35)
        Me.btn_maximize.TabIndex = 3
        Me.btn_maximize.UseVisualStyleBackColor = True
        '
        'facebook
        '
        Me.facebook.FlatAppearance.BorderSize = 0
        Me.facebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.facebook.IconChar = FontAwesome.Sharp.IconChar.Facebook
        Me.facebook.IconColor = System.Drawing.Color.Brown
        Me.facebook.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.facebook.IconSize = 35
        Me.facebook.Location = New System.Drawing.Point(45, 618)
        Me.facebook.Name = "facebook"
        Me.facebook.Size = New System.Drawing.Size(35, 35)
        Me.facebook.TabIndex = 5
        Me.facebook.UseVisualStyleBackColor = True
        '
        'messager
        '
        Me.messager.FlatAppearance.BorderSize = 0
        Me.messager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.messager.IconChar = FontAwesome.Sharp.IconChar.FacebookMessenger
        Me.messager.IconColor = System.Drawing.Color.Brown
        Me.messager.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.messager.IconSize = 35
        Me.messager.Location = New System.Drawing.Point(86, 618)
        Me.messager.Name = "messager"
        Me.messager.Size = New System.Drawing.Size(35, 35)
        Me.messager.TabIndex = 6
        Me.messager.UseVisualStyleBackColor = True
        '
        'youtube
        '
        Me.youtube.FlatAppearance.BorderSize = 0
        Me.youtube.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.youtube.IconChar = FontAwesome.Sharp.IconChar.Youtube
        Me.youtube.IconColor = System.Drawing.Color.Brown
        Me.youtube.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.youtube.IconSize = 35
        Me.youtube.Location = New System.Drawing.Point(127, 618)
        Me.youtube.Name = "youtube"
        Me.youtube.Size = New System.Drawing.Size(35, 35)
        Me.youtube.TabIndex = 7
        Me.youtube.UseVisualStyleBackColor = True
        '
        'telegrame
        '
        Me.telegrame.FlatAppearance.BorderSize = 0
        Me.telegrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.telegrame.IconChar = FontAwesome.Sharp.IconChar.Telegram
        Me.telegrame.IconColor = System.Drawing.Color.Brown
        Me.telegrame.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.telegrame.IconSize = 35
        Me.telegrame.Location = New System.Drawing.Point(168, 618)
        Me.telegrame.Name = "telegrame"
        Me.telegrame.Size = New System.Drawing.Size(35, 35)
        Me.telegrame.TabIndex = 8
        Me.telegrame.UseVisualStyleBackColor = True
        '
        'instagram
        '
        Me.instagram.FlatAppearance.BorderSize = 0
        Me.instagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.instagram.IconChar = FontAwesome.Sharp.IconChar.Instagram
        Me.instagram.IconColor = System.Drawing.Color.Brown
        Me.instagram.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.instagram.IconSize = 35
        Me.instagram.Location = New System.Drawing.Point(209, 618)
        Me.instagram.Name = "instagram"
        Me.instagram.Size = New System.Drawing.Size(35, 35)
        Me.instagram.TabIndex = 9
        Me.instagram.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Tiktok
        Me.IconButton1.IconColor = System.Drawing.Color.Brown
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 35
        Me.IconButton1.Location = New System.Drawing.Point(250, 618)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(35, 35)
        Me.IconButton1.TabIndex = 10
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'whatapp
        '
        Me.whatapp.FlatAppearance.BorderSize = 0
        Me.whatapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.whatapp.IconChar = FontAwesome.Sharp.IconChar.Whatsapp
        Me.whatapp.IconColor = System.Drawing.Color.Brown
        Me.whatapp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.whatapp.IconSize = 35
        Me.whatapp.Location = New System.Drawing.Point(12, 618)
        Me.whatapp.Name = "whatapp"
        Me.whatapp.Size = New System.Drawing.Size(35, 35)
        Me.whatapp.TabIndex = 11
        Me.whatapp.UseVisualStyleBackColor = True
        '
        'bnt_home
        '
        Me.bnt_home.FlatAppearance.BorderSize = 0
        Me.bnt_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnt_home.Font = New System.Drawing.Font("Khmer OS Siemreap", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_home.ForeColor = System.Drawing.Color.Brown
        Me.bnt_home.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.bnt_home.IconColor = System.Drawing.Color.Brown
        Me.bnt_home.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.bnt_home.IconSize = 35
        Me.bnt_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bnt_home.Location = New System.Drawing.Point(0, 268)
        Me.bnt_home.Name = "bnt_home"
        Me.bnt_home.Size = New System.Drawing.Size(294, 35)
        Me.bnt_home.TabIndex = 12
        Me.bnt_home.Text = "ទំព័រដើម"
        Me.bnt_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bnt_home.UseVisualStyleBackColor = True
        '
        'btn_menu
        '
        Me.btn_menu.FlatAppearance.BorderSize = 0
        Me.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu.IconChar = FontAwesome.Sharp.IconChar.List
        Me.btn_menu.IconColor = System.Drawing.Color.Brown
        Me.btn_menu.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_menu.IconSize = 35
        Me.btn_menu.Location = New System.Drawing.Point(265, 0)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(35, 35)
        Me.btn_menu.TabIndex = 13
        Me.btn_menu.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Khmer OS Siemreap", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.Color.Brown
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Cog
        Me.IconButton2.IconColor = System.Drawing.Color.Brown
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 35
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(0, 453)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(294, 35)
        Me.IconButton2.TabIndex = 14
        Me.IconButton2.Text = "ការកំណត់"
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Khmer OS Siemreap", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.Color.Brown
        Me.btn_logout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btn_logout.IconColor = System.Drawing.Color.Brown
        Me.btn_logout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_logout.IconSize = 35
        Me.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logout.Location = New System.Drawing.Point(0, 494)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(294, 35)
        Me.btn_logout.TabIndex = 15
        Me.btn_logout.Text = "ចាកចេញ"
        Me.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.logo.ForeColor = System.Drawing.Color.Brown
        Me.logo.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.logo.IconColor = System.Drawing.Color.Brown
        Me.logo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.logo.IconSize = 150
        Me.logo.Location = New System.Drawing.Point(64, 71)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(150, 150)
        Me.logo.TabIndex = 16
        Me.logo.TabStop = False
        '
        'Frm_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1400, 700)
        Me.Controls.Add(Me.Panel_Content)
        Me.Controls.Add(Me.Panel_Menu)
        Me.Controls.Add(Me.Panel_Title)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.8!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "Frm_Dashboard"
        Me.Text = "Frm_Dashboard"
        Me.Panel_Title.ResumeLayout(False)
        Me.Panel_Menu.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Title As Panel
    Friend WithEvents Panel_Menu As Panel
    Friend WithEvents Panel_Content As Panel
    Friend WithEvents btn_maximize As FontAwesome.Sharp.IconButton
    Friend WithEvents bnt_minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents tbn_restore As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_close As FontAwesome.Sharp.IconButton
    Friend WithEvents logo As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btn_logout As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_menu As FontAwesome.Sharp.IconButton
    Friend WithEvents bnt_home As FontAwesome.Sharp.IconButton
    Friend WithEvents whatapp As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents instagram As FontAwesome.Sharp.IconButton
    Friend WithEvents telegrame As FontAwesome.Sharp.IconButton
    Friend WithEvents youtube As FontAwesome.Sharp.IconButton
    Friend WithEvents messager As FontAwesome.Sharp.IconButton
    Friend WithEvents facebook As FontAwesome.Sharp.IconButton
End Class
