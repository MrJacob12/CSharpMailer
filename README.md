## C#Mailer
---
## Required
* [.NET 5][link1]

```c#
    var smtpClient = new SmtpClient("server adress") // server adress
    {
        Port = 587,
        Credentials = new NetworkCredential("email", "password"), // email and password account
        EnableSsl = true,
    };

    var mailMessage = new MailMessage
    {
        From = new MailAddress("email"), // sender email
        Subject = "TEST",
        Body = "<h1>TEST</h1>",
        IsBodyHtml = true,
    };
    mailMessage.To.Add("email"); // reciver email

    smtpClient.Send(mailMessage);
```

[link1]: https://dotnet.microsoft.com/download/dotnet/5.0