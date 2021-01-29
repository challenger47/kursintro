using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGameSeller
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Mernis Doğrulandı-Kayıt Oldu");
            }else
            {
                Console.WriteLine("Mernis Doğrulanmadı");
            }
           
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Silindi");

        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Güncellendi");

        }
    }
}
