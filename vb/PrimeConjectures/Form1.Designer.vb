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
        Me.generatePairs = New System.Windows.Forms.Button()
        Me.pairLimit = New System.Windows.Forms.TextBox()
        Me.twinPrimeList = New System.Windows.Forms.RichTextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.redmondSunExceptions = New System.Windows.Forms.RichTextBox()
        Me.rangeLimit = New System.Windows.Forms.TextBox()
        Me.generateExceptions = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'generatePairs
        '
        Me.generatePairs.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.generatePairs.Location = New System.Drawing.Point(297, 38)
        Me.generatePairs.Name = "generatePairs"
        Me.generatePairs.Size = New System.Drawing.Size(146, 23)
        Me.generatePairs.TabIndex = 0
        Me.generatePairs.Text = "Find Twin Pairs"
        Me.generatePairs.UseVisualStyleBackColor = True
        '
        'pairLimit
        '
        Me.pairLimit.Location = New System.Drawing.Point(103, 40)
        Me.pairLimit.Name = "pairLimit"
        Me.pairLimit.Size = New System.Drawing.Size(178, 20)
        Me.pairLimit.TabIndex = 1
        '
        'twinPrimeList
        '
        Me.twinPrimeList.Location = New System.Drawing.Point(28, 69)
        Me.twinPrimeList.Name = "twinPrimeList"
        Me.twinPrimeList.Size = New System.Drawing.Size(415, 248)
        Me.twinPrimeList.TabIndex = 4
        Me.twinPrimeList.Text = ""
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 83)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(487, 380)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.pairLimit)
        Me.TabPage1.Controls.Add(Me.twinPrimeList)
        Me.TabPage1.Controls.Add(Me.generatePairs)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(479, 351)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Twin Primes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(297, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "There are infinitely many primes p such that p + 2 is also prime"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "# of Pairs: "
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.redmondSunExceptions)
        Me.TabPage2.Controls.Add(Me.rangeLimit)
        Me.TabPage2.Controls.Add(Me.generateExceptions)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(479, 351)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Redmond-Sun"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(439, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "[x^m, y^n] with x, y, m, n ∈ {2, 3, 4, ..., n} contains primes with only finitely" & _
    " many exceptions"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Input n value:"
        '
        'redmondSunExceptions
        '
        Me.redmondSunExceptions.Location = New System.Drawing.Point(28, 69)
        Me.redmondSunExceptions.Name = "redmondSunExceptions"
        Me.redmondSunExceptions.Size = New System.Drawing.Size(415, 248)
        Me.redmondSunExceptions.TabIndex = 5
        Me.redmondSunExceptions.Text = ""
        '
        'rangeLimit
        '
        Me.rangeLimit.Location = New System.Drawing.Point(103, 42)
        Me.rangeLimit.Name = "rangeLimit"
        Me.rangeLimit.Size = New System.Drawing.Size(183, 20)
        Me.rangeLimit.TabIndex = 4
        '
        'generateExceptions
        '
        Me.generateExceptions.Location = New System.Drawing.Point(292, 39)
        Me.generateExceptions.Name = "generateExceptions"
        Me.generateExceptions.Size = New System.Drawing.Size(151, 23)
        Me.generateExceptions.TabIndex = 3
        Me.generateExceptions.Text = "Find Exceptions"
        Me.generateExceptions.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PrimeConjectures.My.Resources.Resources.banner
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(512, 83)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(486, 464)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Prime Conjectures"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents generatePairs As System.Windows.Forms.Button
    Friend WithEvents pairLimit As System.Windows.Forms.TextBox
    Friend WithEvents twinPrimeList As System.Windows.Forms.RichTextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents rangeLimit As System.Windows.Forms.TextBox
    Friend WithEvents generateExceptions As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents redmondSunExceptions As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
