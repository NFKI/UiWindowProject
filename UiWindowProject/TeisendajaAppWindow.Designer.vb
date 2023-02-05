<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeisendajaApp
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
        Me.BtnTeisendaja = New System.Windows.Forms.Button()
        Me.KiloEntry = New System.Windows.Forms.TextBox()
        Me.MiiliOut = New System.Windows.Forms.TextBox()
        Me.KiloLabel = New System.Windows.Forms.Label()
        Me.MiiliLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnTeisendaja
        '
        Me.BtnTeisendaja.Location = New System.Drawing.Point(406, 193)
        Me.BtnTeisendaja.Name = "BtnTeisendaja"
        Me.BtnTeisendaja.Size = New System.Drawing.Size(192, 23)
        Me.BtnTeisendaja.TabIndex = 0
        Me.BtnTeisendaja.Text = "Teisenda Miilidesse"
        Me.BtnTeisendaja.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnTeisendaja.UseVisualStyleBackColor = True
        '
        'KiloEntry
        '
        Me.KiloEntry.Location = New System.Drawing.Point(406, 152)
        Me.KiloEntry.Name = "KiloEntry"
        Me.KiloEntry.Size = New System.Drawing.Size(192, 22)
        Me.KiloEntry.TabIndex = 1
        '
        'MiiliOut
        '
        Me.MiiliOut.Location = New System.Drawing.Point(406, 237)
        Me.MiiliOut.Name = "MiiliOut"
        Me.MiiliOut.ReadOnly = True
        Me.MiiliOut.Size = New System.Drawing.Size(192, 22)
        Me.MiiliOut.TabIndex = 2
        '
        'KiloLabel
        '
        Me.KiloLabel.AutoSize = True
        Me.KiloLabel.Location = New System.Drawing.Point(327, 155)
        Me.KiloLabel.Name = "KiloLabel"
        Me.KiloLabel.Size = New System.Drawing.Size(29, 16)
        Me.KiloLabel.TabIndex = 3
        Me.KiloLabel.Text = "Kilo"
        '
        'MiiliLabel
        '
        Me.MiiliLabel.AutoSize = True
        Me.MiiliLabel.Location = New System.Drawing.Point(327, 240)
        Me.MiiliLabel.Name = "MiiliLabel"
        Me.MiiliLabel.Size = New System.Drawing.Size(64, 16)
        Me.MiiliLabel.TabIndex = 4
        Me.MiiliLabel.Text = "MiiliLabel"
        '
        'TeisendajaApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MiiliLabel)
        Me.Controls.Add(Me.KiloLabel)
        Me.Controls.Add(Me.MiiliOut)
        Me.Controls.Add(Me.KiloEntry)
        Me.Controls.Add(Me.BtnTeisendaja)
        Me.Name = "TeisendajaApp"
        Me.Text = "Teisendaja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTeisendaja As Button
    Friend WithEvents KiloEntry As TextBox
    Friend WithEvents MiiliOut As TextBox
    Friend WithEvents KiloLabel As Label
    Friend WithEvents MiiliLabel As Label
End Class
