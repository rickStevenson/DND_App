using DND_App.Web.Models.Domain;
using DND_App.Web.StaticClasses.Constants;
using System.Text;

namespace DND_App.Web.StaticClasses
{
    public static class HelperMethods
    {
        public static List<string> GetAlignments()
        {
            return typeof(Alignment).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)
                                    .Where(f => f.FieldType == typeof(string))
                                    .Select(f => (string)f.GetValue(null))
                                    .ToList();
        }
        public static List<string> GetGender()
        {
            return typeof(Gender).GetFields
                (System.Reflection.BindingFlags.Public |
                System.Reflection.BindingFlags.Static)
                    .Where(f => f.FieldType == typeof(string))
                    .Select(f => (string)f.GetValue(null))
                    .ToList();
        }
        public static int CalculateProficiencyBonus(int level)
        {
            if (level >= 1 && level <= 4) return 2;
            else if (level >= 5 && level <= 8) return 3;
            else if (level >= 9 && level <= 12) return 4;
            else if (level >= 13 && level <= 16) return 5;
            else if (level >= 17 && level <= 20) return 6;

            throw new ArgumentException("Invalid level.");
        }
        public static int CalculateAbilityModifier(int attribute)
        {
            if (attribute == 1) return -5;
            else if (attribute >= 2 && attribute <= 3) return -4;
            else if (attribute >= 4 && attribute <= 5) return -3;
            else if (attribute >= 6 && attribute <= 7) return -2;
            else if (attribute >= 8 && attribute <= 9) return -1;
            else if (attribute >= 10 && attribute <= 11) return 0;
            else if (attribute >= 12 && attribute <= 13) return 1;
            else if (attribute >= 14 && attribute <= 15) return 2;
            else if (attribute >= 16 && attribute <= 17) return 3;
            else if (attribute >= 18 && attribute <= 19) return 4;
            else if (attribute >= 20 && attribute <= 21) return 5;
            else if (attribute >= 22 && attribute <= 23) return 6;
            else if (attribute >= 24 && attribute <= 25) return 7;
            else if (attribute >= 26 && attribute <= 27) return 8;
            else if (attribute >= 28 && attribute <= 29) return 9;
            else if (attribute >= 29 && attribute <= 30) return 10;
            throw new ArgumentException("Invalid score.");
        }
        public static int CalculateArmorClass(Character character)
        {
            int baseAC = 10; // Default AC if no armor is worn.
            int dexterityModifier = (character.Dexterity - 10) / 2;

            // Check if character has equipped armor.
            var equippedArmor = character.CharacterItems
                .FirstOrDefault(item => item.Item != null && item.Item.Category == Constants.Category.Armor);

            if (equippedArmor != null && equippedArmor.Item != null)
            {
                switch (equippedArmor.Item.Name)
                {
                    case Constants.Items.LeatherArmor:
                        baseAC = 11 + dexterityModifier;
                        break;

                    case Constants.Items.ChainShirt:
                        baseAC = 13 + Math.Min(dexterityModifier, 2);
                        break;

                    case Constants.Items.Chainmail:
                        baseAC = 16 + Math.Min(dexterityModifier, 2);
                        break;

                    case Constants.Items.PlateArmor:
                        baseAC = 18;
                        break;

                    default:
                        break;
                }
            }
            else
            {
                // If no armor is equipped, check for special class AC bonuses.
                if (character.CharacterClass.Name == Constants.Classes.Barbarian)
                {
                    int constitutionModifier = (character.Constitution - 10) / 2;
                    baseAC = 10 + dexterityModifier + constitutionModifier;
                }
                else if (character.CharacterClass.Name == Constants.Classes.Monk)
                {
                    int wisdomModifier = (character.Wisdom - 10) / 2;
                    baseAC = 10 + dexterityModifier + wisdomModifier;
                }
            }

            // Check if a shield is equipped.
            var shieldEquipped = character.CharacterItems
                .Any(item => item.Item != null && item.Item.Name == Constants.Items.Shield);
            if (shieldEquipped)
            {
                baseAC += 2;
            }

            // Add bonuses from magic items.
            int magicBonus = character.CharacterItems
                .Where(item => item.Item.ArmorClassBonus > 0)
                .Sum(item => item.Item.ArmorClassBonus);

            baseAC += magicBonus;

            return baseAC;
        }
        public static string RenderAttributeSkillsAndTotalModifier(Character character, string attributeName, int attributeValue)
        {
            if (character == null || character.CharacterSkills == null || string.IsNullOrWhiteSpace(attributeName))
                return string.Empty;

            var abilityModifier = CalculateAbilityModifier(attributeValue);
            var proficiencyBonus = character.ProficiencyBonus;

            var stringBuilder = new StringBuilder();

            // Add Modifier
            stringBuilder.AppendLine($"<p>Modifier: {abilityModifier}</p>");

            // List proficient skills aligned with the specified attribute
            var proficientSkills = character.CharacterSkills
                .Where(cs => cs.IsProficient && cs.Skill.AlignedAttribute.Equals(attributeName, StringComparison.OrdinalIgnoreCase));

            if (proficientSkills.Any())
            {
                stringBuilder.AppendLine("<ul>");
                foreach (var skill in proficientSkills)
                {
                    var totalSkillModifier = abilityModifier + proficiencyBonus;

                    stringBuilder.AppendLine("<div class='mb-0'>");
                    stringBuilder.AppendLine($"<label class='form-label'>");
                    stringBuilder.AppendLine($"Skill Name: {skill.Skill.Name} <br />");
                    stringBuilder.AppendLine($"Proficiency Bonus: {proficiencyBonus} <br />");
                    stringBuilder.AppendLine($"Total Modifier: {totalSkillModifier}");
                    stringBuilder.AppendLine("</label>");
                    stringBuilder.AppendLine("</div>");
                }
                stringBuilder.AppendLine("</ul>");
            }

            return stringBuilder.ToString();
        }


    }
}
