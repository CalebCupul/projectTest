using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectTest.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character { Name = "Sam", Id = 1}
        };

        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character GetCharacterById(int id)
        {
            // make it so if there no character with that id, return an exception with a message
            return characters.FirstOrDefault(c => c.Id == id) ?? throw new Exception("Character not found");
        }

        public List<Character> UpdateCharacter(int id, Character updatedCharacter)
        {
            Character character = characters.FirstOrDefault(c => c.Id == id);
            character.Name = updatedCharacter.Name;
            character.Class = updatedCharacter.Class;
            character.Defense = updatedCharacter.Defense;
            character.HitPoints = updatedCharacter.HitPoints;
            character.Intelligence = updatedCharacter.Intelligence;
            character.Strength = updatedCharacter.Strength;
            return characters;
        }
    }
}