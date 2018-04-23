Imports Microsoft.VisualBasic
	Imports System
	Imports DevExpress.Xpo
Namespace Northwind

	<Persistent("Customers")> _
	Public Class Customer
		Inherits XPLiteObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Private customerIDValue As String
		<Key> _
		Public Property CustomerID() As String
			Get
				Return customerIDValue
			End Get
			Set(ByVal value As String)
				SetPropertyValue("CustomerID", customerIDValue, value)
			End Set
		End Property

		Private contactTitleValue As String
		Public Property ContactTitle() As String
			Get
				Return contactTitleValue
			End Get
			Set(ByVal value As String)
				SetPropertyValue("ContactTitle", contactTitleValue, value)
			End Set
		End Property

		<Delayed> _
		Public Property CompanyName() As String
			Get
				Return GetDelayedPropertyValue(Of String)("CompanyName")
			End Get
			Set(ByVal value As String)
				SetDelayedPropertyValue("CompanyName", value)
			End Set
		End Property

		<Delayed> _
		Public Property Address() As String
			Get
				Return GetDelayedPropertyValue(Of String)("Address")
			End Get
			Set(ByVal value As String)
				SetDelayedPropertyValue("Address", value)
			End Set
		End Property

		<Association("CustomerOrders", GetType(Order))> _
		Public ReadOnly Property Orders() As XPCollection(Of Order)
			Get
				Return GetCollection(Of Order)("Orders")
			End Get
		End Property
	End Class

	<Persistent("Orders")> _
	Public Class Order
		Inherits XPLiteObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		<Key(True), Persistent> _
		Private OrderID As Integer = -1

		<PersistentAlias("OrderID")> _
		Public ReadOnly Property ID() As Integer
			Get
				Return OrderID
			End Get
		End Property

		Private shippedDateValue As DateTime
		Public Property ShippedDate() As DateTime
			Get
				Return shippedDateValue
			End Get
			Set(ByVal value As DateTime)
				SetPropertyValue("ShippedDate", shippedDateValue, value)
			End Set
		End Property

		Private customerValue As Customer
		<Persistent("CustomerID"), Association("CustomerOrders")> _
		Public Property Customer() As Customer
			Get
				Return customerValue
			End Get
			Set(ByVal value As Customer)
				SetPropertyValue("Customer", customerValue, value)
			End Set
		End Property
	End Class
End Namespace
