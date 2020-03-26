Module ModuleKakuha
    Public t(12) As Integer 'Tableau statique de 12 cases 
    Public nbg(2) As Integer 'Tableau du nombre de grains de deux joueurs
    Public nbgtotal As Integer = 0 'Nombre total de grains

    Public Sub Jouer(ByVal a As Integer, ByVal n As Byte) 'Cette fonction permet de semer les graines 
        'le joueur n a la main il joue la case a
        Dim x As Integer 'La variable x correspond à la case jouée 
        Dim b As Integer = t(a)
        x = a
        t(a) = 0  'on vide la case jouée
        For i = 1 To b - 1  'RéPARTITION DES graines dans un semi
            x = x + 1
            If x > 12 Then  'gestion des cycles de répartition dans le tableau
                x = 1
            End If
            t(x) = t(x) + 1 'répartition d'une graine  
        Next
        nbg(n) = nbg(n) + 1 'Le nombre de graines du joueur n augmente d'un 
    End Sub
    Public Sub Retourner(ByVal a As Integer, ByVal n As Byte) 'Cette fonction permet de revenir en arrière mais seulement d'une étape
        Dim x As Integer
        Dim b As Integer = t(a)
        x = a
        For i = 1 To b - 1
            x = x - 1
            If x < 1 Then
                x = 12
            End If
            t(x) = t(x) - 1 'Quand on utilise la fonction "Retourner", on revient au nombre de grains obtenu précédemment 
        Next
        nbg(n) = nbg(n) - 1 'Le nombre de graines du joueur n diminue d'un
    End Sub

    Public Function PeuJouer(ByVal i As Integer) As Boolean ' Permet de vérifier si le joueur i peut jouer 
        Dim pjouer As Boolean = False '
        For a = (1 + 6 * (i - 1)) To (6 + 6 * (i - 1)) 'On effectue la boucle selon le domaine du tableau, soit de 1 à 6, soit de 7 à 12
            pjouer = pjouer Or (t(a) <> 0) 'On va vérifier la valeur de pjouer, s'il y a un trou qui n'est pas vide, la valeur pjouer va être vraie
        Next
        Return pjouer
    End Function
    Public Sub InitialiseJeu()
        nbgtotal = 0 'La valeur totale des grains est égale à 0 à l'initialisation du jeu 
        For a = 1 To 12
            t(a) = 4 'On affecte le nombre de grains de chaque trou dans le tableau 
            nbgtotal = nbgtotal + t(a) 'Permet de calculer le nombre de grains total dans les trous 
        Next
        For a = 1 To 2
            nbg(a) = 0 'On initialise le nombre de grains des joueurs à 0 
        Next
    End Sub
    Public Function JeuTermine() As Boolean ' Cette fonction permet de terminer la partie
        Dim jtermine As Boolean
        If (PeuJouer(1) = False And PeuJouer(2) = False) Then 'Si les deux joueurs ne peuvent plus jouer, le jeu se termine 
            jtermine = True
        Else
            jtermine = False
        End If
        Return jtermine
    End Function
End Module
