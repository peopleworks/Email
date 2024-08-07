** Envio de Correos desde 

** Crear el objecto Para Mensajería
InternetMail1=CreateObject("SocketTools.InternetMail.5")

InternetMail1.RelayServer = "smtp.gmail.com"  && Servidor Para envio de mensajes (smtp)
InternetMail1.UserName ="micorreo@gmail.com"   && Usuario Para el mensaje 
InternetMail1.Password =""                    && Contraseña     
InternetMail1.RelayPort   = 465               && Puerto del servidor smtp
InternetMail1.SecureProtocol = 2              && Protocolo de seguridad
InternetMail1.Timeout = 300                   && Tiempo de espera en milisegundos 
InternetMail1.Secure = .t.                    && si el servidor es seguro


*** Mensaje ***
InternetMail1.From = "micorreo@gmail.com"
InternetMail1.To = "tucorreo@claro.com.do"
InternetMail1.Date = Date()
InternetMail1.Subject = "Motivo del mensaje"
InternetMail1.MessageText = "Cuerpo del mensaje"

nError = InternetMail1.SendMessage(  , , , 4 )   && el último parametro es usado en los servidores smtp seguros

*** Verificar si hay error ***
If nError > 0 
    Messagebox( "Unable to send the message " + InternetMail1.LastErrorString )
    _cliptext=InternetMail1.LastErrorString
EndIf


