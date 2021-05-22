Public Class Form1

    Dim Minas, TamañoX, TamañoY As Integer
    Dim Mapa(,) As Integer
    Dim Estado(,) As Boolean
    Dim AnchoCelda, AltoCelda As Integer
    Dim Entro As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TamañoX = NumericUpDownAlto.Value
        TamañoY = NumericUpDownAncho.Value
        Minas = NumericUpDownMinas.Value
        ReDim Mapa(TamañoX, TamañoY)
        ReDim Estado(TamañoX, TamañoY)
        Entro = "Vacio"
        AnchoCelda = 25
        AltoCelda = 25

    End Sub

    Dim Posiciones As PointF

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Posiciones = New PointF(10, 10)
        Cargar(e.Graphics)
    End Sub

    Dim CeldaX, CeldaY As Integer
    Function Cargar(g As Graphics)

        Dim Brush As Brush = Brushes.DarkGray
        Dim lapizNegro As New Pen(Color.Black, 1.0F)
        'vector
        If Entro = "Vacio" Then
            For x As Integer = 0 To TamañoX - 1 Step 1
                For y As Integer = 0 To TamañoY - 1 Step 1
                    Mapa(x, y) = 0
                    Estado(x, y) = False
                    g.FillRectangle(Brush, x * AnchoCelda + Posiciones.X, y *
                                    AltoCelda + Posiciones.Y, AnchoCelda, AltoCelda)
                Next
            Next
            PonerMinas()
            'Entro = "Muerto"
            MostrarTodo(g)
        ElseIf Entro = "Validar" Then
            Dim Fila, Columna As Integer
            If Estado(CeldaX, CeldaY) = False Then
                Estado(CeldaX, CeldaY) = True
                Dim Valor As Integer = Mapa(celdaX, CeldaY)
                If Mapa(CeldaX, CeldaY) = 9 Then
                    Entro = "Muerto"
                ElseIf Mapa(CeldaX, CeldaY) = 0 Then
                    For Fila = Max(0, CeldaX - 1) To Min(TamañoX, CeldaX + 1) Step 1
                        For Columna = Max(0, CeldaY - 1) To Min(TamañoY, CeldaY + 1) Step 1

                            If Mapa(Fila, Columna) <> 9 Then
                                Estado(Fila, Columna) = True
                            End If
                        Next
                    Next
                End If
            End If
            MostrarTodo(g)
        End If
        'Lineas horizontales
        For i As Integer = 0 To TamañoY Step 1
            g.DrawLine(lapizNegro, Posiciones.X, AltoCelda * i + Posiciones.Y,
        AnchoCelda * TamañoX + Posiciones.X, AltoCelda * i + Posiciones.Y)
        Next
        'Lineas verticales
        For i As Integer = 0 To TamañoX Step 1
            g.DrawLine(lapizNegro, AnchoCelda * i + Posiciones.X, Posiciones.Y,
        AnchoCelda * i + Posiciones.X, AltoCelda * TamañoY + Posiciones.Y)
        Next
        Return ""
    End Function

    Function PonerMinas()
        Dim Recorrido, Fila, Columna, Fila2, Columna2, Final As Integer
        Dim Aleatorio As Random = New Random
        Recorrido = 1
        Final = Minas
        While Recorrido <= Final
            Do
                Fila = Aleatorio.Next(0, TamañoX - 1)
                Columna = Aleatorio.Next(0, TamañoY - 1)
            Loop Until (Mapa(Fila, Columna) <> 9)
            'Reperesentamos la mina con el nùmero 9
            Mapa(Fila, Columna) = 9

            'Ahora incremento el nùmero de minas cercanas en las casillas vecinas
            For Fila2 = Max(0, Fila - 1) To Min(TamañoX, Fila + 1) Step 1
                For Columna2 = Max(0, Columna - 1) To Min(TamañoY, Columna + 1) Step 1
                    'le crea los numeros a la matriz para su anàlisis
                    If Mapa(Fila2, Columna2) <> 9 Then
                        Mapa(Fila2, Columna2) = Mapa(Fila2, Columna2) + 1
                    End If
                Next
            Next
            Recorrido += 1

        End While
        Return ""
    End Function

    Function MostrarTodo(g As Graphics)
        Dim Brush As Brush = Brushes.White
        Dim brushMina As Brush = Brushes.Red
        Dim brushTexto As Brush = Brushes.Black
        'Casillas
        For x As Integer = 0 To TamañoX - 1 Step 1
            For y As Integer = 0 To TamañoY - 1 Step 1
                Dim Valor As Integer = Mapa(x, y)
                Dim Condicion As Boolean = Estado(x, y)
                Select Case Entro
                    Case "Validar"
                        Select Case Condicion
                            Case True
                                g.FillRectangle(Brush, x * AnchoCelda + Posiciones.X, y * AltoCelda + Posiciones.Y, AnchoCelda, AltoCelda)
                                If Valor = 0 Then
                                    g.DrawString("", New Font("Arial", 13), brushTexto, x * AnchoCelda + Posiciones.X, y * AltoCelda + Posiciones.Y)
                                ElseIf Valor <> 9 Then
                                    g.FillRectangle(Brush, x * AnchoCelda + Posiciones.X, y * AltoCelda + Posiciones.Y, AnchoCelda, AltoCelda)
                                    g.DrawString(Valor.ToString(), New Font("Arial", 13), brushTexto, x * AnchoCelda + Posiciones.X, y * AltoCelda + Posiciones.Y)
                                End If
                        End Select
                    Case "Muerto"
                        Select Case Valor
                            Case 0
                                g.FillRectangle(Brush, x * AnchoCelda + Posiciones.X, y * AltoCelda + Posiciones.Y, AnchoCelda, AltoCelda)
                            Case 9
                                g.FillRectangle(brushMina, x * AnchoCelda + Posiciones.X, y * AltoCelda + Posiciones.Y, AnchoCelda, AltoCelda)
                            Case Else
                                g.DrawString(Valor.ToString(), New Font("Arial", 13), brushTexto, x * AnchoCelda + Posiciones.X, y * AltoCelda + Posiciones.Y)
                        End Select
                        Estado(x, y) = True
                End Select
            Next
        Next
        If Entro = "Muerto" Then MsgBox("Perdio")
        Return ""
    End Function

    Function Max(Numero1 As Integer, Numero2 As Integer) As Integer
        Dim num As Integer
        If Numero1 > Numero2 Then
            num = Numero1
        Else
            num = Numero2
        End If
        Return num
    End Function

    Function Min(Numero1 As Integer, Numero2 As Integer) As Integer
        Dim num As Integer
        If Numero1 < Numero2 Then
            num = Numero1
        Else
            num = Numero2
        End If
        Return num
    End Function

    Private Sub ButtonCargar_Click(sender As Object, e As EventArgs) Handles ButtonCargar.Click
        If NumericUpDownMinas.Value < (NumericUpDownAlto.Value * NumericUpDownAncho.Value) - 1 Then
            TamañoX = NumericUpDownAlto.Value
            TamañoY = NumericUpDownAncho.Value
            Minas = NumericUpDownMinas.Value
            ReDim Mapa(TamañoX, TamañoY)
            ReDim Estado(TamañoX, TamañoY)
            Entro = "Vacio"
            Panel1.Invalidate()
        Else
            MsgBox("Debe haber al menos una casilla sin minas!", vbCritical, "Advertencia")

        End If
    End Sub
    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick

        CeldaX = (e.X - CInt(Posiciones.X) * (1 + 0.9)) / AnchoCelda
        CeldaY = (e.Y - CInt(Posiciones.Y) * (1 + 0.9)) / AltoCelda
        If Entro <> "Muerto" Then
            If Estado(CeldaX, CeldaY) = False Then
                Entro = "Validar"
                Panel1.Invalidate()
            Else
                MsgBox(" Ya le dio Click a este ")
            End If
        Else
            MsgBox(" Ya està muerto, perdiò ")
        End If

    End Sub


End Class
