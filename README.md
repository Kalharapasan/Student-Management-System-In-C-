# 🎓 Student Management System (SQLite)

**Student Management System** is a Windows desktop application built using **C# (.NET Framework)** and **SQLite**.  
It provides an intuitive interface to **add, view, edit, delete, and manage student records** in a lightweight, local database.

---

## ✨ Features

- 🧾 Add new student records  
- ✏️ Edit or update existing details  
- ❌ Delete student information  
- 🔍 Search and filter student data  
- 💾 Stores data locally using **SQLite**  
- 🪟 Modern tabbed UI (via **EasyTabs** library)  
- ⚡ Fast, portable, and easy to use — no external server required  

---

## 🧰 Technologies Used

- **Language:** C# (.NET Framework 4.5+)  
- **Database:** SQLite  
- **IDE:** Microsoft Visual Studio 2015+  
- **Libraries / NuGet Packages:**  
  - `EasyTabs` — tabbed interface support  
  - `System.Data.SQLite` — SQLite database integration  
  - `SQLitePCLRaw.core` — portable SQLite runtime  

---

## 🗂️ Project Structure

```
Student_Manegement_System_Sqlit/
├── Student_Manegment_System_Sqlit.sln       # Visual Studio solution
├── packages/                                # NuGet dependencies
│   ├── EasyTabs.2.0.0/
│   ├── SQLitePCLRaw.core/
│   ├── Stub.System.Data.SQLite.Core.NetFramework/
│   └── ...
├── .vs/                                     # Visual Studio workspace files
├── bin/ & obj/                              # Build outputs (generated automatically)
└── src/ (if included)                       # Application source code
```

---

## ▶️ How to Run

1. **Open the project** in **Visual Studio**:
   - Double-click the solution file:  
     ```
     Student_Manegment_System_Sqlit.sln
     ```

2. **Restore NuGet packages**:  
   In Visual Studio, go to  
   `Tools → NuGet Package Manager → Restore Packages`

3. **Build the project**:  
   - Press **Ctrl + Shift + B** or select **Build → Build Solution`

4. **Run the application**:  
   - Press **F5** or select **Debug → Start Debugging`

---

## 🧩 Main Components

| Component | Description |
|------------|-------------|
| `System.Data.SQLite` | Provides SQLite database functionality |
| `EasyTabs` | Adds multi-tab UI support |
| `SQLitePCLRaw.core` | Cross-platform SQLite integration |
| `Program.cs` | Entry point of the application |
| `App.config` | Configuration for database and dependencies |

---

## 🗃️ Database

The system uses **SQLite** for data storage.  
Default database file may be created automatically on first run.  
You can modify database logic or schema directly in the code.

---

## 💡 Future Improvements

- Add student photo support  
- Implement data export to Excel or CSV  
- Include attendance and grading modules  
- Add user authentication  

---

## 📄 License

 [License](./LICENSE.md): Proprietary – Permission Required

---