using DND_App.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Constants = DND_App.Web.StaticClasses.Constants;

namespace DND_App.Web.Data.Extensions
{
    public static class SeedCharacterRacesExtension
    {
        public static void SeedCharacterRaces (this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CharacterRace>().HasData(
                new CharacterRace
                {
                    Id = 1,
                    Name = Constants.RaceNames.AirGenasi,
                    Description = "Aasimar are beings touched by the divine. They serve as celestial champions, guardians of justice and virtue, and often possess a celestial guide to aid them in their quests. Aasimar are marked by their radiant appearance—gleaming eyes, a faint golden or silver sheen to their skin, and an aura of grace. They are driven by a sense of purpose to protect the weak, fight evil, and uphold righteousness.",
                    StrengthBonus = 0,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 2,
                    WisdomBonus = 0,
                    CharismaBonus = 1,
                    MaleImage = "/images/races/Aasimar_Male.png",
                    FemaleImage = "/images/races/Aasimar_Female.png"
                },
                new CharacterRace
                {
                    Id = 2,
                    Name = Constants.RaceNames.Dragonborn,
                    Description = "Dragonborn are proud, draconic humanoids with ancestry linked to the great dragons. Their scales shimmer in hues tied to their draconic lineage—red, blue, green, or even metallic tones. They exude strength and confidence and often bear a natural affinity for leadership. Dragonborn breathe an element of their dragon heritage, whether fire, lightning, or frost, making them fearsome warriors on the battlefield.",
                    StrengthBonus = 2,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 1,
                    MaleImage = "/images/races/Dragonborn_Male.png",
                    FemaleImage = "/images/races/Dragonborn_Female.png"
                },
                new CharacterRace
                {
                    Id = 3,
                    Name = Constants.RaceNames.Dwarf,
                    StrengthBonus = 0,
                    Description = "Dwarves are sturdy, hearty, and known for their unparalleled craftsmanship. They are short and stocky with a build designed for endurance. Dwarves are fiercely loyal to their kin, and their stronghold cities are engineering marvels carved deep into mountains. Their culture revolves around tradition, respect for ancestry, and a relentless work ethic.",
                    DexterityBonus = 0,
                    ConstitutionBonus = 2,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    MaleImage = "/images/races/Dwarf_Male.png",
                    FemaleImage = "/images/races/Dwarf_Female.png"
                },
                new CharacterRace
                {
                    Id = 4,
                    Name = Constants.RaceNames.Elf,
                    Description = "Elves are graceful and otherworldly beings closely tied to nature and the arcane. With sharp features, pointed ears, and a timeless beauty, elves are creatures of both mystery and elegance. They live much longer than humans and tend to focus on mastering arts, magic, or combat during their lifetimes. Their connection to the Feywild grants them agility and other supernatural abilities.",
                    StrengthBonus = 0,
                    DexterityBonus = 2,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    MaleImage = "/images/races/Elf_Male.png",
                    FemaleImage = "/images/races/Elf_Female.png"
                },
                new CharacterRace
                {
                    Id = 5,
                    Name = Constants.RaceNames.Firbolg,
                    Description = "Firbolgs are gentle giants connected to the natural world. They live in harmony with the forests, often serving as protectors of the wilds. Firbolgs are shy and reclusive, avoiding contact with the outside world unless their forests are threatened. Despite their peaceful demeanor, they possess incredible strength and innate magical abilities, allowing them to commune with nature and defend it.",
                    StrengthBonus = 1,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 2,
                    CharismaBonus = 0,
                    MaleImage = "/images/races/Firbolg_Male.png",
                    FemaleImage = "/images/races/Firbolg_Female.png"
                },
                new CharacterRace
                {
                    Id = 6,
                    Name = Constants.RaceNames.AirGenasi,
                    Description = "Air Genasi are beings with elemental air ancestry, often descended from djinn. They are free-spirited and dynamic, embodying the essence of the wind. Their connection to the element of air makes them agile and quick, both in thought and movement. Air Genasi are often drawn to exploration and adventure, thriving in environments where they can experience freedom and movement.",
                    StrengthBonus = 0,
                    DexterityBonus = 1,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    MaleImage = "/images/races/GenasiAir_Male.png",
                    FemaleImage = "/images/races/GenasiAir_Female.png"
                },
                new CharacterRace
                {
                    Id = 7,
                    Name = Constants.RaceNames.EarthGenasi,
                    Description = "Earth Genasi have elemental earth ancestry, often traced back to dao. They are solid, steady, and reliable, with a physicality that seems carved from the earth itself. Earth Genasi are deeply grounded and unwavering in their decisions, often acting as anchors in chaotic situations. They feel a strong connection to stone and soil, often favoring lives of craftsmanship or exploration beneath the surface.",
                    StrengthBonus = 1,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    MaleImage = "/images/races/GenasiEarth_Male.png",
                    FemaleImage = "/images/races/GenasiEarth_Female.png"
                },
                new CharacterRace
                {
                    Id = 8,
                    Name = Constants.RaceNames.FireGenasi,
                    Description = "Fire Genasi are tied to the elemental power of fire, often through lineage connected to efreeti. They are passionate, intense, and prone to bursts of emotion. Their fiery nature often makes them charismatic and inspiring, but also volatile and quick-tempered. Fire Genasi are naturally drawn to heat and light, feeling most comfortable in warm environments.",
                    StrengthBonus = 0,
                    DexterityBonus = 1,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    MaleImage = "/images/races/GenasiFire_Male.png",
                    FemaleImage = "/images/races/GenasiFire_Female.png"
                },
                new CharacterRace
                {
                    Id = 9,
                    Name = Constants.RaceNames.WaterGenasi,
                    Description = "Water Genasi possess a connection to elemental water, often through marid ancestry. They are fluid and adaptable, with a calming presence that reflects the stillness of a tranquil sea or the power of a raging storm. Water Genasi are drawn to aquatic environments and often feel at home near rivers, lakes, or oceans.",
                    StrengthBonus = 0,
                    DexterityBonus = 0,
                    ConstitutionBonus = 1,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    MaleImage = "/images/races/GenasiWater_Male.png",
                    FemaleImage = "/images/races/GenasiWater_Female.png"
                },
                new CharacterRace
                {
                    Id = 10,
                    Name = Constants.RaceNames.Gnome,
                    Description = "Gnomes are whimsical, energetic, and endlessly curious. They are small but brimming with creativity, wit, and intelligence. Known for their ingenuity, gnomes are often inventors, alchemists, or skilled artisans. They are highly social and love storytelling, jokes, and puzzles. Gnomes are divided into subraces, with forest gnomes being connected to nature and rock gnomes excelling in invention and craftsmanship.",
                    StrengthBonus = 0,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 2,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    MaleImage = "/images/races/Gnome_Male.png",
                    FemaleImage = "/images/races/Gnome_Female.png"
                },
                new CharacterRace
                {
                    Id = 11,
                    Name = Constants.RaceNames.Goliath,
                    Description = "Goliaths are towering, rugged humanoids who dwell in mountainous regions, living in harmony with their harsh environment. They are known for their immense strength, endurance, and competitive nature. Goliaths view life as a series of challenges to overcome, valuing strength and self-sufficiency above all else. Their culture is deeply tied to survival, with each individual striving to prove their worth to the tribe.",
                    StrengthBonus = 2,
                    DexterityBonus = 0,
                    ConstitutionBonus = 1,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    MaleImage = "/images/races/Goliath_Male.png",
                    FemaleImage = "/images/races/Goliath_Female.png"
                },
                new CharacterRace
                {
                    Id = 12,
                    Name = Constants.RaceNames.HalfElf,
                    Description = "Half-elves are the offspring of humans and elves, embodying the grace and agility of their elven heritage with the ambition and versatility of humanity. They often struggle to find a place in either culture, but their adaptability and charm allow them to thrive in diverse societies. Half-elves are natural diplomats, blending the best qualities of their dual heritage.",
                    StrengthBonus = 0,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 2,
                    MaleImage = "/images/races/HalfElf_Male.png",
                    FemaleImage = "/images/races/HalfElf_Female.png"
                },
                new CharacterRace
                {
                    Id = 13,
                    Name = Constants.RaceNames.Halfling,
                    Description = "Halflings are small, cheerful, and resourceful folk who live simple lives in tight-knit communities. They are known for their optimism, courage, and love of home and hearth. Despite their size, halflings possess remarkable agility and luck, often escaping danger through quick thinking or sheer serendipity. They prefer peaceful lives but are not afraid to rise to challenges when necessary.",
                    StrengthBonus = 0,
                    DexterityBonus = 2,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    MaleImage = "/images/races/Halfling_Male.png",
                    FemaleImage = "/images/races/Halfling_Female.png"
                },
                new CharacterRace
                {
                    Id = 14,
                    Name = Constants.RaceNames.HalfOrc,
                    Description = "Half-orcs are the result of human and orc unions, combining the brute strength and resilience of orcs with human adaptability. They often face prejudice but channel their inner strength to prove their worth. Many half-orcs are driven by a desire to overcome their perceived savagery, seeking honor, redemption, or greatness in their lives.",
                    StrengthBonus = 2,
                    DexterityBonus = 0,
                    ConstitutionBonus = 1,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    MaleImage = "/images/races/HalfOrc_Male.png",
                    FemaleImage = "/images/races/HalfOrc_Female.png"
                },
                new CharacterRace
                {
                    Id = 15,
                    Name = Constants.RaceNames.Human,
                    Description = "Humans are the most versatile and ambitious of all the races, thriving in nearly every environment and excelling in a wide variety of fields. Their relatively short lifespans drive them to achieve greatness quickly, whether through exploration, invention, or conquest. Humans are known for their adaptability, ingenuity, and the diversity of their cultures.",
                    StrengthBonus = 1,
                    DexterityBonus = 1,
                    ConstitutionBonus = 1,
                    IntelligenceBonus = 1,
                    WisdomBonus = 1,
                    CharismaBonus = 1,
                    MaleImage = "/images/races/Human_Male.png",
                    FemaleImage = "/images/races/Human_Female.png"
                },
                new CharacterRace
                {
                    Id = 16,
                    Name = Constants.RaceNames.Kenku,
                    Description = "Kenku are avian humanoids who resemble flightless crows or ravens. Once capable of flight and speech of their own, they were cursed long ago and now mimic the voices and sounds they hear around them. Kenku are resourceful and clever, often excelling as spies, thieves, or merchants. Their lack of original speech and creativity forces them to rely on imitation and cunning to survive in the world.",
                    StrengthBonus = 0,
                    DexterityBonus = 2,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    MaleImage = "/images/races/Kenku_Male.png",
                    FemaleImage = "/images/races/Kenku_Female.png"
                },
                new CharacterRace
                {
                    Id = 17,
                    Name = Constants.RaceNames.Tabaxi,
                    Description = "Tabaxi are feline humanoids hailing from distant, exotic lands. They are naturally curious and driven by an insatiable wanderlust, always seeking out new stories, relics, and experiences. Tabaxi are agile and dexterous, often excelling as scouts, rogues, or bards. Their feline grace and inquisitive nature make them both charming and unpredictable.",
                    StrengthBonus = 0,
                    DexterityBonus = 2,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    MaleImage = "/images/races/Tabaxi_Male.png",
                    FemaleImage = "/images/races/Tabaxi_Female.png"
                },
                new CharacterRace
                {
                    Id = 18,
                    Name = Constants.RaceNames.Tiefling,
                    Description = "Tieflings are humanoids with infernal heritage, often descended from fiends or those who made pacts with devils. Their infernal bloodline is evident in their appearance—horns, tails, and glowing eyes mark them as different. Despite their fiendish origins, Tieflings are not inherently evil and often seek to rise above the stigma of their heritage, forging their own path in life.",
                    StrengthBonus = 0,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 1,
                    WisdomBonus = 0,
                    CharismaBonus = 2,
                    MaleImage = "/images/races/Tiefling_Male.png",
                    FemaleImage = "/images/races/Tiefling_Female.png"
                },
                new CharacterRace
                {
                    Id = 19,
                    Name = Constants.RaceNames.Tortle,
                    Description = "Tortles are humanoid turtles, known for their calm demeanor and love of exploration. They carry their homes on their backs in the form of durable shells, making them self-reliant and capable of traveling wherever their curiosity takes them. Tortles are often wise and contemplative, with a deep connection to nature and a strong appreciation for life’s simple pleasures.",
                    StrengthBonus = 2,
                    DexterityBonus = 0,
                    ConstitutionBonus = 1,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    MaleImage = "/images/races/Tortle_Male.png",
                    FemaleImage = "/images/races/Tortle_Female.png"
                },
                new CharacterRace
                {
                    Id = 20,
                    Name = Constants.RaceNames.YuanTiPureblood,
                    Description = "Yuan-Ti Purebloods are snake-like humanoids descended from a once-great serpent empire. They are cold, calculating, and ambitious, often serving as spies, diplomats, or manipulators for their kind. Yuan-Ti Purebloods are the most human-looking of the Yuan-Ti, allowing them to infiltrate societies more easily, but their serpent features—such as scaled skin or slit-pupil eyes—betray their heritage.",
                    StrengthBonus = 0,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 1,
                    WisdomBonus = 0,
                    CharismaBonus = 2,
                    MaleImage = "/images/races/YuanTiPureblood_Male.png",
                    FemaleImage = "/images/races/YuanTiPureblood_Female.png"
                }
            );
        }
    }
}
