# 📚 Aura Dictionary

> A professional desktop dictionary application built with C# Windows Forms and MySQL for searching, managing, and learning words.

## ✨ Overview

**Aura Dictionary** is a database-driven desktop dictionary application designed for students and everyday learners. It combines dictionary lookup with complete word management and user account features in a modern Windows Forms interface.

### What it provides

- 🔎 Search words
- 💡 Meaning, synonyms and antonyms
- 💡 Database-based word suggestions
- ➕ Add new words
- ✏️ Edit/update words
- 🗑️ Delete words
- 🚫 Duplicate-word prevention
- 🔐 Registration and login
- 👤 User profile
- 🚪 Logout/session clearing
- 🖥️ MDI application interface
- 🪟 Maximized child forms
- 💾 MySQL database integration
- 🎨 Custom Aura-themed UI

---

## 🚀 Features

### 🔐 User Authentication

The application includes a complete registration and login flow.

**Registration fields**

- Name
- Email
- Username
- Password
- Confirm Password

**Login**

- Username/password validation
- Empty-field validation
- Database credential verification
- Login success/failure messages
- Current-user session management

---

### 👤 Profile

The Profile screen displays the currently logged-in user's stored information:

```text
Name
Email
Username
```

User information is maintained through the `UserSession` class.

```csharp
internal class UserSession
{
    public static int UserId { get; set; }
    public static string Name { get; set; }
    public static string Email { get; set; }
    public static string Username { get; set; }

    public static void Clear()
    {
        UserId = 0;
        Name = "";
        Email = "";
        Username = "";
    }
}
```

---

### 🔎 Search Dictionary

Users can search for a word and view:

```text
Word
Meaning
Synonym
Antonym
```

The application reads the result directly from MySQL.

Example query:

```sql
SELECT word, meaning, synonym, antonym
FROM words
WHERE word = @word;
```

---

### 💡 Word Suggestions

The search interface can suggest words already available in the database.

For example:

```text
User types: hap

Suggestions:
Happy
```

This makes dictionary lookup faster and easier.

---

### ➕ Add Word

New dictionary records can be added with:

- Word
- Meaning
- Synonym
- Antonym

Example:

```sql
INSERT INTO words (word, meaning, synonym, antonym)
VALUES (@word, @meaning, @synonym, @antonym);
```

Before insertion, the application checks whether the word already exists.

---

### 🚫 Duplicate Prevention

Aura Dictionary is designed so the same word is not repeatedly added.

A database-level unique constraint is recommended:

```sql
ALTER TABLE words
ADD UNIQUE (word);
```

Application-level validation should also display a clear message when a duplicate is attempted.

---

### ✏️ Edit Word

Existing dictionary entries can be updated.

```sql
UPDATE words
SET meaning = @meaning,
    synonym = @synonym,
    antonym = @antonym
WHERE word = @word;
```

---

### 🗑️ Delete Word

Dictionary entries can be removed through the Delete Word screen.

```sql
DELETE FROM words
WHERE word = @word;
```

A confirmation dialog should be displayed before deletion.

---

## 🏗️ Application Architecture

```text
                    ┌─────────────────────┐
                    │   Registration      │
                    └──────────┬──────────┘
                               │
                               ▼
                    ┌─────────────────────┐
                    │       Login         │
                    └──────────┬──────────┘
                               │
                               ▼
                 ┌────────────────────────────┐
                 │        FrmMain             │
                 │   Aura Dictionary Home     │
                 └────────────┬───────────────┘
                              │
          ┌───────────────────┼───────────────────┐
          ▼                   ▼                   ▼
   ┌─────────────┐     ┌─────────────┐     ┌─────────────┐
   │ Search Word │     │  Add Word   │     │ Edit Word   │
   └──────┬──────┘     └──────┬──────┘     └──────┬──────┘
          │                   │                   │
          └───────────────────┼───────────────────┘
                              ▼
                       ┌─────────────┐
                       │   MySQL     │
                       │   Database  │
                       └─────────────┘
                              ▲
                              │
                       ┌──────┴──────┐
                       │ Delete Word │
                       └─────────────┘
```

---

## 🗄️ Database

### Database name

```text
dictionary_db
```

### `users`

| Column | Description |
|---|---|
| `id` | Unique user ID |
| `name` | User name |
| `email` | Email address |
| `username` | Login username |
| `password` | Account password |

### `words`

| Column | Description |
|---|---|
| `id` | Unique word ID |
| `word` | Dictionary word |
| `meaning` | Word definition |
| `synonym` | Similar words |
| `antonym` | Opposite words |
| `created_at` | Record creation timestamp |

---

## 🧰 Technology Stack

| Category | Technology |
|---|---|
| Language | C# |
| UI | Windows Forms |
| Framework | .NET |
| Database | MySQL |
| Database Library | MySQL Connector/NET |
| Database Tool | phpMyAdmin |
| IDE | Visual Studio |
| Version Control | Git / GitHub |

---

## 📁 Project Structure

```text
Aura_dictionary/
│
├── Properties/
├── References/
│
├── App.config
├── DBConnection.cs
├── UserSession.cs
├── Program.cs
│
├── Form1.cs
├── Form1.Designer.cs
│
├── Form2.cs
├── Form2.Designer.cs
│
├── FrmMain.cs
├── FrmMain.Designer.cs
│
├── FrmDictionary.cs
├── FrmDictionary.Designer.cs
│
├── FrmAddWord.cs
├── FrmAddWord.Designer.cs
│
├── FrmEditWord.cs
├── FrmEditWord.Designer.cs
│
├── FrmDeleteWord.cs
├── FrmDeleteWord.Designer.cs
│
├── FrmProfile.cs
└── FrmProfile.Designer.cs
```

