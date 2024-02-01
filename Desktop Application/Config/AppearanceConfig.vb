Public Class AppearanceConfig

#Region "Default values"

    ' General font
    Private Const ListsFontNameDefault As String = "Microsoft Sans Serif"
    Private Const ListsFontSizeDefault As Single = 8.25
    Private Const ListsFontBoldDefault As Boolean = False

    ' Toolbar colors 
    Private Const ToolbarContainerBackColorDefault As String = "Control"
    Private Const ToolbarBackColorDefault As String = "Control"

    ' Grid row colors standard
    Private Const GridRowBackColorDefault As String = "Window"
    Private Const GridRowForeColorDefault As String = "ControlText"
    Private Const GridRowSelectionBackColorDefault As String = "Highlight"
    Private Const GridRowSelectionForeColorDefault As String = "HighlightText"
    Private Const GridAlternateRowBackColorDefault As String = "GradientActiveCaption"
    Private Const GridAlternateRowForeColorDefault As String = "ControlText"
    Private Const GridAlternateRowSelectionBackColorDefault As String = "Highlight"
    Private Const GridAlternateRowSelectionForeColorDefault As String = "HighlightText"

    ' Grid row colors error
    Private Const GridRowErrorBackColorDefault As String = "Pink"
    Private Const GridRowErrorForeColorDefault As String = "ControlText"
    Private Const GridRowErrorSelectionBackColorDefault As String = "DeepPink"
    Private Const GridRowErrorSelectionForeColorDefault As String = "HighlightText"
    Private Const GridAlternateRowErrorBackColorDefault As String = "Pink"
    Private Const GridAlternateRowErrorForeColorDefault As String = "ControlText"
    Private Const GridAlternateRowErrorSelectionBackColorDefault As String = "DeepPink"
    Private Const GridAlternateRowErrorSelectionForeColorDefault As String = "HighlightText"

#End Region

#Region "Fields"

    Private _ListsFont As Font

    ' Toolbar colors 
    Private _ToolbarContainerBackColorObject As Color
    Private _ToolbarBackColorObject As Color

    ' Grid row colors standard
    Private _GridRowBackColorObject As Color
    Private _GridRowForeColorObject As Color
    Private _GridRowSelectionBackColorObject As Color
    Private _GridRowSelectionForeColorObject As Color
    Private _GridAlternateRowBackColorObject As Color
    Private _GridAlternateRowForeColorObject As Color
    Private _GridAlternateRowSelectionBackColorObject As Color
    Private _GridAlternateRowSelectionForeColorObject As Color

    ' Grid row colors error
    Private _GridRowErrorBackColorObject As Color
    Private _GridRowErrorForeColorObject As Color
    Private _GridRowErrorSelectionBackColorObject As Color
    Private _GridRowErrorSelectionForeColorObject As Color
    Private _GridAlternateRowErrorBackColorObject As Color
    Private _GridAlternateRowErrorForeColorObject As Color
    Private _GridAlternateRowErrorSelectionBackColorObject As Color
    Private _GridAlternateRowErrorSelectionForeColorObject As Color

#End Region

#Region "Serializable properties"

    Public Property EnableVisualStyles As Boolean
    Public Property MinimumSplashScreenDisplaySeconds As Integer
    Public Property MdiFormMargin As Byte
    Public Property UseCustomDialogForErrorMessage As Boolean
    Public Property ListsFontName As String
    Public Property ListsFontSize As Single
    Public Property ListsFontBold As Boolean
    Public Property ToolbarContainerBackColor As String
    Public Property ToolbarBackColor As String
    Public Property GridRowBackColor As String
    Public Property GridRowForeColor As String
    Public Property GridRowSelectionBackColor As String
    Public Property GridRowSelectionForeColor As String
    Public Property GridAlternateRowBackColor As String
    Public Property GridAlternateRowForeColor As String
    Public Property GridAlternateRowSelectionBackColor As String
    Public Property GridAlternateRowSelectionForeColor As String
    Public Property GridRowErrorBackColor As String
    Public Property GridRowErrorForeColor As String
    Public Property GridRowErrorSelectionBackColor As String
    Public Property GridRowErrorSelectionForeColor As String
    Public Property GridAlternateRowErrorBackColor As String
    Public Property GridAlternateRowErrorForeColor As String
    Public Property GridAlternateRowErrorSelectionBackColor As String
    Public Property GridAlternateRowErrorSelectionForeColor As String

#End Region

