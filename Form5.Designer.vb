<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbSecim = New System.Windows.Forms.RadioButton()
        Me.rbSecim2 = New System.Windows.Forms.RadioButton()
        Me.rbSecim3 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSayi2 = New System.Windows.Forms.Label()
        Me.lblSayi1 = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.Soru1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Soru2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Soru3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Soru4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Soru5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.KapatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbSecim)
        Me.GroupBox1.Controls.Add(Me.rbSecim2)
        Me.GroupBox1.Controls.Add(Me.rbSecim3)
        Me.GroupBox1.Location = New System.Drawing.Point(108, 238)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 74)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seçenekler"
        '
        'rbSecim
        '
        Me.rbSecim.AutoSize = True
        Me.rbSecim.Location = New System.Drawing.Point(27, 31)
        Me.rbSecim.Name = "rbSecim"
        Me.rbSecim.Size = New System.Drawing.Size(31, 17)
        Me.rbSecim.TabIndex = 1
        Me.rbSecim.Text = "?"
        Me.rbSecim.UseVisualStyleBackColor = True
        '
        'rbSecim2
        '
        Me.rbSecim2.AutoSize = True
        Me.rbSecim2.Location = New System.Drawing.Point(147, 31)
        Me.rbSecim2.Name = "rbSecim2"
        Me.rbSecim2.Size = New System.Drawing.Size(31, 17)
        Me.rbSecim2.TabIndex = 1
        Me.rbSecim2.Text = "?"
        Me.rbSecim2.UseVisualStyleBackColor = True
        '
        'rbSecim3
        '
        Me.rbSecim3.AutoSize = True
        Me.rbSecim3.Location = New System.Drawing.Point(283, 31)
        Me.rbSecim3.Name = "rbSecim3"
        Me.rbSecim3.Size = New System.Drawing.Size(31, 17)
        Me.rbSecim3.TabIndex = 1
        Me.rbSecim3.Text = "?"
        Me.rbSecim3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(562, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 72)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Soru Sor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(389, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "= ?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(197, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "+"
        '
        'lblSayi2
        '
        Me.lblSayi2.AutoSize = True
        Me.lblSayi2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSayi2.Location = New System.Drawing.Point(250, 138)
        Me.lblSayi2.Name = "lblSayi2"
        Me.lblSayi2.Size = New System.Drawing.Size(72, 25)
        Me.lblSayi2.TabIndex = 6
        Me.lblSayi2.Text = "Sayı 2"
        '
        'lblSayi1
        '
        Me.lblSayi1.AutoSize = True
        Me.lblSayi1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSayi1.Location = New System.Drawing.Point(103, 138)
        Me.lblSayi1.Name = "lblSayi1"
        Me.lblSayi1.Size = New System.Drawing.Size(72, 25)
        Me.lblSayi1.TabIndex = 7
        Me.lblSayi1.Text = "Sayı 1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Soru1ToolStripMenuItem, Me.Soru2ToolStripMenuItem, Me.Soru3ToolStripMenuItem, Me.Soru4ToolStripMenuItem, Me.Soru5ToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip2.TabIndex = 16
        Me.MenuStrip2.Text = "MenuStrip2"
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KapatToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(105, 26)
        '
        'KapatToolStripMenuItem
        '
        Me.KapatToolStripMenuItem.Name = "KapatToolStripMenuItem"
        Me.KapatToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.KapatToolStripMenuItem.Text = "Kapat"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSayi2)
        Me.Controls.Add(Me.lblSayi1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbSecim As RadioButton
    Friend WithEvents rbSecim2 As RadioButton
    Friend WithEvents rbSecim3 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSayi2 As Label
    Friend WithEvents lblSayi1 As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents Soru1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Soru2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Soru3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Soru4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Soru5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents KapatToolStripMenuItem As ToolStripMenuItem
End Class
