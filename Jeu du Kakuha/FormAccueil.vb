Public Class FormAccueil

    Private Sub btnp_Click(sender As System.Object, e As System.EventArgs) Handles btnp.Click
        FormKakuha.Show() 'Permet d'afficher l'interface du jeu 
    End Sub

    Private Sub btnc_Click(sender As System.Object, e As System.EventArgs) Handles btnc.Click
        MsgBox("Le jeu se joue à 2 personnes. " & vbCr & "Chaque joueur dispose d’une rangée de 6 trous dans lesquels sont disposées 4 graines." & vbCr & "Chaque joueur choisit un trou de sa rangée, prélève les graines et les sème une à une dans les trous qui suivent, dans le sens contraire des aiguilles d’une montre. Il conserve la dernière graine. Le joueur répète ces opérations jusqu’à ce qu’il tombe sur un trou vide. " & vbCr & "C'est maintenant au tour de l’autre joueur de jouer. Le jeu s’arrête lorsqu’il n’est plus possible à aucun des joueurs de prélever des graines, et le vainqueur est celui qui a accumulé le plus grand nombre de graines." & vbCr & "A vous de jouer !")
    End Sub


End Class