Local loPdfData
Local lnSuccess
Local lcB64
Local loPdfData2

loPdfData = Createobject('Chilkat_9_5_0.BinData')

lnSuccess = loPdfData.LoadFile("c:\redpeopleworks\i360doc.pdf")
If (lnSuccess <> 1) Then
	? "failed to load PDF file."
	Release loPdfData
	Cancel
Endif

* Encode the PDF to base64
* Note: to produce base64 on multiple lines (as it would appear in the MIME of an email),
* pass the string "base64_mime" instead of "base64".
lcB64 = loPdfData.GetEncoded("base64")
*? lcB64

Strtofile(lcB64, [c:\spooler\admin\encode.txt], .T.)


* Decode from base64 PDF.
loPdfData2 = Createobject('Chilkat_9_5_0.BinData')
loPdfData2.AppendEncoded(lcB64,"base64")
lnSuccess = loPdfData2.WriteFile("c:\redpeopleworks\i360v5.pdf")
If (lnSuccess <> 1) Then
	? "failed to write PDF file."
	Release loPdfData
	Release loPdfData2
	Cancel
Endif

Release loPdfData
Release loPdfData2
