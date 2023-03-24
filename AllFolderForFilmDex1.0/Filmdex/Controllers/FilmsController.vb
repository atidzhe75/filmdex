Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Data
Imports Data.Model

Namespace Controllers
    Public Class FilmsController
        Inherits System.Web.Mvc.Controller

        Private db As New FilmdexContext

        ' GET: Films
        Function Index() As ActionResult
            Return View(db.Film.ToList())
        End Function

        ' GET: Films/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim film As Film = db.Film.Find(id)
            If IsNothing(film) Then
                Return HttpNotFound()
            End If
            Return View(film)
        End Function

        ' GET: Films/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Films/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,Title,Genre,WatchedOn")> ByVal film As Film) As ActionResult
            If ModelState.IsValid Then
                db.Film.Add(film)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(film)
        End Function

        ' GET: Films/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim film As Film = db.Film.Find(id)
            If IsNothing(film) Then
                Return HttpNotFound()
            End If
            Return View(film)
        End Function

        ' POST: Films/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,Title,Genre,WatchedOn")> ByVal film As Film) As ActionResult
            If ModelState.IsValid Then
                db.Entry(film).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(film)
        End Function

        ' GET: Films/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim film As Film = db.Film.Find(id)
            If IsNothing(film) Then
                Return HttpNotFound()
            End If
            Return View(film)
        End Function

        ' POST: Films/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim film As Film = db.Film.Find(id)
            db.Film.Remove(film)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
