﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Restore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Restore))
        Me.l_restore = New System.Windows.Forms.Label()
        Me.tv_restore = New System.Windows.Forms.TreeView()
        Me.L_available_Datasets = New System.Windows.Forms.Label()
        Me.btn_startrestore = New System.Windows.Forms.Button()
        Me.tb_targetdir = New System.Windows.Forms.TextBox()
        Me.L_targetpath = New System.Windows.Forms.Label()
        Me.lc_loading_datasets = New MRG.Controls.UI.LoadingCircle()
        Me.L_status = New System.Windows.Forms.Label()
        Me.bw_Reload_Settings = New System.ComponentModel.BackgroundWorker()
        Me.l_log = New System.Windows.Forms.Label()
        Me.rtb_log = New System.Windows.Forms.RichTextBox()
        Me.l_restore_active = New System.Windows.Forms.Label()
        Me.lc_restore_active = New MRG.Controls.UI.LoadingCircle()
        Me.fbd_searchRestoretargetpath = New System.Windows.Forms.FolderBrowserDialog()
        Me.b_editSource = New System.Windows.Forms.Button()
        Me.fbd_edittargetpath = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'l_restore
        '
        Me.l_restore.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.l_restore.AutoSize = True
        Me.l_restore.BackColor = System.Drawing.Color.Transparent
        Me.l_restore.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_restore.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.l_restore.Location = New System.Drawing.Point(213, 9)
        Me.l_restore.Name = "l_restore"
        Me.l_restore.Size = New System.Drawing.Size(110, 31)
        Me.l_restore.TabIndex = 11
        Me.l_restore.Text = "Restore"
        '
        'tv_restore
        '
        Me.tv_restore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tv_restore.Location = New System.Drawing.Point(26, 87)
        Me.tv_restore.Name = "tv_restore"
        Me.tv_restore.Size = New System.Drawing.Size(490, 323)
        Me.tv_restore.TabIndex = 12
        '
        'L_available_Datasets
        '
        Me.L_available_Datasets.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.L_available_Datasets.AutoSize = True
        Me.L_available_Datasets.BackColor = System.Drawing.Color.Transparent
        Me.L_available_Datasets.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_available_Datasets.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.L_available_Datasets.Location = New System.Drawing.Point(63, 50)
        Me.L_available_Datasets.Name = "L_available_Datasets"
        Me.L_available_Datasets.Size = New System.Drawing.Size(401, 24)
        Me.L_available_Datasets.TabIndex = 13
        Me.L_available_Datasets.Text = "Available Datasets: (Choose the one to restore)"
        '
        'btn_startrestore
        '
        Me.btn_startrestore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_startrestore.Location = New System.Drawing.Point(26, 472)
        Me.btn_startrestore.Name = "btn_startrestore"
        Me.btn_startrestore.Size = New System.Drawing.Size(490, 35)
        Me.btn_startrestore.TabIndex = 29
        Me.btn_startrestore.Text = "Start Restore"
        Me.btn_startrestore.UseVisualStyleBackColor = True
        '
        'tb_targetdir
        '
        Me.tb_targetdir.AccessibleRole = System.Windows.Forms.AccessibleRole.Border
        Me.tb_targetdir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_targetdir.Location = New System.Drawing.Point(26, 440)
        Me.tb_targetdir.Name = "tb_targetdir"
        Me.tb_targetdir.Size = New System.Drawing.Size(399, 26)
        Me.tb_targetdir.TabIndex = 30
        '
        'L_targetpath
        '
        Me.L_targetpath.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.L_targetpath.AutoSize = True
        Me.L_targetpath.BackColor = System.Drawing.Color.Transparent
        Me.L_targetpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_targetpath.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.L_targetpath.Location = New System.Drawing.Point(143, 413)
        Me.L_targetpath.Name = "L_targetpath"
        Me.L_targetpath.Size = New System.Drawing.Size(247, 24)
        Me.L_targetpath.TabIndex = 31
        Me.L_targetpath.Text = "Target path for restored files:"
        '
        'lc_loading_datasets
        '
        Me.lc_loading_datasets.Active = False
        Me.lc_loading_datasets.BackColor = System.Drawing.Color.Transparent
        Me.lc_loading_datasets.Color = System.Drawing.Color.WhiteSmoke
        Me.lc_loading_datasets.InnerCircleRadius = 8
        Me.lc_loading_datasets.Location = New System.Drawing.Point(26, 507)
        Me.lc_loading_datasets.Name = "lc_loading_datasets"
        Me.lc_loading_datasets.NumberSpoke = 24
        Me.lc_loading_datasets.OuterCircleRadius = 9
        Me.lc_loading_datasets.RotationSpeed = 85
        Me.lc_loading_datasets.Size = New System.Drawing.Size(66, 58)
        Me.lc_loading_datasets.SpokeThickness = 4
        Me.lc_loading_datasets.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.IE7
        Me.lc_loading_datasets.TabIndex = 32
        Me.lc_loading_datasets.Text = "Wait while Content is loading...."
        '
        'L_status
        '
        Me.L_status.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.L_status.AutoSize = True
        Me.L_status.BackColor = System.Drawing.Color.Transparent
        Me.L_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_status.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.L_status.Location = New System.Drawing.Point(88, 522)
        Me.L_status.Name = "L_status"
        Me.L_status.Size = New System.Drawing.Size(100, 24)
        Me.L_status.TabIndex = 33
        Me.L_status.Text = "Status: Idle"
        '
        'bw_Reload_Settings
        '
        '
        'l_log
        '
        Me.l_log.AutoSize = True
        Me.l_log.BackColor = System.Drawing.Color.Transparent
        Me.l_log.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_log.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.l_log.Location = New System.Drawing.Point(242, 544)
        Me.l_log.Name = "l_log"
        Me.l_log.Size = New System.Drawing.Size(47, 24)
        Me.l_log.TabIndex = 35
        Me.l_log.Text = "Log:"
        '
        'rtb_log
        '
        Me.rtb_log.BackColor = System.Drawing.SystemColors.Window
        Me.rtb_log.Location = New System.Drawing.Point(26, 571)
        Me.rtb_log.Name = "rtb_log"
        Me.rtb_log.ReadOnly = True
        Me.rtb_log.Size = New System.Drawing.Size(490, 55)
        Me.rtb_log.TabIndex = 34
        Me.rtb_log.Text = ""
        '
        'l_restore_active
        '
        Me.l_restore_active.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.l_restore_active.AutoSize = True
        Me.l_restore_active.BackColor = System.Drawing.Color.Transparent
        Me.l_restore_active.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_restore_active.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.l_restore_active.Location = New System.Drawing.Point(366, 522)
        Me.l_restore_active.Name = "l_restore_active"
        Me.l_restore_active.Size = New System.Drawing.Size(158, 24)
        Me.l_restore_active.TabIndex = 37
        Me.l_restore_active.Text = "No Restore active"
        '
        'lc_restore_active
        '
        Me.lc_restore_active.Active = False
        Me.lc_restore_active.BackColor = System.Drawing.Color.Transparent
        Me.lc_restore_active.Color = System.Drawing.Color.WhiteSmoke
        Me.lc_restore_active.InnerCircleRadius = 8
        Me.lc_restore_active.Location = New System.Drawing.Point(304, 507)
        Me.lc_restore_active.Name = "lc_restore_active"
        Me.lc_restore_active.NumberSpoke = 24
        Me.lc_restore_active.OuterCircleRadius = 9
        Me.lc_restore_active.RotationSpeed = 85
        Me.lc_restore_active.Size = New System.Drawing.Size(66, 58)
        Me.lc_restore_active.SpokeThickness = 4
        Me.lc_restore_active.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.IE7
        Me.lc_restore_active.TabIndex = 36
        Me.lc_restore_active.Text = "Wait while Content is loading...."
        Me.lc_restore_active.Visible = False
        '
        'b_editSource
        '
        Me.b_editSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_editSource.Location = New System.Drawing.Point(431, 440)
        Me.b_editSource.Name = "b_editSource"
        Me.b_editSource.Size = New System.Drawing.Size(85, 26)
        Me.b_editSource.TabIndex = 38
        Me.b_editSource.Text = "Browse"
        Me.b_editSource.UseVisualStyleBackColor = True
        '
        'fbd_edittargetpath
        '
        Me.fbd_edittargetpath.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'Restore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WinBackupper.My.Resources.Resources.gray_background_3
        Me.ClientSize = New System.Drawing.Size(545, 633)
        Me.Controls.Add(Me.b_editSource)
        Me.Controls.Add(Me.l_restore_active)
        Me.Controls.Add(Me.lc_restore_active)
        Me.Controls.Add(Me.l_log)
        Me.Controls.Add(Me.rtb_log)
        Me.Controls.Add(Me.L_status)
        Me.Controls.Add(Me.lc_loading_datasets)
        Me.Controls.Add(Me.L_targetpath)
        Me.Controls.Add(Me.tb_targetdir)
        Me.Controls.Add(Me.btn_startrestore)
        Me.Controls.Add(Me.L_available_Datasets)
        Me.Controls.Add(Me.tv_restore)
        Me.Controls.Add(Me.l_restore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Restore"
        Me.Text = "Restore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents l_restore As Label
    Friend WithEvents tv_restore As TreeView
    Friend WithEvents L_available_Datasets As Label
    Friend WithEvents btn_startrestore As Button
    Friend WithEvents tb_targetdir As TextBox
    Friend WithEvents L_targetpath As Label
    Friend WithEvents lc_loading_datasets As MRG.Controls.UI.LoadingCircle
    Friend WithEvents L_status As Label
    Friend WithEvents bw_Reload_Settings As System.ComponentModel.BackgroundWorker
    Friend WithEvents l_log As Label
    Friend WithEvents rtb_log As RichTextBox
    Friend WithEvents l_restore_active As Label
    Friend WithEvents lc_restore_active As MRG.Controls.UI.LoadingCircle
    Friend WithEvents fbd_searchRestoretargetpath As FolderBrowserDialog
    Friend WithEvents b_editSource As Button
    Friend WithEvents fbd_edittargetpath As FolderBrowserDialog
End Class
