# Utility for Practice

Just a simple command line tool to punch in.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

.NET Core runtime
[Install.NetCore](https://dotnet.microsoft.com/download)

Just install them, you kown how to do it.  

### Installing

Dowload the application in release.

## Configuring and using

Explain how to use it.

### Configuring it for your own use

first test can it run properly:
  
Linux example

```bash
dotnet gpcli.dll config set path '/home/user/GoPractice,Root directory of the GoPractice folder'
```
  
windows example

```bash
gpcli.dll config set path 'C:/Users/user/Documents/Gopractice,Root directory of the GoPractice folder'
```
after setting the path, you can start using.  

### Creat or Edit a report

```bash
dotnet gpcli.dll new -d [date]
```

simply use no paramter to use today's date.
    
use:
```bash
dotnet gpcli.dll select
``` 
to select working on file,

```bash
dotnet gpcli.dll edit -h
```
to see how to edit the selected report.

## Built With

* [CommandDotnet]() - The library used

## Contributing

Myself.

## License

This project is licensed under the MIT License - feel free to play with it.

## Acknowledgments

* You may see: NotImplementedException: "Too lazy to implement."
