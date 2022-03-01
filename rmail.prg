Local nMessages
Local InternetMail1
Local nError
Local nMessage

** Resivir mensajes ...

** Crear el objecto Para Mensajería
InternetMail1=Createobject("SocketTools.InternetMail.5")


** Información de La cuenta **
InternetMail1.ServerName = "pop.gmail.com"  && Nombre servidor POP3 
InternetMail1.ServerPort = 995              && Puerto servidor POP3 
InternetMail1.UserName = "miusurio"         && Usuario   
InternetMail1.Password = ""                 && Contraseña


** Conexión **
nError = InternetMail1.Connect() 

**  ----------------------------------------------------
*** Verificar si hay error conectandose al servidor POP3 ***
**  ----------------------------------------------------
If nError > 0
	Messagebox( "Unable to connect to mail server" + InternetMail1.LastErrorString )
	_Cliptext=InternetMail1.LastErrorString
Endif

nMessages = InternetMail1.MessageCount   && Cantidad de Mensajes sin leer en el Inbox ( Bandeja de Entrada )


If nMessages > 0

	For nMessage = 1 To InternetMail1.LastMessage

		InternetMail1.MessageIndex = nMessage
		? InternetMail1.Subject
		? InternetMail1.Message 
		? InternetMail1.MessageText 

	Next
Else
	Wait Windows "No hay mensajes en el Inbox"
Endif

InternetMail1.Disconnect()



