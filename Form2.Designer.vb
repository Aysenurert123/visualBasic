<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Soru1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Soru2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Soru3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Soru4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Soru5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.KapatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Soru1ToolStripMenuItem, Me.Soru2ToolStripMenuItem, Me.Soru3ToolStripMenuItem, Me.Soru4ToolStripMenuItem, Me.Soru5ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Soru1ToolStripMenuItem
        '
        Me.Soru1ToolStripMenuItem.Name = "Soru1ToolStripMenuItem"
        Me.Soru1ToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.Soru1ToolStripMenuItem.Text = "Soru-1"
        '
        'Soru2ToolStripMenuItem
        '
        Me.Soru2ToolStripMenuItem.Name = "Soru2ToolStripMenuItem"
        Me.Soru2ToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.Soru2ToolStripMenuItem.Text = "Soru-2"
        '
        'Soru3ToolStripMenuItem
        '
        Me.Soru3ToolStripMenuItem.Name = "Soru3ToolStripMenuItem"
        Me.Soru3ToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.Soru3ToolStripMenuItem.Text = "Soru-3"
        '
        'Soru4ToolStripMenuItem
        '
        Me.Soru4ToolStripMenuItem.Name = "Soru4ToolStripMenuItem"
        Me.Soru4ToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.Soru4ToolStripMenuItem.Text = "Soru-4"
        '
        'Soru5ToolStripMenuItem
        '
        Me.Soru5ToolStripMenuItem.Name = "Soru5ToolStripMenuItem"
        Me.Soru5ToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.Soru5ToolStripMenuItem.Text = "Soru-5"
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.Color.White
        Me.TrackBar1.Location = New System.Drawing.Point(138, 87)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(45, 333)
        Me.TrackBar1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(234, 395)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = " 0 sn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(199, 395)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Süre"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KapatToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(105, 26)
        '
        'KapatToolStripMenuItem
        '
        Me.KapatToolStripMenuItem.Name = "KapatToolStripMenuItem"
        Me.KapatToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.KapatToolStripMenuItem.Text = "Kapat"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Soru1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Soru2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Soru3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Soru4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Soru5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents KapatToolStripMenuItem As ToolStripMenuItem
End Class
