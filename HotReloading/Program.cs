
/* Visual Studio 2022: run the app, change the message, click Hot Reload.
   (It's not required to click Hot Reload if one saves the file, but it may be a good practice to do so.)
   Visual Studio Code: run the app, using dotnet watch, change the message.
*/

while (true)
{
    WriteLine("Hello, Hot Reload! :-)");
    await Task.Delay(2000);
}
