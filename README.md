C# Web Server
A simple C# web server created for educational purposes.

Steps to create a similar web server from scratch:

Choose the localhost IP address (127.0.0.1) and a free local port
Create a TcpListener and accept incomming client request asynchronously
Write a valid HTTP response and convert it to a byte array
Add Content-Type and Content-Length headers (be careful with UTF8 characters)
Read the request in chunks (1024 bytes each) and store it in a StringBuilder
Extract separate server and HTTP classes
Parse the HTTP request
Create routing table which should allow various HTTP methods
Make sure the HTTP server can populate the routing table
Create specific HTTP response classes - TextResponse, for example
Implement the ToString method for the HTTP response class
Tasks:

Fully working routing system
Working controllers
Views and HTML
Forms and user input
Cookies and state
Reflection-based controllers
Dependency inversion concepts
Model binding
Views with models
Session and cache
Basic authentication