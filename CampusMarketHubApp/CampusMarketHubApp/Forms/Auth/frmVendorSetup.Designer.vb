<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendorSetup
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
        pnlLeft = New Panel()
        lblBrand = New Label()
        pnlRight = New Panel()
        lblTitle = New Label()
        lblSubtitle = New Label()
        txtShopName = New TextBox()
        pnlShopNameLine = New Panel()
        txtContact = New TextBox()
        pnlContactLine = New Panel()
        lblDescription = New Label()
        txtDescription = New TextBox()
        lblError = New Label()
        btnSave = New Button()
        lblSkip = New Label()
        pnlLeft.SuspendLayout()
        pnlRight.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlLeft
        ' 
        pnlLeft.Controls.Add(lblBrand)
        pnlLeft.Location = New Point(0, 0)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Size = New Size(380, 620)
        pnlLeft.TabIndex = 0
        ' 
        ' lblBrand
        ' 
        lblBrand.AutoSize = True
        lblBrand.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBrand.ForeColor = Color.FromArgb(CByte(219), CByte(68), CByte(68))
        lblBrand.Location = New Point(40, 40)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New Size(348, 46)
        lblBrand.TabIndex = 0
        lblBrand.Text = "Campus Market Hub"
        ' 
        ' pnlRight
        ' 
        pnlRight.BackColor = Color.White
        pnlRight.Controls.Add(lblSkip)
        pnlRight.Controls.Add(btnSave)
        pnlRight.Controls.Add(lblError)
        pnlRight.Controls.Add(txtDescription)
        pnlRight.Controls.Add(lblDescription)
        pnlRight.Controls.Add(pnlContactLine)
        pnlRight.Controls.Add(txtContact)
        pnlRight.Controls.Add(pnlShopNameLine)
        pnlRight.Controls.Add(txtShopName)
        pnlRight.Controls.Add(lblSubtitle)
        pnlRight.Controls.Add(lblTitle)
        pnlRight.Location = New Point(380, 0)
        pnlRight.Name = "pnlRight"
        pnlRight.Size = New Size(520, 620)
        pnlRight.TabIndex = 1
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.Black
        lblTitle.Location = New Point(60, 60)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(256, 41)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Set up your shop"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 10F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(125), CByte(129), CByte(132))
        lblSubtitle.Location = New Point(60, 105)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(220, 23)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Tell buyers about your shop"
        ' 
        ' txtShopName
        ' 
        txtShopName.BorderStyle = BorderStyle.None
        txtShopName.Font = New Font("Segoe UI", 10F)
        txtShopName.ForeColor = Color.White
        txtShopName.Location = New Point(60, 150)
        txtShopName.Name = "txtShopName"
        txtShopName.Size = New Size(360, 23)
        txtShopName.TabIndex = 2
        ' 
        ' pnlShopNameLine
        ' 
        pnlShopNameLine.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        pnlShopNameLine.Location = New Point(60, 181)
        pnlShopNameLine.Name = "pnlShopNameLine"
        pnlShopNameLine.Size = New Size(360, 1)
        pnlShopNameLine.TabIndex = 3
        ' 
        ' txtContact
        ' 
        txtContact.BorderStyle = BorderStyle.None
        txtContact.Font = New Font("Segoe UI", 10F)
        txtContact.ForeColor = Color.White
        txtContact.Location = New Point(60, 215)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(360, 23)
        txtContact.TabIndex = 4
        ' 
        ' pnlContactLine
        ' 
        pnlContactLine.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        pnlContactLine.Location = New Point(60, 246)
        pnlContactLine.Name = "pnlContactLine"
        pnlContactLine.Size = New Size(360, 1)
        pnlContactLine.TabIndex = 4
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.ForeColor = Color.FromArgb(CByte(125), CByte(129), CByte(132))
        lblDescription.Location = New Point(60, 265)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(123, 20)
        lblDescription.TabIndex = 5
        lblDescription.Text = "Shop Description"
        ' 
        ' txtDescription
        ' 
        txtDescription.BorderStyle = BorderStyle.None
        txtDescription.Font = New Font("Segoe UI", 10F)
        txtDescription.ForeColor = Color.White
        txtDescription.Location = New Point(60, 285)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.ScrollBars = ScrollBars.Vertical
        txtDescription.Size = New Size(360, 80)
        txtDescription.TabIndex = 6
        ' 
        ' lblError
        ' 
        lblError.AutoSize = True
        lblError.ForeColor = Color.FromArgb(CByte(219), CByte(68), CByte(68))
        lblError.Location = New Point(60, 375)
        lblError.Name = "lblError"
        lblError.Size = New Size(0, 20)
        lblError.TabIndex = 7
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(219), CByte(68), CByte(68))
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 10F)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(60, 400)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(360, 44)
        btnSave.TabIndex = 8
        btnSave.Text = "Save and Continue"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' lblSkip
        ' 
        lblSkip.AutoSize = True
        lblSkip.Cursor = Cursors.Hand
        lblSkip.Font = New Font("Segoe UI", 10F)
        lblSkip.ForeColor = Color.FromArgb(CByte(125), CByte(129), CByte(132))
        lblSkip.Location = New Point(185, 460)
        lblSkip.Name = "lblSkip"
        lblSkip.Size = New Size(104, 23)
        lblSkip.TabIndex = 9
        lblSkip.Text = "Skip for now"
        ' 
        ' frmVendorSetup
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(882, 617)
        Controls.Add(pnlRight)
        Controls.Add(pnlLeft)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmVendorSetup"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Campus Market Hub — Shop Setup"
        pnlLeft.ResumeLayout(False)
        pnlLeft.PerformLayout()
        pnlRight.ResumeLayout(False)
        pnlRight.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLeft As Panel
    Friend WithEvents lblBrand As Label
    Friend WithEvents pnlRight As Panel
    Friend WithEvents txtShopName As TextBox
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblError As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents pnlContactLine As Panel
    Friend WithEvents txtContact As TextBox
    Friend WithEvents pnlShopNameLine As Panel
    Friend WithEvents lblSkip As Label
    Friend WithEvents btnSave As Button
End Class
