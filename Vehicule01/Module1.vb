Imports System.Data
Imports System.Data.SqlClient

Module Module1

    'Public con As New SqlConnection("Data Source=.;Initial Catalog=Parc-Auto;User ID=sa")
    Public con As New SqlConnection("data source=.;initial catalog=Parc-Auto;integrated security=true")
    Public cmd As SqlCommand
    Public dr As SqlDataReader


End Module
