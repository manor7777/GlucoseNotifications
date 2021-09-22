<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlertDialog
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlertDialog))
        Me.BigSound = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonDismissAll = New System.Windows.Forms.Button()
        Me.AlertText = New System.Windows.Forms.Label()
        Me.AlertImage = New System.Windows.Forms.PictureBox()
        CType(Me.AlertImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BigSound
        '
        Me.BigSound.Interval = 2000
        '
        'ButtonDismissAll
        '
        Me.ButtonDismissAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDismissAll.Location = New System.Drawing.Point(1172, 733)
        Me.ButtonDismissAll.Name = "ButtonDismissAll"
        Me.ButtonDismissAll.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDismissAll.TabIndex = 0
        Me.ButtonDismissAll.Text = "Dismiss"
        Me.ButtonDismissAll.UseVisualStyleBackColor = True
        '
        'AlertText
        '
        Me.AlertText.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AlertText.AutoEllipsis = True
        Me.AlertText.Font = New System.Drawing.Font("Microsoft Sans Serif", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlertText.ForeColor = System.Drawing.Color.Red
        Me.AlertText.Location = New System.Drawing.Point(-5, 23)
        Me.AlertText.Name = "AlertText"
        Me.AlertText.Size = New System.Drawing.Size(1268, 152)
        Me.AlertText.TabIndex = 2
        Me.AlertText.Text = "GLUCOSE ALERT"
        Me.AlertText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AlertImage
        '
        Me.AlertImage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlertImage.Image = Global.GlucoseNotifications.My.Resources.Resources.warning_33_512
        Me.AlertImage.Location = New System.Drawing.Point(298, 210)
        Me.AlertImage.Name = "AlertImage"
        Me.AlertImage.Size = New System.Drawing.Size(677, 483)
        Me.AlertImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.AlertImage.TabIndex = 1
        Me.AlertImage.TabStop = False
        '
        'AlertDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 768)
        Me.Controls.Add(Me.AlertText)
        Me.Controls.Add(Me.AlertImage)
        Me.Controls.Add(Me.ButtonDismissAll)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AlertDialog"
        Me.ShowInTaskbar = False
        Me.Text = "AlertWindow"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AlertImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BigSound As Timer
    Friend WithEvents ButtonDismissAll As Button
    Friend WithEvents AlertImage As PictureBox
    Friend WithEvents AlertText As Label
End Class
