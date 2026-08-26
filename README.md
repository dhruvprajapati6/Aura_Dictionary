# 🌌 Aura Dictionary (Aura_Dictionary)

> A modern, elegant, and interactive Desktop Dictionary Application built using C# Windows Forms and Database integration. **Aura Dictionary** provides complete vocabulary management, user authentication, and seamless lexical search with an immersive cosmic-themed UI.

---

## 📸 Screenshots & Showcase

<!-- Place your showcase image below -->
![Aura Dictionary Showcase](YOUR_IMAGE_URL_OR_PATH_HERE)

---

## ✨ Key Features

- 🔐 **Authentication System**:
  - Registration with input validation (Name, Email, Username, Password, Confirm Password).
  - Login system with persistent user session management (`UserSession.cs`).
  
- 📖 **Comprehensive Vocabulary CRUD**:
  - **Search Word (`Ctrl + S`)**: Instant lookup of word definitions, phonetic details, synonyms, and antonyms.
  - **Add Word (`Ctrl + A`)**: Add custom vocabulary records to your local or central database.
  - **Update Word (`Ctrl + E`)**: Fetch and update existing word records dynamically.
  - **Delete Word (`Ctrl + Del`)**: Safely delete word records from database.

- 👤 **Profile & Session Management**:
  - View logged-in account details (Full Name, Email, Username).
  - Secure session logout and exit routines.

- 🎨 **Cosmic Themed Glassmorphic UI**:
  - Custom celestial sci-fi UI layout with glowing neon aesthetics and structured layout panels.

---

## 🛠️ Technology Stack

- **Framework**: .NET Framework (Windows Forms / WinForms)
- **Language**: C# (`.cs`)
- **Database**: ADO.NET / SQL Database (`DBConnection.cs`)
- **IDE**: Microsoft Visual Studio 2022 / 2019
- **Architecture**: Modular Multi-Form Architecture with centralized Session & DB handling

---

## 📂 Project Architecture & File Structure

```text
Aura_dictionary/
│
├── 📄 Program.cs                  # Application Entry Point
├── 📄 DBConnection.cs             # Centralized Database Connection Handler
├── 📄 UserSession.cs              # Global State & User Session Tracker
│
├── 🖥️ Windows Forms & UI:
│   ├── Form1.cs / Form1.Designer.cs           # User Registration Form
│   ├── Form2.cs / Form2.Designer.cs           # User Login Form
│   ├── FrmMain.cs / FrmMain.Designer.cs       # Main Navigation Dashboard
│   ├── FrmDictionary.cs                       # Search & Dictionary Operations
│   ├── FrmAddWord.cs                          # Add New Word Module
│   ├── FrmEditWord.cs                         # Edit / Update Word Module
│   ├── FrmDeleteWord.cs                       # Delete Word Module
│   └── FrmProfile.cs                          # User Profile View
│
├── 📁 Assets/                     # UI Graphics, Backgrounds & Glowing Icons
└── 📁 Properties/                 # Assembly & Resource Configurations