#Region "Internal properties"

    Friend Property ListsFont As Font
        Get
            Return GetFont(ListsFontName, ListsFontSize, ListsFontBold, _ListsFont, ListsFontNameDefault, ListsFontSizeDefault, ListsFontBoldDefault)
        End Get
        Set(value As Font)
            SetFont(value, ListsFontName, ListsFontSize, ListsFontBold, _ListsFont, ListsFontNameDefault, ListsFontSizeDefault, ListsFontBoldDefault)
        End Set
    End Property

    Friend Property ToolbarContainerBackColorObject As Color
        Get
            Return GetColor(ToolbarContainerBackColor, _ToolbarContainerBackColorObject, ToolbarContainerBackColorDefault)
        End Get
        Set(value As Color)
            GridRowBackColor = SetColor(value, _ToolbarContainerBackColorObject, ToolbarContainerBackColorDefault)
        End Set
    End Property

    Friend Property ToolbarBackColorObject As Color
        Get
            Return GetColor(ToolbarBackColor, _ToolbarBackColorObject, ToolbarBackColorDefault)
        End Get
        Set(value As Color)
            GridRowBackColor = SetColor(value, _ToolbarBackColorObject, ToolbarBackColorDefault)
        End Set
    End Property

    Friend Property GridRowBackColorObject As Color
        Get
            Return GetColor(GridRowBackColor, _GridRowBackColorObject, GridRowBackColorDefault)
        End Get
        Set(value As Color)
            GridRowBackColor = SetColor(value, _GridRowBackColorObject, GridRowBackColorDefault)
        End Set
    End Property

    Friend Property GridRowForeColorObject As Color
        Get
            Return GetColor(GridRowForeColor, _GridRowForeColorObject, GridRowForeColorDefault)
        End Get
        Set(value As Color)
            GridRowForeColor = SetColor(value, _GridRowForeColorObject, GridRowForeColorDefault)
        End Set
    End Property

    Friend Property GridRowSelectionBackColorObject As Color
        Get
            Return GetColor(GridRowSelectionBackColor, _GridRowSelectionBackColorObject, GridRowSelectionBackColorDefault)
        End Get
        Set(value As Color)
            GridRowSelectionBackColor = SetColor(value, _GridRowSelectionBackColorObject, GridRowSelectionBackColorDefault)
        End Set
    End Property

    Friend Property GridRowSelectionForeColorObject As Color
        Get
            Return GetColor(GridRowSelectionForeColor, _GridRowSelectionForeColorObject, GridRowSelectionForeColorDefault)
        End Get
        Set(value As Color)
            GridRowSelectionForeColor = SetColor(value, _GridRowSelectionForeColorObject, GridRowSelectionForeColorDefault)
        End Set
    End Property

    Friend Property GridAlternateRowBackColorObject As Color
        Get
            Return GetColor(GridAlternateRowBackColor, _GridAlternateRowBackColorObject, GridAlternateRowBackColorDefault)
        End Get
        Set(value As Color)
            GridAlternateRowBackColor = SetColor(value, _GridAlternateRowBackColorObject, GridAlternateRowBackColorDefault)
        End Set
    End Property

    Friend Property GridAlternateRowForeColorObject As Color
        Get
            Return GetColor(GridAlternateRowForeColor, _GridAlternateRowForeColorObject, GridAlternateRowForeColorDefault)
        End Get
        Set(value As Color)
            GridAlternateRowForeColor = SetColor(value, _GridAlternateRowForeColorObject, GridAlternateRowForeColorDefault)
        End Set
    End Property

    Friend Property GridAlternateRowSelectionBackColorObject As Color
        Get
            Return GetColor(GridAlternateRowSelectionBackColor, _GridAlternateRowSelectionBackColorObject, GridAlternateRowSelectionBackColorDefault)
        End Get
        Set(value As Color)
            GridAlternateRowSelectionBackColor = SetColor(value, _GridAlternateRowSelectionBackColorObject, GridAlternateRowSelectionBackColorDefault)
        End Set
    End Property

    Friend Property GridAlternateRowSelectionForeColorObject As Color
        Get
            Return GetColor(GridAlternateRowSelectionForeColor, _GridAlternateRowSelectionForeColorObject, GridAlternateRowSelectionForeColorDefault)
        End Get
        Set(value As Color)
            GridAlternateRowSelectionForeColor = SetColor(value, _GridAlternateRowSelectionForeColorObject, GridAlternateRowSelectionForeColorDefault)
        End Set
    End Property

    Friend Property GridRowErrorBackColorObject As Color
        Get
            Return GetColor(GridRowErrorBackColor, _GridRowErrorBackColorObject, GridRowErrorBackColorDefault)
        End Get
        Set(value As Color)
            GridRowErrorBackColor = SetColor(value, _GridRowErrorBackColorObject, GridRowErrorBackColorDefault)
        End Set
    End Property

    Friend Property GridRowErrorForeColorObject As Color
        Get
            Return GetColor(GridRowErrorForeColor, _GridRowErrorForeColorObject, GridRowErrorForeColorDefault)
        End Get
        Set(value As Color)
            GridRowErrorForeColor = SetColor(value, _GridRowErrorForeColorObject, GridRowErrorForeColorDefault)
        End Set
    End Property

    Friend Property GridRowErrorSelectionBackColorObject As Color
        Get
            Return GetColor(GridRowErrorSelectionBackColor, _GridRowErrorSelectionBackColorObject, GridRowErrorSelectionBackColorDefault)
        End Get
        Set(value As Color)
            GridRowErrorSelectionBackColor = SetColor(value, _GridRowErrorSelectionBackColorObject, GridRowErrorSelectionBackColorDefault)
        End Set
    End Property

    Friend Property GridRowErrorSelectionForeColorObject As Color
        Get
            Return GetColor(GridRowErrorSelectionForeColor, _GridRowErrorSelectionForeColorObject, GridRowErrorSelectionForeColorDefault)
        End Get
        Set(value As Color)
            GridRowErrorSelectionForeColor = SetColor(value, _GridRowErrorSelectionForeColorObject, GridRowErrorSelectionForeColorDefault)
        End Set
    End Property

    Friend Property GridAlternateRowErrorBackColorObject As Color
        Get
            Return GetColor(GridAlternateRowErrorBackColor, _GridAlternateRowErrorBackColorObject, GridAlternateRowErrorBackColorDefault)
        End Get
        Set(value As Color)
            GridAlternateRowErrorBackColor = SetColor(value, _GridAlternateRowErrorBackColorObject, GridAlternateRowErrorBackColorDefault)
        End Set
    End Property

    Friend Property GridAlternateRowErrorForeColorObject As Color
        Get
            Return GetColor(GridAlternateRowErrorForeColor, _GridAlternateRowErrorForeColorObject, GridAlternateRowErrorForeColorDefault)
        End Get
        Set(value As Color)
            GridAlternateRowErrorForeColor = SetColor(value, _GridAlternateRowErrorForeColorObject, GridAlternateRowErrorForeColorDefault)
        End Set
    End Property

    Friend Property GridAlternateRowErrorSelectionBackColorObject As Color
        Get
            Return GetColor(GridAlternateRowErrorSelectionBackColor, _GridAlternateRowErrorSelectionBackColorObject, GridAlternateRowErrorSelectionBackColorDefault)
        End Get
        Set(value As Color)
            GridAlternateRowErrorSelectionBackColor = SetColor(value, _GridAlternateRowErrorSelectionBackColorObject, GridAlternateRowErrorSelectionBackColorDefault)
        End Set
    End Property

    Friend Property GridAlternateRowErrorSelectionForeColorObject As Color
        Get
            Return GetColor(GridAlternateRowErrorSelectionForeColor, _GridAlternateRowErrorSelectionForeColorObject, GridAlternateRowErrorSelectionForeColorDefault)
        End Get
        Set(value As Color)
            GridAlternateRowErrorSelectionForeColor = SetColor(value, _GridAlternateRowErrorSelectionForeColorObject, GridAlternateRowErrorSelectionForeColorDefault)
        End Set
    End Property

