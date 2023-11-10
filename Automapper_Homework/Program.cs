// Automapper farklı türdeki nesneleri birbirine dönüştüren hazır bir kütüphanedir. Web projelerde kullanımı : mapping için bir sınıf oluşturulup Automapper'dan gelen Profile sınıfı miras alınır ve sınıfın constructor'ında aşağıdaki methoddaki gibi gibi CreateMap işlemleri yapılır daha sonra containerda bu sınıf automapper olarak projeye dahil edilir. Kullanılacak sınıfta IMapper nesnesi oluşturulup sınıfın ctor'unda dahil edilir ve o nesneyle 13. satırdaki gibi istenilen mapleme işlemleri yapılır.

using AutoMapper;
using Automapper_Homework.DTOs;
using Automapper_Homework.Models;

IMapper _mapper;

InitializeAutoMapper();

Product product = new() {Id = 1 , Name = "Dis Fircasi",Color="Mavi",Description="Cok iyi firca",Price = 25.55 };

ProductDTO mappedProduct = _mapper.Map<ProductDTO>(product);

Console.WriteLine(mappedProduct);


void InitializeAutoMapper()
{
    var config = new MapperConfiguration(config =>
    {
        config.CreateMap<Product,ProductDTO>().ReverseMap();  // ReverseMap çift taraflı dönüşüm için hem Product'tan dto'ya hem de dto'dan product'a
    });
    _mapper = config.CreateMapper();
}

