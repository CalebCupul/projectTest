using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectTest.Services.CharacterService
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
        Character GetCharacterById(int id);
        List<Character> AddCharacter(Character newCharacter);
        List<Character> UpdateCharacter(int id, Character updatedCharacter);
    }
}