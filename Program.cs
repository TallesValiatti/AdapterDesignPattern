using AdapterDesignPattern.Services.Implementations;
using AdapterDesignPattern.Services.Interfaces;

IUserService userService = new UserService();

var result = userService.GetAll();

if(result.Success)
    foreach(var user in result.Data!)
        Console.WriteLine($"User name: {user.Name} - Age: {user.Age}");
else    
    Console.WriteLine(result.Message);