---

## ⚙️ Setup

### 1. Requirements

Install:

- Visual Studio
- .NET / required .NET Framework version for the project
- MySQL Server
- phpMyAdmin
- MySQL Connector/NET

### 2. Clone

```bash
git clone <your-repository-url>
```

### 3. Open

Open the Visual Studio solution:

```text
Aura_dictionary.sln
```

### 4. Create database

```sql
CREATE DATABASE dictionary_db;
```

Then create the required `users` and `words` tables.

### 5. Configure connection

Update the project's database connection configuration.

Example:

```text
Server=localhost;
Database=dictionary_db;
Uid=root;
Pwd=;
```

### 6. Build

In Visual Studio:

```text
Build → Build Solution
```

### 7. Run

Press:

```text
F5
```

---

## 🔌 Database Connection

A centralized `DBConnection` class keeps database access consistent.

Example:

```csharp
public static MySqlConnection GetConnection()
{
    return new MySqlConnection(
        "server=localhost;database=dictionary_db;uid=root;pwd=;"
    );
}
```

Use the actual credentials/configuration for your local environment.

---

## 🛡️ Database Safety

The application should use parameterized queries:

```csharp
cmd.Parameters.AddWithValue("@word", txtWord.Text);
```

Avoid building SQL queries by directly concatenating textbox input.

For a production application, passwords should also be securely hashed instead of being stored as plain text.

---

## 🧪 Testing Checklist

- [ ] Registration works
- [ ] Empty fields are validated
- [ ] Password confirmation works
- [ ] Login works
- [ ] Invalid login is rejected
- [ ] User session loads correctly
- [ ] Profile displays logged-in user details
- [ ] Search works
- [ ] Meaning displays correctly
- [ ] Synonyms display correctly
- [ ] Antonyms display correctly
- [ ] Suggestions work
- [ ] Add Word works
- [ ] Duplicate Word is rejected
- [ ] Edit Word works
- [ ] Delete Word works
- [ ] Delete confirmation works
- [ ] Logout clears the session
- [ ] MDI forms open correctly
- [ ] Child forms maximize correctly
- [ ] Database errors are handled

---

## 🎨 UI Design

Aura Dictionary uses a custom visual identity inspired by books and modern digital interfaces.

### Design language

- 🌌 Dark space-inspired backgrounds
- 💜 Purple/violet Aura accents
- ✨ Glow effects
- 📖 Dictionary/book visual identity
- 🧩 Clean form layouts
- 🖥️ Desktop-focused interface
- 🔘 Clear navigation controls

The goal is to give a traditional dictionary application a modern desktop experience.

---

## 🧭 Main Navigation

```text
Dictionary
├── Search Word
├── Add Word
├── Edit Word
└── Delete Word

Account
├── Profile
└── Logout

Help
└── Application information
```

---

## 📚 Sample Dictionary Data

Example records:

| Word | Meaning | Synonym | Antonym |
|---|---|---|---|
| Happy | Feeling pleasure or satisfaction. | Joyful, Glad, Cheerful | Sad, Unhappy |
| Big | Large in size or amount. | Large, Huge, Giant | Small, Tiny |
| Fast | Moving or able to move quickly. | Quick, Rapid, Swift | Slow, Sluggish |
| Beautiful | Having qualities that give great pleasure to the senses. | Pretty, Attractive, Lovely | Ugly, Unattractive |
| Brave | Ready to face danger or difficult situations. | Courageous, Bold, Fearless | Cowardly, Afraid |
| Easy | Not difficult to do or understand. | Simple, Effortless | Difficult, Hard |
| Rich | Having a great deal of money or valuable possessions. | Wealthy, Affluent | Poor, Needy |
| Start | To begin an activity or process. | Begin, Commence, Initiate | End, Finish, Stop |
| Love | A strong feeling of affection or care. | Affection, Fondness, Adoration | Hate, Dislike |
| Smart | Having a good ability to learn, understand, or solve problems. | Clever, Intelligent, Bright | Stupid, Unintelligent |

---

## 🔮 Future Enhancements

Potential future versions may include:

- 🔊 Word pronunciation
- 🎙️ Voice search
- 📖 Example sentences
- ⭐ Favorite words
- 🕘 Search history
- 📅 Word of the Day
- 🧠 Vocabulary quizzes
- 📊 Learning progress
- 🌐 Multi-language support
- 🌙 Theme switching
- 🤖 AI-powered explanations
- ☁️ Cloud database
- 📱 Mobile/web companion application

---

## 🎯 Project Objectives

Aura Dictionary demonstrates practical software-development concepts:

- Object-Oriented Programming
- C# Windows Forms
- Event-driven programming
- MDI applications
- Form-to-form navigation
- CRUD operations
- SQL queries
- MySQL connectivity
- Authentication
- Session management
- Input validation
- Database-driven UI design

---

## 📌 Project Status

**Status:** ✅ Completed / Functional

The project can be extended with additional dictionary data, improved security, pronunciation features, AI functionality, and advanced learning tools.

---

## 📄 License

This project is intended for educational and personal development purposes.

Add a separate `LICENSE` file if you plan to distribute the project publicly.

---

## ⭐ Aura Dictionary

**Search. Add. Edit. Delete. Learn.**

> **Expand Your Words, Enrich Your World.**
