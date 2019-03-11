Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Initial
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Movies",
                Function(c) New With
                    {
                        .id = c.Int(nullable := False, identity := True),
                        .Name = c.String(),
                        .Genre = c.String()
                    }) _
                .PrimaryKey(Function(t) t.id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Movies")
        End Sub
    End Class
End Namespace
