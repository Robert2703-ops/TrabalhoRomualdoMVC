using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrabalhoRomualdo.Models;
using System;

namespace TrabalhoRomualdo.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult SetInfo()
        {
            return View();
        }

        [HttpPost()]
        public IActionResult ShowInfo(string UserName, DateTime BirthDate, string UserHeight, string UserWeight)
        {
            Usuario NewUserModel = new Usuario();
            NewUserModel.Name = UserName;
            NewUserModel.BirthDate = BirthDate.ToString("dd/MM/yyyy");
            //ToString, aqui para retornar somente a data, sem a hora

            switch(BirthDate.DayOfWeek)
           {
               case DayOfWeek.Monday:
               NewUserModel.BirthDay = "Segunda-Feira";
               break;
               case DayOfWeek.Tuesday:
               NewUserModel.BirthDay = "Terça-Feira";
               break;
               case DayOfWeek.Wednesday:
               NewUserModel.BirthDay = "Quarta-Feira";
               break;
               case DayOfWeek.Thursday:
               NewUserModel.BirthDay = "Quinta-Feira";
               break;
               case DayOfWeek.Friday:
               NewUserModel.BirthDay = "Sexta-feira";
               break;
               case DayOfWeek.Saturday:
               NewUserModel.BirthDay = "Sábado";
               break;
               case DayOfWeek.Sunday:
               NewUserModel.BirthDay = "Domingo";
               break;
           }

            NewUserModel.Height = float.Parse(UserHeight);
            NewUserModel.Weight = float.Parse(UserWeight);
            float IMCValue = NewUserModel.Weight/(NewUserModel.Height * NewUserModel.Height);  
            NewUserModel.IMC = IMCValue.ToString("f");
            return View(NewUserModel);
        }
    }
}