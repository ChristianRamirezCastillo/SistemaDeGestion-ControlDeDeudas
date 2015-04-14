﻿Module IniciarFormulario
    ''' <summary>
    ''' Metodo para inicializar el formulario
    ''' </summary>
    ''' <param name="form">Objeto formulario</param>
    ''' <param name="titulo">Titulo del formulario</param>
    ''' <param name="borderStyle">Borde del formlario</param>
    ''' <param name="maximizeBox">Maximizar el formulario</param>
    ''' <param name="windowsState">Estado inicial de la ventana del formulario</param>
    ''' <remarks></remarks>
    Public Sub InicializarFormulario(form As Form, titulo As String, borderStyle As FormBorderStyle,
                                     maximizeBox As Boolean, windowsState As FormWindowState)
        With form
            .Text = titulo
            .FormBorderStyle = borderStyle
            .MaximizeBox = maximizeBox
            .WindowState = windowsState
        End With
    End Sub
    Public Sub FormularioHijo()

    End Sub
End Module
