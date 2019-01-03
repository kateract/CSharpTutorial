# C# Lunch &amp; Learn Getting Started Guide

# Introduction

This guide will help you install .NET Core and Visual Studio Code, which is going to be the platform that we are going to use to learn C# and the .NET framework.  It will also guide you through creating and running your first program in C#, and give you some resources for further learning.

## Why .NET Core?

.NET Core is an open source, cross platform version of the .NET Framework that has been developed by Microsoft with support from the broader community.  It supports the majority of the features that the full .NET Framework does, and starting next year with the release of 3.0, it will support the creation of Windows applications.  Also, PowerBuilder 2018 is going to implement targets that will target .NET Core for their C# Web API and C# Class Library targets.  Finally, It is free, and requires no license for you to use.

## Why Visual Studio Code?

Visual Studio Code is a lightweight, open source IDE/Text Editor that has been written by Microsoft with support from the broader community.  It is free and has great support for features and extensions.  There is also a Community Edition of Visual Studio that you can use to develop for the .NET Framework if you are using it for developing open source software, using it for educational purposes, or are working on a team of less than 5 people.  However, I&#39;m choosing to use Visual Studio Code to avoid potential ambiguity in licensing with a complete version of Visual Studio.  Feel free to try it out on your machine at home.

# Install Requisite Software

## Install .NET Core SDK

The .NET Core SDK can be found at the following link:

[https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

Make sure you download the .NET SDK version 2.1.500 or later from the link near the top of the page.  This is the only software that you have to install to be able to follow along with what we&#39;re going to be learning for a while.

## Install Visual Studio Code

Visual studio code can be found at the following link:

[https://code.visualstudio.com/Download](https://code.visualstudio.com/Download)

You can use the User or System 64 bit installer to install the software.  The System install requires administrative rights as it installs for all users.   I recommend letting it associate itself with files and allowing it to add the explorer context menu options.

## Optional Configurations

I recommend setting your default Command Prompt in Windows to PowerShell.  To do this, open  **Settings**  \&gt; Personalization \&gt; Taskbar. Now, turn the &quot;Replace **Command**  Prompt with Windows  **PowerShell**  in the menu when I right-click the Start button or press Windows key + X&quot; option to &quot;On&quot;.

After that, you can also add PowerShell to your quick access toolbar at the top of explorer windows by opening an Explorer window, clicking File \&gt; Open PowerShell, then right click on Open in Windows PowerShell and choose Add to Quick Access Toolbar.

# Run Your First Program

## Hello World, C# Edition

1. Create a new folder called HelloWorld, and navigate inside of it.
2. Click File \&gt; Open Windows PowerShell \&gt; Open Windows PowerShell
3. Run the command dotnet new console in the PowerShell Window
4. Run the command code . in the PowerShell window.  This will open the code in Visual Studio Code so you can review it.  It should already have Hello World printing with a Console.WriteLine() call.
5. Visual Studio Code might prompt you to install the C# Extension, do so.
6. Visual Studio Code might prompt you and say that required objects are missing, click yes.
7. Return to the PowerShell window and run the command dotnet run
8. You&#39;re done!
