copy /Y "%~dp0ikev2-maib.xml" "%ProgramData%\Cisco\Cisco AnyConnect Secure Mobility Client\Profile\"
certutil.exe -addstore root "%~dp0MAIB.MD RootCA.crt"
