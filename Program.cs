// See https://aka.ms/new-console-template for more information
using CSharp_advanced;
using System;


// Extensions
string post = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.";
var shortenedPost = post.Shorten(5);

Console.WriteLine(shortenedPost);


// LINQ
var books = new BookRepository().GetBooks();

// LINQ Query Operators
//var cheaperBooks =
//    from b in books
//    where b.Price < 10
//    orderby b.Title
//    select b.Title;


// LINQ Extension Methods
var cheaperBooks = books
    .Where(b => b.Price < 10) // predicates -> lambda expressions
    .OrderBy(b => b.Title)
    .Select(b => b.Title);


foreach (var book in cheaperBooks)
{
    Console.WriteLine(book);
}

// other useful extension methods
//books.Where(); // returns a list of matches
//books.Single();
//books.SingleOrDefault(); // return a single match or null

//books.First();
//books.FirstOrDefault();
//books.Last();
//books.LastOrDefault();

//// aggregate functions
//books.Min();
//books.Max();
//books.Count();
//books.Sum(b => b.Price);
//books.Average(b => b.Price);

//// used for paging
//books.Skip(3).Take(2);


// Nullable type

DateTime? date = null;

Console.WriteLine(date.GetValueOrDefault());
Console.WriteLine(date.HasValue);
//Console.WriteLine(date.Value);


//null coalescing operator
DateTime date2 = date ?? DateTime.Today;

Console.WriteLine(date2);


// Exception handling - try catch blocks
StreamReader streamReader = null;
try
{
    //var calculator = new Calculator();
    //var result = calculator.Divide(5, 0);
    streamReader = new StreamReader(@"c:\...");
    var content = streamReader.ReadToEnd();
}
catch (Exception ex)
{
    Console.WriteLine("An unexpected error occured.");
}
// finally block - manually calling Dispose()
finally
{
    if (streamReader != null)
        streamReader.Dispose();
}


// using statement - automatically call the finally
try
{
    using (var streamReader1 = new StreamReader(@"c:\..."))
    {
        var content = streamReader1.ReadToEnd();

    }

}
catch (Exception ex)
{
    Console.WriteLine("An exception occured.");
}


// custom exception
try
{
    var api = new YouTubeApi();
    var videos = api.GetVideos("doris");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}













