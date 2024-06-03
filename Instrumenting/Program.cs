// See p. 203 for more information

using System.Diagnostics;

var logPath = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt");

WriteLine($"Writing to file at {logPath}");

TextWriterTraceListener logFile = new(File.CreateText(logPath));

Trace.Listeners.Add(logFile);

#if DEBUG
// Text writer is buffered, so this option calls
// Flush() on all listeners after writing.

Trace.AutoFlush = true;
#endif

Debug.WriteLine("Debug says, I am watching.");
Trace.WriteLine("Trace says, I am watching.");
// See Debug and Trace output in the Output window in Visual Studio
// when running in Debug (!) mode
Console.WriteLine("Console says, I send comments always.");

// Debug and Trace messages are written to the file and the Output window!

// Close the text file (also flushes) and releases resources.
Debug.Close();
Trace.Close();