using consume_web_api;
using consume_web_api.Models;
using static System.Console;

HTTPClient client = new HTTPClient();

var user = await client.GetUserId(1);

Users users = new Users();


WriteLine("Имя юзера с айди 1" + user.name);

WriteLine("Введите пароль");
users.password = ReadLine();
WriteLine("Введите фамилию");
users.surname = ReadLine();
WriteLine("Введите отчество");
users.patronymic = ReadLine();
WriteLine("Введите логин");
users.login = ReadLine();
WriteLine("Введите имя");
users.name = ReadLine();
WriteLine("Введите пароль");
users.Id = Convert.ToInt32(ReadLine());

WriteLine(await client.AddUserID(users));

users.Id = 6;
users.name = "негр";

WriteLine(await client.EditUserId(users));

WriteLine(await client.DeleteUserId(5));

ReadKey();