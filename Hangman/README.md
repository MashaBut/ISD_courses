1. play.csproj - naming rules//+
2. separate class methods with new line//+
3. all class members should have access modificator//+
4. public void FileRead() -> all file operations should be inclaused in try/catch. better to check if file exist outside class and avoid FileExictance method.//+
5. IManagerPicture is similar to ManagerFile//+
6. for (int i = 0; i < 7; i++) avoid magic numbers//+
7. image[i] = new Bitmap($""{Path}\\виселица{j}.jpg""); => try/catch for file opers and imageS as it's array.//+
8. public Bitmap GetElement(int index) -> no check for index range.//+
9. bool GetChangeSumbol{get; } => ..SYmbol.. and getter should be noun.//+
10. TrueAns  => not clear name.//+
11. bool poz; => poSition//+
12. CheckElement changes the value but nothing is said about this//+
13. CheckTrueString => for small sb use toString().contains()//+
14. MessageLosser => Looser//+
15. Hangman.cs => separate layers by proper class naming.//+
16. extract interfaces to separate files.//+
17. Color color { get; set; } => props as methods should start with capital.//+
18. char sumbol; => for reserved words use synonim//+
19. GenerateButton => create btn and then add it to array. index is extra operations
20. BiuldButton => use tablePanel to avoid coords hell
21. ColorButton => button already is button not need to cast
22. Content.Clear(); => why?
23. MessageBoxPrint => doesn't print anything//+
24. string pathToPicture = @""C:\Users\Мария\Do... => all pathes should relative to resourses and should not be hardcoded.//+
25. managerString.SecretString => no need to return StringBuilder to convert it to string//+
26. string str = managerString.CheckElement(hangman.ButtonElement).ToString(); => use EventArgs
27. Application.Restart(); => no need to restart application if you need to restart game round//+
28. hangman.color = c[1]; => use Color constants inline//+
29. Button[] buttons = new Button[32]; => unsued array//+
30. 1251 => use utf"//+
