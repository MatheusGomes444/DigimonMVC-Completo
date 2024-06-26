// Services/DigimonService.cs
using System;
using System.Collections.Generic;
using DigimonMvc.Models;

public class DigimonService
{
    private List<ClasseDigimon> digimons;

    public DigimonService()
    {
        
        digimons = new List<ClasseDigimon>
        {
            new ClasseDigimon { Nome = "Agumon", Tipo = "Reptile", Nivel = 3 },
            new ClasseDigimon { Nome = "Gabumon", Tipo = "Beast", Nivel = 4 },
            new ClasseDigimon { Nome = "Patamon", Tipo = "Mammal", Nivel = 3 },
            new ClasseDigimon { Nome = "Gomamon", Tipo = "Aquatic", Nivel = 4 },
            new ClasseDigimon { Nome = "Palmon", Tipo = "Plant", Nivel = 3 },
            new ClasseDigimon { Nome = "Tentomon", Tipo = "Insect", Nivel = 3 },
            new ClasseDigimon { Nome = "Gatomon", Tipo = "Holy Beast", Nivel = 4 },
            new ClasseDigimon { Nome = "Veemon", Tipo = "Dragon", Nivel = 3 }
          
        };
    }

    public ClasseDigimon SortearDigimon()
    {
      
        Random random = new Random(DateTime.Now.Millisecond);

 
        int indiceSorteado = random.Next(digimons.Count);

        
        return digimons[indiceSorteado];
    }
}