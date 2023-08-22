<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtDisplay = New TextBox()
        btn1 = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        btn2 = New Button()
        btn3 = New Button()
        btn4 = New Button()
        btn5 = New Button()
        btn6 = New Button()
        btn7 = New Button()
        btn8 = New Button()
        btn9 = New Button()
        btnResult = New Button()
        btnDot = New Button()
        btn0 = New Button()
        btnDiv = New Button()
        btnMult = New Button()
        btnSub = New Button()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        btnDel = New Button()
        btnAC = New Button()
        btnSqrt = New Button()
        btnPercent = New Button()
        btnAdd = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtDisplay
        ' 
        txtDisplay.BackColor = SystemColors.WindowFrame
        txtDisplay.Font = New Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtDisplay.Location = New Point(12, 27)
        txtDisplay.Multiline = True
        txtDisplay.Name = "txtDisplay"
        txtDisplay.Size = New Size(318, 75)
        txtDisplay.TabIndex = 0
        txtDisplay.Text = "0"
        txtDisplay.TextAlign = HorizontalAlignment.Right
        ' 
        ' btn1
        ' 
        btn1.BackColor = SystemColors.ControlDark
        btn1.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn1.Location = New Point(12, 351)
        btn1.Name = "btn1"
        btn1.Size = New Size(75, 75)
        btn1.TabIndex = 1
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = False
        ' 
        ' btn2
        ' 
        btn2.BackColor = SystemColors.ControlDark
        btn2.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn2.Location = New Point(93, 351)
        btn2.Name = "btn2"
        btn2.Size = New Size(75, 75)
        btn2.TabIndex = 2
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = False
        ' 
        ' btn3
        ' 
        btn3.BackColor = SystemColors.ControlDark
        btn3.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn3.Location = New Point(174, 351)
        btn3.Name = "btn3"
        btn3.Size = New Size(75, 75)
        btn3.TabIndex = 3
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = False
        ' 
        ' btn4
        ' 
        btn4.BackColor = SystemColors.ControlDark
        btn4.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn4.Location = New Point(12, 270)
        btn4.Name = "btn4"
        btn4.Size = New Size(75, 75)
        btn4.TabIndex = 6
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = False
        ' 
        ' btn5
        ' 
        btn5.BackColor = SystemColors.ControlDark
        btn5.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn5.Location = New Point(93, 270)
        btn5.Name = "btn5"
        btn5.Size = New Size(75, 75)
        btn5.TabIndex = 5
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = False
        ' 
        ' btn6
        ' 
        btn6.BackColor = SystemColors.ControlDark
        btn6.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn6.Location = New Point(174, 270)
        btn6.Name = "btn6"
        btn6.Size = New Size(75, 75)
        btn6.TabIndex = 4
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = False
        ' 
        ' btn7
        ' 
        btn7.BackColor = SystemColors.ControlDark
        btn7.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn7.Location = New Point(12, 189)
        btn7.Name = "btn7"
        btn7.Size = New Size(75, 75)
        btn7.TabIndex = 9
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = False
        ' 
        ' btn8
        ' 
        btn8.BackColor = SystemColors.ControlDark
        btn8.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn8.Location = New Point(93, 189)
        btn8.Name = "btn8"
        btn8.Size = New Size(75, 75)
        btn8.TabIndex = 8
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = False
        ' 
        ' btn9
        ' 
        btn9.BackColor = SystemColors.ControlDark
        btn9.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn9.Location = New Point(174, 189)
        btn9.Name = "btn9"
        btn9.Size = New Size(75, 75)
        btn9.TabIndex = 7
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = False
        ' 
        ' btnResult
        ' 
        btnResult.BackColor = SystemColors.ControlDark
        btnResult.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnResult.Location = New Point(174, 432)
        btnResult.Name = "btnResult"
        btnResult.Size = New Size(75, 75)
        btnResult.TabIndex = 12
        btnResult.Text = "="
        btnResult.UseVisualStyleBackColor = False
        ' 
        ' btnDot
        ' 
        btnDot.BackColor = SystemColors.ControlDark
        btnDot.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnDot.Location = New Point(93, 432)
        btnDot.Name = "btnDot"
        btnDot.Size = New Size(75, 75)
        btnDot.TabIndex = 11
        btnDot.Text = "."
        btnDot.UseVisualStyleBackColor = False
        ' 
        ' btn0
        ' 
        btn0.BackColor = SystemColors.ControlDark
        btn0.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn0.Location = New Point(12, 432)
        btn0.Name = "btn0"
        btn0.Size = New Size(75, 75)
        btn0.TabIndex = 10
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = False
        ' 
        ' btnDiv
        ' 
        btnDiv.BackColor = SystemColors.ButtonShadow
        btnDiv.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnDiv.Location = New Point(255, 432)
        btnDiv.Name = "btnDiv"
        btnDiv.Size = New Size(75, 75)
        btnDiv.TabIndex = 16
        btnDiv.Text = "/"
        btnDiv.UseVisualStyleBackColor = False
        ' 
        ' btnMult
        ' 
        btnMult.BackColor = SystemColors.ControlDark
        btnMult.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnMult.Location = New Point(255, 351)
        btnMult.Name = "btnMult"
        btnMult.Size = New Size(75, 75)
        btnMult.TabIndex = 15
        btnMult.Text = "*"
        btnMult.UseVisualStyleBackColor = False
        ' 
        ' btnSub
        ' 
        btnSub.BackColor = SystemColors.ControlDark
        btnSub.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnSub.Location = New Point(255, 270)
        btnSub.Name = "btnSub"
        btnSub.Size = New Size(75, 75)
        btnSub.TabIndex = 14
        btnSub.Text = "-"
        btnSub.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(343, 24)
        MenuStrip1.TabIndex = 17
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(39, 20)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' btnDel
        ' 
        btnDel.BackColor = SystemColors.ControlDark
        btnDel.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnDel.Location = New Point(12, 108)
        btnDel.Name = "btnDel"
        btnDel.Size = New Size(75, 75)
        btnDel.TabIndex = 21
        btnDel.Text = "DEL"
        btnDel.UseVisualStyleBackColor = False
        ' 
        ' btnAC
        ' 
        btnAC.BackColor = SystemColors.ControlDark
        btnAC.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnAC.Location = New Point(93, 108)
        btnAC.Name = "btnAC"
        btnAC.Size = New Size(75, 75)
        btnAC.TabIndex = 20
        btnAC.Text = "AC"
        btnAC.UseVisualStyleBackColor = False
        ' 
        ' btnSqrt
        ' 
        btnSqrt.BackColor = SystemColors.ControlDark
        btnSqrt.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnSqrt.Location = New Point(174, 108)
        btnSqrt.Name = "btnSqrt"
        btnSqrt.Size = New Size(75, 75)
        btnSqrt.TabIndex = 19
        btnSqrt.Text = "√"
        btnSqrt.UseVisualStyleBackColor = False
        ' 
        ' btnPercent
        ' 
        btnPercent.BackColor = SystemColors.ControlDark
        btnPercent.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnPercent.Location = New Point(255, 108)
        btnPercent.Name = "btnPercent"
        btnPercent.Size = New Size(75, 75)
        btnPercent.TabIndex = 18
        btnPercent.Text = "%"
        btnPercent.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = SystemColors.ControlDark
        btnAdd.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnAdd.Location = New Point(255, 189)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 75)
        btnAdd.TabIndex = 22
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(343, 518)
        Controls.Add(btnAdd)
        Controls.Add(btnDel)
        Controls.Add(btnAC)
        Controls.Add(btnSqrt)
        Controls.Add(btnPercent)
        Controls.Add(btnDiv)
        Controls.Add(btnMult)
        Controls.Add(btnSub)
        Controls.Add(btnResult)
        Controls.Add(btnDot)
        Controls.Add(btn0)
        Controls.Add(btn7)
        Controls.Add(btn8)
        Controls.Add(btn9)
        Controls.Add(btn4)
        Controls.Add(btn5)
        Controls.Add(btn6)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(txtDisplay)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btn1 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btnResult As Button
    Friend WithEvents btnDot As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnMult As Button
    Friend WithEvents btnSub As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnDel As Button
    Friend WithEvents btnAC As Button
    Friend WithEvents btnSqrt As Button
    Friend WithEvents btnPercent As Button
    Friend WithEvents btnAdd As Button
End Class
