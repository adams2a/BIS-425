'Project: PetCharacteristics
'Programmer: Austin Adams
'Date: September 3, 2017
'Class: Pet Class
'Description: this class contain all the properties of your Pet.  This is the class that contains all business logic.  Private variables/constants are available to and used by this class only.  Properties are used to communicate with other objects outside of the class.

Public Class PetsClass
	Private NameString As String
	Private TypeString As String
	Private BreedString As String
	Private ColorString As String
	Sub New(ByVal NameIn As String, ByVal TypeIn As String, ByVal BreedIn As String, ByVal ColorIn As String)
		'Set the property values 

		Name = NameIn
		Type = TypeIn
		Breed = BreedIn
		Color = ColorIn
	End Sub
	Property Name() As String
		Get
			Return NameString
		End Get
		Set(ByVal Value As String)
			If Value <> "" Then
				NameString = Value
			Else
				Dim ex As New ApplicationException("Please enter a name for your pet.")
				ex.Source = "Name"
				Throw ex
			End If
		End Set
	End Property
	Property Type() As String
		Get
			Return TypeString
		End Get
		Set(ByVal Value As String)
			If Value <> "" Then
				TypeString = Value
			Else
				Dim ex As New ApplicationException("Please enter your pet's type.")
				ex.Source = "Type"
				Throw ex
			End If
		End Set
	End Property

	Property Breed() As String
		Get
			Return BreedString
		End Get
		Set(ByVal Value As String)
			If Value <> "" Then
				BreedString = Value
			Else
				Dim ex As New ApplicationException("Please enter your pet's breed.")
				ex.Source = "Breed"
				Throw ex
			End If
		End Set
	End Property

	Property Color() As String
		Get
			Return ColorString
		End Get
		Set(ByVal Value As String)
			If Value <> "" Then
				ColorString = Value
			Else
				Dim ex As New ApplicationException("Please enter your pet's color.")
				ex.Source = "Color"
				Throw ex
			End If
		End Set
	End Property

End Class
