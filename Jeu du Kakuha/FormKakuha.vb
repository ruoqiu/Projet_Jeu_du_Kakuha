Public Class FormKakuha
    Public i As Integer
    Public njoueur As Integer 'numéro du joueur
    Dim nbpas As Integer = 0 'le nombre de clics pour commencer et recommencer
    Dim nbpasreturn As Integer = 0
    Dim numtrou As Integer = 0 'le numéro du trou
    Dim z As Integer = 0 'on définit une variable qui permet de stocker le nombre de grains dans le bouton sur lequel on a cliqué
    Private Sub FormKakuha_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load 'on charge l'interface du jeu 
        Call isEnabled()
        Call InitialiseJeu()
        For b = 1 To 12
            Controls("btn" & b).Text = t(b)
        Next
    End Sub
    Private Sub isEnabled() 'désactiver le bouton
        For a = 1 To 12
            Controls("btn" & a).Enabled = False
            Controls("btn" & a).BackColor = Color.Khaki
        Next
        btnreturn.Enabled = False
    End Sub
    Public Sub joueur(i) 'si on choisit le joueur i, les boutons de ce joueur sont activés
        nbpasreturn = 0
        For a = (1 + 6 * (i - 1)) To (6 + 6 * (i - 1))
            If Controls("btn" & a).Text > 0 Then 'on vérifie s'il y a des grains dans le trou 
                Controls("btn" & a).Enabled = True 'si il y a des grains dans le trou, on active le bouton 
                Controls("btn" & a).BackColor = Color.Orange 'on change la couleur du bouton sur lequel on peut cliquer
            End If
        Next
    End Sub

    Private Sub btninitial_Click(sender As System.Object, e As System.EventArgs) Handles btninitial.Click
        nbpas = nbpas + 1 'Enregistrer le nombre de fois qu'on a cliqué sur le bouton
        If nbpas = 1 Then ' Si on a cliqué une fois, on commence le jeu 
            btninitial.Text = "Recommencer" 'On change le texte en remplacant "commencer" par "recommencer"
        ElseIf nbpas > 1 Then 'Si on a cliqué plus d'une fois, on recommence le jeu
            If MsgBox("Vous confirmez recommencer ?", vbOKCancel, "confirmation") = 1 Then 'On affiche un message de confirmation pour demander au joueur s'il veut recommencer
                Call InitialiseJeu() 'On fait appel à la fonction pour initialiser le jeu 
                For b = 1 To 12
                    Controls("btn" & b).Text = t(b)
                    Controls("btn" & b).Enabled = False
                    Controls("btn" & b).BackColor = Color.Khaki
                Next
                lblnbg1.Text = ""
                lblnbg2.Text = ""
            Else
                Exit Sub
            End If
        End If
        Dim prompt As String = String.Empty 'Déclarer que la variable prompt est de type chaîne de caractère et qu'elle est vide
        Dim title As String = String.Empty 'Déclarer que la variable title est de type chaîne de caractère et qu'elle est vide
        Dim defaultResponse As String = String.Empty 'Déclarer que la variable "defaultresponse" est de type chaîne de caractère 
        Dim x As String 'x est une variable qui permet d'obtenir ce qu'il y a de saisi dans "InputBox"
        prompt = "Vous voulez commençer par joueur 1 ou joueur 2 ?"
        title = "Choisir un joueur"
        defaultResponse = "1" 'on affiche par défaut le joueur 1
