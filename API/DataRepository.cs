using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API
{
    public static class DataRepository
    {
        public static Amigo[] Amigos = new Amigo[]
        {
            new Amigo() { AmigoId = 1, FName = "Renan", LName = "Herrmann", Email = "re.herrmann@gmail.com", Phone = 123456789, Niver = 10/10/2023},
            new Amigo() { AmigoId = 2, FName = "Cabo", LName = "Nara", Email = "carbonara@gmail.com", Phone = 123456789, Niver = 10/10/2023},
            new Amigo() { AmigoId = 3, FName = "Hot", LName = "Dog", Email = "hotdog@gmail.com", Phone = 123456789, Niver = 10/10/2023},
            new Amigo() { AmigoId = 4, FName = "Hot", LName = "Holl", Email = "hotholln@gmail.com", Phone = 123456789, Niver = 10/10/2023},
            new Amigo() { AmigoId = 5, FName = "Pizza", LName = "cheese", Email = "pizza@gmail.com", Phone = 123456789, Niver = 10/10/2023}
        };

    }
}