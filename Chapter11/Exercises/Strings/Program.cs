// using System.Range;
// using System.Index;


#region 

    // Compare, CompareOrdinal, Contains, Concat, CopyTo
    // EndsWith,
    // Format,
    // IndexOf, Insert
    // Join,
    // LastIndexOf,
    // Replace,
    // Split, Substring
    // ToLower, ToUpper, Trim


    // Print();
    // PrintValue("hello");
    
    // void Print()
    // {
    //     string text = """
    //             <element attr="content">
    //                 <body>
    //                 </body>
    //             </element>
    //             """;
    //     Console.WriteLine(text);
    // }
    
    // void PrintValue(string val)
    // {
    //     string text = $"""
    //             <element attr="content">
    //                 <body>
    //                 {val}
    //                 </body>
    //             </element>
    //             """;
    //     //// или так 
    //     //string text =  $$"""
    //     //          <element attr="content">
    //     //            <body>
    //     //            {{val}}
    //     //            </body>
    //     //          </element>
    //     //          """;
    //     Console.WriteLine(text);
    // }


#endregion



#region Concationation

    string s1 = "hello";
    string s2 = "world";
    string s3 = s1 + " " + s2;

    string s4 = string.Concat(s3, "!!! Moda*cka");
    Console.WriteLine(s4);

#endregion



#region 

    string s5 = "An apple";
    string s6 = "a day";
    string s7 = "keeps";
    string s8 = "a doctor";
    string s9 = "away";
    string[] values = new string[] { s5, s6, s7, s8, s9 };
    
    string s10 = string.Join(" ", values);
    Console.WriteLine(s10);

#endregion




#region Compare

    string s11 = "hello";
    string s12 = "world";
    
    int result = string.Compare(s1, s2);
    if (result < 0)
    {
        Console.WriteLine("String s1 stands in front of s2");
    }
    else if (result > 0)
    {
        Console.WriteLine("String s1 stands after s2");
    }
    else
    {
        Console.WriteLine("Strings s1 and s2 are equal");
    }

#endregion



#region Split

    string someString = "hello world! I am happy to be here";
    // bool result1 = someString.Contains("or");
    // bool result1 = someString.StartsWith("he");
    bool result1 = someString.EndsWith("here");
    Console.WriteLine(result1);

    Console.WriteLine();

    string[] words = someString.Split(" ");
    foreach (string word in words)
    {
        Console.WriteLine(word);
    }


    string[] words1 = someString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    foreach (string s in words)
    {
        Console.WriteLine(s);
    }


    string anotherString = someString.Trim(new char[] { 'h', 'e', 'd', 'l' });
    Console.WriteLine(anotherString);

    Console.WriteLine();


    string yetAnotherString = someString.Substring(6);
    Console.WriteLine(yetAnotherString);


    // Index index1 = 6;
    // Index index2 = ^5;
    // Range range1 = index1..index2;
    // string yetAnotherString1 = someString[..^5];
    string yetAnotherString1 = someString[6..^5];
    Console.WriteLine(yetAnotherString1);

    string yetAnotherString2 = someString.Substring(6, 15);
    Console.WriteLine(yetAnotherString2);



    string text = "What a beautiful wedding!";
    string text1 = text.Remove(text.Length - 1);
    Console.WriteLine();
    Console.WriteLine(text1);

    string text2 = text.Remove(3, 5);  // Remove(Start index, number of characters to delete)
    Console.WriteLine(text2);

    string text3 = text.Replace("beautiful", "wonderful");
    Console.WriteLine();
    Console.WriteLine(text3);

    string text4 = text.Insert(text.Length, "except for groom's bride is a whore...");
    Console.WriteLine();
    Console.WriteLine(text4);

#endregion