linechoisin: x = InputBox(prompt, title, defaultResponse)
        If IsNumeric(x) = False Then 'On vérifie si le joueur a saisi un numéro
            MsgBox("Veuillez choisir un numéro") 'On demande au joueur de saisir un numéro 
            GoTo linechoisin 'Si le joueur n'a pas saisi un numéro, on affiche de nouveau un message qui lui permet de saisir un numéro  
        Else
            If CInt(x) <> 1 And CInt(x) <> 2 Then 'Si le numéro saisi n'est ni 1 ni 2, on redemande au joueur de saisir un numéro compris entre 1 et 2
                MsgBox("Veuillez choisir numéro 1 ou 2")
                GoTo linechoisin
            ElseIf CInt(x) = 1 Then
                njoueur = 1 ' Si il a saisi le chiffre 1, c'est au tour du joueur 1
            ElseIf CInt(x) = 2 Then
                njoueur = 2 ' Si il a saisi le chiffre 2, c'est au tour du joueur 2
            End If
        End If
        Call joueur(njoueur) 'On fait appel à la fonction "Joueur" 
    End Sub

    Private Sub btn_Click(sender As System.Object, e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn10.Click, btn11.Click, btn12.Click
        Call isEnabled() 'Chaque fois qu'on clique sur un bouton, on désactive tous les boutons concernant les trous 
        nbpasreturn = nbpasreturn + 1
        If nbpasreturn = 1 Then
            btnreturn.Enabled = True 'Si on veut retourner sur le trou sur lequel on a cliqué précédemment 
        End If
        Select Case sender.name 'Pour obtenir le nom du bouton sur lequel tu as cliqué 
            Case "btn1" 'Si le nom du bouton est "btn1" alors on affecte la valeur 1 à i, on fait pareil pour toutes les autres valeurs des boutons
                i = 1
            Case "btn2"
                i = 2
            Case "btn3"
                i = 3
            Case "btn4"
                i = 4
            Case "btn5"
                i = 5
            Case "btn6"
                i = 6
            Case "btn7"
                i = 7
            Case "btn8"
                i = 8
            Case "btn9"
                i = 9
            Case "btn10"
                i = 10
            Case "btn11"
                i = 11
            Case "btn12"
                i = 12
        End Select
        z = Controls("btn" & i).Text
        Call Jouer(i, njoueur) 'On fait appel à la fonction "Jouer", "i" correspond au bouton sur lequel on a cliqué et "njoueur" est le numéro du joueur 
        numtrou = i 'On affecte une valeur de "i" au numéro du trou 
        Controls("btn" & (numtrou)).Text = t(numtrou) 'On assigne la valeur du tableau à la valeur du bouton correspondante 
        For a = 1 To z 'On effectue une boucle de la valeur 1 à la valeur z pour donner la valeur de la case correspondante au bouton
            numtrou = numtrou + 1
            If numtrou > 12 Then 'Si le numéro de la case du tableau est supérieure à 12, on revient à la case 1 
                numtrou = 1
            End If
            Controls("btn" & (numtrou)).Text = t(numtrou) 'On assigne la valeur du tableau à la valeur du bouton correspondante pour les cases suivantes 
        Next
        Controls("lblnbg" & njoueur).Text = "Le joueur " & njoueur & " a obtenu " & nbg(njoueur) & " grains" 'On affiche le nombre de grains que le joueur njoueur a obtenu
        If t(numtrou) > 0 Then 'Permet de vérifier que si le trou n'est pas vide, le joueur peut continuer à jouer
            Controls("btn" & numtrou).Enabled = True
            Controls("btn" & numtrou).BackColor = Color.Red 'La couleur rouge indique la case sur laquelle le joueur peut cliquer  
        Else ' Si le trou est vide, le joueur ne peut pas continuer à jouer 
            If JeuTermine() = False Then
                If PeuJouer(3 - njoueur) = True Then ' Si le jeu n'est pas terminé, on vérifie si l'autre joueur peut jouer 
                    njoueur = 3 - njoueur
                Else
                    MsgBox("vous n'avez pas de grains à jouer ! C'est le tour du joueur " & njoueur) 'On affiche un message pour indiquer au joueur njoueur qu'il ne peut plus jouer 
                End If

                While (nbg(njoueur) > nbgtotal / 2) ' Si un joueur a déjà obtenu plus de la moitié des graines disponibles, on lui demande s'il veut continuer à jouer 
                    If MsgBox("Ce doit être le joueur " & njoueur & " qui gagne, vous voulez continuer ?", vbYesNo) = vbNo Then 'S'il ne veut pas continuer, on recommence le jeu
                        Call InitialiseJeu()
                        For b = 1 To 12
                            Controls("btn" & b).Text = t(b)
                            Controls("btn" & b).Enabled = False
                            Controls("btn" & b).BackColor = Color.Khaki
                        Next
                        lblnbg1.Text = ""
                        lblnbg2.Text = ""
                        Exit Sub
                    Else
                        GoTo linecontinue ' S'il veut continuer, le joueur continue de jouer 
                    End If
                End While
                MsgBox("C'est le tour du joueur " & njoueur)
                btnreturn.Enabled = False
linecontinue:   Call joueur(njoueur)
            Else ' Si le jeu est terminé, on vérifie qui des deux a le plus de grains 
                If nbg(njoueur) > nbg(3 - njoueur) Then
                    MsgBox("Le gagnant est le joueur " & njoueur)
                ElseIf nbg(njoueur) = nbg(3 - njoueur) Then
                    MsgBox("Vous faites un match nul !") 'Si les deux joueurs ont le même nombre de grains, alors on affiche un message les prévenant qu'il y a égalité 
                Else
                    MsgBox("Le gagnant est le joueur " & 3 - njoueur)
                End If
            End If
        End If
    End Sub

    Private Sub btnreturn_Click(sender As System.Object, e As System.EventArgs) Handles btnreturn.Click 'Cette fonction permet de retourner à la case précédente
        Controls("btn" & numtrou).Enabled = False
        Controls("btn" & numtrou).BackColor = Color.Khaki
        Call Retourner(numtrou, njoueur)
        For a = 1 To z
            numtrou = numtrou - 1
            If numtrou < 1 Then
                numtrou = 12
            End If
            Controls("btn" & (numtrou)).Text = t(numtrou) 'On affecte la nouvelle valeur du tableau au bouton correspondant 
        Next
        Controls("lblnbg" & njoueur).Text = "Le joueur " & njoueur & "  a obtenu " & nbg(njoueur) & "grains" 'On affiche le nouveau nombre de grains que njoueur a obtenu 
        t(numtrou) = z
        Controls("btn" & numtrou).Text = t(numtrou)
        Call joueur(njoueur)
        btnreturn.Enabled = False 'Après avoir cliqué sur le bouton "Retourner", on ne peut pas cliquer à nouveau dessus pour revenir au trou précédent
    End Sub

    Private Sub btnexit_Click(sender As System.Object, e As System.EventArgs) Handles btnexit.Click
        Me.Close() 'Permet de quitter l'interface du jeu 
        FormAccueil.Show() 'On revient à la page d'accueil du jeu 
    End Sub
End Class
