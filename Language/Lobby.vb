﻿Public Class Lobby
    Public Shared Lobby As String = ""
    Public Shared Patch As String = ""
    Public Shared Options As String = ""
    Public Shared Help As String = ""
    Public Shared Save_EE As String = ""
    Public Shared Games As String = ""
    Public Shared Poker As String = ""
    Public Shared Donations As String = ""
    Public Shared Training As String = ""

    Public Shared Current_Games As String = ""

    Public Shared Lobby_Chat As String = ""
    Public Shared Chat_Console As String = ""
    Public Shared Chat As String = ""
    Public Shared Whisper As String = ""
    Public Shared Warn As String = ""
    Public Shared Alert As String = ""
    Public Shared Send As String = ""

    Public Shared Users_Friends As String = ""
    Public Shared Currently_1_User_Online As String = ""
    Public Shared Currently_X_Users_Online As String = ""
    Public Shared Online As String = ""
    Public Shared Offline As String = ""
    Public Shared Administrators As String = ""
    Public Shared Moderators As String = ""
    Public Shared Donators As String = ""
    Public Shared Friends As String = ""
    Public Shared Cheaters As String = ""
    Public Shared Ignore As String = ""
    Public Shared Ignored As String = ""
    Public Shared Users As String = ""

    Public Shared Back As String = ""
    Public Shared Forward As String = ""

    Public Shared Sub SetLanguage(ByVal lang As Main.Languages)
        Select Case lang
            Case Main.Languages.Deutsch
                Lobby = "Lobby"
                Patch = "Patch"
                Options = "Optionen"
                Help = "Hilfe"
                Save_EE = "Save-EE"
                Games = "Spiele"
                Poker = "Poker"
                Donations = "Donations"
                Training = "Training"

                Current_Games = "Aktuelle Spiele"

                Lobby_Chat = "Lobby Chat"
                Chat_Console = "Chat Konsole"
                Chat = "Chat"
                Whisper = "Flüstern"
                Warn = "Warnen"
                Alert = "Alarmieren"
                Send = "Senden"

                Users_Friends = "Benutzer & Freunde"
                Currently_1_User_Online = "Zurzeit 1 Benutzer Online"
                Currently_X_Users_Online = "Zurzeit X Benutzer Online"
                Online = "Online"
                Offline = "Offline"
                Administrators = "Administratoren"
                Moderators = "Moderatoren"
                Donators = "Spender"
                Friends = "Freunde"
                Cheaters = "Cheater"
                Ignore = "Ignorieren"
                Ignored = "Ignoriert"
                Users = "Benutzer"

                Back = "Zurück"
                Forward = "Vorwärts"
            Case Main.Languages.English
                Lobby = "Lobby"
                Patch = "Patch"
                Options = "Options"
                Help = "Help"
                Save_EE = "Save-EE"
                Games = "Games"
                Poker = "Poker"
                Donations = "Donations"
                Training = "Training"

                Current_Games = "Current Games"

                Lobby_Chat = "Lobby Chat"
                Chat_Console = "Chat Console"
                Chat = "Chat"
                Whisper = "Whisper"
                Warn = "Warn"
                Alert = "Alert"
                Send = "Send"

                Users_Friends = "Users & Friends"
                Currently_1_User_Online = "Currently 1 User Online"
                Currently_X_Users_Online = "Currently X Users Online"
                Online = "Online"
                Offline = "Offline"
                Administrators = "Administrators"
                Moderators = "Moderators"
                Donators = "Donators"
                Friends = "Friends"
                Cheaters = "Cheaters"
                Ignore = "Ignore"
                Ignored = "Ignored"
                Users = "Users"

                Back = "Back"
                Forward = "Forward"
            Case Main.Languages.Español
                Lobby = "Pasillo"
                Patch = "Parche"
                Options = "Opciones"
                Help = "Ayuda"
                Save_EE = "Save-EE"
                Games = "Juegos"
                Poker = "Póker"
                Donations = "Donations"
                Training = "Training"

                Current_Games = "Juegos Actuales"

                Lobby_Chat = "Charla en el Pasillo"
                Chat_Console = "Consola Para Charla"
                Chat = "Charla"
                Whisper = "Susurro"
                Warn = "Advertencia"
                Alert = "Alerta"
                Send = "Envío"

                Users_Friends = "Usuarios & Amigos"
                Currently_1_User_Online = "Actualmente 1 Usuario Conectado"
                Currently_X_Users_Online = "Actualmente X usuarios Conectados"
                Online = "Conectado"
                Offline = "Desconectado"
                Administrators = "Administradores"
                Moderators = "Moderadores"
                Donators = "Donadores"
                Friends = "Amigos"
                Cheaters = "Tramposos"
                Ignore = "Ignorar"
                Ignored = "Ignorados"
                Users = "Usuarios"

                Back = "De vuelta"
                Forward = "Adelante"
            Case Main.Languages.Français
                Lobby = "Hall"
                Patch = "Patch"
                Options = "Options"
                Help = "Aide"
                Save_EE = "Save-EE"
                Games = "Jeux"
                Poker = "Poker"
                Donations = "Donations"
                Training = "Training"

                Current_Games = "Parties en cours"

                Lobby_Chat = "Chat Hall"
                Chat_Console = "Chat Console"
                Chat = "Chat"
                Whisper = "Chuchoter"
                Warn = "Avertissement"
                Alert = "Alerte"
                Send = "Envoyer"

                Users_Friends = "Utilisateurs & Amis"
                Currently_1_User_Online = "1 utilisateur est en ligne"
                Currently_X_Users_Online = "X utilisateurs sont en ligne"
                Online = "En ligne"
                Offline = "Hors ligne"
                Administrators = "Administrateurs"
                Moderators = "Modérateurs"
                Donators = "Donateurs"
                Friends = "Amis"
                Cheaters = "Tricheurs"
                Ignore = "Bloquer"
                Ignored = "Bloqué"
                Users = "Utilisateurs"

                Back = "Précédent"
                Forward = "Suivant"
            Case Main.Languages.Nederlands
                Lobby = "Lobby"
                Patch = "Patch"
                Options = "Opties"
                Help = "Help"
                Save_EE = "Save-EE"
                Games = "Spellen"
                Poker = "Poker"
                Donations = "Donations"
                Training = "Training"

                Current_Games = "Huidige Spellen"

                Lobby_Chat = "Lobby Chat"
                Chat_Console = "Chat Paneel"
                Chat = "Chat"
                Whisper = "Fluister"
                Warn = "Waarschuwing"
                Alert = "Alert"
                Send = "Verzend"

                Users_Friends = "Spelers & Vrienden"
                Currently_1_User_Online = "1 Gebruiker online"
                Currently_X_Users_Online = "X Gebruikers online"
                Online = "Online"
                Offline = "Offline"
                Administrators = "Administrateurs"
                Moderators = "Moderatoren"
                Donators = "Donateurs"
                Friends = "Vrienden"
                Cheaters = "Cheaters"
                Ignore = "Negeer"
                Ignored = "Genegeerd"
                Users = "Gebruikers"

                Back = "Terug"
                Forward = "Vooruit"
            Case Main.Languages.Português
                Lobby = "Portaria"
                Patch = "Patch"
                Options = "Opções"
                Help = "Ajuda"
                Save_EE = "Save-EE"
                Games = "Jogos"
                Donations = "Doações"
                Training = "Training"

                Current_Games = "Jogos Actuais"

                Lobby_Chat = "Portaria de Conversa"
                Chat_Console = "Consola de Conversa "
                Chat = "Conversa"
                Whisper = "Susurro"
                Warn = "Advertência"
                Alert = "Alerta"
                Send = "Envia"

                Users_Friends = "Usuários & Amigos"
                Currently_1_User_Online = "Actualmente 1 usuário Conectado"
                Currently_X_Users_Online = "Actualmente X usuários Conectados"
                Online = "Conectado"
                Offline = "Desconectado"
                Administrators = "Administradores"
                Moderators = "Moderadores"
                Donators = "Doadores"
                Friends = "Amigos"
                Cheaters = "Batoteiros"
                Ignore = "Ignorar"
                Ignored = "Ignorados"
                Users = "Usuários"

                Back = "Atráz"
                Forward = "Adiante"
            Case Main.Languages.Suomi
                Lobby = "Aula"
                Patch = "Päivitä"
                Options = "Asetukset"
                Help = "Apua"
                Save_EE = "Save-EE"
                Games = "Pelit"
                Poker = "Pokeri"
                Donations = "Donations"
                Training = "Training"

                Current_Games = "Nykyiset Pelit"

                Lobby_Chat = "Keskustelu"
                Chat_Console = "Chat"
                Chat = "Keskustelu"
                Whisper = "Sano"
                Warn = "Varoitus"
                Alert = "Hälytys"
                Send = "Lähetä"

                Users_Friends = "Käyttäjät & Ystävät"
                Currently_1_User_Online = "1 Käyttäjä Palvelimella"
                Currently_X_Users_Online = "X Käyttäjää Palvelimella"
                Online = "Online"
                Offline = "Offline"
                Administrators = "Ylläpitäjät"
                Moderators = "Moderaattorit"
                Donators = "Lahjoittajat"
                Friends = "Ystävät"
                Cheaters = "Huijarit"
                Ignore = "Torjutut"
                Ignored = "Torjuttu"
                Users = "Käyttäjät"

                Back = "Takaisin"
                Forward = "Seuraava"
            Case Else
                SetLanguage(Main.Languages.English)
        End Select
    End Sub
End Class