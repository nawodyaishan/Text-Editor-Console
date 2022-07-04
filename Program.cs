namespace CommandDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Cyan;
            string logo = "Text Editor | v1.0";
            Console.SetCursorPosition((Console.WindowWidth - logo.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo);


            Console.WriteLine("   Enter Your Current Text   \n");
            Console.Write(">>:");
            string InitialUserInput = Console.ReadLine();
            TextEditor myTextEditor = new TextEditor(InitialUserInput);


            while (true)
            {
                Console.SetCursorPosition((Console.WindowWidth - logo.Length) / 2, Console.CursorTop);
                Console.WriteLine(logo);
                Console.WriteLine("\nEnter your preference\n");
                Console.WriteLine("[1] Add \n[2] Clear \n[3] Remove \n[4] Undo\n[5] Exit\n\n");
                Console.Write(">>:");

                string userOption = Console.ReadLine();


                if (Equals("1", userOption))
                {
                    #region Single Operation

                    Console.Clear();
                    myTextEditor.SaveText();
                    // Getting User Input to Add and Constructing Append Class Instance
                    Console.WriteLine("You Selected to Add String to Current Text\nPlease Enter the Text\n");
                    string textToAdd = Console.ReadLine();
                    Append onGoingAppend = new Append(textToAdd);

                    // Calling Methods from TextEditor Class
                    myTextEditor.ExecuteICommand(onGoingAppend);
                    myTextEditor.DisplayProcessed();
                    Console.WriteLine("\nPlease Press Any key to Continue....");
                    Console.ReadKey();
                    Console.Clear();
                    myTextEditor.DisplayCurrentText();

                    #endregion
                }

                else if (Equals("2", userOption))
                {
                    #region Single Operation

                    Console.Clear();
                    myTextEditor.SaveText();
                    // Getting User Input to Add and Constructing Append Class Instance
                    Console.WriteLine("You Selected to Add String to Current Text\nPlease Enter the Text\n");
                    Clear reset = new Clear();

                    // Calling Methods from TextEditor Class
                    myTextEditor.ExecuteICommand(reset);
                    myTextEditor.DisplayProcessed();
                    Console.WriteLine("\nPlease Press Any key to Continue....");
                    Console.ReadKey();
                    Console.Clear();
                    myTextEditor.DisplayCurrentText();

                    #endregion
                }
                else if (Equals("3", userOption))
                {
                    #region Single Operation

                    Console.Clear();
                    myTextEditor.SaveText();
                    // Getting User Input to Add and Constructing Append Class Instance
                    Console.WriteLine(
                        "You Selected to Remove String to Current Text\nPlease Enter the number of text to remove\n");
                    string indexToRemove = Console.ReadLine();
                    BackSpace toRemove = new BackSpace(Int32.Parse(indexToRemove));

                    // Calling Methods from TextEditor Class
                    myTextEditor.ExecuteICommand(toRemove);
                    myTextEditor.DisplayProcessed();
                    Console.WriteLine("\nPlease Press Any key to Continue....");
                    Console.ReadKey();
                    Console.Clear();
                    myTextEditor.DisplayCurrentText();

                    #endregion
                }

                else if (Equals("4", userOption))
                {
                    Console.Clear();

                    myTextEditor.UndoText();
                    myTextEditor.SaveText();

                    Console.WriteLine("\nPlease Press Any key to Continue....");
                    Console.ReadKey();
                }

                else if (Equals("5", userOption))
                {
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }
    }
}