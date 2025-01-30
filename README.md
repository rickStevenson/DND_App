1. Project Title
D&D Character Creator

2. Introduction
The D&D Character Creator is a web-based application designed to streamline character creation and management for Dungeons & Dragons (D&D) players.
Traditional paper character sheets can be difficult to manage, prone to wear and tear, and often require manual calculations for stats like ability modifiers, saving throws, and armor class.
This project aims to eliminate the hassle of paper sheets by providing a digital, database-driven solution that:
Automates stat calculations for ability scores, skill checks, combat stats, and spellcasting.
Provides a clean, user-friendly interface to create, edit, and manage multiple characters.
Stores character data securely in a database, ensuring no loss of information.
Allows customization with features like character portrait uploads and inventory tracking.
Supports Dungeon Masters (DMs) in managing campaigns by tracking player stats.
By digitizing the character sheet, this application enhances accessibility, improves gameplay efficiency, and reduces the potential for errors, making D&D sessions more immersive and enjoyable.
3. Objectives
The primary goal of this project is to create an automated, easy-to-use character sheet generator that removes the burden of manual calculations while offering a feature-rich experience for players and Dungeon Masters.
Key Objectives:
Full Database Integration – All character attributes, inventory, and stats will be stored persistently, eliminating the need for paper tracking.
Automatic Stat Calculations – Derived stats like ability modifiers, saving throws, proficiency bonuses, armor class, and initiative will be calculated dynamically based on D&D rules.
Character Progression – Players can track experience points, leveling, and class-specific features as their character advances.
User-Friendly Interface – The UI will be intuitive, mobile-friendly, and visually appealing, making it easy for both new and experienced players to use.
Character Portrait Uploads – Users can upload an image representation of their character to personalize their sheet.
Inventory & Spell Management – Players can manage weapons, armor, consumables, and spells directly within the app.
Multi-User Support – Users will be able to create and store multiple characters, allowing for seamless campaign tracking.
Dungeon Master Tools (Future Expansion) – DMs will have options to track player characters, monitor their stats, and manage game mechanics in real time.
Scalability & Deployment – The app will be designed for cloud hosting, ensuring scalability, reliability, and performance.
By achieving these objectives, this project will provide a modern, digital approach to character management in D&D, making gameplay more efficient, accessible, and immersive for players of all experience levels.

4. Project Description:
The D&D Character Creator is a web-based application designed to help players create and manage their Dungeons & Dragons characters digitally. Traditional paper-based character sheets can be cumbersome, prone to damage, or easily lost. This project provides a structured digital alternative, allowing players to maintain an accurate and up-to-date character record.
This application will:
Store character attributes, race, class, abilities, inventory, and other key stats in a database.
Automatically calculate ability modifiers, saving throws, armor class, initiative, and other derived stats.
Allow file uploads for character portraits.
Feature an intuitive UI that simplifies character creation and modification.
Implement dynamic validation to ensure correct stat progression and adherence to D&D rules.
Support multi-user accounts, so players can maintain multiple characters.
By creating this automated and scalable tool, players can focus more on storytelling and gameplay rather than manually tracking character details.

5. Technologies and Tools
The project leverages modern full-stack web development technologies:
Frontend:
ASP.NET Core MVC – For structuring the web application.
HTML, CSS, Bootstrap – To create an intuitive and responsive user interface.
JavaScript (Vanilla or jQuery) – To enhance interactivity.
Backend:
C# – Core programming language for handling logic.
Entity Framework Core – ORM for database interactions.
Dapper – Lightweight alternative to EF Core for optimized queries.
Database:
MySQL (or SQL Server) – Stores characters, stats, classes, spells, inventory, and other game-related data.
Testing:
xUnit – Unit testing framework.
Moq – For mocking dependencies in tests.
Other Tools:
Git & GitHub – Version control and collaboration.
Froala – An all-purpose, easy to use WYSIWYG editor with elegance.
Cloudinary – For hosting and managing user-uploaded character images.

