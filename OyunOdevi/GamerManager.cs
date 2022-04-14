using System;
using System.Collections.Generic;
using System.Text;

namespace OyunOdevi
{
    class GamerManager : IGamerService
    {
        private IUserValidationService UserValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            UserValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (UserValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt Olundu");

            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız.");

            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
