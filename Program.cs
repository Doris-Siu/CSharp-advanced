// See https://aka.ms/new-console-template for more information
using CSharp_advanced;
using System;


// Extensions
string post = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.";
var shortenedPost = post.Shorten(5);

Console.WriteLine(shortenedPost);

