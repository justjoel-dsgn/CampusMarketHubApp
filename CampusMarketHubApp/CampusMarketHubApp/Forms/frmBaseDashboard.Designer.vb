<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaseDashboard
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
        pnlTopNav = New Panel()
        lblBrand = New Label()
        lblLoggedInUser = New Label()
        lblRoleBadge = New Label()
        lblLogout = New Label()
        pnlNavBorder = New FlowLayoutPanel()
        pnlSidebar = New Panel()
        pnlMenuItems = New Panel()
        pnlMainContent = New Panel()
        pnlSidebarBottom = New Panel()
        lblSidebarLogout = New Label()
        pnlTopNav.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlMenuItems.SuspendLayout()
        pnlSidebarBottom.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlTopNav
        ' 
        pnlTopNav.BackColor = Color.White
        pnlTopNav.Controls.Add(pnlNavBorder)
        pnlTopNav.Controls.Add(lblLogout)
        pnlTopNav.Controls.Add(lblRoleBadge)
        pnlTopNav.Controls.Add(lblLoggedInUser)
        pnlTopNav.Controls.Add(lblBrand)
        pnlTopNav.Dock = DockStyle.Top
        pnlTopNav.Location = New Point(0, 0)
        pnlTopNav.Name = "pnlTopNav"
        pnlTopNav.Size = New Size(1262, 70)
        pnlTopNav.TabIndex = 0
        ' 
        ' lblBrand
        ' 
        lblBrand.AutoSize = True
        lblBrand.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBrand.ForeColor = Color.FromArgb(CByte(219), CByte(68), CByte(68))
        lblBrand.Location = New Point(24, 20)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New Size(234, 31)
        lblBrand.TabIndex = 0
        lblBrand.Text = "Campus Market Hub"
        ' 
        ' lblLoggedInUser
        ' 
        lblLoggedInUser.AutoSize = True
        lblLoggedInUser.Font = New Font("Segoe UI", 10F)
        lblLoggedInUser.ForeColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        lblLoggedInUser.Location = New Point(950, 25)
        lblLoggedInUser.Name = "lblLoggedInUser"
        lblLoggedInUser.Size = New Size(0, 23)
        lblLoggedInUser.TabIndex = 1
        ' 
        ' lblRoleBadge
        ' 
        lblRoleBadge.AutoSize = True
        lblRoleBadge.BackColor = Color.FromArgb(CByte(219), CByte(68), CByte(68))
        lblRoleBadge.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRoleBadge.ForeColor = Color.White
        lblRoleBadge.Location = New Point(950, 46)
        lblRoleBadge.Name = "lblRoleBadge"
        lblRoleBadge.Padding = New Padding(4, 2, 4, 2)
        lblRoleBadge.Size = New Size(8, 21)
        lblRoleBadge.TabIndex = 2
        ' 
        ' lblLogout
        ' 
        lblLogout.AutoSize = True
        lblLogout.Cursor = Cursors.Hand
        lblLogout.Font = New Font("Segoe UI", 10F)
        lblLogout.ForeColor = Color.FromArgb(CByte(219), CByte(68), CByte(68))
        lblLogout.Location = New Point(1150, 25)
        lblLogout.Name = "lblLogout"
        lblLogout.Size = New Size(64, 23)
        lblLogout.TabIndex = 3
        lblLogout.Text = "Logout"
        ' 
        ' pnlNavBorder
        ' 
        pnlNavBorder.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        pnlNavBorder.Dock = DockStyle.Bottom
        pnlNavBorder.Location = New Point(0, 69)
        pnlNavBorder.Name = "pnlNavBorder"
        pnlNavBorder.Size = New Size(1262, 1)
        pnlNavBorder.TabIndex = 4
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        pnlSidebar.Controls.Add(pnlMenuItems)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 70)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(220, 683)
        pnlSidebar.TabIndex = 1
        ' 
        ' pnlMenuItems
        ' 
        pnlMenuItems.AutoScroll = True
        pnlMenuItems.Controls.Add(pnlSidebarBottom)
        pnlMenuItems.Location = New Point(0, 20)
        pnlMenuItems.Name = "pnlMenuItems"
        pnlMenuItems.Size = New Size(220, 600)
        pnlMenuItems.TabIndex = 0
        ' 
        ' pnlMainContent
        ' 
        pnlMainContent.Dock = DockStyle.Fill
        pnlMainContent.Location = New Point(220, 70)
        pnlMainContent.Name = "pnlMainContent"
        pnlMainContent.Padding = New Padding(24)
        pnlMainContent.Size = New Size(1042, 683)
        pnlMainContent.TabIndex = 2
        ' 
        ' pnlSidebarBottom
        ' 
        pnlSidebarBottom.BackColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        pnlSidebarBottom.Controls.Add(lblSidebarLogout)
        pnlSidebarBottom.Dock = DockStyle.Bottom
        pnlSidebarBottom.Location = New Point(0, 540)
        pnlSidebarBottom.Name = "pnlSidebarBottom"
        pnlSidebarBottom.Size = New Size(220, 60)
        pnlSidebarBottom.TabIndex = 0
        ' 
        ' lblSidebarLogout
        ' 
        lblSidebarLogout.AutoSize = True
        lblSidebarLogout.Cursor = Cursors.Hand
        lblSidebarLogout.Font = New Font("Segoe UI", 10F)
        lblSidebarLogout.ForeColor = Color.FromArgb(CByte(189), CByte(189), CByte(189))
        lblSidebarLogout.Location = New Point(24, 18)
        lblSidebarLogout.Name = "lblSidebarLogout"
        lblSidebarLogout.Size = New Size(87, 23)
        lblSidebarLogout.TabIndex = 0
        lblSidebarLogout.Text = "⬡  Logout"
        ' 
        ' frmBaseDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1262, 753)
        Controls.Add(pnlMainContent)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlTopNav)
        MinimumSize = New Size(1024, 600)
        Name = "frmBaseDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Campus Market Hub"
        WindowState = FormWindowState.Maximized
        pnlTopNav.ResumeLayout(False)
        pnlTopNav.PerformLayout()
        pnlSidebar.ResumeLayout(False)
        pnlMenuItems.ResumeLayout(False)
        pnlSidebarBottom.ResumeLayout(False)
        pnlSidebarBottom.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTopNav As Panel
    Friend WithEvents lblBrand As Label
    Friend WithEvents pnlNavBorder As FlowLayoutPanel
    Friend WithEvents lblLogout As Label
    Friend WithEvents lblRoleBadge As Label
    Friend WithEvents lblLoggedInUser As Label
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlMenuItems As Panel
    Friend WithEvents pnlSidebarBottom As Panel
    Friend WithEvents lblSidebarLogout As Label
    Friend WithEvents pnlMainContent As Panel
End Class