6. Features
The application includes the following key features:
Core Features
Character Creation – Players can create new characters, select race/class, and define attributes.
Automatic Calculations – The system calculates derived attributes such as ability modifiers, armor class, spell slots, initiative, and saving throws.
Inventory & Equipment Management – Players can manage weapons, armor, potions, and magical items.
Spell Management System – Track available spells and usage based on class and level.
Character Progression – Experience points and levels are tracked, and bonuses are applied as characters grow.
Additional Features
Portrait Upload – Users can upload an image for their character.
Combat Tracker – Turn-based initiative tracking for battles.
Multi-User Support – Each player can store and manage multiple characters.
Interactive UI – Responsive and easy to navigate.
DM Features – Dungeon Masters can view and edit character stats if needed.

7. Implementation Plan
The development process follows an iterative approach using Agile principles:
Phase 1: Database & Models
Define Character, Race, Class, Spells, Inventory, and other entities.
Establish database relationships (1-to-many, many-to-many).
Implement data seeding to populate the database with initial D&D rules.
Phase 2: Backend Logic
Create C# models, repositories, and services for CRUD operations.
Implement business logic for stat calculations.
Build unit tests to validate core logic (e.g., ability modifiers, AC, etc.).
Phase 3: User Interface & User Experience
Design and build Razor Views using Bootstrap.
Implement form validation for input constraints.
Add JavaScript enhancements for interactive elements.
Phase 4: Testing & Debugging
Write unit tests with xUnit and Moq.
Conduct manual testing to simulate character creation and stat progression.
Debug potential edge cases (e.g., character creation errors).
Phase 5: Deployment & User Feedback
Deploy to Azure or another cloud hosting provider.
Gather user feedback for improvements.
Implement future enhancements, such as multiplayer campaign tracking.

8. User Interface (UI) Design
The UI follows D&D aesthetics, prioritizing clarity and efficiency. Key design principles include:
Character Dashboard: Displays key stats at a glance.
Editable Forms: Users can easily update character details.
Collapsible Sections: Organizes attributes, skills, and inventory for better navigation.
Thematic Styling: Uses dark mode options, medieval fonts, and fantasy-inspired icons.
Wireframes (to be added to GitHub):
Character Overview Page – Displays core stats and progression.
Equipment Page – Lists inventory with a drag-and-drop feature.
Spellbook UI – Shows available spells and cooldowns.

9. Testing Plan
The testing strategy includes automated unit tests and manual QA testing:
Unit Testing
HelperMethods Unit Tests – Tests calculations like Ability Modifiers, Proficiency Bonuses, and Armor Class.
Repository Tests – Ensures proper database interactions.
Controller Tests – Validates API calls and view rendering.

Integration Testing
Simulates end-to-end character creation and modification.
Ensures multi-user handling works correctly.

Manual Testing
Checks UI responsiveness and interactions.
Verifies database integrity after character modifications.
Identifies edge cases and potential exploits.

10. Deployment
The project will be deployed using:
Hosting: Azure
Database: Cloud-based SQL Server
CDN: Cloudinary for image hosting

Scalability Considerations:

Uses Entity Framework for optimized queries.
Implements caching mechanisms to reduce load times.
Supports multi-user access for campaign-based play.

11. Expected Outcome
By the end of development, the D&D Character Creator should be:
Fully functional with dynamic character sheets.
Capable of handling multiple characters per user.
Able to calculate all stats and derived attributes automatically.
Visually appealing with a user-friendly interface.
Scalable, allowing future enhancements like NPC and campaign tracking.

Success Criteria: 
Players can create, save, and edit characters.
All calculations are automated and accurate.
Images can be uploaded and displayed correctly.
The system passes all unit and integration tests.
The app is deployed and accessible online.

12. Conclusion
The D&D Character Creator aims to streamline the character creation process and enhance player experience through automation and intuitive design.
By replacing traditional paper sheets with a robust web app, players will have easy access to their characters anytime, anywhere.
The project will be continuously improved based on user feedback, and additional features such as campaign management and encounter tracking may be introduced in future updates.
