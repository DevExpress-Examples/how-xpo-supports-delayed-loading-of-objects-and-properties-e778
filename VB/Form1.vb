Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports Northwind

Namespace DelayedProperties
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private textEdit2 As DevExpress.XtraEditors.TextEdit
		Private textEdit3 As DevExpress.XtraEditors.TextEdit
		Private textEdit4 As DevExpress.XtraEditors.TextEdit
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private xpCollection1 As DevExpress.Xpo.XPCollection
		Private label5 As System.Windows.Forms.Label
		Private textEdit5 As DevExpress.XtraEditors.TextEdit
		Private textBox1 As TextBox
		Private unitOfWork1 As UnitOfWork
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			System.Diagnostics.Trace.Listeners.Add(New MyTraceListner(textBox1))
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
			Me.xpCollection1 = New DevExpress.Xpo.XPCollection()
			Me.unitOfWork1 = New DevExpress.Xpo.UnitOfWork()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
			Me.textEdit3 = New DevExpress.XtraEditors.TextEdit()
			Me.textEdit4 = New DevExpress.XtraEditors.TextEdit()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.textEdit5 = New DevExpress.XtraEditors.TextEdit()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataNavigator1
			' 
			Me.dataNavigator1.DataSource = Me.xpCollection1
			Me.dataNavigator1.Location = New System.Drawing.Point(14, 195)
			Me.dataNavigator1.Name = "dataNavigator1"
			Me.dataNavigator1.Size = New System.Drawing.Size(423, 28)
			Me.dataNavigator1.TabIndex = 5
			Me.dataNavigator1.Text = "dataNavigator1"
			Me.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
			' 
			' xpCollection1
			' 
			Me.xpCollection1.ObjectType = GetType(Northwind.Customer)
			Me.xpCollection1.Session = Me.unitOfWork1
			' 
			' textEdit1
			' 
			Me.textEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "ContactTitle", True))
			Me.textEdit1.Location = New System.Drawing.Point(216, 47)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(221, 22)
			Me.textEdit1.TabIndex = 1
			' 
			' textEdit2
			' 
			Me.textEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "CompanyName", True))
			Me.textEdit2.Location = New System.Drawing.Point(216, 84)
			Me.textEdit2.Name = "textEdit2"
			Me.textEdit2.Size = New System.Drawing.Size(221, 22)
			Me.textEdit2.TabIndex = 2
			' 
			' textEdit3
			' 
			Me.textEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "Address", True))
			Me.textEdit3.Location = New System.Drawing.Point(216, 121)
			Me.textEdit3.Name = "textEdit3"
			Me.textEdit3.Size = New System.Drawing.Size(221, 22)
			Me.textEdit3.TabIndex = 3
			' 
			' textEdit4
			' 
			Me.textEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "Orders.ID", True))
			Me.textEdit4.Location = New System.Drawing.Point(216, 158)
			Me.textEdit4.Name = "textEdit4"
			Me.textEdit4.Size = New System.Drawing.Size(221, 22)
			Me.textEdit4.TabIndex = 4
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(14, 47)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(192, 27)
			Me.label1.TabIndex = 5
			Me.label1.Text = "Contact Title (Immediate):"
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(14, 84)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(192, 27)
			Me.label2.TabIndex = 6
			Me.label2.Text = "Company Name (Delayed):"
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(14, 121)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(192, 27)
			Me.label3.TabIndex = 7
			Me.label3.Text = "Address (Delayed):"
			' 
			' label4
			' 
			Me.label4.Location = New System.Drawing.Point(14, 158)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(192, 27)
			Me.label4.TabIndex = 8
			Me.label4.Text = "Orders.ID (Delayed):"
			' 
			' label5
			' 
			Me.label5.Location = New System.Drawing.Point(14, 10)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(192, 27)
			Me.label5.TabIndex = 5
			Me.label5.Text = "CustomerID (Immediate):"
			' 
			' textEdit5
			' 
			Me.textEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "CustomerID", True))
			Me.textEdit5.Location = New System.Drawing.Point(216, 10)
			Me.textEdit5.Name = "textEdit5"
			Me.textEdit5.Size = New System.Drawing.Size(221, 22)
			Me.textEdit5.TabIndex = 0
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(14, 297)
			Me.textBox1.Multiline = True
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(423, 228)
			Me.textBox1.TabIndex = 9
			Me.textBox1.WordWrap = False
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(14, 263)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(423, 27)
			Me.simpleButton1.TabIndex = 10
			Me.simpleButton1.Text = "Read CompanyName of object #3 (Delayed)"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(14, 230)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(423, 26)
			Me.simpleButton2.TabIndex = 11
			Me.simpleButton2.Text = "Read ContactTitle of object #3 (already loaded)"
'			Me.simpleButton2.Click += New System.EventHandler(Me.simpleButton2_Click);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
			Me.ClientSize = New System.Drawing.Size(453, 467)
			Me.Controls.Add(Me.simpleButton2)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.textBox1)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.textEdit4)
			Me.Controls.Add(Me.textEdit3)
			Me.Controls.Add(Me.textEdit2)
			Me.Controls.Add(Me.textEdit1)
			Me.Controls.Add(Me.dataNavigator1)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.textEdit5)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Dim conn As String = MSSqlConnectionProvider.GetConnectionString("(local)", "Northwind")
			XpoDefault.DataLayer = XpoDefault.GetDataLayer(conn, AutoCreateOption.None)
			Application.Run(New Form1())
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			Dim cust As Customer = CType(xpCollection1(2), Customer)
			MessageBox.Show(cust.ContactTitle)
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim cust As Customer = CType(xpCollection1(2), Customer)
			MessageBox.Show(cust.CompanyName)
		End Sub
	End Class
End Namespace