#End Region

#Region "Special properties assignment"

    Private Function GetFont(name As String, size As Single, bold As Boolean, font As Font, nameDefault As String, sizeDefault As Single, boldDefault As Boolean) As Font
        If font Is Nothing Then
            If String.IsNullOrWhiteSpace(name) OrElse size <= 0 Then
                name = nameDefault
                size = sizeDefault
                bold = boldDefault
            End If
            Try
                name = name.Trim()
                font = New Font(name, size, CType(IIf(bold, FontStyle.Bold, FontStyle.Regular), FontStyle))
            Catch ex As Exception
                Throw ex
            End Try
        End If
        Return font
    End Function

    Private Sub SetFont(value As Font, ByRef name As String, ByRef size As Single, ByRef bold As Boolean, ByRef font As Font, nameDefault As String, sizeDefault As Single, boldDefault As Boolean)
        font = value
        If font Is Nothing Then
            name = nameDefault
            size = sizeDefault
            bold = boldDefault
        Else
            name = font.Name
            size = font.Size
            bold = font.Bold
        End If
    End Sub

    Private Function GetColor(colorString As String, color As Color, colorStringDefault As String) As Color
        If color.IsEmpty Then
            CardonerSistemas.Colors.GetFromHexOrNameString(colorString, color, CardonerSistemas.Colors.RegExHexadecimalRgbDoubleDigits, colorStringDefault)
        End If
        Return color
    End Function

    Private Function SetColor(value As Color, ByRef color As Color, colorStringDefault As String) As String
        color = value
        If color.IsEmpty Then
            If String.IsNullOrWhiteSpace(colorStringDefault) Then
                Return String.Empty
            Else
                Return colorStringDefault
            End If
        Else
            Return CardonerSistemas.Colors.SetToNamedOrHexRgbString(color)
        End If
    End Function

#End Region

End Class
