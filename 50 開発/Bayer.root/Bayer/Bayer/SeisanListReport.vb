Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document
Imports AppLib
Imports CommonLib

Public Class SeisanListReport

    Private pLoginUser As TableDef.MS_USER.DataStruct
    Public WriteOnly Property LoginUser() As TableDef.MS_USER.DataStruct
        Set(ByVal value As TableDef.MS_USER.DataStruct)
            pLoginUser = value
        End Set
    End Property

    Private pJoken As TableDef.Joken.DataStruct
    Public WriteOnly Property Joken() As TableDef.Joken.DataStruct
        Set(ByVal value As TableDef.Joken.DataStruct)
            pJoken = value
        End Set
    End Property


End Class
